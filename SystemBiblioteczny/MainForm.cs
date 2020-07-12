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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void dodajKsiazkeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookManageForm book = new BookManageForm();
            book.MdiParent = this;
            book.Show();
        }

        private void dodajKategorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryAddForm book = new CategoryAddForm();
            book.MdiParent = this;
            book.Show();
        }

        private void usuńKsiazkeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void wypozyczToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookSearchingForm book = new BookSearchingForm();
            book.MdiParent = this;
            book.Show();
        }

        private void oddajKsiazkeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookReturnForm book = new BookReturnForm();
            book.MdiParent = this;
            book.Show();
        }

        


    }
}
