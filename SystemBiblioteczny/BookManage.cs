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
        SystemBibliotecznyEntities123 context = new SystemBibliotecznyEntities123(); // przez context mamy dostep do dany z bazy

        public BookManageForm()
        {
            InitializeComponent();
            BookCategoryCB.DataSource = context.Categories.ToList();
            BookCategoryCB.DisplayMember = "TitleCategory";
        }

        private void BookAddButton_Click(object sender, EventArgs e) /// Funkcja przycisnięcia buttona dodaj ksiazke
        {
            
            Book book = new Book(); // nowa instacja book
            book.BookID = BookIDNumberTB.Text;
            book.Title = BookTitleTB.Text;
            book.Category = BookCategoryCB.Text;
            book.Quantity = Convert.ToInt32(BookQuantityTB.Text);
            context.Books.Add(book);
            context.SaveChanges();
            MessageBox.Show("Dodano ksiazke");


        }


        private void BookSearchButton_Click(object sender, EventArgs e)
        {
            
            var book = context.Books.Where(x => x.BookID == BookIDNumberRemoveTB.Text).FirstOrDefault(); // jednak ksiazka o numerze id ksiazki
            

            if (book == null)
            {
                MessageBox.Show("Nie ma ksiazki");
            }
            else
            {
                BookTitleRemoveTB.Text = book.Title;
                BookCategoryRemoveTB.Text = book.Category;
                BookQuantityAviableTB.Text = Convert.ToString(book.Quantity);
                BookTitleRemoveTB.ReadOnly = true;
                BookCategoryRemoveTB.ReadOnly = true;
                BookQuantityAviableTB.ReadOnly = true;
            }
            
        }

        private void BookRemoveButton_Click(object sender, EventArgs e)
        {
            
            var book = context.Books.Where(x => x.BookID == BookIDNumberRemoveTB.Text).FirstOrDefault();
            if (book.Quantity == 0)
            {
                MessageBox.Show("Nie ma ksiazki na stanie");
            }
            else
            {
                var bookQuantity = book.Quantity - Convert.ToInt32(BookQuantityToRemoveTB.Text);
                book.Quantity = bookQuantity;
                context.Books.Remove(book);
                context.SaveChanges();
                MessageBox.Show("Ksiazka " + BookTitleRemoveTB.Text + " usunieta!");
            }
           // var bookQuantity = book.Quantity - Convert.ToInt32(BookQuantityToRemoveTB.Text);
            //book.Quantity = bookQuantity;

            //context.Books.Remove(book);
            //context.SaveChanges();
            //MessageBox.Show("Ksiazka " + BookTitleRemoveTB.Text +  " usunieta!");
        }

        private void BookCategoryCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        
    }
}


