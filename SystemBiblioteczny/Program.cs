using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemBiblioteczny
{
    static public class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }

        /// <summary>
        ///  Metoda Sprawdzenia dostepnosci ksiazki. Metoda do testów
        /// </summary>
        /// <param name="title"></param>
        
        static public bool SprawdzKsiazke(string title)
        {
            SystemBibliotecznyEntities123 context = new SystemBibliotecznyEntities123();
            Book book = new Book();

            

            if (book == null)
            {
                
                return false;
            }
            else
            {
                var Szukaj = (from d in context.Books
                                        where d.Title == title
                                        select d).Single();

                
                return true;
            }

        }
        
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
