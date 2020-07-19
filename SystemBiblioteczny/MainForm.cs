using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemBiblioteczny
{
    /// <summary>
    /// Klasa dla głownego okna.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Metoda dla głownego okna.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metoda Strip menu dodaj ksiazke. Po przycisnieciu odpala okno Menadzera ksiazek
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dodajKsiazkeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookManageForm book = new BookManageForm();
            book.MdiParent = this;
            book.Show();
        }
        /// <summary>
        /// Metoda Strip menu dodaj kategorie. Po przycisnieciu odpala okno Dodawania i usuwania kategorii
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dodajKategorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryAddForm book = new CategoryAddForm();
            book.MdiParent = this;
            book.Show();
        }

        /// <summary>
        ///  Metoda Strip menu Wypozycz. Po przycisnieciu odpala okno Wyszukania ksiazki 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void wypozyczToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookSearchingForm book = new BookSearchingForm();
            book.MdiParent = this;
            book.Show();
        }
        /// <summary>
        ///  Metoda Strip menu Oddaj ksiazke. Po przycisnieciu odpala nam okno Oddawania ksiazki
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void oddajKsiazkeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookReturnForm book = new BookReturnForm();
            book.MdiParent = this;
            book.Show();
        }
        /// <summary>
        /// Metoda Strip menu Dane o wypozyczeniach. Po przycisnieciu odpala nam okno w ktorym jest data grid informacji z bazy Issue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void daneOWypozyczeniachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueInfo book = new IssueInfo();
            book.MdiParent = this;
            book.Show();
        }
    }
}
