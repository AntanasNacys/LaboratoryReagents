using LaboratoryReagents.DL.Models;
using System.Windows;

namespace LaboratoryReagents.UI
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void btnLogInWindowLogIn_Click(object sender, RoutedEventArgs e)
        {
            string inputUsername = txtUserName.Text;
            string inputPassword = txtUserPassword.Text;

            foreach (var user in )
            {

            }

        }

        //private bool CheckUser(string username, string password)
        //{
        //    if (username != Username) return false;
        //    if (password != Password) return false;
        //    return true;
        //}

    }
}
