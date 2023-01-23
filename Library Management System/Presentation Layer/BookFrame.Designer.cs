
namespace Library_Management_System.Presentation_Layer
{
    partial class BookFrame
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
            this.cbox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.qntxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.authortxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.pricetxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbox = new System.Windows.Forms.ComboBox();
            this.lbox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.getAllBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.insertBtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.bkTable = new System.Windows.Forms.DataGridView();
            this.bkTable2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bkTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bkTable2)).BeginInit();
            this.SuspendLayout();
            // 
            // cbox1
            // 
            this.cbox1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox1.FormattingEnabled = true;
            this.cbox1.Items.AddRange(new object[] {
            "Art & Music",
            "Biographies",
            "Com. Science",
            "Comics",
            "Entertainment",
            "Fictions",
            "Health",
            "History",
            "Science & Math",
            "Travel",
            "Soc. Sience",
            "Religion"});
            this.cbox1.Location = new System.Drawing.Point(132, 217);
            this.cbox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbox1.Name = "cbox1";
            this.cbox1.Size = new System.Drawing.Size(216, 31);
            this.cbox1.TabIndex = 71;
            this.cbox1.TabStop = false;
            this.cbox1.Text = "Category";
            this.cbox1.SelectedIndexChanged += new System.EventHandler(this.cbox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 220);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 23);
            this.label7.TabIndex = 70;
            this.label7.Text = "Category:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 23);
            this.label4.TabIndex = 69;
            this.label4.Text = "Price:";
            // 
            // qntxt
            // 
            this.qntxt.CausesValidation = false;
            this.qntxt.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qntxt.Location = new System.Drawing.Point(132, 142);
            this.qntxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.qntxt.Name = "qntxt";
            this.qntxt.Size = new System.Drawing.Size(114, 31);
            this.qntxt.TabIndex = 68;
            this.qntxt.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 145);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 23);
            this.label1.TabIndex = 67;
            this.label1.Text = "Quantity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 66;
            this.label2.Text = "Author:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 65;
            this.label3.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 23);
            this.label5.TabIndex = 64;
            this.label5.Text = "ID:";
            // 
            // authortxt
            // 
            this.authortxt.CausesValidation = false;
            this.authortxt.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authortxt.Location = new System.Drawing.Point(133, 105);
            this.authortxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.authortxt.Name = "authortxt";
            this.authortxt.Size = new System.Drawing.Size(216, 31);
            this.authortxt.TabIndex = 63;
            this.authortxt.TabStop = false;
            // 
            // nametxt
            // 
            this.nametxt.CausesValidation = false;
            this.nametxt.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametxt.Location = new System.Drawing.Point(133, 67);
            this.nametxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(216, 31);
            this.nametxt.TabIndex = 62;
            this.nametxt.TabStop = false;
            // 
            // idtxt
            // 
            this.idtxt.CausesValidation = false;
            this.idtxt.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idtxt.Location = new System.Drawing.Point(133, 31);
            this.idtxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(114, 31);
            this.idtxt.TabIndex = 61;
            this.idtxt.TabStop = false;
            // 
            // pricetxt
            // 
            this.pricetxt.CausesValidation = false;
            this.pricetxt.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricetxt.Location = new System.Drawing.Point(133, 180);
            this.pricetxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.Size = new System.Drawing.Size(114, 31);
            this.pricetxt.TabIndex = 60;
            this.pricetxt.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(701, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 23);
            this.label6.TabIndex = 73;
            this.label6.Text = "All Book Details";
            // 
            // cbox
            // 
            this.cbox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox.FormattingEnabled = true;
            this.cbox.Items.AddRange(new object[] {
            "Art & Music",
            "Biographies",
            "Com. Science",
            "Comics",
            "Entertainment",
            "Fictions",
            "Health",
            "History",
            "Science & Math",
            "Travel",
            "Soc. Sience",
            "Religion"});
            this.cbox.Location = new System.Drawing.Point(841, 245);
            this.cbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbox.Name = "cbox";
            this.cbox.Size = new System.Drawing.Size(175, 31);
            this.cbox.TabIndex = 75;
            this.cbox.Text = "Book Category";
            this.cbox.SelectedIndexChanged += new System.EventHandler(this.cbox_SelectedIndexChanged);
            // 
            // lbox
            // 
            this.lbox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbox.FormattingEnabled = true;
            this.lbox.Items.AddRange(new object[] {
            "Row 1, Column 1",
            "Row 1, Column 2",
            "Row 1, Column 3",
            "Row 2, Column 1",
            "Row 2, Column 2",
            "Row 2, Column 3",
            "Row 3, Column 1",
            "Row 3, Column 2",
            "Row 3, Column 3",
            "Row 4, Column 1",
            "Row 4, Column 2",
            "Row 4, Column 3"});
            this.lbox.Location = new System.Drawing.Point(132, 263);
            this.lbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lbox.Name = "lbox";
            this.lbox.Size = new System.Drawing.Size(168, 31);
            this.lbox.TabIndex = 85;
            this.lbox.TabStop = false;
            this.lbox.Text = "Location";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 263);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 23);
            this.label8.TabIndex = 84;
            this.label8.Text = "Location:";
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(379, 346);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(105, 32);
            this.backBtn.TabIndex = 83;
            this.backBtn.TabStop = false;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // getAllBtn
            // 
            this.getAllBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getAllBtn.Location = new System.Drawing.Point(407, 117);
            this.getAllBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.getAllBtn.Name = "getAllBtn";
            this.getAllBtn.Size = new System.Drawing.Size(99, 40);
            this.getAllBtn.TabIndex = 82;
            this.getAllBtn.TabStop = false;
            this.getAllBtn.Text = "Get All";
            this.getAllBtn.UseVisualStyleBackColor = true;
            this.getAllBtn.Click += new System.EventHandler(this.getAllBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.Location = new System.Drawing.Point(407, 183);
            this.refreshBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(98, 37);
            this.refreshBtn.TabIndex = 81;
            this.refreshBtn.TabStop = false;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(254, 346);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(108, 32);
            this.deleteBtn.TabIndex = 80;
            this.deleteBtn.TabStop = false;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(118, 346);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(116, 32);
            this.updateBtn.TabIndex = 79;
            this.updateBtn.TabStop = false;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // insertBtn
            // 
            this.insertBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertBtn.Location = new System.Drawing.Point(11, 346);
            this.insertBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(91, 32);
            this.insertBtn.TabIndex = 78;
            this.insertBtn.TabStop = false;
            this.insertBtn.Text = "Insert";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadBtn.Location = new System.Drawing.Point(407, 62);
            this.loadBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(99, 36);
            this.loadBtn.TabIndex = 77;
            this.loadBtn.TabStop = false;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.Location = new System.Drawing.Point(11, 399);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(101, 38);
            this.logoutBtn.TabIndex = 76;
            this.logoutBtn.TabStop = false;
            this.logoutBtn.Text = "Log Out";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // bkTable
            // 
            this.bkTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bkTable.Location = new System.Drawing.Point(563, 43);
            this.bkTable.Name = "bkTable";
            this.bkTable.RowHeadersWidth = 51;
            this.bkTable.RowTemplate.Height = 24;
            this.bkTable.Size = new System.Drawing.Size(453, 177);
            this.bkTable.TabIndex = 86;
            // 
            // bkTable2
            // 
            this.bkTable2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bkTable2.Location = new System.Drawing.Point(563, 289);
            this.bkTable2.Name = "bkTable2";
            this.bkTable2.RowHeadersWidth = 51;
            this.bkTable2.RowTemplate.Height = 24;
            this.bkTable2.Size = new System.Drawing.Size(454, 177);
            this.bkTable2.TabIndex = 87;
            // 
            // BookFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 478);
            this.Controls.Add(this.bkTable2);
            this.Controls.Add(this.bkTable);
            this.Controls.Add(this.lbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.getAllBtn);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.cbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.qntxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.authortxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.pricetxt);
            this.Name = "BookFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookFrame";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BookFrame_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bkTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bkTable2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox qntxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox authortxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.TextBox pricetxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbox;
        private System.Windows.Forms.ComboBox lbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button getAllBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.DataGridView bkTable;
        private System.Windows.Forms.DataGridView bkTable2;
    }
}