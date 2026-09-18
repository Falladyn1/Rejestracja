using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Rejestracja2
{
    public partial class UcLogin : UserControl
    {

        public UcLogin()
        {
            InitializeComponent();

            ShowLoginMode();
        }

        // flaga do pokazania czy ktoś jest aktualnie zalogowany
        public bool IsLoggedIn { get; private set; } = false;

        // zdarzenie przez które przekazujemy że logowanie się powiodło
        public event EventHandler? LoginSucceeded;

        public bool TryLogin()
        {
            if (IsEmpty(textBoxLogin, textBoxPasswd))
            {
                ShowLoginError("Wypełnij wszystkie pola");
                return false;
            }

            string username = textBoxLogin.Text;
            string password = textBoxPasswd.Text;

            // pobranie listy użytkowników
            List<User> users = UserDatabase.LoadUsers();

            // szukanie dopasowania
            foreach (User user in users)
            {
                if (user.Username == username && user.Password == password)
                {
                    MessageBox.Show("Zalogowano pomyślnie");

                    IsLoggedIn = true;

                    // zapisanie aktualnego użytkownika     
                    Session.LoggedInUser = user.Username;

                    return true;
                }
            }

            ShowLoginError("Błędny login lub hasło");
            ClearLoginFields();

            IsLoggedIn = false;
            return false;
        }

        // jesli metoda TryLogin zwroci true to odpalamy zdarzenie
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (TryLogin())
            {
                LoginSucceeded?.Invoke(this, EventArgs.Empty);
            }
        }


        private void ShowLoginMode()
        {
            btnLogin.Visible = true;
            labelWrong.Visible = false;
        }




        private bool IsEmpty(params TextBox[] textBoxes)
        {
            foreach (TextBox textBox in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    return true;
                }
            }

            return false;
        }

        private void ShowLoginError(string message)
        {
            if (!labelWrong.Visible)
            {
                labelWrong.Visible = true;
            }

            labelWrong.Text = message;
        }



        private void ClearLoginFields()
        {
            textBoxLogin.Clear();
            textBoxPasswd.Clear();
        }
    }
}