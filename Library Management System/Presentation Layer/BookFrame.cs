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
    public partial class BookFrame : Form
    {
        User u;
        BookDataAccess rb;
        public BookFrame()
        {
            InitializeComponent();
            this.u = u;
            this.rb = new BookDataAccess();
        }

        private void BookFrame_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            string bookId = this.idtxt.Text;
            Book b = rb.GetBook(bookId);

            if (b == null)
            {
                MessageBox.Show("Enter BookId...");
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
                this.insertBtn.Enabled = false;
                this.updateBtn.Enabled = true;
                this.deleteBtn.Enabled = true;
                this.refreshBtn.Enabled = true;

                this.idtxt.Enabled = false;
            }
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            //Book b = new Book();

            try
            {
                string id = this.idtxt.Text;
                string name = this.nametxt.Text;
                string author = this.authortxt.Text;
                string quantity = Convert.ToString(this.qntxt.Text);
                string price = Convert.ToString(this.pricetxt.Text);
                string category = this.cbox1.Text;
                string location = this.lbox.Text;

                if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(author) || string.IsNullOrEmpty(quantity) || string.IsNullOrEmpty(price) || string.IsNullOrEmpty(category) || string.IsNullOrEmpty(location))
                {
                    MessageBox.Show("Invalid/Insufficient information");
                    return;
                }
                //else
                //{
                //    b.BookId = this.idtxt.Text;
                //    b.Name = this.nametxt.Text;
                //    b.Author = this.authortxt.Text;
                //    b.Quantity = Convert.ToInt32(this.qntxt.Text);
                //    b.Price = float.Parse(this.pricetxt.Text);
                //    b.Category = this.cbox1.Text;
                //    b.Location = this.lbox.Text;
                //}

                string query1 = "INSERT into Book(bookId,name,author,quantity,price,category,location) Values('" + id + "', '" + name + "', '" + author + "', '" + quantity + "', '" + price + "', '" + category + "', '" + location + "')";
                if (DatabaseConnection.ExecuteQuery(query1) == true)
                {
                    MessageBox.Show("Book added successfully");

                    this.refreshBtn_Click(sender, e);
                    this.getAllBtn_Click(sender, e);

                    this.idtxt.Text = "";
                    this.nametxt.Text = "";
                    this.authortxt.Text = "";
                    this.qntxt.Text = "";
                    this.pricetxt.Text = "";
                    this.cbox1.Text = "";
                    this.lbox.Text = "";
                }
                else
                {
                    MessageBox.Show("Cannot add Book");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Data" + ex.StackTrace);
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            this.idtxt.Text = "";
            this.nametxt.Text = "";
            this.authortxt.Text = "";
            this.qntxt.Text = "";
            this.pricetxt.Text = "";
            this.cbox1.Text = "";
            this.lbox.Text = "";

            this.refreshBtn.Enabled = false;
            this.loadBtn.Enabled = true;
            this.insertBtn.Enabled = true;
            this.updateBtn.Enabled = false;
            this.deleteBtn.Enabled = false;

            this.idtxt.Enabled = true;
            this.idtxt.Focus();
        }

        private void getAllBtn_Click(object sender, EventArgs e)
        {
            List<Book> listOfBook = rb.GetAllBooks();
            bkTable.DataSource = listOfBook;

            bkTable.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            bkTable.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            bkTable.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            bkTable.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            bkTable.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            bkTable.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            bkTable.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            Book b = new Book();

            try
            {
                b.BookId = this.idtxt.Text;
                b.Name = this.nametxt.Text;
                b.Author = this.authortxt.Text;
                b.Quantity = Convert.ToInt32(this.qntxt.Text);
                b.Price = float.Parse(this.pricetxt.Text);
                b.Category = this.cbox1.Text;
                b.Location = this.lbox.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid value" + ex.StackTrace);
                return;
            }
            if (rb.UpdateBook(b))
            {
                MessageBox.Show("Book updated successfully");
                this.getAllBtn_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Cannot update Book");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Book b = new Book();
            string id = this.idtxt.Text;

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("BookId required");
                return;
            }
            else
            {
                b.BookId = this.idtxt.Text;
            }

            if (rb.DeleteBook(b))
            {
                MessageBox.Show("Book removed");
                this.refreshBtn_Click(sender, e);
                this.getAllBtn_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Cannot remove Book");
                this.refreshBtn_Click(sender, e);
                this.getAllBtn_Click(sender, e);
            }
        }

        private void bkTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.idtxt.Text = bkTable.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.nametxt.Text = bkTable.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.authortxt.Text = bkTable.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.pricetxt.Text = bkTable.Rows[e.RowIndex].Cells[3].Value.ToString();
            this.qntxt.Text = bkTable.Rows[e.RowIndex].Cells[4].Value.ToString();
            this.cbox1.Text = bkTable.Rows[e.RowIndex].Cells[5].Value.ToString();
            this.lbox.Text = bkTable.Rows[e.RowIndex].Cells[6].Value.ToString();

            this.refreshBtn.Enabled = true;
            this.loadBtn.Enabled = false;
            this.insertBtn.Enabled = false;
            this.updateBtn.Enabled = true;
            this.deleteBtn.Enabled = true;

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

        private void backBtn_Click(object sender, EventArgs e)
        {
            AdminDashBoard ah = new AdminDashBoard();
            this.Visible = false;
            ah.Visible = true;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            this.Visible = false;
            f.Visible = true;
        }

        private void cbox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
