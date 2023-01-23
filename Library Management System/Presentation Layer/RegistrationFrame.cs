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
    public partial class RegistrationFrame : Form
    {
        User u;
        UserDataAccess ru;
        StudentDataAccess rs;

        public RegistrationFrame()
        {
            InitializeComponent();
            this.ru = new UserDataAccess();
            this.rs = new StudentDataAccess();
        }

        private void RegistrationFrame_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
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

                if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Invalid/Insufficient information");
                    return;
                }

                string query1 = "INSERT into Students(studentId,name,email,address,balance,fine) Values ('" + id + "', '" + name + "', '" + email + "', '" + address + "', 0, 0)";
                string query2 = "INSERT into [User](userId,password,status) Values ('" + userId + "', '" + password + "', " + status + ")";

                if (DatabaseConnection.ExecuteQuery(query1) == true)
                {
                    if (DatabaseConnection.ExecuteQuery(query2) == true)
                    {
                        MessageBox.Show("Student Added with Id: " + userId + " & Password: " + password);
                        Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Cannot add User");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Cannot add Student");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void balancetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Login rf = new Login();
            rf.Visible = true;
            this.Visible = false;
        }
    }
}
