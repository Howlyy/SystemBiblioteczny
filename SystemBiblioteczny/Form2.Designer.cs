namespace SystemBiblioteczny
{
    partial class BookSearchingForm
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
            this.BookTitleCategoryGB = new System.Windows.Forms.GroupBox();
            this.BookCategoryLabel = new System.Windows.Forms.Label();
            this.BookTitleLabel = new System.Windows.Forms.Label();
            this.BookTitleCB = new System.Windows.Forms.ComboBox();
            this.BookCategoryCB = new System.Windows.Forms.ComboBox();
            this.BookCategoryTitleSearchButton = new System.Windows.Forms.Button();
            this.SearchingResultGB = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BookDataGB = new System.Windows.Forms.GroupBox();
            this.BookTitleGBLabel = new System.Windows.Forms.Label();
            this.BookAuthorGBLabel = new System.Windows.Forms.Label();
            this.BookQuantityGBLabel = new System.Windows.Forms.Label();
            this.BookCategoryGBLabel = new System.Windows.Forms.Label();
            this.BookIDGBLabel = new System.Windows.Forms.Label();
            this.StudentIDGBLabel = new System.Windows.Forms.Label();
            this.BookTitleGBTB = new System.Windows.Forms.TextBox();
            this.BookAutorGBTB = new System.Windows.Forms.TextBox();
            this.BookQuantityGBTB = new System.Windows.Forms.TextBox();
            this.BookCategoryGBTB = new System.Windows.Forms.TextBox();
            this.BookIDGBTB = new System.Windows.Forms.TextBox();
            this.StudentIDGBTB = new System.Windows.Forms.TextBox();
            this.BookTitleCategoryGB.SuspendLayout();
            this.SearchingResultGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.BookDataGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // BookTitleCategoryGB
            // 
            this.BookTitleCategoryGB.Controls.Add(this.BookCategoryTitleSearchButton);
            this.BookTitleCategoryGB.Controls.Add(this.BookCategoryCB);
            this.BookTitleCategoryGB.Controls.Add(this.BookTitleCB);
            this.BookTitleCategoryGB.Controls.Add(this.BookCategoryLabel);
            this.BookTitleCategoryGB.Controls.Add(this.BookTitleLabel);
            this.BookTitleCategoryGB.Location = new System.Drawing.Point(42, 50);
            this.BookTitleCategoryGB.Name = "BookTitleCategoryGB";
            this.BookTitleCategoryGB.Size = new System.Drawing.Size(343, 215);
            this.BookTitleCategoryGB.TabIndex = 0;
            this.BookTitleCategoryGB.TabStop = false;
            this.BookTitleCategoryGB.Text = "Kryteria wyszukiwania - Wybierz przynajmniej jedną opcje";
            // 
            // BookCategoryLabel
            // 
            this.BookCategoryLabel.AutoSize = true;
            this.BookCategoryLabel.Location = new System.Drawing.Point(30, 120);
            this.BookCategoryLabel.Name = "BookCategoryLabel";
            this.BookCategoryLabel.Size = new System.Drawing.Size(87, 13);
            this.BookCategoryLabel.TabIndex = 2;
            this.BookCategoryLabel.Text = "Kategoria książki";
            // 
            // BookTitleLabel
            // 
            this.BookTitleLabel.AutoSize = true;
            this.BookTitleLabel.Location = new System.Drawing.Point(30, 48);
            this.BookTitleLabel.Name = "BookTitleLabel";
            this.BookTitleLabel.Size = new System.Drawing.Size(67, 13);
            this.BookTitleLabel.TabIndex = 2;
            this.BookTitleLabel.Text = "Tytuł książki";
            // 
            // BookTitleCB
            // 
            this.BookTitleCB.FormattingEnabled = true;
            this.BookTitleCB.Location = new System.Drawing.Point(170, 40);
            this.BookTitleCB.Name = "BookTitleCB";
            this.BookTitleCB.Size = new System.Drawing.Size(150, 21);
            this.BookTitleCB.TabIndex = 3;
            // 
            // BookCategoryCB
            // 
            this.BookCategoryCB.FormattingEnabled = true;
            this.BookCategoryCB.Location = new System.Drawing.Point(170, 112);
            this.BookCategoryCB.Name = "BookCategoryCB";
            this.BookCategoryCB.Size = new System.Drawing.Size(150, 21);
            this.BookCategoryCB.TabIndex = 3;
            // 
            // BookCategoryTitleSearchButton
            // 
            this.BookCategoryTitleSearchButton.Location = new System.Drawing.Point(199, 168);
            this.BookCategoryTitleSearchButton.Name = "BookCategoryTitleSearchButton";
            this.BookCategoryTitleSearchButton.Size = new System.Drawing.Size(121, 42);
            this.BookCategoryTitleSearchButton.TabIndex = 4;
            this.BookCategoryTitleSearchButton.Text = "Szukaj";
            this.BookCategoryTitleSearchButton.UseVisualStyleBackColor = true;
            // 
            // SearchingResultGB
            // 
            this.SearchingResultGB.Controls.Add(this.dataGridView1);
            this.SearchingResultGB.Location = new System.Drawing.Point(438, 50);
            this.SearchingResultGB.Name = "SearchingResultGB";
            this.SearchingResultGB.Size = new System.Drawing.Size(502, 322);
            this.SearchingResultGB.TabIndex = 1;
            this.SearchingResultGB.TabStop = false;
            this.SearchingResultGB.Text = "groupBox2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(502, 287);
            this.dataGridView1.TabIndex = 0;
            // 
            // BookDataGB
            // 
            this.BookDataGB.Controls.Add(this.StudentIDGBTB);
            this.BookDataGB.Controls.Add(this.BookIDGBTB);
            this.BookDataGB.Controls.Add(this.BookCategoryGBTB);
            this.BookDataGB.Controls.Add(this.BookQuantityGBTB);
            this.BookDataGB.Controls.Add(this.BookAutorGBTB);
            this.BookDataGB.Controls.Add(this.BookTitleGBTB);
            this.BookDataGB.Controls.Add(this.StudentIDGBLabel);
            this.BookDataGB.Controls.Add(this.BookIDGBLabel);
            this.BookDataGB.Controls.Add(this.BookCategoryGBLabel);
            this.BookDataGB.Controls.Add(this.BookQuantityGBLabel);
            this.BookDataGB.Controls.Add(this.BookAuthorGBLabel);
            this.BookDataGB.Controls.Add(this.BookTitleGBLabel);
            this.BookDataGB.Location = new System.Drawing.Point(42, 378);
            this.BookDataGB.Name = "BookDataGB";
            this.BookDataGB.Size = new System.Drawing.Size(897, 230);
            this.BookDataGB.TabIndex = 2;
            this.BookDataGB.TabStop = false;
            this.BookDataGB.Text = "Dane ksiązki";
            // 
            // BookTitleGBLabel
            // 
            this.BookTitleGBLabel.AutoSize = true;
            this.BookTitleGBLabel.Location = new System.Drawing.Point(44, 44);
            this.BookTitleGBLabel.Name = "BookTitleGBLabel";
            this.BookTitleGBLabel.Size = new System.Drawing.Size(67, 13);
            this.BookTitleGBLabel.TabIndex = 0;
            this.BookTitleGBLabel.Text = "Tytuł książki";
            // 
            // BookAuthorGBLabel
            // 
            this.BookAuthorGBLabel.AutoSize = true;
            this.BookAuthorGBLabel.Location = new System.Drawing.Point(44, 80);
            this.BookAuthorGBLabel.Name = "BookAuthorGBLabel";
            this.BookAuthorGBLabel.Size = new System.Drawing.Size(35, 13);
            this.BookAuthorGBLabel.TabIndex = 0;
            this.BookAuthorGBLabel.Text = "Autor ";
            // 
            // BookQuantityGBLabel
            // 
            this.BookQuantityGBLabel.AutoSize = true;
            this.BookQuantityGBLabel.Location = new System.Drawing.Point(44, 113);
            this.BookQuantityGBLabel.Name = "BookQuantityGBLabel";
            this.BookQuantityGBLabel.Size = new System.Drawing.Size(68, 13);
            this.BookQuantityGBLabel.TabIndex = 0;
            this.BookQuantityGBLabel.Text = "Ilość ksiązek";
            // 
            // BookCategoryGBLabel
            // 
            this.BookCategoryGBLabel.AutoSize = true;
            this.BookCategoryGBLabel.Location = new System.Drawing.Point(44, 142);
            this.BookCategoryGBLabel.Name = "BookCategoryGBLabel";
            this.BookCategoryGBLabel.Size = new System.Drawing.Size(87, 13);
            this.BookCategoryGBLabel.TabIndex = 0;
            this.BookCategoryGBLabel.Text = "Kategoria książki";
            // 
            // BookIDGBLabel
            // 
            this.BookIDGBLabel.AutoSize = true;
            this.BookIDGBLabel.Location = new System.Drawing.Point(339, 90);
            this.BookIDGBLabel.Name = "BookIDGBLabel";
            this.BookIDGBLabel.Size = new System.Drawing.Size(87, 13);
            this.BookIDGBLabel.TabIndex = 0;
            this.BookIDGBLabel.Text = "Numer ID książki";
            // 
            // StudentIDGBLabel
            // 
            this.StudentIDGBLabel.AutoSize = true;
            this.StudentIDGBLabel.Location = new System.Drawing.Point(330, 44);
            this.StudentIDGBLabel.Name = "StudentIDGBLabel";
            this.StudentIDGBLabel.Size = new System.Drawing.Size(96, 13);
            this.StudentIDGBLabel.TabIndex = 0;
            this.StudentIDGBLabel.Text = "Numer ID studenta";
            // 
            // BookTitleGBTB
            // 
            this.BookTitleGBTB.Location = new System.Drawing.Point(166, 41);
            this.BookTitleGBTB.Name = "BookTitleGBTB";
            this.BookTitleGBTB.Size = new System.Drawing.Size(102, 20);
            this.BookTitleGBTB.TabIndex = 1;
            // 
            // BookAutorGBTB
            // 
            this.BookAutorGBTB.Location = new System.Drawing.Point(166, 73);
            this.BookAutorGBTB.Name = "BookAutorGBTB";
            this.BookAutorGBTB.Size = new System.Drawing.Size(102, 20);
            this.BookAutorGBTB.TabIndex = 1;
            // 
            // BookQuantityGBTB
            // 
            this.BookQuantityGBTB.Location = new System.Drawing.Point(166, 106);
            this.BookQuantityGBTB.Name = "BookQuantityGBTB";
            this.BookQuantityGBTB.Size = new System.Drawing.Size(102, 20);
            this.BookQuantityGBTB.TabIndex = 1;
            // 
            // BookCategoryGBTB
            // 
            this.BookCategoryGBTB.Location = new System.Drawing.Point(166, 139);
            this.BookCategoryGBTB.Name = "BookCategoryGBTB";
            this.BookCategoryGBTB.Size = new System.Drawing.Size(102, 20);
            this.BookCategoryGBTB.TabIndex = 1;
            // 
            // BookIDGBTB
            // 
            this.BookIDGBTB.Location = new System.Drawing.Point(470, 90);
            this.BookIDGBTB.Name = "BookIDGBTB";
            this.BookIDGBTB.Size = new System.Drawing.Size(102, 20);
            this.BookIDGBTB.TabIndex = 1;
            // 
            // StudentIDGBTB
            // 
            this.StudentIDGBTB.Location = new System.Drawing.Point(470, 41);
            this.StudentIDGBTB.Name = "StudentIDGBTB";
            this.StudentIDGBTB.Size = new System.Drawing.Size(102, 20);
            this.StudentIDGBTB.TabIndex = 1;
            // 
            // BookSearchingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 633);
            this.Controls.Add(this.BookDataGB);
            this.Controls.Add(this.SearchingResultGB);
            this.Controls.Add(this.BookTitleCategoryGB);
            this.Name = "BookSearchingForm";
            this.Text = "Wyszukiwanie ksiazki";
            this.BookTitleCategoryGB.ResumeLayout(false);
            this.BookTitleCategoryGB.PerformLayout();
            this.SearchingResultGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.BookDataGB.ResumeLayout(false);
            this.BookDataGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox BookTitleCategoryGB;
        private System.Windows.Forms.Label BookCategoryLabel;
        private System.Windows.Forms.Label BookTitleLabel;
        private System.Windows.Forms.Button BookCategoryTitleSearchButton;
        private System.Windows.Forms.ComboBox BookCategoryCB;
        private System.Windows.Forms.ComboBox BookTitleCB;
        private System.Windows.Forms.GroupBox SearchingResultGB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox BookDataGB;
        private System.Windows.Forms.TextBox StudentIDGBTB;
        private System.Windows.Forms.TextBox BookIDGBTB;
        private System.Windows.Forms.TextBox BookCategoryGBTB;
        private System.Windows.Forms.TextBox BookQuantityGBTB;
        private System.Windows.Forms.TextBox BookAutorGBTB;
        private System.Windows.Forms.TextBox BookTitleGBTB;
        private System.Windows.Forms.Label StudentIDGBLabel;
        private System.Windows.Forms.Label BookIDGBLabel;
        private System.Windows.Forms.Label BookCategoryGBLabel;
        private System.Windows.Forms.Label BookQuantityGBLabel;
        private System.Windows.Forms.Label BookAuthorGBLabel;
        private System.Windows.Forms.Label BookTitleGBLabel;
    }
}