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
            this.BookAddGB = new System.Windows.Forms.GroupBox();
            this.BookCategoryCB = new System.Windows.Forms.ComboBox();
            this.BookQuantityTB = new System.Windows.Forms.TextBox();
            this.BookTitleTB = new System.Windows.Forms.TextBox();
            this.BookIDNumberTB = new System.Windows.Forms.TextBox();
            this.BookRemoveGB = new System.Windows.Forms.GroupBox();
            this.BookQuantityToRemoveTB = new System.Windows.Forms.TextBox();
            this.BookCategoryRemoveTB = new System.Windows.Forms.TextBox();
            this.BookTitleRemoveTB = new System.Windows.Forms.TextBox();
            this.BookIDNumberRemoveTB = new System.Windows.Forms.TextBox();
            this.BookQuantityToRemoveLabel = new System.Windows.Forms.Label();
            this.BookRemoveButton = new System.Windows.Forms.Button();
            this.BookAddButton = new System.Windows.Forms.Button();
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
            this.BookTitleLabel.Location = new System.Drawing.Point(13, 61);
            this.BookTitleLabel.Name = "BookTitleLabel";
            this.BookTitleLabel.Size = new System.Drawing.Size(67, 13);
            this.BookTitleLabel.TabIndex = 0;
            this.BookTitleLabel.Text = "Tytuł książki";
            // 
            // BookCategoryLabel
            // 
            this.BookCategoryLabel.AutoSize = true;
            this.BookCategoryLabel.Location = new System.Drawing.Point(13, 108);
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
            this.BookIDNumberRemoveLabel.Location = new System.Drawing.Point(37, 34);
            this.BookIDNumberRemoveLabel.Name = "BookIDNumberRemoveLabel";
            this.BookIDNumberRemoveLabel.Size = new System.Drawing.Size(87, 13);
            this.BookIDNumberRemoveLabel.TabIndex = 0;
            this.BookIDNumberRemoveLabel.Text = "Numer ID książki";
            // 
            // BookTitleRemoveLabel
            // 
            this.BookTitleRemoveLabel.AutoSize = true;
            this.BookTitleRemoveLabel.Location = new System.Drawing.Point(46, 89);
            this.BookTitleRemoveLabel.Name = "BookTitleRemoveLabel";
            this.BookTitleRemoveLabel.Size = new System.Drawing.Size(67, 13);
            this.BookTitleRemoveLabel.TabIndex = 0;
            this.BookTitleRemoveLabel.Text = "Tytuł ksiażki";
            // 
            // BookCategoryRemoveLabel
            // 
            this.BookCategoryRemoveLabel.AutoSize = true;
            this.BookCategoryRemoveLabel.Location = new System.Drawing.Point(46, 135);
            this.BookCategoryRemoveLabel.Name = "BookCategoryRemoveLabel";
            this.BookCategoryRemoveLabel.Size = new System.Drawing.Size(52, 13);
            this.BookCategoryRemoveLabel.TabIndex = 0;
            this.BookCategoryRemoveLabel.Text = "Kategoria";
            // 
            // BookAddGB
            // 
            this.BookAddGB.Controls.Add(this.BookAddButton);
            this.BookAddGB.Controls.Add(this.BookCategoryCB);
            this.BookAddGB.Controls.Add(this.BookQuantityTB);
            this.BookAddGB.Controls.Add(this.BookTitleTB);
            this.BookAddGB.Controls.Add(this.BookIDNumberTB);
            this.BookAddGB.Controls.Add(this.BookQuantityLabel);
            this.BookAddGB.Controls.Add(this.BookCategoryLabel);
            this.BookAddGB.Controls.Add(this.BookTitleLabel);
            this.BookAddGB.Controls.Add(this.BookIDNumberLabel);
            this.BookAddGB.Location = new System.Drawing.Point(77, 35);
            this.BookAddGB.Name = "BookAddGB";
            this.BookAddGB.Size = new System.Drawing.Size(476, 270);
            this.BookAddGB.TabIndex = 1;
            this.BookAddGB.TabStop = false;
            this.BookAddGB.Text = "Dodawanie książki";
            // 
            // BookCategoryCB
            // 
            this.BookCategoryCB.FormattingEnabled = true;
            this.BookCategoryCB.Location = new System.Drawing.Point(168, 105);
            this.BookCategoryCB.Name = "BookCategoryCB";
            this.BookCategoryCB.Size = new System.Drawing.Size(221, 21);
            this.BookCategoryCB.TabIndex = 2;
            // 
            // BookQuantityTB
            // 
            this.BookQuantityTB.Location = new System.Drawing.Point(172, 154);
            this.BookQuantityTB.Name = "BookQuantityTB";
            this.BookQuantityTB.Size = new System.Drawing.Size(221, 20);
            this.BookQuantityTB.TabIndex = 1;
            // 
            // BookTitleTB
            // 
            this.BookTitleTB.Location = new System.Drawing.Point(172, 58);
            this.BookTitleTB.Name = "BookTitleTB";
            this.BookTitleTB.Size = new System.Drawing.Size(221, 20);
            this.BookTitleTB.TabIndex = 1;
            // 
            // BookIDNumberTB
            // 
            this.BookIDNumberTB.Location = new System.Drawing.Point(172, 16);
            this.BookIDNumberTB.Name = "BookIDNumberTB";
            this.BookIDNumberTB.Size = new System.Drawing.Size(221, 20);
            this.BookIDNumberTB.TabIndex = 1;
            // 
            // BookRemoveGB
            // 
            this.BookRemoveGB.Controls.Add(this.BookRemoveButton);
            this.BookRemoveGB.Controls.Add(this.BookQuantityToRemoveTB);
            this.BookRemoveGB.Controls.Add(this.BookCategoryRemoveTB);
            this.BookRemoveGB.Controls.Add(this.BookTitleRemoveTB);
            this.BookRemoveGB.Controls.Add(this.BookIDNumberRemoveTB);
            this.BookRemoveGB.Controls.Add(this.BookQuantityToRemoveLabel);
            this.BookRemoveGB.Controls.Add(this.BookCategoryRemoveLabel);
            this.BookRemoveGB.Controls.Add(this.BookTitleRemoveLabel);
            this.BookRemoveGB.Controls.Add(this.BookIDNumberRemoveLabel);
            this.BookRemoveGB.Location = new System.Drawing.Point(44, 328);
            this.BookRemoveGB.Name = "BookRemoveGB";
            this.BookRemoveGB.Size = new System.Drawing.Size(545, 278);
            this.BookRemoveGB.TabIndex = 2;
            this.BookRemoveGB.TabStop = false;
            this.BookRemoveGB.Text = "Usuwanie książki";
            // 
            // BookQuantityToRemoveTB
            // 
            this.BookQuantityToRemoveTB.Location = new System.Drawing.Point(201, 189);
            this.BookQuantityToRemoveTB.Name = "BookQuantityToRemoveTB";
            this.BookQuantityToRemoveTB.Size = new System.Drawing.Size(221, 20);
            this.BookQuantityToRemoveTB.TabIndex = 1;
            // 
            // BookCategoryRemoveTB
            // 
            this.BookCategoryRemoveTB.Location = new System.Drawing.Point(201, 135);
            this.BookCategoryRemoveTB.Name = "BookCategoryRemoveTB";
            this.BookCategoryRemoveTB.Size = new System.Drawing.Size(221, 20);
            this.BookCategoryRemoveTB.TabIndex = 1;
            // 
            // BookTitleRemoveTB
            // 
            this.BookTitleRemoveTB.Location = new System.Drawing.Point(201, 86);
            this.BookTitleRemoveTB.Name = "BookTitleRemoveTB";
            this.BookTitleRemoveTB.Size = new System.Drawing.Size(221, 20);
            this.BookTitleRemoveTB.TabIndex = 1;
            // 
            // BookIDNumberRemoveTB
            // 
            this.BookIDNumberRemoveTB.Location = new System.Drawing.Point(203, 31);
            this.BookIDNumberRemoveTB.Name = "BookIDNumberRemoveTB";
            this.BookIDNumberRemoveTB.Size = new System.Drawing.Size(221, 20);
            this.BookIDNumberRemoveTB.TabIndex = 1;
            // 
            // BookQuantityToRemoveLabel
            // 
            this.BookQuantityToRemoveLabel.AutoSize = true;
            this.BookQuantityToRemoveLabel.Location = new System.Drawing.Point(30, 189);
            this.BookQuantityToRemoveLabel.Name = "BookQuantityToRemoveLabel";
            this.BookQuantityToRemoveLabel.Size = new System.Drawing.Size(131, 13);
            this.BookQuantityToRemoveLabel.TabIndex = 0;
            this.BookQuantityToRemoveLabel.Text = "Ilość książek do usunięcia";
            // 
            // BookRemoveButton
            // 
            this.BookRemoveButton.Location = new System.Drawing.Point(173, 233);
            this.BookRemoveButton.Name = "BookRemoveButton";
            this.BookRemoveButton.Size = new System.Drawing.Size(195, 45);
            this.BookRemoveButton.TabIndex = 3;
            this.BookRemoveButton.Text = "Usuń książke";
            this.BookRemoveButton.UseVisualStyleBackColor = true;
            this.BookRemoveButton.Click += new System.EventHandler(this.BookRemoveButton_Click);
            // 
            // BookAddButton
            // 
            this.BookAddButton.Location = new System.Drawing.Point(153, 208);
            this.BookAddButton.Name = "BookAddButton";
            this.BookAddButton.Size = new System.Drawing.Size(202, 56);
            this.BookAddButton.TabIndex = 3;
            this.BookAddButton.Text = "dodaj";
            this.BookAddButton.UseVisualStyleBackColor = true;
            this.BookAddButton.Click += new System.EventHandler(this.BookAddButton_Click);
            // 
            // BookManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 663);
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
        private System.Windows.Forms.GroupBox BookAddGB;
        private System.Windows.Forms.ComboBox BookCategoryCB;
        private System.Windows.Forms.TextBox BookTitleTB;
        private System.Windows.Forms.TextBox BookIDNumberTB;
        private System.Windows.Forms.GroupBox BookRemoveGB;
        private System.Windows.Forms.TextBox BookTitleRemoveTB;
        private System.Windows.Forms.TextBox BookIDNumberRemoveTB;
        private System.Windows.Forms.Button BookRemoveButton;
        private System.Windows.Forms.Label BookQuantityToRemoveLabel;
        private System.Windows.Forms.TextBox BookQuantityTB;
        private System.Windows.Forms.TextBox BookQuantityToRemoveTB;
        private System.Windows.Forms.TextBox BookCategoryRemoveTB;
        private System.Windows.Forms.Button BookAddButton;
    }
}