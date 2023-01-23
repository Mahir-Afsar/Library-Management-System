
namespace Library_Management_System.Presentation_Layer
{
    partial class AdminDashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminFrameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminFraneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookFrameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loanListFrameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminFrameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminFrameToolStripMenuItem
            // 
            this.adminFrameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminFraneToolStripMenuItem,
            this.bookFrameToolStripMenuItem,
            this.loanListFrameToolStripMenuItem});
            this.adminFrameToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminFrameToolStripMenuItem.Name = "adminFrameToolStripMenuItem";
            this.adminFrameToolStripMenuItem.Size = new System.Drawing.Size(144, 32);
            this.adminFrameToolStripMenuItem.Text = "AdminHome";
            this.adminFrameToolStripMenuItem.Click += new System.EventHandler(this.adminFrameToolStripMenuItem_Click);
            // 
            // adminFraneToolStripMenuItem
            // 
            this.adminFraneToolStripMenuItem.Name = "adminFraneToolStripMenuItem";
            this.adminFraneToolStripMenuItem.Size = new System.Drawing.Size(234, 32);
            this.adminFraneToolStripMenuItem.Text = "AdminFrame";
            this.adminFraneToolStripMenuItem.Click += new System.EventHandler(this.adminFraneToolStripMenuItem_Click);
            // 
            // bookFrameToolStripMenuItem
            // 
            this.bookFrameToolStripMenuItem.Name = "bookFrameToolStripMenuItem";
            this.bookFrameToolStripMenuItem.Size = new System.Drawing.Size(234, 32);
            this.bookFrameToolStripMenuItem.Text = "BookFrame";
            this.bookFrameToolStripMenuItem.Click += new System.EventHandler(this.bookFrameToolStripMenuItem_Click);
            // 
            // loanListFrameToolStripMenuItem
            // 
            this.loanListFrameToolStripMenuItem.Name = "loanListFrameToolStripMenuItem";
            this.loanListFrameToolStripMenuItem.Size = new System.Drawing.Size(234, 32);
            this.loanListFrameToolStripMenuItem.Text = "LoanListFrame";
            this.loanListFrameToolStripMenuItem.Click += new System.EventHandler(this.loanListFrameToolStripMenuItem_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(655, 374);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(121, 50);
            this.logoutButton.TabIndex = 2;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // AdminDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashBoard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminHome_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminFrameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminFraneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookFrameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loanListFrameToolStripMenuItem;
        private System.Windows.Forms.Button logoutButton;
    }
}