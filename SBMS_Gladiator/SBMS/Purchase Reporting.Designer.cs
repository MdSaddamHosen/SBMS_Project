namespace SBMS
{
    partial class Purchase_Reporting
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
            this.startDateTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.purchaseReportingDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.endDateTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseReportingDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Date";
            // 
            // startDateTextBox
            // 
            this.startDateTextBox.Location = new System.Drawing.Point(106, 44);
            this.startDateTextBox.Name = "startDateTextBox";
            this.startDateTextBox.Size = new System.Drawing.Size(157, 20);
            this.startDateTextBox.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(573, 38);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(71, 26);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // purchaseReportingDataGridView
            // 
            this.purchaseReportingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchaseReportingDataGridView.Location = new System.Drawing.Point(43, 89);
            this.purchaseReportingDataGridView.Name = "purchaseReportingDataGridView";
            this.purchaseReportingDataGridView.Size = new System.Drawing.Size(648, 180);
            this.purchaseReportingDataGridView.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "End Date";
            // 
            // endDateTextBox
            // 
            this.endDateTextBox.Location = new System.Drawing.Point(367, 43);
            this.endDateTextBox.Name = "endDateTextBox";
            this.endDateTextBox.Size = new System.Drawing.Size(157, 20);
            this.endDateTextBox.TabIndex = 1;
            // 
            // Purchase_Reporting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 291);
            this.Controls.Add(this.purchaseReportingDataGridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.endDateTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startDateTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Purchase_Reporting";
            this.Text = "Purchase_Reporting";
            ((System.ComponentModel.ISupportInitialize)(this.purchaseReportingDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox startDateTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView purchaseReportingDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox endDateTextBox;
    }
}