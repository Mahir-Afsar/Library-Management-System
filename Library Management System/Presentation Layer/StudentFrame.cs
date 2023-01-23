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
    public partial class StudentFrame : Form
    {
        User u;
        StudentDataAccess rs;
        DatabaseConnection dbc;
        public StudentFrame()
        {
            InitializeComponent();
            this.rs = new StudentDataAccess();
            dbc = new DatabaseConnection();
        }

        private void StudentFrame_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            //if (!idtxt.Text.Equals("") || !idtxt.Text.Equals(null))
            //{
            //    if (idtxt.Text.Equals(u.userId))
            //    {
            //        string studentId = this.idtxt.Text;
            //        Student s = rs.GetStudent(studentId);

            //        if (s == null)
            //        {
            //            MessageBox.Show("Invalid ID! Enter your ID...");
            //        }
            //        else
            //        {
            //            this.nametxt.Text = s.Name;
            //            this.emailtxt.Text = s.Email;
            //            this.addresstxt.Text = s.Address;
            //            this.balancetxt.Text = s.Balance + "";
            //            this.finetxt.Text = s.Fine + "";

            //            idtxt.Enabled = false;
            //            //idtxt.Focus();
            //            nametxt.Enabled = true;
            //            addresstxt.Enabled = true;
            //            emailtxt.Enabled = true;
            //            balancetxt.Enabled = false;
            //            finetxt.Enabled = false;

            //            this.loadBtn.Enabled = false;
            //            this.updateBtn.Enabled = true;
            //            this.refreshBtn.Enabled = true;
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Please insert your ID!!");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("ID cannot be null!! Enter your ID...");
            //}

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
                //this.insertBtn.Enabled = false;
                this.updateBtn.Enabled = true;
                //this.deleteBtn.Enabled = true;
                this.refreshBtn.Enabled = true;

                this.idtxt.Enabled = false;
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            Student s = new Student();

            s.StudentId = this.idtxt.Text;
            s.Name = this.nametxt.Text;
            s.Email = this.emailtxt.Text;
            s.Address = this.addresstxt.Text;
            s.Balance = Convert.ToInt32(this.balancetxt.Text);
            s.Fine = Convert.ToInt32(this.finetxt.Text);

            if (rs.UpdateStudents(s))
            {
                MessageBox.Show("Student data updated successfully");
            }
            else
            {
                MessageBox.Show("Cannot update Student data");
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            this.addresstxt.Text = "";
            this.nametxt.Text = "";
            this.emailtxt.Text = "";
            this.balancetxt.Text = "";
            this.finetxt.Text = "";

            this.refreshBtn.Enabled = false;
            this.loadBtn.Enabled = true;
            this.updateBtn.Enabled = false;

            this.idtxt.Enabled = true;

            this.nametxt.Focus();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            StudentDashBoard sh = new StudentDashBoard();
            this.Visible = false;
            sh.Visible = true;
        }

        private void balanceBtn_Click(object sender, EventArgs e)
        {
            string query1 = "Update Students SET Balance = Balance + " + Convert.ToInt32(deptxt.Text) + " WHERE StudentId = '" + idtxt.Text + "'";
            try
            {
                dbc.ConnectWithDB();
                int n1 = dbc.ExecuteSQL(query1);
                dbc.CloseConnection();

                deptxt.Text = "";

                MessageBox.Show("Successfully Deposited...");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Deposit" + ex.StackTrace);
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            this.Visible = false;
            f.Visible = true;
        }
    }
}
