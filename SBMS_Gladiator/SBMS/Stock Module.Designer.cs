namespace SBMS
{
    partial class Stock_Module
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
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.stockModuleDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startDateTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.endDateTextBox = new System.Windows.Forms.TextBox();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.reOrderLevelCheckBox = new System.Windows.Forms.CheckBox();
            this.expiredCheckBox = new System.Windows.Forms.CheckBox();
            this.damageCheckBox = new System.Windows.Forms.CheckBox();
            this.lostCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.stockModuleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(516, 49);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(82, 34);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // stockModuleDataGridView
            // 
            this.stockModuleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockModuleDataGridView.Location = new System.Drawing.Point(29, 190);
            this.stockModuleDataGridView.Name = "stockModuleDataGridView";
            this.stockModuleDataGridView.Size = new System.Drawing.Size(537, 199);
            this.stockModuleDataGridView.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Catagory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Start Date";
            // 
            // startDateTextBox
            // 
            this.startDateTextBox.Location = new System.Drawing.Point(332, 31);
            this.startDateTextBox.Name = "startDateTextBox";
            this.startDateTextBox.Size = new System.Drawing.Size(159, 20);
            this.startDateTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "End Date";
            // 
            // endDateTextBox
            // 
            this.endDateTextBox.Location = new System.Drawing.Point(332, 76);
            this.endDateTextBox.Name = "endDateTextBox";
            this.endDateTextBox.Size = new System.Drawing.Size(159, 20);
            this.endDateTextBox.TabIndex = 1;
            // 
            // productComboBox
            // 
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(76, 38);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(163, 21);
            this.productComboBox.TabIndex = 4;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(81, 80);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(163, 21);
            this.categoryComboBox.TabIndex = 4;
            // 
            // reOrderLevelCheckBox
            // 
            this.reOrderLevelCheckBox.AutoSize = true;
            this.reOrderLevelCheckBox.Location = new System.Drawing.Point(82, 129);
            this.reOrderLevelCheckBox.Name = "reOrderLevelCheckBox";
            this.reOrderLevelCheckBox.Size = new System.Drawing.Size(98, 17);
            this.reOrderLevelCheckBox.TabIndex = 5;
            this.reOrderLevelCheckBox.Text = "Re Order Lebel";
            this.reOrderLevelCheckBox.UseVisualStyleBackColor = true;
            // 
            // expiredCheckBox
            // 
            this.expiredCheckBox.AutoSize = true;
            this.expiredCheckBox.Location = new System.Drawing.Point(185, 129);
            this.expiredCheckBox.Name = "expiredCheckBox";
            this.expiredCheckBox.Size = new System.Drawing.Size(61, 17);
            this.expiredCheckBox.TabIndex = 5;
            this.expiredCheckBox.Text = "Expired";
            this.expiredCheckBox.UseVisualStyleBackColor = true;
            // 
            // damageCheckBox
            // 
            this.damageCheckBox.AutoSize = true;
            this.damageCheckBox.Location = new System.Drawing.Point(298, 129);
            this.damageCheckBox.Name = "damageCheckBox";
            this.damageCheckBox.Size = new System.Drawing.Size(66, 17);
            this.damageCheckBox.TabIndex = 5;
            this.damageCheckBox.Text = "Damage";
            this.damageCheckBox.UseVisualStyleBackColor = true;
            // 
            // lostCheckBox
            // 
            this.lostCheckBox.AutoSize = true;
            this.lostCheckBox.Location = new System.Drawing.Point(408, 129);
            this.lostCheckBox.Name = "lostCheckBox";
            this.lostCheckBox.Size = new System.Drawing.Size(46, 17);
            this.lostCheckBox.TabIndex = 5;
            this.lostCheckBox.Text = "Lost";
            this.lostCheckBox.UseVisualStyleBackColor = true;
            // 
            // Stock_Module
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 418);
            this.Controls.Add(this.lostCheckBox);
            this.Controls.Add(this.damageCheckBox);
            this.Controls.Add(this.expiredCheckBox);
            this.Controls.Add(this.reOrderLevelCheckBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.productComboBox);
            this.Controls.Add(this.stockModuleDataGridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.endDateTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startDateTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Stock_Module";
            this.Text = "Stock_Module";
            ((System.ComponentModel.ISupportInitialize)(this.stockModuleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView stockModuleDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox startDateTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox endDateTextBox;
        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.CheckBox reOrderLevelCheckBox;
        private System.Windows.Forms.CheckBox expiredCheckBox;
        private System.Windows.Forms.CheckBox damageCheckBox;
        private System.Windows.Forms.CheckBox lostCheckBox;
    }
}