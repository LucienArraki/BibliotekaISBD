using System;
using System.Data;
using System.Data.Linq;
using System.Linq;
using System.Windows.Forms;
using Biblioteka;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteka.Model;

namespace Library
{
    public partial class FormLogin : Form
    {
        BibliotekaSQLDataContext dataContext = new BibliotekaSQLDataContext();
        public string userPESEL;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            /*Register register = new Register();                         // Otwiera okno rejestracji
            register.Show();*/
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            if (textBoxPESEL.Text == "" | textBoxPassword.Text == "")
            {
                textBoxPESEL.Text = "";
                textBoxPassword.Text = "";                              // Sprawdza czy podano login i hasło
            }
            else
            {
                userPESEL = textBoxPESEL.Text;

                try                                                                 // Pilnuje aby nie przekroczyć zakresu
                {
                    var login = (from User in dataContext.Uzytkownik where User.Login == textBoxPESEL.Text where User.Login != null select User).FirstOrDefault();

                    if (login.Haslo == textBoxPassword.Text)
                    {
                        if (login.Haslo == "admin")
                        {
                            /*AdminLibrary admin = new AdminLibrary();        // Jeśli login to admin to loguje admin
                            admin.Show();*/
                            MessageBox.Show("Zalogowano na konto administratora");
                        }
                        else
                        {
                            //UserLibrary user = new UserLibrary(userPESEL);  // Jeśli login inny to loguje na konto User
                            MessageBox.Show("Zalogowano na " + userPESEL);
                        }
                    }
                    else { MessageBox.Show("Blad"); }
                }
                catch (Exception) { MessageBox.Show("Exception"); }
            }
        }
    }
}
