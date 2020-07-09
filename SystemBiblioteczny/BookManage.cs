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
    public partial class BookManageForm : Form
    {
        public BookManageForm()
        {
            InitializeComponent();
        }

        private void BookAddButton_Click(object sender, EventArgs e) /// Funkcja przycisnięcia buttona dodaj ksiazke
        {
            SystemBibliotecznyEntities123 context = new SystemBibliotecznyEntities123();
            Book book = new Book(); // nowa instacja book
            book.BookID = BookIDNumberTB.Text;
            book.Title = BookTitleTB.Text;
            book.Category = BookCategoryCB.SelectedText;
            book.Quantity = Convert.ToInt32(BookQuantityTB.Text);
            context.Books.Add(book);
            context.SaveChanges();


        }


       /* private void BookSearchButton_Click(object sender, EventArgs e)
        {
            SystemBibliotecznyEntities123 context = new SystemBibliotecznyEntities123();
            var book = context.Books.Where(x => x.BookID == BookIDNumberRemoveTB.Text).FirstOrDefault(); // jednak ksiazka o numerze id ksiazki
            BookTitleRemoveTB.Text = book.Title;
            BookCategoryRemoveTB.Text = book.Category;
            BookQuantityAviableTB.Text = Convert.ToString(book.Quantity);
            BookTitleRemoveTB.ReadOnly = true;
            BookCategoryRemoveTB.ReadOnly = true;
            BookQuantityAviableTB.ReadOnly = true;
        }*/

        private void BookRemoveButton_Click(object sender, EventArgs e)
        {
            SystemBibliotecznyEntities123 context = new SystemBibliotecznyEntities123();
            var book = context.Books.Where(x => x.BookID == BookIDNumberRemoveTB.Text).FirstOrDefault(); 
            var bookQuantity = book.Quantity - Convert.ToInt32(BookQuantityToRemoveTB.Text);
            book.Quantity = bookQuantity;

            //context.Books.Remove(book);
            context.SaveChanges();
            MessageBox.Show("Ksiazka " + BookTitleRemoveTB.Text +  " usunieta!");
        }

        
    }
}


