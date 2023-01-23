using Library_Management_System.Data_Access_Layer;
using Library_Management_System.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System.Presentation_Layer
{
    public partial class LoanListFrame : Form
    {
        User u;
        LoanListDataAccess rl;

        public LoanListFrame()
        {
            InitializeComponent();
            //this.u = u;
            rl = new LoanListDataAccess();
        }

        private void llTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoanListFrame_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            string loanId = this.lidtxt.Text;
            LoanList l = rl.GetLoanList(loanId);

            if (l == null)
            {
                MessageBox.Show("Enter Loan ID...");
            }
            else
            {
                this.lidtxt.Text = l.LoanId;
                this.bidtxt.Text = l.BookId;
                this.snametxt.Text = l.StudentName;
                this.sidtxt.Text = l.StudentId;
                this.idatetxt.Text = l.IDate;
                this.ddatetxt.Text = l.DDate;
                this.statustxt.Text = l.Status;
                this.finetxt.Text = l.Fine + "";

                this.loadBtn.Enabled = false;
                this.insertBtn.Enabled = false;
                this.updateBtn.Enabled = true;
                this.deleteBtn.Enabled = true;
                this.refreshBtn.Enabled = true;

                this.lidtxt.Enabled = false;
            }
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            LoanList l = new LoanList();
            try
            {
                string lid = this.lidtxt.Text;
                string bid = this.bidtxt.Text;
                string sname = this.snametxt.Text;
                string sid = this.sidtxt.Text;
                string idate = Convert.ToString(this.idatetxt.Text);
                string ddate = Convert.ToString(this.ddatetxt.Text);
                string rdate = this.rdatetxt.Text;
                string status = this.statustxt.Text;
                //string fine = Convert.ToString(this.finetxt.Text);

                //if (string.IsNullOrEmpty(lid) || string.IsNullOrEmpty(bid) || string.IsNullOrEmpty(sname) || string.IsNullOrEmpty(sid) || string.IsNullOrEmpty(idate) || string.IsNullOrEmpty(ddate) || string.IsNullOrEmpty(status) || string.IsNullOrEmpty(fine))
                if (string.IsNullOrEmpty(lid) || string.IsNullOrEmpty(bid) || string.IsNullOrEmpty(sname) || string.IsNullOrEmpty(sid) || string.IsNullOrEmpty(idate) || string.IsNullOrEmpty(ddate) || string.IsNullOrEmpty(status))
                {
                    MessageBox.Show("Invalid Information");
                    return;
                }
                else
                {
                    l.LoanId = this.lidtxt.Text;
                    l.BookId = this.bidtxt.Text;
                    l.StudentName = this.snametxt.Text;
                    l.StudentId = this.sidtxt.Text;
                    l.IDate = this.idatetxt.Text;
                    l.DDate = this.ddatetxt.Text;
                    l.RDate = this.rdatetxt.Text;
                    //l.Fine = Convert.ToInt32(this.finetxt.Text);

                    if (statustxt.Text.Equals("Issued"))
                    {
                        l.Status = this.statustxt.Text;
                    }
                    else
                    {
                        MessageBox.Show("Invalid Status");
                        return;
                    }
                }

                if (rl.InsertLoanList(l))
                {
                    MessageBox.Show("Book Issued successfully");

                    this.refreshBtn_Click(sender, e);
                    this.getAllBtn_Click(sender, e);

                    this.lidtxt.Text = "";
                    this.bidtxt.Text = "";
                    this.snametxt.Text = "";
                    this.sidtxt.Text = "";
                    this.idatetxt.Text = DateTime.Now.ToString();
                    this.ddatetxt.Text = DateTime.Now.ToString();
                    this.rdatetxt.Text = "";
                    this.statustxt.Text = "";
                    this.finetxt.Text = "";
                }
                else
                {
                    MessageBox.Show("Cannot Issue Book " + l.LoanId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Data" + ex.StackTrace);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            LoanList l = new LoanList();

            try
            {
                l.LoanId = this.lidtxt.Text;
                l.BookId = this.bidtxt.Text;
                l.StudentName = this.snametxt.Text;
                l.StudentId = this.sidtxt.Text;
                l.IDate = this.idatetxt.Text;
                l.DDate = this.ddatetxt.Text;
                l.RDate = this.rdatetxt.Text;
                l.Status = this.statustxt.Text;
                l.Fine = Convert.ToInt32(this.finetxt.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid value" + ex.StackTrace);
                return;
            }

            if (rl.UpdateLoanList(l))
            {
                MessageBox.Show("Updated");
                this.getAllBtn_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Can not update");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            LoanList l = new LoanList();

            string id = this.lidtxt.Text;

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("LoanId required");
                return;
            }
            else
            {
                l.LoanId = this.lidtxt.Text;
            }

            if (rl.DeleteLoanList(l))
            {
                MessageBox.Show("Loan Id removed");
                this.refreshBtn_Click(sender, e);
                this.getAllBtn_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Cannot remove LoanId");
                this.refreshBtn_Click(sender, e);
                this.getAllBtn_Click(sender, e);
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            this.lidtxt.Text = "";
            this.bidtxt.Text = "";
            this.snametxt.Text = "";
            this.sidtxt.Text = "";
            this.idatetxt.Text = DateTime.Now.ToString();
            this.ddatetxt.Text = DateTime.Now.ToString();
            this.rdatetxt.Text = "";
            this.statustxt.Text = "";
            this.finetxt.Text = "";

            this.refreshBtn.Enabled = false;
            this.loadBtn.Enabled = true;
            this.insertBtn.Enabled = true;
            this.updateBtn.Enabled = false;
            this.deleteBtn.Enabled = false;

            this.lidtxt.Enabled = true;
            this.lidtxt.Focus();
        }

        private void getAllBtn_Click(object sender, EventArgs e)
        {
            //List<LoanList> listOfBook = rl.GetAllLoanList();
            //llTable.DataSource = listOfBook;

            List<LoanList> listOfLoan = rl.GetAllLoanList();
            llTable.DataSource = listOfLoan;

            llTable.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            llTable.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            llTable.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            llTable.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            llTable.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            llTable.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            llTable.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            llTable.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            llTable.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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

        private void llTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (llTable == null)
            {
                return;
            }

            if (llTable.Rows.Count == 0)
            {
                MessageBox.Show("Invalid Id");
                return;
            }

            try
            {
                this.lidtxt.Text = llTable.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.bidtxt.Text = llTable.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.sidtxt.Text = llTable.Rows[e.RowIndex].Cells[2].Value.ToString();
                this.snametxt.Text = llTable.Rows[e.RowIndex].Cells[3].Value.ToString();
                this.idatetxt.Text = llTable.Rows[e.RowIndex].Cells[4].Value.ToString();
                this.ddatetxt.Text = llTable.Rows[e.RowIndex].Cells[5].Value.ToString();
                this.rdatetxt.Text = llTable.Rows[e.RowIndex].Cells[6].Value.ToString();
                this.statustxt.Text = llTable.Rows[e.RowIndex].Cells[7].Value.ToString();
                this.finetxt.Text = llTable.Rows[e.RowIndex].Cells[8].Value.ToString();

                this.refreshBtn.Enabled = true;
                this.loadBtn.Enabled = false;
                this.insertBtn.Enabled = false;
                this.updateBtn.Enabled = true;
                this.deleteBtn.Enabled = true;

                this.lidtxt.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoanListFrame_Load(object sender, EventArgs e)
        {

        }
    }
}
