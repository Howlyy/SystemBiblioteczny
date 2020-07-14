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
            this.BookTitleTB = new System.Windows.Forms.TextBox();
            this.BookCategoryTitleSearchButton = new System.Windows.Forms.Button();
            this.BookCategoryCB = new System.Windows.Forms.ComboBox();
            this.BookCategoryLabel = new System.Windows.Forms.Label();
            this.BookTitleLabel = new System.Windows.Forms.Label();
            this.SearchingResultGB = new System.Windows.Forms.GroupBox();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.BookDataGB = new System.Windows.Forms.GroupBox();
            this.BookIssueButton = new System.Windows.Forms.Button();
            this.StudentIDGBTB = new System.Windows.Forms.TextBox();
            this.BookIDGBTB = new System.Windows.Forms.TextBox();
            this.BookCategoryGBTB = new System.Windows.Forms.TextBox();
            this.BookQuantityGBTB = new System.Windows.Forms.TextBox();
            this.BookTitleGBTB = new System.Windows.Forms.TextBox();
            this.StudentIDGBLabel = new System.Windows.Forms.Label();
            this.BookIDGBLabel = new System.Windows.Forms.Label();
            this.BookCategoryGBLabel = new System.Windows.Forms.Label();
            this.BookQuantityGBLabel = new System.Windows.Forms.Label();
            this.BookTitleGBLabel = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numer_ID_Ksiazki = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookTitleCategoryGB.SuspendLayout();
            this.SearchingResultGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.BookDataGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // BookTitleCategoryGB
            // 
            this.BookTitleCategoryGB.Controls.Add(this.BookTitleTB);
            this.BookTitleCategoryGB.Controls.Add(this.BookCategoryTitleSearchButton);
            this.BookTitleCategoryGB.Controls.Add(this.BookCategoryCB);
            this.BookTitleCategoryGB.Controls.Add(this.BookCategoryLabel);
            this.BookTitleCategoryGB.Controls.Add(this.BookTitleLabel);
            this.BookTitleCategoryGB.Location = new System.Drawing.Point(12, 12);
            this.BookTitleCategoryGB.Name = "BookTitleCategoryGB";
            this.BookTitleCategoryGB.Size = new System.Drawing.Size(325, 215);
            this.BookTitleCategoryGB.TabIndex = 0;
            this.BookTitleCategoryGB.TabStop = false;
            this.BookTitleCategoryGB.Text = "Kryteria wyszukiwania - Wybierz przynajmniej jedną opcje";
            // 
            // BookTitleTB
            // 
            this.BookTitleTB.Location = new System.Drawing.Point(170, 45);
            this.BookTitleTB.Name = "BookTitleTB";
            this.BookTitleTB.Size = new System.Drawing.Size(150, 20);
            this.BookTitleTB.TabIndex = 5;
            // 
            // BookCategoryTitleSearchButton
            // 
            this.BookCategoryTitleSearchButton.Location = new System.Drawing.Point(104, 167);
            this.BookCategoryTitleSearchButton.Name = "BookCategoryTitleSearchButton";
            this.BookCategoryTitleSearchButton.Size = new System.Drawing.Size(121, 42);
            this.BookCategoryTitleSearchButton.TabIndex = 4;
            this.BookCategoryTitleSearchButton.Text = "Szukaj";
            this.BookCategoryTitleSearchButton.UseVisualStyleBackColor = true;
            this.BookCategoryTitleSearchButton.Click += new System.EventHandler(this.BookCategoryTitleSearchButton_Click);
            // 
            // BookCategoryCB
            // 
            this.BookCategoryCB.FormattingEnabled = true;
            this.BookCategoryCB.Location = new System.Drawing.Point(170, 112);
            this.BookCategoryCB.Name = "BookCategoryCB";
            this.BookCategoryCB.Size = new System.Drawing.Size(150, 21);
            this.BookCategoryCB.TabIndex = 3;
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
            // SearchingResultGB
            // 
            this.SearchingResultGB.Controls.Add(this.DataGrid);
            this.SearchingResultGB.Location = new System.Drawing.Point(361, 12);
            this.SearchingResultGB.Name = "SearchingResultGB";
            this.SearchingResultGB.Size = new System.Drawing.Size(511, 310);
            this.SearchingResultGB.TabIndex = 1;
            this.SearchingResultGB.TabStop = false;
            this.SearchingResultGB.Text = "groupBox2";
            // 
            // DataGrid
            // 
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Numer_ID_Ksiazki,
            this.Title,
            this.Quantity,
            this.Category});
            this.DataGrid.Location = new System.Drawing.Point(0, 19);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.Size = new System.Drawing.Size(505, 287);
            this.DataGrid.TabIndex = 0;
            this.DataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellClick);
            // 
            // BookDataGB
            // 
            this.BookDataGB.Controls.Add(this.BookIssueButton);
            this.BookDataGB.Controls.Add(this.StudentIDGBTB);
            this.BookDataGB.Controls.Add(this.BookIDGBTB);
            this.BookDataGB.Controls.Add(this.BookCategoryGBTB);
            this.BookDataGB.Controls.Add(this.BookQuantityGBTB);
            this.BookDataGB.Controls.Add(this.BookTitleGBTB);
            this.BookDataGB.Controls.Add(this.StudentIDGBLabel);
            this.BookDataGB.Controls.Add(this.BookIDGBLabel);
            this.BookDataGB.Controls.Add(this.BookCategoryGBLabel);
            this.BookDataGB.Controls.Add(this.BookQuantityGBLabel);
            this.BookDataGB.Controls.Add(this.BookTitleGBLabel);
            this.BookDataGB.Location = new System.Drawing.Point(88, 340);
            this.BookDataGB.Name = "BookDataGB";
            this.BookDataGB.Size = new System.Drawing.Size(615, 195);
            this.BookDataGB.TabIndex = 2;
            this.BookDataGB.TabStop = false;
            this.BookDataGB.Text = "Dane ksiązki";
            // 
            // BookIssueButton
            // 
            this.BookIssueButton.Location = new System.Drawing.Point(392, 142);
            this.BookIssueButton.Name = "BookIssueButton";
            this.BookIssueButton.Size = new System.Drawing.Size(141, 43);
            this.BookIssueButton.TabIndex = 2;
            this.BookIssueButton.Text = "Wypożycz książke";
            this.BookIssueButton.UseVisualStyleBackColor = true;
            this.BookIssueButton.Click += new System.EventHandler(this.BookIssueButton_Click);
            // 
            // StudentIDGBTB
            // 
            this.StudentIDGBTB.Location = new System.Drawing.Point(470, 41);
            this.StudentIDGBTB.Name = "StudentIDGBTB";
            this.StudentIDGBTB.Size = new System.Drawing.Size(102, 20);
            this.StudentIDGBTB.TabIndex = 1;
            // 
            // BookIDGBTB
            // 
            this.BookIDGBTB.Location = new System.Drawing.Point(470, 90);
            this.BookIDGBTB.Name = "BookIDGBTB";
            this.BookIDGBTB.Size = new System.Drawing.Size(102, 20);
            this.BookIDGBTB.TabIndex = 1;
            // 
            // BookCategoryGBTB
            // 
            this.BookCategoryGBTB.Location = new System.Drawing.Point(166, 139);
            this.BookCategoryGBTB.Name = "BookCategoryGBTB";
            this.BookCategoryGBTB.Size = new System.Drawing.Size(102, 20);
            this.BookCategoryGBTB.TabIndex = 1;
            // 
            // BookQuantityGBTB
            // 
            this.BookQuantityGBTB.Location = new System.Drawing.Point(166, 90);
            this.BookQuantityGBTB.Name = "BookQuantityGBTB";
            this.BookQuantityGBTB.Size = new System.Drawing.Size(102, 20);
            this.BookQuantityGBTB.TabIndex = 1;
            // 
            // BookTitleGBTB
            // 
            this.BookTitleGBTB.Location = new System.Drawing.Point(166, 41);
            this.BookTitleGBTB.Name = "BookTitleGBTB";
            this.BookTitleGBTB.Size = new System.Drawing.Size(102, 20);
            this.BookTitleGBTB.TabIndex = 1;
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
            // BookIDGBLabel
            // 
            this.BookIDGBLabel.AutoSize = true;
            this.BookIDGBLabel.Location = new System.Drawing.Point(339, 93);
            this.BookIDGBLabel.Name = "BookIDGBLabel";
            this.BookIDGBLabel.Size = new System.Drawing.Size(87, 13);
            this.BookIDGBLabel.TabIndex = 0;
            this.BookIDGBLabel.Text = "Numer ID książki";
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
            // BookQuantityGBLabel
            // 
            this.BookQuantityGBLabel.AutoSize = true;
            this.BookQuantityGBLabel.Location = new System.Drawing.Point(43, 93);
            this.BookQuantityGBLabel.Name = "BookQuantityGBLabel";
            this.BookQuantityGBLabel.Size = new System.Drawing.Size(68, 13);
            this.BookQuantityGBLabel.TabIndex = 0;
            this.BookQuantityGBLabel.Text = "Ilość ksiązek";
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
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 60;
            // 
            // Numer_ID_Ksiazki
            // 
            this.Numer_ID_Ksiazki.DataPropertyName = "BookID";
            this.Numer_ID_Ksiazki.HeaderText = "Numer_ID_Ksiazki";
            this.Numer_ID_Ksiazki.Name = "Numer_ID_Ksiazki";
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            // 
            // BookSearchingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.BookDataGB);
            this.Controls.Add(this.SearchingResultGB);
            this.Controls.Add(this.BookTitleCategoryGB);
            this.Name = "BookSearchingForm";
            this.Text = "Wyszukiwanie ksiazki";
            this.BookTitleCategoryGB.ResumeLayout(false);
            this.BookTitleCategoryGB.PerformLayout();
            this.SearchingResultGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
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
        private System.Windows.Forms.GroupBox SearchingResultGB;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.GroupBox BookDataGB;
        private System.Windows.Forms.TextBox StudentIDGBTB;
        private System.Windows.Forms.TextBox BookIDGBTB;
        private System.Windows.Forms.TextBox BookCategoryGBTB;
        private System.Windows.Forms.TextBox BookQuantityGBTB;
        private System.Windows.Forms.TextBox BookTitleGBTB;
        private System.Windows.Forms.Label StudentIDGBLabel;
        private System.Windows.Forms.Label BookIDGBLabel;
        private System.Windows.Forms.Label BookCategoryGBLabel;
        private System.Windows.Forms.Label BookQuantityGBLabel;
        private System.Windows.Forms.Label BookTitleGBLabel;
        private System.Windows.Forms.Button BookIssueButton;
        private System.Windows.Forms.TextBox BookTitleTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numer_ID_Ksiazki;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
    }
}