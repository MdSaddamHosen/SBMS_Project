namespace SBMS
{
    partial class Reporting_Sales
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
            this.endDateTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.reportingSalesDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.startDateTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.reportingSalesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "End Date";
            // 
            // endDateTextBox
            // 
            this.endDateTextBox.Location = new System.Drawing.Point(388, 39);
            this.endDateTextBox.Name = "endDateTextBox";
            this.endDateTextBox.Size = new System.Drawing.Size(154, 20);
            this.endDateTextBox.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(584, 36);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(72, 25);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // reportingSalesDataGridView
            // 
            this.reportingSalesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportingSalesDataGridView.Location = new System.Drawing.Point(33, 83);
            this.reportingSalesDataGridView.Name = "reportingSalesDataGridView";
            this.reportingSalesDataGridView.Size = new System.Drawing.Size(690, 239);
            this.reportingSalesDataGridView.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Start Date";
            // 
            // startDateTextBox
            // 
            this.startDateTextBox.Location = new System.Drawing.Point(106, 42);
            this.startDateTextBox.Name = "startDateTextBox";
            this.startDateTextBox.Size = new System.Drawing.Size(154, 20);
            this.startDateTextBox.TabIndex = 1;
            // 
            // Reporting_Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 345);
            this.Controls.Add(this.reportingSalesDataGridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.startDateTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.endDateTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Reporting_Sales";
            this.Text = "Reporting_Sales";
            ((System.ComponentModel.ISupportInitialize)(this.reportingSalesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox endDateTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView reportingSalesDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox startDateTextBox;
    }
}