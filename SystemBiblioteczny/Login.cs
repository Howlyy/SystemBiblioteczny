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
    /// Klasa dla okna Logowania
    /// </summary>
    public partial class LoginForm : Form 
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Metoda przycisku Login. Po przycisnieciu Sprawdza dane z TextBoxów czy poprawne tak jak w bazie i loguje dalej
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginButton_Click(object sender, EventArgs e) 
        {
            SystemBibliotecznyEntities123 content = new SystemBibliotecznyEntities123(); //połaczenie do bazy
            if (UsernameTB.Text != string.Empty && PasswordTB.Text != string.Empty) // sprawdzenie czy user i pass nie są puste
            {
                var user = content.Admins.Where(x => x.Username.Equals(UsernameTB.Text)).FirstOrDefault(); // sprawdzenie username w tabeli Admin
                if (user!=null) 
                {
                    if (user.Password.Equals(PasswordTB.Text))
                    {
                        MessageBox.Show("Zalogowano!");
                        new MainForm().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Hasło nieprawidłowe!");
                    }
                }
                else
                {
                    MessageBox.Show("Nazwa użytkownika nieprawidłowe!");
                }
            }
        }
    }
}
