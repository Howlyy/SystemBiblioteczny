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
    public partial class BookSearchingForm : Form /// panel Szukania ksiazki 
    {
        SystemBibliotecznyEntities123 context = new SystemBibliotecznyEntities123(); // powiązanie
        public BookSearchingForm() 
        {
            InitializeComponent();
            BookCategoryCB.DataSource = context.Categories.ToList();
            BookCategoryCB.DisplayMember = "TitleCategory";
        }

        private void BookCategoryCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BookCategoryTitleSearchButton_Click(object sender, EventArgs e) /// Przycisk wyszukiwania na DataGridzie danych z bazy
        {
            var book = context.Books.Where(x => x.Title == BookTitleCB.Text || x.Category == BookCategoryCB.Text).ToList();
            DataGrid.DataSource = book;
        }
    }
}
