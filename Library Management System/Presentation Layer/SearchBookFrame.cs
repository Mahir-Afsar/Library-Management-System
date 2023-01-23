using Library_Management_System.Data_Access_Layer;
using Library_Management_System.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System.Presentation_Layer
{
    public partial class SearchBookFrame : Form
    {
        User u;
        BookDataAccess rb;
        public SearchBookFrame()
        {
            InitializeComponent();
            this.u = u;
            this.rb = new BookDataAccess();
        }

        private void SearchBookFrame_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            string bookId = this.idtxt.Text;
            Book b = rb.GetBook(bookId);

            if (b == null)
            {
                MessageBox.Show("Invalid ID");
            }
            else
            {
                this.nametxt.Text = b.Name;
                this.authortxt.Text = b.Author;
                this.qntxt.Text = b.Quantity + "";
                this.pricetxt.Text = b.Price + "";
                this.cbox1.Text = b.Category;
                this.lbox.Text = b.Location;

                this.loadBtn.Enabled = false;
                this.refreshBtn.Enabled = true;

                this.idtxt.Enabled = false;
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            this.pricetxt.Text = "";
            this.nametxt.Text = "";
            this.authortxt.Text = "";
            this.qntxt.Text = "";
            this.idtxt.Text = "";
            this.cbox1.Text = "";
            this.lbox.Text = "";

            this.refreshBtn.Enabled = false;
            this.loadBtn.Enabled = true;

            this.idtxt.Enabled = true;
            this.idtxt.Focus();
        }

        private void getAllBtn_Click(object sender, EventArgs e)
        {
            List<Book> listOfBook = rb.GetAllBooks();
            sbTable.DataSource = listOfBook;

            sbTable.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            sbTable.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            sbTable.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            sbTable.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            sbTable.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            sbTable.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            sbTable.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            StudentDashBoard ah = new StudentDashBoard();
            this.Visible = false;
            ah.Visible = true;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            this.Visible = false;
            f.Visible = true;
        }

        private void sbTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            this.idtxt.Text = sbTable.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.nametxt.Text = sbTable.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.authortxt.Text = sbTable.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.pricetxt.Text = sbTable.Rows[e.RowIndex].Cells[3].Value.ToString();
            this.qntxt.Text = sbTable.Rows[e.RowIndex].Cells[4].Value.ToString();
            this.cbox1.Text = sbTable.Rows[e.RowIndex].Cells[5].Value.ToString();
            this.lbox.Text = sbTable.Rows[e.RowIndex].Cells[6].Value.ToString();

            this.refreshBtn.Enabled = true;
            this.loadBtn.Enabled = false;

            this.idtxt.Enabled = true;
        }

        private void cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string con = ConfigurationManager.ConnectionStrings["LibraryManagment"].ConnectionString;

            SqlConnection sn = new SqlConnection(con);

            SqlCommand sc = new SqlCommand();
            sc.CommandText = "Select Name,Author,Location from Book WHERE Category = '" + cbox.SelectedItem + "'";
            sc.Connection = sn;

            DataSet ds = new DataSet();
            SqlDataAdapter sdr = new SqlDataAdapter(sc);
            sdr.Fill(ds);
            bkTable2.DataSource = ds.Tables[0];

            bkTable2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            bkTable2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            bkTable2.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
    }
}
