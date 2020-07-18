namespace SystemBiblioteczny
{
    partial class IssueInfo
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
            this.DataGridIssue = new System.Windows.Forms.DataGridView();
            this.SearchIssueButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridIssue)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridIssue
            // 
            this.DataGridIssue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridIssue.Location = new System.Drawing.Point(12, 54);
            this.DataGridIssue.Name = "DataGridIssue";
            this.DataGridIssue.Size = new System.Drawing.Size(467, 417);
            this.DataGridIssue.TabIndex = 0;
            // 
            // SearchIssueButton
            // 
            this.SearchIssueButton.Location = new System.Drawing.Point(12, 12);
            this.SearchIssueButton.Name = "SearchIssueButton";
            this.SearchIssueButton.Size = new System.Drawing.Size(126, 35);
            this.SearchIssueButton.TabIndex = 1;
            this.SearchIssueButton.Text = "Szukaj";
            this.SearchIssueButton.UseVisualStyleBackColor = true;
            this.SearchIssueButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // IssueInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 480);
            this.Controls.Add(this.SearchIssueButton);
            this.Controls.Add(this.DataGridIssue);
            this.Name = "IssueInfo";
            this.Text = "Dane o wypozyczeniach";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridIssue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridIssue;
        private System.Windows.Forms.Button SearchIssueButton;
    }
}