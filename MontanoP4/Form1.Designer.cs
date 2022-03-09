namespace MontanoP4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabHowToUse = new System.Windows.Forms.TabPage();
            this.lblHowToUse = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabInventory = new System.Windows.Forms.TabPage();
            this.cbxTypeOFDep = new System.Windows.Forms.ComboBox();
            this.lbxInventory = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAddToInventory = new System.Windows.Forms.Button();
            this.dtpOutofInventory = new System.Windows.Forms.DateTimePicker();
            this.dtpInInventory = new System.Windows.Forms.DateTimePicker();
            this.txbLifetime = new System.Windows.Forms.TextBox();
            this.txbEndVal = new System.Windows.Forms.TextBox();
            this.txbStartVal = new System.Windows.Forms.TextBox();
            this.txbTitle = new System.Windows.Forms.TextBox();
            this.lblDateOutOfInventory = new System.Windows.Forms.Label();
            this.lblDateInInventory = new System.Windows.Forms.Label();
            this.lblLifetime = new System.Windows.Forms.Label();
            this.lblEndVal = new System.Windows.Forms.Label();
            this.lblStartVal = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabSummary = new System.Windows.Forms.TabPage();
            this.btnCalculateInventoryVal = new System.Windows.Forms.Button();
            this.txbTotalInventory = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabHowToUse.SuspendLayout();
            this.tabInventory.SuspendLayout();
            this.tabSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabHowToUse);
            this.tabControl1.Controls.Add(this.tabInventory);
            this.tabControl1.Controls.Add(this.tabSummary);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(21, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(830, 648);
            this.tabControl1.TabIndex = 0;
            // 
            // tabHowToUse
            // 
            this.tabHowToUse.BackColor = System.Drawing.Color.Peru;
            this.tabHowToUse.Controls.Add(this.lblHowToUse);
            this.tabHowToUse.Controls.Add(this.textBox1);
            this.tabHowToUse.Location = new System.Drawing.Point(4, 24);
            this.tabHowToUse.Name = "tabHowToUse";
            this.tabHowToUse.Padding = new System.Windows.Forms.Padding(3);
            this.tabHowToUse.Size = new System.Drawing.Size(822, 620);
            this.tabHowToUse.TabIndex = 0;
            this.tabHowToUse.Text = "How to use this application";
            // 
            // lblHowToUse
            // 
            this.lblHowToUse.AutoSize = true;
            this.lblHowToUse.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblHowToUse.Location = new System.Drawing.Point(223, 135);
            this.lblHowToUse.Name = "lblHowToUse";
            this.lblHowToUse.Size = new System.Drawing.Size(293, 30);
            this.lblHowToUse.TabIndex = 1;
            this.lblHowToUse.Text = "Depreciation Calculator App";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(177, 249);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(382, 178);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Welcome. Click the inventory tab and enter the information needed. The summary ta" +
    "b will give you the total of your inventory.";
            // 
            // tabInventory
            // 
            this.tabInventory.BackColor = System.Drawing.Color.Peru;
            this.tabInventory.Controls.Add(this.cbxTypeOFDep);
            this.tabInventory.Controls.Add(this.lbxInventory);
            this.tabInventory.Controls.Add(this.btnRemove);
            this.tabInventory.Controls.Add(this.btnAddToInventory);
            this.tabInventory.Controls.Add(this.dtpOutofInventory);
            this.tabInventory.Controls.Add(this.dtpInInventory);
            this.tabInventory.Controls.Add(this.txbLifetime);
            this.tabInventory.Controls.Add(this.txbEndVal);
            this.tabInventory.Controls.Add(this.txbStartVal);
            this.tabInventory.Controls.Add(this.txbTitle);
            this.tabInventory.Controls.Add(this.lblDateOutOfInventory);
            this.tabInventory.Controls.Add(this.lblDateInInventory);
            this.tabInventory.Controls.Add(this.lblLifetime);
            this.tabInventory.Controls.Add(this.lblEndVal);
            this.tabInventory.Controls.Add(this.lblStartVal);
            this.tabInventory.Controls.Add(this.lblTitle);
            this.tabInventory.Location = new System.Drawing.Point(4, 24);
            this.tabInventory.Name = "tabInventory";
            this.tabInventory.Padding = new System.Windows.Forms.Padding(3);
            this.tabInventory.Size = new System.Drawing.Size(822, 620);
            this.tabInventory.TabIndex = 1;
            this.tabInventory.Text = "Inventory";
            // 
            // cbxTypeOFDep
            // 
            this.cbxTypeOFDep.FormattingEnabled = true;
            this.cbxTypeOFDep.Items.AddRange(new object[] {
            "Straight Line",
            "Double Decline"});
            this.cbxTypeOFDep.Location = new System.Drawing.Point(575, 315);
            this.cbxTypeOFDep.Name = "cbxTypeOFDep";
            this.cbxTypeOFDep.Size = new System.Drawing.Size(163, 23);
            this.cbxTypeOFDep.TabIndex = 17;
            this.cbxTypeOFDep.Text = "Straight Line";
            // 
            // lbxInventory
            // 
            this.lbxInventory.FormattingEnabled = true;
            this.lbxInventory.HorizontalScrollbar = true;
            this.lbxInventory.ItemHeight = 15;
            this.lbxInventory.Location = new System.Drawing.Point(40, 51);
            this.lbxInventory.Name = "lbxInventory";
            this.lbxInventory.Size = new System.Drawing.Size(342, 424);
            this.lbxInventory.TabIndex = 16;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(40, 492);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(342, 62);
            this.btnRemove.TabIndex = 15;
            this.btnRemove.Text = "Remove Selected Item From Inventory";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAddToInventory
            // 
            this.btnAddToInventory.Location = new System.Drawing.Point(456, 424);
            this.btnAddToInventory.Name = "btnAddToInventory";
            this.btnAddToInventory.Size = new System.Drawing.Size(327, 39);
            this.btnAddToInventory.TabIndex = 14;
            this.btnAddToInventory.Text = "Add Item to Inventory";
            this.btnAddToInventory.UseVisualStyleBackColor = true;
            this.btnAddToInventory.Click += new System.EventHandler(this.btnAddToInventory_Click);
            // 
            // dtpOutofInventory
            // 
            this.dtpOutofInventory.Location = new System.Drawing.Point(550, 258);
            this.dtpOutofInventory.Name = "dtpOutofInventory";
            this.dtpOutofInventory.Size = new System.Drawing.Size(233, 23);
            this.dtpOutofInventory.TabIndex = 12;
            // 
            // dtpInInventory
            // 
            this.dtpInInventory.Location = new System.Drawing.Point(550, 211);
            this.dtpInInventory.Name = "dtpInInventory";
            this.dtpInInventory.Size = new System.Drawing.Size(233, 23);
            this.dtpInInventory.TabIndex = 11;
            // 
            // txbLifetime
            // 
            this.txbLifetime.BackColor = System.Drawing.Color.PeachPuff;
            this.txbLifetime.Location = new System.Drawing.Point(550, 174);
            this.txbLifetime.Name = "txbLifetime";
            this.txbLifetime.Size = new System.Drawing.Size(233, 23);
            this.txbLifetime.TabIndex = 10;
            // 
            // txbEndVal
            // 
            this.txbEndVal.BackColor = System.Drawing.Color.PeachPuff;
            this.txbEndVal.Location = new System.Drawing.Point(550, 137);
            this.txbEndVal.Name = "txbEndVal";
            this.txbEndVal.Size = new System.Drawing.Size(233, 23);
            this.txbEndVal.TabIndex = 9;
            // 
            // txbStartVal
            // 
            this.txbStartVal.BackColor = System.Drawing.Color.PeachPuff;
            this.txbStartVal.Location = new System.Drawing.Point(550, 98);
            this.txbStartVal.Name = "txbStartVal";
            this.txbStartVal.Size = new System.Drawing.Size(233, 23);
            this.txbStartVal.TabIndex = 8;
            // 
            // txbTitle
            // 
            this.txbTitle.BackColor = System.Drawing.Color.PeachPuff;
            this.txbTitle.Location = new System.Drawing.Point(550, 55);
            this.txbTitle.Name = "txbTitle";
            this.txbTitle.Size = new System.Drawing.Size(233, 23);
            this.txbTitle.TabIndex = 7;
            // 
            // lblDateOutOfInventory
            // 
            this.lblDateOutOfInventory.AutoSize = true;
            this.lblDateOutOfInventory.BackColor = System.Drawing.Color.Transparent;
            this.lblDateOutOfInventory.Location = new System.Drawing.Point(403, 264);
            this.lblDateOutOfInventory.Name = "lblDateOutOfInventory";
            this.lblDateOutOfInventory.Size = new System.Drawing.Size(128, 15);
            this.lblDateOutOfInventory.TabIndex = 6;
            this.lblDateOutOfInventory.Text = "Date out of inventory";
            // 
            // lblDateInInventory
            // 
            this.lblDateInInventory.AutoSize = true;
            this.lblDateInInventory.BackColor = System.Drawing.Color.Transparent;
            this.lblDateInInventory.Location = new System.Drawing.Point(403, 217);
            this.lblDateInInventory.Name = "lblDateInInventory";
            this.lblDateInInventory.Size = new System.Drawing.Size(104, 15);
            this.lblDateInInventory.TabIndex = 5;
            this.lblDateInInventory.Text = "Date in inventory";
            // 
            // lblLifetime
            // 
            this.lblLifetime.AutoSize = true;
            this.lblLifetime.BackColor = System.Drawing.Color.Transparent;
            this.lblLifetime.Location = new System.Drawing.Point(403, 177);
            this.lblLifetime.Name = "lblLifetime";
            this.lblLifetime.Size = new System.Drawing.Size(94, 15);
            this.lblLifetime.TabIndex = 4;
            this.lblLifetime.Text = "Lifetime (years)";
            // 
            // lblEndVal
            // 
            this.lblEndVal.AutoSize = true;
            this.lblEndVal.BackColor = System.Drawing.Color.Transparent;
            this.lblEndVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEndVal.Location = new System.Drawing.Point(403, 140);
            this.lblEndVal.Name = "lblEndVal";
            this.lblEndVal.Size = new System.Drawing.Size(70, 15);
            this.lblEndVal.TabIndex = 3;
            this.lblEndVal.Text = "End Value $";
            // 
            // lblStartVal
            // 
            this.lblStartVal.AutoSize = true;
            this.lblStartVal.BackColor = System.Drawing.Color.Transparent;
            this.lblStartVal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStartVal.Location = new System.Drawing.Point(403, 101);
            this.lblStartVal.Name = "lblStartVal";
            this.lblStartVal.Size = new System.Drawing.Size(95, 15);
            this.lblStartVal.TabIndex = 2;
            this.lblStartVal.Text = "Starting Value $";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitle.Location = new System.Drawing.Point(403, 63);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(32, 15);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            // 
            // tabSummary
            // 
            this.tabSummary.BackColor = System.Drawing.Color.Peru;
            this.tabSummary.Controls.Add(this.btnCalculateInventoryVal);
            this.tabSummary.Controls.Add(this.txbTotalInventory);
            this.tabSummary.Location = new System.Drawing.Point(4, 24);
            this.tabSummary.Name = "tabSummary";
            this.tabSummary.Padding = new System.Windows.Forms.Padding(3);
            this.tabSummary.Size = new System.Drawing.Size(822, 620);
            this.tabSummary.TabIndex = 2;
            this.tabSummary.Text = "Summary";
            // 
            // btnCalculateInventoryVal
            // 
            this.btnCalculateInventoryVal.Location = new System.Drawing.Point(199, 172);
            this.btnCalculateInventoryVal.Name = "btnCalculateInventoryVal";
            this.btnCalculateInventoryVal.Size = new System.Drawing.Size(377, 52);
            this.btnCalculateInventoryVal.TabIndex = 1;
            this.btnCalculateInventoryVal.Text = "Calculate Inventory Value";
            this.btnCalculateInventoryVal.UseVisualStyleBackColor = true;
            // 
            // txbTotalInventory
            // 
            this.txbTotalInventory.Location = new System.Drawing.Point(199, 269);
            this.txbTotalInventory.Name = "txbTotalInventory";
            this.txbTotalInventory.Size = new System.Drawing.Size(377, 23);
            this.txbTotalInventory.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(883, 729);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Montano Depreciation Calculator";
            this.tabControl1.ResumeLayout(false);
            this.tabHowToUse.ResumeLayout(false);
            this.tabHowToUse.PerformLayout();
            this.tabInventory.ResumeLayout(false);
            this.tabInventory.PerformLayout();
            this.tabSummary.ResumeLayout(false);
            this.tabSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabHowToUse;
        private System.Windows.Forms.Label lblHowToUse;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabInventory;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAddToInventory;
        private System.Windows.Forms.DateTimePicker dtpOutofInventory;
        private System.Windows.Forms.DateTimePicker dtpInInventory;
        private System.Windows.Forms.TextBox txbLifetime;
        private System.Windows.Forms.TextBox txbEndVal;
        private System.Windows.Forms.TextBox txbStartVal;
        private System.Windows.Forms.TextBox txbTitle;
        private System.Windows.Forms.Label lblDateOutOfInventory;
        private System.Windows.Forms.Label lblDateInInventory;
        private System.Windows.Forms.Label lblLifetime;
        private System.Windows.Forms.Label lblEndVal;
        private System.Windows.Forms.Label lblStartVal;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabPage tabSummary;
        private System.Windows.Forms.Button btnCalculateInventoryVal;
        private System.Windows.Forms.TextBox txbTotalInventory;
        private System.Windows.Forms.ListBox lbxInventory;
        private System.Windows.Forms.ComboBox cbxTypeOFDep;
    }
}
