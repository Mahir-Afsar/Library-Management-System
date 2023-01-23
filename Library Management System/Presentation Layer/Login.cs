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
    public partial class Login : Form
    {
        User u;
        public Login()
        {
            InitializeComponent();
        }

        //public Login(User u)
        //{
        //    InitializeComponent();
        //}

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            UserDataAccess ur = new UserDataAccess();
            string userId = usertxt.Text;
            string password = passtxt.Text;

            u = ur.GetUser(userId, password);

            if (u != null)
            {
                if (u.Status == 0)
                {
                    AdminDashBoard ah = new AdminDashBoard();
                    ah.Visible = true;
                    this.Visible = false;
                }
                else if (u.Status == 1)
                {
                    StudentDashBoard sh = new StudentDashBoard();
                    sh.Visible = true;
                    this.Visible = false;
                }
            }
            else
            {
                MessageBox.Show(this, "Invaild Id or Password");
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //private void showBtn_MouseHover(object sender, EventArgs e)
        //{
        //    passtxt.PasswordChar = '\0';
        //}

        //private void showBtn_MouseLeave(object sender, EventArgs e)
        //{
        //    passtxt.PasswordChar = '*';
        //}

        private void regBtn_Click(object sender, EventArgs e)
        {
            RegistrationFrame rf = new RegistrationFrame();
            rf.Visible = true;
            this.Visible = false;
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            if (passtxt.PasswordChar == '\0')
            {
                passtxt.PasswordChar = '*';
            }
            else
            {
                passtxt.PasswordChar = '\0';
            }
        }
    }
}
