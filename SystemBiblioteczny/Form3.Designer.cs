namespace SystemBiblioteczny
{
    partial class BookReturnForm
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
            this.BookIDEnterLabel = new System.Windows.Forms.Label();
            this.StudentIDEnterLabel = new System.Windows.Forms.Label();
            this.BookIDEnterTB = new System.Windows.Forms.TextBox();
            this.StudentIDEnterTB = new System.Windows.Forms.TextBox();
            this.BookReturnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BookIDEnterLabel
            // 
            this.BookIDEnterLabel.AutoSize = true;
            this.BookIDEnterLabel.Location = new System.Drawing.Point(73, 52);
            this.BookIDEnterLabel.Name = "BookIDEnterLabel";
            this.BookIDEnterLabel.Size = new System.Drawing.Size(83, 13);
            this.BookIDEnterLabel.TabIndex = 0;
            this.BookIDEnterLabel.Text = "Podaj ID książki";
            // 
            // StudentIDEnterLabel
            // 
            this.StudentIDEnterLabel.AutoSize = true;
            this.StudentIDEnterLabel.Location = new System.Drawing.Point(73, 114);
            this.StudentIDEnterLabel.Name = "StudentIDEnterLabel";
            this.StudentIDEnterLabel.Size = new System.Drawing.Size(95, 13);
            this.StudentIDEnterLabel.TabIndex = 0;
            this.StudentIDEnterLabel.Text = "Podaj ID  studenta";
            // 
            // BookIDEnterTB
            // 
            this.BookIDEnterTB.Location = new System.Drawing.Point(217, 49);
            this.BookIDEnterTB.Name = "BookIDEnterTB";
            this.BookIDEnterTB.Size = new System.Drawing.Size(198, 20);
            this.BookIDEnterTB.TabIndex = 1;
            // 
            // StudentIDEnterTB
            // 
            this.StudentIDEnterTB.Location = new System.Drawing.Point(217, 111);
            this.StudentIDEnterTB.Name = "StudentIDEnterTB";
            this.StudentIDEnterTB.Size = new System.Drawing.Size(198, 20);
            this.StudentIDEnterTB.TabIndex = 1;
            // 
            // BookReturnButton
            // 
            this.BookReturnButton.Location = new System.Drawing.Point(160, 218);
            this.BookReturnButton.Name = "BookReturnButton";
            this.BookReturnButton.Size = new System.Drawing.Size(125, 60);
            this.BookReturnButton.TabIndex = 2;
            this.BookReturnButton.Text = "Oddaj książke";
            this.BookReturnButton.UseVisualStyleBackColor = true;
            // 
            // BookReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 323);
            this.Controls.Add(this.BookReturnButton);
            this.Controls.Add(this.StudentIDEnterTB);
            this.Controls.Add(this.BookIDEnterTB);
            this.Controls.Add(this.StudentIDEnterLabel);
            this.Controls.Add(this.BookIDEnterLabel);
            this.Name = "BookReturnForm";
            this.Text = "Zwrot książki";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BookIDEnterLabel;
        private System.Windows.Forms.Label StudentIDEnterLabel;
        private System.Windows.Forms.TextBox BookIDEnterTB;
        private System.Windows.Forms.TextBox StudentIDEnterTB;
        private System.Windows.Forms.Button BookReturnButton;
    }
}