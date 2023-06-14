namespace CST_150_Final_2._0.PresentationLayer
{
    partial class FrmBudget
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
            this.gvSearchResults = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalSpending = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalIncome = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBudgetLeft = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvSearchResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gvSearchResults
            // 
            this.gvSearchResults.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gvSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSearchResults.Location = new System.Drawing.Point(94, 147);
            this.gvSearchResults.Name = "gvSearchResults";
            this.gvSearchResults.RowHeadersWidth = 82;
            this.gvSearchResults.RowTemplate.Height = 41;
            this.gvSearchResults.Size = new System.Drawing.Size(805, 320);
            this.gvSearchResults.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(555, 551);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Spendings: ";
            // 
            // lblTotalSpending
            // 
            this.lblTotalSpending.AutoSize = true;
            this.lblTotalSpending.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotalSpending.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalSpending.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTotalSpending.Location = new System.Drawing.Point(792, 541);
            this.lblTotalSpending.Name = "lblTotalSpending";
            this.lblTotalSpending.Size = new System.Drawing.Size(107, 45);
            this.lblTotalSpending.TabIndex = 2;
            this.lblTotalSpending.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(94, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 45);
            this.label3.TabIndex = 3;
            this.label3.Text = "Search Results";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(58, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(878, 635);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(588, 506);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total Income: ";
            // 
            // lblTotalIncome
            // 
            this.lblTotalIncome.AutoSize = true;
            this.lblTotalIncome.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotalIncome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalIncome.Location = new System.Drawing.Point(792, 496);
            this.lblTotalIncome.Name = "lblTotalIncome";
            this.lblTotalIncome.Size = new System.Drawing.Size(107, 45);
            this.lblTotalIncome.TabIndex = 6;
            this.lblTotalIncome.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(601, 631);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Budget Left: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(535, 583);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(364, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "-----------------------------------";
            // 
            // lblBudgetLeft
            // 
            this.lblBudgetLeft.AutoSize = true;
            this.lblBudgetLeft.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBudgetLeft.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBudgetLeft.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblBudgetLeft.Location = new System.Drawing.Point(789, 621);
            this.lblBudgetLeft.Name = "lblBudgetLeft";
            this.lblBudgetLeft.Size = new System.Drawing.Size(110, 45);
            this.lblBudgetLeft.TabIndex = 10;
            this.lblBudgetLeft.Text = "label6";
            // 
            // FrmBudget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 748);
            this.Controls.Add(this.lblBudgetLeft);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotalIncome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotalSpending);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvSearchResults);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmBudget";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recommended Budget";
            this.Load += new System.EventHandler(this.FrmBudget_LoadEventHandler);
            ((System.ComponentModel.ISupportInitialize)(this.gvSearchResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView gvSearchResults;
        private Label label1;
        private Label lblTotalSpending;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label2;
        private Label lblTotalIncome;
        private Label label4;
        private Label label5;
        private Label lblBudgetLeft;
    }
}