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
    /// BookSearchingForm to panel służący do wyszukania i wypozyczenia ksiazki
    /// </summary>

    public partial class BookSearchingForm : Form 
    {
        /// <summary>
        /// 
        /// </summary>
         
        public BookSearchingForm() 
        {
            SystemBibliotecznyEntities123 context = new SystemBibliotecznyEntities123();
            InitializeComponent();
            BookCategoryCB.DataSource = context.Categories.ToList();
            BookCategoryCB.DisplayMember = "TitleCategory";
        }

        

       /// <summary>
       ///  Metoda która jest uruchamiana po przyciśnieciu buttona 
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>

        private void BookCategoryTitleSearchButton_Click(object sender, EventArgs e) 
        {
            SystemBibliotecznyEntities123 context = new SystemBibliotecznyEntities123();
            var book = context.Books.Where(x => x.Title == BookTitleCB.Text || x.Category == BookCategoryCB.Text).ToList();
            DataGrid.DataSource = book;
        }

        private void DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var title = DataGrid.Rows[e.RowIndex].Cells[2].Value;
            var Quantity = DataGrid.Rows[e.RowIndex].Cells[4].Value;
            var category = DataGrid.Rows[e.RowIndex].Cells[3].Value;
            var BookId = DataGrid.Rows[e.RowIndex].Cells[1].Value;
            BookTitleGBTB.Text = title.ToString();
            BookQuantityGBTB.Text = Quantity.ToString();
            BookCategoryGBTB.Text = category.ToString();
            BookIDGBTB.Text = BookId.ToString();
        }

        private void BookIssueButton_Click(object sender, EventArgs e)
        {

        }
    }
}
