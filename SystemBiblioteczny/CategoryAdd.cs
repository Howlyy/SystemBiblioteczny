using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemBiblioteczny
{
    /// <summary>
    ///  Klasa dla okna Dodawania i usuwania kategorii
    /// </summary>
    public partial class CategoryAddForm : Form
    {
        
        public CategoryAddForm()
        {
            InitializeComponent();
            
            

        }
        /// <summary>
        /// Metoda przycisku Dodaj kategorie. Po przycisnieciu dodaje kategorie do bazy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CategoryAddButton_Click(object sender, EventArgs e)
        {
            SystemBibliotecznyEntities123 context = new SystemBibliotecznyEntities123();
            Category category = new Category();
            category.TitleCategory = CategoryAddTB.Text;
            context.Categories.Add(category);
            context.SaveChanges();
            MessageBox.Show("Dodano kategorie!");
        
        }
        /// <summary>
        /// Metoda przycisku Usun kategorie. Po przycisnieciu usuwa kategorie z bazy jednoczesnie sprawdza czy taka jest 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CategoryDeleteButton_Click(object sender, EventArgs e) 
        {
            SystemBibliotecznyEntities123 context = new SystemBibliotecznyEntities123();
            Category category = new Category();
            
            

            if (category == null)
            {
                MessageBox.Show("Nie ma kategorii!");
            }
            else
            {
                var categoryToDelete = (from d in context.Categories
                              where d.TitleCategory == CategoryDeleteTB.Text
                              select d).Single();

                context.Categories.Remove(categoryToDelete);
                context.SaveChanges();

                
                MessageBox.Show("Usunięto kategorie!");
                

            }
        
        }
        



    }
}



