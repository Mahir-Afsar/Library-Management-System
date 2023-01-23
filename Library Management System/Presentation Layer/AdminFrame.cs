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
    public partial class AdminFrame : Form
    {
        User u;
        StudentDataAccess rs;
        UserDataAccess ru;
        DatabaseConnection dbc;
        public AdminFrame()
        {
            InitializeComponent();
            //this.u = u;
            this.rs = new StudentDataAccess();
            this.ru = new UserDataAccess();
            dbc = new DatabaseConnection();
        }

        private void AdminFrame_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            string studentId = this.idtxt.Text;
            Student s = rs.GetStudent(studentId);

            if (s == null)
            {
                MessageBox.Show("Enter valid Student Id...");
            }
            else
            {
                this.nametxt.Text = s.Name;
                this.emailtxt.Text = s.Email;
                this.addresstxt.Text = s.Address;
                this.balancetxt.Text = s.Balance + "";
                this.finetxt.Text = s.Fine + "";

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
            Student s = new Student();
            User u = new User();

            Random rd = new Random();
            int x = rd.Next(999) + 10000;

            try
            {
                string id = this.idtxt.Text;
                string name = this.nametxt.Text;
                string email = this.emailtxt.Text;
                string address = this.addresstxt.Text;
                string balance = Convert.ToString(this.balancetxt.Text);
                //string fine = Convert.ToString(this.finetxt.Text);
                string userId = this.idtxt.Text;
                string password = (x + "");
                string status = "1";

                if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(address))
                {
                    MessageBox.Show("Invalid/Insufficient information");
                    return;
                }
                else
                {
                    s.StudentId = this.idtxt.Text;
                    s.Name = this.nametxt.Text;
                    s.Email = this.emailtxt.Text;
                    s.Address = this.addresstxt.Text;
                    s.Balance = Convert.ToInt32(this.balancetxt.Text);
                    //s.Fine = Convert.ToInt32(this.finetxt.Text);

                    u.UserId = this.idtxt.Text;
                    u.Password = (x + "");
                    u.Status = 1;
                }

                string query1 = "INSERT into Students(studentId,name,email,address,balance,fine) Values ('" + id + "', '" + name + "', '" + email + "', '" + address + "','"+balance+"' , 0)";
                string query2 = "INSERT into [User](userId,password,status) Values ('" + userId + "', '" + password + "', " + status + ")";

                if (DatabaseConnection.ExecuteQuery(query1) == true)
                {
                    if (DatabaseConnection.ExecuteQuery(query2) == true)
                    {
                        MessageBox.Show("Students Added with Id: " + u.UserId + " & Password: " + u.Password);

                        this.idtxt.Text = "";
                        this.nametxt.Text = "";
                        this.emailtxt.Text = "";
                        this.addresstxt.Text = "";
                        this.balancetxt.Text = "";
                        this.finetxt.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Cannot add Student");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Data" + ex.StackTrace);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            Student s = new Student();

            try
            {
                s.StudentId = this.idtxt.Text;
                s.Name = this.nametxt.Text;
                s.Email = this.emailtxt.Text;
                s.Address = this.addresstxt.Text;
                s.Balance = Convert.ToInt32(this.balancetxt.Text);
                s.Fine = Convert.ToInt32(this.finetxt.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid value" + ex.StackTrace);
                return;
            }

            if (rs.UpdateStudent(s))
            {
                MessageBox.Show("Student data updated successfully");
                this.getAllBtn_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Cannot update Student data");
            }
        }
        private void getAllBtn_Click(object sender, EventArgs e)
        {
            List<Student> listOfStudent = rs.GetAllStudents();
            stTable.DataSource = listOfStudent;

            stTable.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            stTable.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            stTable.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            stTable.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            stTable.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            stTable.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            User u = new User();

            string id = this.idtxt.Text;

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("StudentId required");
                return;
            }
            else
            {
                s.StudentId = this.idtxt.Text;
                u.UserId = this.idtxt.Text;
            }

            if (rs.DeleteStudent(s))
            {
                ru.DeleteUser(u);

                MessageBox.Show("Student Removed");
                this.refreshBtn_Click(sender, e);
                this.getAllBtn_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Can Not Remove Student");
                this.refreshBtn_Click(sender, e);
                this.getAllBtn_Click(sender, e);
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            this.idtxt.Text = "";
            this.nametxt.Text = "";
            this.emailtxt.Text = "";
            this.addresstxt.Text = "";
            this.balancetxt.Text = "";
            this.finetxt.Text = "";

            this.refreshBtn.Enabled = false;
            this.loadBtn.Enabled = true;
            this.insertBtn.Enabled = true;
            this.updateBtn.Enabled = false;
            this.deleteBtn.Enabled = false;

            this.idtxt.Enabled = true;
            this.idtxt.Focus();
        }

        private void getAllBtn_Click_1(object sender, EventArgs e)
        {
            List<Student> listOfStudent = rs.GetAllStudents();
            stTable.DataSource = listOfStudent;

            stTable.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            stTable.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            stTable.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            stTable.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            stTable.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            stTable.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void balanceBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(idtxt.Text) || string.IsNullOrEmpty(deptxt.Text))
                {
                    MessageBox.Show("Can not deposit, insert Id and Balance");
                    return;
                }
                else
                {
                    string query1 = "Update Students SET Balance = Balance + " + Convert.ToInt32(deptxt.Text) + " WHERE StudentId = '" + idtxt.Text + "'";
                    dbc.ConnectWithDB();
                    int n1 = dbc.ExecuteSQL(query1);
                    dbc.CloseConnection();

                    this.idtxt.Text = "";
                    this.nametxt.Text = "";
                    this.emailtxt.Text = "";
                    this.addresstxt.Text = "";
                    this.balancetxt.Text = "";
                    this.finetxt.Text = "";
                    deptxt.Text = "";

                    MessageBox.Show("Successfully Deposited... ");
                    this.refreshBtn_Click(sender, e);
                    this.getAllBtn_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Occured" + ex.StackTrace);
            }
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

        private void stTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void stTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.idtxt.Text = stTable.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.nametxt.Text = stTable.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.emailtxt.Text = stTable.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.addresstxt.Text = stTable.Rows[e.RowIndex].Cells[3].Value.ToString();
            this.balancetxt.Text = stTable.Rows[e.RowIndex].Cells[4].Value.ToString();
            this.finetxt.Text = stTable.Rows[e.RowIndex].Cells[5].Value.ToString();


            this.refreshBtn.Enabled = true;
            this.loadBtn.Enabled = false;
            this.insertBtn.Enabled = false;
            this.updateBtn.Enabled = true;
            this.deleteBtn.Enabled = true;

            this.idtxt.Enabled = true;
        }
    }
}
