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
    public partial class StudentDashBoard : Form
    {
        public StudentDashBoard()
        {
            InitializeComponent();
        }

        private void StudentDashBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void studentFrameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentFrame sf = new StudentFrame();
            this.Visible = false;
            sf.Visible = true;
        }

        private void searchBookFrameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchBookFrame sbf = new SearchBookFrame();
            this.Visible = false;
            sbf.Visible = true;
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            this.Visible = false;
            f.Visible = true;
        }
    }
}
