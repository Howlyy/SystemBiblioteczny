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
    /// Klasa okna dane o wypozyczeniach.
    /// </summary>
    public partial class IssueInfo : Form
    {
        public IssueInfo()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metoda przycisku Szukaj. Po przycisnieciu na data gridzie pokazuja sie dane z tableki Issue.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            SystemBibliotecznyEntities123 context = new SystemBibliotecznyEntities123();
            var search = context.Issues.ToList();
            DataGridIssue.DataSource = search;
            
        }
    }
}
