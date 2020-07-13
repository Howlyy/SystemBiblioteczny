namespace SystemBiblioteczny
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ksiazkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajKsiazkeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajKategorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wypozyczeniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wypozyczToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oddajKsiazkeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ksiazkiToolStripMenuItem,
            this.wypozyczeniaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(862, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ksiazkiToolStripMenuItem
            // 
            this.ksiazkiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajKsiazkeToolStripMenuItem,
            this.dodajKategorieToolStripMenuItem});
            this.ksiazkiToolStripMenuItem.Name = "ksiazkiToolStripMenuItem";
            this.ksiazkiToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.ksiazkiToolStripMenuItem.Text = "Ksiazki";
            
            // 
            // dodajKsiazkeToolStripMenuItem
            // 
            this.dodajKsiazkeToolStripMenuItem.Name = "dodajKsiazkeToolStripMenuItem";
            this.dodajKsiazkeToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.dodajKsiazkeToolStripMenuItem.Text = "Dodaj/Usuń ksiazke";
            this.dodajKsiazkeToolStripMenuItem.Click += new System.EventHandler(this.dodajKsiazkeToolStripMenuItem_Click);
            // 
            // dodajKategorieToolStripMenuItem
            // 
            this.dodajKategorieToolStripMenuItem.Name = "dodajKategorieToolStripMenuItem";
            this.dodajKategorieToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.dodajKategorieToolStripMenuItem.Text = "Dodaj/usuń kategorie";
            this.dodajKategorieToolStripMenuItem.Click += new System.EventHandler(this.dodajKategorieToolStripMenuItem_Click);
            // 
            // wypozyczeniaToolStripMenuItem
            // 
            this.wypozyczeniaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wypozyczToolStripMenuItem,
            this.oddajKsiazkeToolStripMenuItem});
            this.wypozyczeniaToolStripMenuItem.Name = "wypozyczeniaToolStripMenuItem";
            this.wypozyczeniaToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.wypozyczeniaToolStripMenuItem.Text = "Wypozyczenia";
            // 
            // wypozyczToolStripMenuItem
            // 
            this.wypozyczToolStripMenuItem.Name = "wypozyczToolStripMenuItem";
            this.wypozyczToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.wypozyczToolStripMenuItem.Text = "Wypozycz";
            this.wypozyczToolStripMenuItem.Click += new System.EventHandler(this.wypozyczToolStripMenuItem_Click);
            // 
            // oddajKsiazkeToolStripMenuItem
            // 
            this.oddajKsiazkeToolStripMenuItem.Name = "oddajKsiazkeToolStripMenuItem";
            this.oddajKsiazkeToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.oddajKsiazkeToolStripMenuItem.Text = "Oddaj ksiazke";
            this.oddajKsiazkeToolStripMenuItem.Click += new System.EventHandler(this.oddajKsiazkeToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 569);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ksiazkiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajKsiazkeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajKategorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wypozyczeniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wypozyczToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oddajKsiazkeToolStripMenuItem;
    }
}