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
        /// Klasa okna Wyszukania ksiazki
        /// </summary>
         
        public BookSearchingForm() 
        {
            SystemBibliotecznyEntities123 context = new SystemBibliotecznyEntities123();
            InitializeComponent();
            BookCategoryCB.DataSource = context.Categories.ToList();
            BookCategoryCB.DisplayMember = "TitleCategory"; 
            

        }

        

       /// <summary>
       ///  Metoda przycisku Szukaj. Po przycisnieciu wyrzuca nam dane z tabeli Book na datagrida
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>

        private void BookCategoryTitleSearchButton_Click(object sender, EventArgs e) 
        {
            SystemBibliotecznyEntities123 context = new SystemBibliotecznyEntities123();
            var book = context.Books.Where(x => x.Title == BookTitleTB.Text || x.Category == BookCategoryCB.Text).ToList();
            DataGrid.DataSource = book;
        }
        

        /// <summary>
        ///  Metoda panelu datagrid pokazująca baze z bazy 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var title = DataGrid.Rows[e.RowIndex].Cells[2].Value;
            var Quantity = DataGrid.Rows[e.RowIndex].Cells[3].Value;
            var category = DataGrid.Rows[e.RowIndex].Cells[4].Value;
            var BookId = DataGrid.Rows[e.RowIndex].Cells[1].Value;
            BookTitleGBTB.Text = title.ToString();
            BookQuantityGBTB.Text = Quantity.ToString();
            BookCategoryGBTB.Text = category.ToString();
            BookIDGBTB.Text = BookId.ToString();
        }

        /// <summary>
        /// Metoda przycisku Wypożycz ksiażke. Po kliknięciu wykonuje operacje wypozyczenia z jednoczesnym sprawdzenie czy na stanie sa dane ksiazki
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookIssueButton_Click(object sender, EventArgs e)
        {
            SystemBibliotecznyEntities123 context = new SystemBibliotecznyEntities123();
            Issue book = new Issue();
            book.IDStudenta = StudentIDGBTB.Text;
            book.BookID = BookIDGBTB.Text;
            book.IssueNotReturn = true;
            var singlebook = context.Books.Where(x => x.BookID == BookIDGBTB.Text).FirstOrDefault();
            if (singlebook.Quantity == 0)
            {
                MessageBox.Show("Nie ma tyle ksiazek!");
            }
            else
            {
                singlebook.Quantity -= 1;
                MessageBox.Show("Wypozyczono 1 ksiazke!");
            }
            
            
            context.Issues.Add(book);
            context.SaveChanges();

        }

        
    }
}
