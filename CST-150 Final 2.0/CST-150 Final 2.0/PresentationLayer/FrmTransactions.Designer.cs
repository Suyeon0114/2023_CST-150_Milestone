namespace CST_150_Final_2._0.PresentationLayer
{
    partial class FrmTransactions
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.btnDelItem = new System.Windows.Forms.Button();
            this.btnIncAmount = new System.Windows.Forms.Button();
            this.btnDecAmount = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gvIncome = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.cmbInOrOut = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvIncome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 151);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 65);
            this.label1.TabIndex = 2;
            this.label1.Text = "DailyPay";
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(1206, 50);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(150, 46);
            this.btnReadFile.TabIndex = 4;
            this.btnReadFile.Text = "Read File";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.BtnReadFile_ClickEventHandler);
            // 
            // btnDelItem
            // 
            this.btnDelItem.BackColor = System.Drawing.Color.RosyBrown;
            this.btnDelItem.Location = new System.Drawing.Point(1206, 104);
            this.btnDelItem.Name = "btnDelItem";
            this.btnDelItem.Size = new System.Drawing.Size(150, 46);
            this.btnDelItem.TabIndex = 6;
            this.btnDelItem.Text = "Delete Item";
            this.btnDelItem.UseVisualStyleBackColor = false;
            this.btnDelItem.Click += new System.EventHandler(this.BtnDeleteItem_ClickEventHandler);
            // 
            // btnIncAmount
            // 
            this.btnIncAmount.AutoSize = true;
            this.btnIncAmount.Location = new System.Drawing.Point(873, 104);
            this.btnIncAmount.Name = "btnIncAmount";
            this.btnIncAmount.Size = new System.Drawing.Size(150, 46);
            this.btnIncAmount.TabIndex = 7;
            this.btnIncAmount.Text = "Inc Amount";
            this.btnIncAmount.UseVisualStyleBackColor = true;
            this.btnIncAmount.Click += new System.EventHandler(this.BtnIncAmount_ClickEventHandler);
            // 
            // btnDecAmount
            // 
            this.btnDecAmount.AutoSize = true;
            this.btnDecAmount.Location = new System.Drawing.Point(1037, 104);
            this.btnDecAmount.Name = "btnDecAmount";
            this.btnDecAmount.Size = new System.Drawing.Size(158, 46);
            this.btnDecAmount.TabIndex = 8;
            this.btnDecAmount.Text = "Dec Amount";
            this.btnDecAmount.UseVisualStyleBackColor = true;
            this.btnDecAmount.Click += new System.EventHandler(this.BtnDecAmount_ClickEventHandler);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(916, 167);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(389, 39);
            this.txtSearch.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(1311, 165);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(45, 42);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = ">";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_ClickEventHandler);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(334, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 50);
            this.label3.TabIndex = 12;
            this.label3.Text = "Transactions";
            // 
            // gvIncome
            // 
            this.gvIncome.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gvIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvIncome.Location = new System.Drawing.Point(334, 213);
            this.gvIncome.Name = "gvIncome";
            this.gvIncome.RowHeadersWidth = 82;
            this.gvIncome.RowTemplate.Height = 41;
            this.gvIncome.Size = new System.Drawing.Size(1022, 422);
            this.gvIncome.TabIndex = 13;
            this.gvIncome.Click += new System.EventHandler(this.GridView_ClickEventHandler);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox2.Location = new System.Drawing.Point(334, 653);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1022, 115);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAddItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddItem.Location = new System.Drawing.Point(1285, 674);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(51, 76);
            this.btnAddItem.TabIndex = 15;
            this.btnAddItem.Text = "+";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.BtnAddItem_ClickEventHandler);
            // 
            // cmbInOrOut
            // 
            this.cmbInOrOut.FormattingEnabled = true;
            this.cmbInOrOut.Items.AddRange(new object[] {
            "+",
            "-"});
            this.cmbInOrOut.Location = new System.Drawing.Point(354, 710);
            this.cmbInOrOut.Name = "cmbInOrOut";
            this.cmbInOrOut.Size = new System.Drawing.Size(124, 40);
            this.cmbInOrOut.TabIndex = 16;
            // 
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbMonth.Location = new System.Drawing.Point(484, 710);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(166, 40);
            this.cmbMonth.TabIndex = 17;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Hoilday",
            "Job",
            "Event",
            "Vacation",
            "Grocery",
            "Entertainment",
            "Etc."});
            this.cmbCategory.Location = new System.Drawing.Point(1068, 710);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(201, 40);
            this.cmbCategory.TabIndex = 18;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(656, 711);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(221, 39);
            this.txtName.TabIndex = 19;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(883, 710);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(179, 39);
            this.txtAmount.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(376, 674);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 32);
            this.label4.TabIndex = 21;
            this.label4.Text = "In/Out";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(525, 674);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 32);
            this.label5.TabIndex = 22;
            this.label5.Text = "Month";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(729, 674);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 32);
            this.label6.TabIndex = 23;
            this.label6.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(923, 674);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 32);
            this.label7.TabIndex = 24;
            this.label7.Text = "Amount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Location = new System.Drawing.Point(1116, 674);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 32);
            this.label8.TabIndex = 25;
            this.label8.Text = "Category";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblErrorMsg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblErrorMsg.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErrorMsg.Location = new System.Drawing.Point(334, 213);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(1022, 422);
            this.lblErrorMsg.TabIndex = 26;
            this.lblErrorMsg.Text = "There is something wrong with your input. \r\nPlease try again after checking. ";
            this.lblErrorMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblErrorMsg.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transactionsToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 146);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(283, 666);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "Transactions";
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.transactionsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(279, 41);
            this.transactionsToolStripMenuItem.Text = "Transactions";
            // 
            // FrmTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 813);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.cmbInOrOut);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.gvIncome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnDecAmount);
            this.Controls.Add(this.btnIncAmount);
            this.Controls.Add(this.btnDelItem);
            this.Controls.Add(this.btnReadFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmTransactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DailyPay";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvIncome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnReadFile;
        private Button btnDelItem;
        private Button btnIncAmount;
        private Button btnDecAmount;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label label3;
        private DataGridView gvIncome;
        private PictureBox pictureBox2;
        private Button btnAddItem;
        private ComboBox cmbInOrOut;
        private ComboBox cmbMonth;
        private ComboBox cmbCategory;
        private TextBox txtName;
        private TextBox txtAmount;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private OpenFileDialog openFileDialog;
        private Label lblErrorMsg;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem transactionsToolStripMenuItem;
    }
}