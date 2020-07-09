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
    public partial class CategoryAddForm : Form
    {
        
        public CategoryAddForm()
        {
            InitializeComponent();

        }

        private void CategoryAddButton_Click(object sender, EventArgs e)
        {
            SystemBibliotecznyEntities123 context = new SystemBibliotecznyEntities123();
            Category category = new Category();
            category.TitleCategory = CategoryAddTB.Text;
            context.Categories.Add(category);
            context.SaveChanges();
            MessageBox.Show("Dodano kategorie!");
        }
    }
}
