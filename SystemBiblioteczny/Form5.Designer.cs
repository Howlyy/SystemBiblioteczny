namespace SystemBiblioteczny
{
    partial class BookManageForm
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
            this.BookIDNumberLabel = new System.Windows.Forms.Label();
            this.BookTitleLabel = new System.Windows.Forms.Label();
            this.BookCategoryLabel = new System.Windows.Forms.Label();
            this.BookQuantityLabel = new System.Windows.Forms.Label();
            this.BookIDNumberRemoveLabel = new System.Windows.Forms.Label();
            this.BookTitleRemoveLabel = new System.Windows.Forms.Label();
            this.BookCategoryRemoveLabel = new System.Windows.Forms.Label();
            this.BookQuantityRemoveLabel = new System.Windows.Forms.Label();
            this.BookAddGB = new System.Windows.Forms.GroupBox();
            this.BookCategoryCB = new System.Windows.Forms.ComboBox();
            this.BookQuantityCB = new System.Windows.Forms.TextBox();
            this.BookTitleCB = new System.Windows.Forms.TextBox();
            this.BookIDNumberTB = new System.Windows.Forms.TextBox();
            this.BookRemoveGB = new System.Windows.Forms.GroupBox();
            this.BookCategoryRemoveCB = new System.Windows.Forms.ComboBox();
            this.BookQuantityRemoveTB = new System.Windows.Forms.TextBox();
            this.BookTitleRemoveTB = new System.Windows.Forms.TextBox();
            this.BookIDNumberRemoveTB = new System.Windows.Forms.TextBox();
            this.BookAddButton = new System.Windows.Forms.Button();
            this.BookRemoveButton = new System.Windows.Forms.Button();
            this.BookAddGB.SuspendLayout();
            this.BookRemoveGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // BookIDNumberLabel
            // 
            this.BookIDNumberLabel.AutoSize = true;
            this.BookIDNumberLabel.Location = new System.Drawing.Point(13, 19);
            this.BookIDNumberLabel.Name = "BookIDNumberLabel";
            this.BookIDNumberLabel.Size = new System.Drawing.Size(87, 13);
            this.BookIDNumberLabel.TabIndex = 0;
            this.BookIDNumberLabel.Text = "Numer ID książki";
            // 
            // BookTitleLabel
            // 
            this.BookTitleLabel.AutoSize = true;
            this.BookTitleLabel.Location = new System.Drawing.Point(13, 49);
            this.BookTitleLabel.Name = "BookTitleLabel";
            this.BookTitleLabel.Size = new System.Drawing.Size(67, 13);
            this.BookTitleLabel.TabIndex = 0;
            this.BookTitleLabel.Text = "Tytuł książki";
            // 
            // BookCategoryLabel
            // 
            this.BookCategoryLabel.AutoSize = true;
            this.BookCategoryLabel.Location = new System.Drawing.Point(13, 100);
            this.BookCategoryLabel.Name = "BookCategoryLabel";
            this.BookCategoryLabel.Size = new System.Drawing.Size(52, 13);
            this.BookCategoryLabel.TabIndex = 0;
            this.BookCategoryLabel.Text = "Kategoria";
            // 
            // BookQuantityLabel
            // 
            this.BookQuantityLabel.AutoSize = true;
            this.BookQuantityLabel.Location = new System.Drawing.Point(13, 157);
            this.BookQuantityLabel.Name = "BookQuantityLabel";
            this.BookQuantityLabel.Size = new System.Drawing.Size(68, 13);
            this.BookQuantityLabel.TabIndex = 0;
            this.BookQuantityLabel.Text = "Ilość książek";
            // 
            // BookIDNumberRemoveLabel
            // 
            this.BookIDNumberRemoveLabel.AutoSize = true;
            this.BookIDNumberRemoveLabel.Location = new System.Drawing.Point(72, 38);
            this.BookIDNumberRemoveLabel.Name = "BookIDNumberRemoveLabel";
            this.BookIDNumberRemoveLabel.Size = new System.Drawing.Size(87, 13);
            this.BookIDNumberRemoveLabel.TabIndex = 0;
            this.BookIDNumberRemoveLabel.Text = "Numer ID książki";
            // 
            // BookTitleRemoveLabel
            // 
            this.BookTitleRemoveLabel.AutoSize = true;
            this.BookTitleRemoveLabel.Location = new System.Drawing.Point(72, 93);
            this.BookTitleRemoveLabel.Name = "BookTitleRemoveLabel";
            this.BookTitleRemoveLabel.Size = new System.Drawing.Size(67, 13);
            this.BookTitleRemoveLabel.TabIndex = 0;
            this.BookTitleRemoveLabel.Text = "Tytuł ksiażki";
            // 
            // BookCategoryRemoveLabel
            // 
            this.BookCategoryRemoveLabel.AutoSize = true;
            this.BookCategoryRemoveLabel.Location = new System.Drawing.Point(72, 135);
            this.BookCategoryRemoveLabel.Name = "BookCategoryRemoveLabel";
            this.BookCategoryRemoveLabel.Size = new System.Drawing.Size(52, 13);
            this.BookCategoryRemoveLabel.TabIndex = 0;
            this.BookCategoryRemoveLabel.Text = "Kategoria";
            // 
            // BookQuantityRemoveLabel
            // 
            this.BookQuantityRemoveLabel.AutoSize = true;
            this.BookQuantityRemoveLabel.Location = new System.Drawing.Point(63, 177);
            this.BookQuantityRemoveLabel.Name = "BookQuantityRemoveLabel";
            this.BookQuantityRemoveLabel.Size = new System.Drawing.Size(68, 13);
            this.BookQuantityRemoveLabel.TabIndex = 0;
            this.BookQuantityRemoveLabel.Text = "Ilość książek";
            // 
            // BookAddGB
            // 
            this.BookAddGB.Controls.Add(this.BookCategoryCB);
            this.BookAddGB.Controls.Add(this.BookQuantityCB);
            this.BookAddGB.Controls.Add(this.BookTitleCB);
            this.BookAddGB.Controls.Add(this.BookIDNumberTB);
            this.BookAddGB.Controls.Add(this.BookQuantityLabel);
            this.BookAddGB.Controls.Add(this.BookCategoryLabel);
            this.BookAddGB.Controls.Add(this.BookTitleLabel);
            this.BookAddGB.Controls.Add(this.BookIDNumberLabel);
            this.BookAddGB.Location = new System.Drawing.Point(77, 35);
            this.BookAddGB.Name = "BookAddGB";
            this.BookAddGB.Size = new System.Drawing.Size(476, 200);
            this.BookAddGB.TabIndex = 1;
            this.BookAddGB.TabStop = false;
            this.BookAddGB.Text = "Dodawanie książki";
            // 
            // BookCategoryCB
            // 
            this.BookCategoryCB.FormattingEnabled = true;
            this.BookCategoryCB.Location = new System.Drawing.Point(204, 100);
            this.BookCategoryCB.Name = "BookCategoryCB";
            this.BookCategoryCB.Size = new System.Drawing.Size(215, 21);
            this.BookCategoryCB.TabIndex = 2;
            // 
            // BookQuantityCB
            // 
            this.BookQuantityCB.Location = new System.Drawing.Point(199, 150);
            this.BookQuantityCB.Name = "BookQuantityCB";
            this.BookQuantityCB.Size = new System.Drawing.Size(221, 20);
            this.BookQuantityCB.TabIndex = 1;
            // 
            // BookTitleCB
            // 
            this.BookTitleCB.Location = new System.Drawing.Point(199, 42);
            this.BookTitleCB.Name = "BookTitleCB";
            this.BookTitleCB.Size = new System.Drawing.Size(221, 20);
            this.BookTitleCB.TabIndex = 1;
            // 
            // BookIDNumberTB
            // 
            this.BookIDNumberTB.Location = new System.Drawing.Point(199, 16);
            this.BookIDNumberTB.Name = "BookIDNumberTB";
            this.BookIDNumberTB.Size = new System.Drawing.Size(221, 20);
            this.BookIDNumberTB.TabIndex = 1;
            // 
            // BookRemoveGB
            // 
            this.BookRemoveGB.Controls.Add(this.BookCategoryRemoveCB);
            this.BookRemoveGB.Controls.Add(this.BookQuantityRemoveTB);
            this.BookRemoveGB.Controls.Add(this.BookTitleRemoveTB);
            this.BookRemoveGB.Controls.Add(this.BookIDNumberRemoveTB);
            this.BookRemoveGB.Controls.Add(this.BookQuantityRemoveLabel);
            this.BookRemoveGB.Controls.Add(this.BookCategoryRemoveLabel);
            this.BookRemoveGB.Controls.Add(this.BookTitleRemoveLabel);
            this.BookRemoveGB.Controls.Add(this.BookIDNumberRemoveLabel);
            this.BookRemoveGB.Location = new System.Drawing.Point(44, 328);
            this.BookRemoveGB.Name = "BookRemoveGB";
            this.BookRemoveGB.Size = new System.Drawing.Size(545, 226);
            this.BookRemoveGB.TabIndex = 2;
            this.BookRemoveGB.TabStop = false;
            this.BookRemoveGB.Text = "Usuwanie książki";
            // 
            // BookCategoryRemoveCB
            // 
            this.BookCategoryRemoveCB.FormattingEnabled = true;
            this.BookCategoryRemoveCB.Location = new System.Drawing.Point(235, 132);
            this.BookCategoryRemoveCB.Name = "BookCategoryRemoveCB";
            this.BookCategoryRemoveCB.Size = new System.Drawing.Size(215, 21);
            this.BookCategoryRemoveCB.TabIndex = 2;
            // 
            // BookQuantityRemoveTB
            // 
            this.BookQuantityRemoveTB.Location = new System.Drawing.Point(235, 170);
            this.BookQuantityRemoveTB.Name = "BookQuantityRemoveTB";
            this.BookQuantityRemoveTB.Size = new System.Drawing.Size(221, 20);
            this.BookQuantityRemoveTB.TabIndex = 1;
            // 
            // BookTitleRemoveTB
            // 
            this.BookTitleRemoveTB.Location = new System.Drawing.Point(235, 86);
            this.BookTitleRemoveTB.Name = "BookTitleRemoveTB";
            this.BookTitleRemoveTB.Size = new System.Drawing.Size(221, 20);
            this.BookTitleRemoveTB.TabIndex = 1;
            // 
            // BookIDNumberRemoveTB
            // 
            this.BookIDNumberRemoveTB.Location = new System.Drawing.Point(235, 31);
            this.BookIDNumberRemoveTB.Name = "BookIDNumberRemoveTB";
            this.BookIDNumberRemoveTB.Size = new System.Drawing.Size(221, 20);
            this.BookIDNumberRemoveTB.TabIndex = 1;
            // 
            // BookAddButton
            // 
            this.BookAddButton.Location = new System.Drawing.Point(223, 250);
            this.BookAddButton.Name = "BookAddButton";
            this.BookAddButton.Size = new System.Drawing.Size(195, 45);
            this.BookAddButton.TabIndex = 3;
            this.BookAddButton.Text = "Dodaj książke";
            this.BookAddButton.UseVisualStyleBackColor = true;
            // 
            // BookRemoveButton
            // 
            this.BookRemoveButton.Location = new System.Drawing.Point(202, 560);
            this.BookRemoveButton.Name = "BookRemoveButton";
            this.BookRemoveButton.Size = new System.Drawing.Size(195, 45);
            this.BookRemoveButton.TabIndex = 3;
            this.BookRemoveButton.Text = "Usuń książke";
            this.BookRemoveButton.UseVisualStyleBackColor = true;
            // 
            // BookManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 631);
            this.Controls.Add(this.BookRemoveButton);
            this.Controls.Add(this.BookAddButton);
            this.Controls.Add(this.BookRemoveGB);
            this.Controls.Add(this.BookAddGB);
            this.Name = "BookManageForm";
            this.Text = "Menadżer książek";
            this.BookAddGB.ResumeLayout(false);
            this.BookAddGB.PerformLayout();
            this.BookRemoveGB.ResumeLayout(false);
            this.BookRemoveGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label BookIDNumberLabel;
        private System.Windows.Forms.Label BookTitleLabel;
        private System.Windows.Forms.Label BookCategoryLabel;
        private System.Windows.Forms.Label BookQuantityLabel;
        private System.Windows.Forms.Label BookIDNumberRemoveLabel;
        private System.Windows.Forms.Label BookTitleRemoveLabel;
        private System.Windows.Forms.Label BookCategoryRemoveLabel;
        private System.Windows.Forms.Label BookQuantityRemoveLabel;
        private System.Windows.Forms.GroupBox BookAddGB;
        private System.Windows.Forms.ComboBox BookCategoryCB;
        private System.Windows.Forms.TextBox BookQuantityCB;
        private System.Windows.Forms.TextBox BookTitleCB;
        private System.Windows.Forms.TextBox BookIDNumberTB;
        private System.Windows.Forms.GroupBox BookRemoveGB;
        private System.Windows.Forms.ComboBox BookCategoryRemoveCB;
        private System.Windows.Forms.TextBox BookQuantityRemoveTB;
        private System.Windows.Forms.TextBox BookTitleRemoveTB;
        private System.Windows.Forms.TextBox BookIDNumberRemoveTB;
        private System.Windows.Forms.Button BookAddButton;
        private System.Windows.Forms.Button BookRemoveButton;
    }
}