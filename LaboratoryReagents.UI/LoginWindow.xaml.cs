using LaboratoryReagents.DL.Models;
using System.Windows;
using System.Linq;
using LaboratoryReagents.DL;
using System.Collections.Generic;
using LaboratoryReagents.BL.Services;

namespace LaboratoryReagents.UI
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        List<User> Users = new List<User>();

        public LoginWindow()
        {
            InitializeComponent();

            

            UserManager userManager = new UserManager();

            Users = userManager.GetAll();

        }

        
        
        private void btnLogInWindowLogIn_Click(object sender, RoutedEventArgs e)
        {
            string givenUsername = txtUserName.Text;
            string givenPassword = txtUserPassword.Text;

            if (txtUserName.Text.Length == 0)
            {
                errorMessage.Text = "Please enter Username!";
                txtUserName.Select(0, txtUserName.Text.Length);
                txtUserName.Focus();
            }

            CheckUser(givenUsername, givenPassword);
        }

        public bool CheckUser(string username, string password)
        {
            foreach (var user in Users)
            {
                if (username != user.Username)
                {
                    return false;
                }
                if (password != user.Password)
                {
                    return false;
                }
                


            }
            return true;
            errorMessage.Text = "User name was not found!";
            
        }

    }
}
