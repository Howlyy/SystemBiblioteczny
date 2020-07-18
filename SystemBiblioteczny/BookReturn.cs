using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemBiblioteczny
{
    /// <summary>
    /// Klasa dla okna zwrotu ksiazki.
    /// </summary>
    public partial class BookReturnForm : Form
    {
        SystemBibliotecznyEntities123 context = new SystemBibliotecznyEntities123();
        public BookReturnForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metoda przycisku Oddaj ksiazke. Po przycisnieciu oddaje jedna ksiazke po BookID 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookReturnButton_Click(object sender, EventArgs e)
        {
            var Issuebook = context.Issues.Where(x => x.BookID == BookIDEnterTB.Text && x.IssueNotReturn == true).FirstOrDefault();
            Issuebook.IssueNotReturn = false;
            var book = context.Books.Where(x => x.BookID == BookIDEnterTB.Text).FirstOrDefault();
            book.Quantity += 1;
            context.SaveChanges();
            MessageBox.Show("Ksiazka oddana!");
        }
    }
}