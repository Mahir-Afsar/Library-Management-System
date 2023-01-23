
namespace Library_Management_System.Presentation_Layer
{
    partial class SearchBookFrame
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
            this.bkTable2 = new System.Windows.Forms.DataGridView();
            this.sbTable = new System.Windows.Forms.DataGridView();
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
            this.cbox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.bkTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbTable)).BeginInit();
            this.SuspendLayout();
            // 
            // bkTable2
            // 
            this.bkTable2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bkTable2.Location = new System.Drawing.Point(520, 99);
            this.bkTable2.Name = "bkTable2";
            this.bkTable2.RowHeadersWidth = 51;
            this.bkTable2.RowTemplate.Height = 24;
            this.bkTable2.Size = new System.Drawing.Size(481, 189);
            this.bkTable2.TabIndex = 113;
            // 
            // sbTable
            // 
            this.sbTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sbTable.Location = new System.Drawing.Point(19, 99);
            this.sbTable.Name = "sbTable";
            this.sbTable.RowHeadersWidth = 51;
            this.sbTable.RowTemplate.Height = 24;
            this.sbTable.Size = new System.Drawing.Size(474, 189);
            this.sbTable.TabIndex = 112;
            this.sbTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sbTable_CellClick);
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
            this.lbox.Location = new System.Drawing.Point(632, 399);
            this.lbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lbox.Name = "lbox";
            this.lbox.Size = new System.Drawing.Size(168, 31);
            this.lbox.TabIndex = 111;
            this.lbox.TabStop = false;
            this.lbox.Text = "Location";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(532, 399);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 23);
            this.label8.TabIndex = 110;
            this.label8.Text = "Location:";
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(829, 475);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(106, 40);
            this.backBtn.TabIndex = 109;
            this.backBtn.TabStop = false;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // getAllBtn
            // 
            this.getAllBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getAllBtn.Location = new System.Drawing.Point(170, 476);
            this.getAllBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.getAllBtn.Name = "getAllBtn";
            this.getAllBtn.Size = new System.Drawing.Size(99, 40);
            this.getAllBtn.TabIndex = 108;
            this.getAllBtn.TabStop = false;
            this.getAllBtn.Text = "Get All";
            this.getAllBtn.UseVisualStyleBackColor = true;
            this.getAllBtn.Click += new System.EventHandler(this.getAllBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.Location = new System.Drawing.Point(289, 478);
            this.refreshBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(98, 37);
            this.refreshBtn.TabIndex = 107;
            this.refreshBtn.TabStop = false;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Enabled = false;
            this.deleteBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(692, 476);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(117, 40);
            this.deleteBtn.TabIndex = 106;
            this.deleteBtn.TabStop = false;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // updateBtn
            // 
            this.updateBtn.Enabled = false;
            this.updateBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(549, 476);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(127, 40);
            this.updateBtn.TabIndex = 105;
            this.updateBtn.TabStop = false;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            // 
            // insertBtn
            // 
            this.insertBtn.Enabled = false;
            this.insertBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertBtn.Location = new System.Drawing.Point(425, 477);
            this.insertBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(103, 40);
            this.insertBtn.TabIndex = 104;
            this.insertBtn.TabStop = false;
            this.insertBtn.Text = "Insert";
            this.insertBtn.UseVisualStyleBackColor = true;
            // 
            // loadBtn
            // 
            this.loadBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadBtn.Location = new System.Drawing.Point(51, 477);
            this.loadBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(99, 40);
            this.loadBtn.TabIndex = 103;
            this.loadBtn.TabStop = false;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.Location = new System.Drawing.Point(900, 12);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(101, 38);
            this.logoutBtn.TabIndex = 102;
            this.logoutBtn.TabStop = false;
            this.logoutBtn.Text = "Log Out";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
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
            this.cbox.Location = new System.Drawing.Point(810, 63);
            this.cbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbox.Name = "cbox";
            this.cbox.Size = new System.Drawing.Size(191, 31);
            this.cbox.TabIndex = 101;
            this.cbox.Text = "Book Category";
            this.cbox.SelectedIndexChanged += new System.EventHandler(this.cbox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(157, 60);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 23);
            this.label6.TabIndex = 100;
            this.label6.Text = "All Book Details";
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
            this.cbox1.Location = new System.Drawing.Point(631, 362);
            this.cbox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbox1.Name = "cbox1";
            this.cbox1.Size = new System.Drawing.Size(216, 31);
            this.cbox1.TabIndex = 99;
            this.cbox1.TabStop = false;
            this.cbox1.Text = "Category";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(530, 365);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 23);
            this.label7.TabIndex = 98;
            this.label7.Text = "Category:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(531, 328);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 23);
            this.label4.TabIndex = 97;
            this.label4.Text = "Price:";
            // 
            // qntxt
            // 
            this.qntxt.CausesValidation = false;
            this.qntxt.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qntxt.Location = new System.Drawing.Point(170, 419);
            this.qntxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.qntxt.Name = "qntxt";
            this.qntxt.Size = new System.Drawing.Size(114, 31);
            this.qntxt.TabIndex = 96;
            this.qntxt.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 422);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 23);
            this.label1.TabIndex = 95;
            this.label1.Text = "Quantity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 385);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 94;
            this.label2.Text = "Author:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 348);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 93;
            this.label3.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 314);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 23);
            this.label5.TabIndex = 92;
            this.label5.Text = "ID:";
            // 
            // authortxt
            // 
            this.authortxt.CausesValidation = false;
            this.authortxt.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authortxt.Location = new System.Drawing.Point(171, 382);
            this.authortxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.authortxt.Name = "authortxt";
            this.authortxt.Size = new System.Drawing.Size(216, 31);
            this.authortxt.TabIndex = 91;
            this.authortxt.TabStop = false;
            // 
            // nametxt
            // 
            this.nametxt.CausesValidation = false;
            this.nametxt.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametxt.Location = new System.Drawing.Point(171, 344);
            this.nametxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(216, 31);
            this.nametxt.TabIndex = 90;
            this.nametxt.TabStop = false;
            // 
            // idtxt
            // 
            this.idtxt.CausesValidation = false;
            this.idtxt.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idtxt.Location = new System.Drawing.Point(171, 308);
            this.idtxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(114, 31);
            this.idtxt.TabIndex = 89;
            this.idtxt.TabStop = false;
            // 
            // pricetxt
            // 
            this.pricetxt.CausesValidation = false;
            this.pricetxt.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricetxt.Location = new System.Drawing.Point(632, 325);
            this.pricetxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.Size = new System.Drawing.Size(114, 31);
            this.pricetxt.TabIndex = 88;
            this.pricetxt.TabStop = false;
            // 
            // SearchBookFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 550);
            this.Controls.Add(this.bkTable2);
            this.Controls.Add(this.sbTable);
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
            this.Name = "SearchBookFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchBookFrame";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchBookFrame_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bkTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView bkTable2;
        private System.Windows.Forms.DataGridView sbTable;
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
        private System.Windows.Forms.ComboBox cbox;
        private System.Windows.Forms.Label label6;
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
    }
}