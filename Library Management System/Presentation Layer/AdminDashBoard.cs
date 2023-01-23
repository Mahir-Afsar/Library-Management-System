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
    public partial class AdminDashBoard : Form
    {
        public AdminDashBoard()
        {
            InitializeComponent();
        }

        private void AdminHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void adminFraneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminFrame af = new AdminFrame();
            this.Visible = false;
            af.Visible = true;
        }

        private void adminFrameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bookFrameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookFrame bf = new BookFrame();
            this.Visible = false;
            bf.Visible = true;
        }

        private void loanListFrameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoanListFrame bf = new LoanListFrame();
            this.Visible = false;
            bf.Visible = true;
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            this.Visible = false;
            f.Visible = true;
        }
    }
}
