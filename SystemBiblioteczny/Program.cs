using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemBiblioteczny
{
    /// <summary>
    /// Klasa Program
    /// </summary>
    static public class Program
    {
        /// <summary>
        /// Main. Start programu
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        /// <summary>
        ///  Metoda Sprawdzenia dostepnosci ksiazki. Metoda do testów
        /// </summary>
        /// <param name="title"></param>
        
        
        static public bool SprawdzKsiazke1(string title)
        {
            

        SqlConnection Sqlcon = new SqlConnection("Data Source=(LocalDB)\\MSSQLLOCALDB;Initial Catalog=SystemBiblioteczny;Integrated Security=True;Pooling=False");

        SqlDataAdapter sda = new SqlDataAdapter("Select * from [Book] where [Title]='"+title+"'",Sqlcon);
         DataTable dt = new DataTable("Ksiazka");
         sda.Fill(dt);

         if (dt.Rows.Count >0)
         {
             return true;
         }
         else
         {
            return false;
         }

     }
    }
}
