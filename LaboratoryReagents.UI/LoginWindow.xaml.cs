using LaboratoryReagents.DL.Models;
using System.Windows;
using System.Linq;
using System.ComponentModel;
using System.Collections.Generic;
using LaboratoryReagents.BL.Services;

namespace LaboratoryReagents.UI
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public event RoutedEventHandler btnLogInWindowLogIn_ClickHandler;
        private List<User> Users = new List<User>();
        public User loggedUser;
        
       

        public LoginWindow()
        {
            InitializeComponent();
        }


        

        private void btnLogInWindowLogIn_Click(object sender, RoutedEventArgs e)
        {
            UserManager userManager = new UserManager();
            Users = userManager.GetAll();
            string givenUsername = txtUserName.Text;
            string givenPassword = txtUserPassword.Password;

            if (txtUserName.Text.Length == 0 && txtUserPassword.Password.Length == 0)
            {

                txtUserName.Select(0, txtUserName.Text.Length);
                txtUserName.Focus();

            }
            else
            {
                if (CheckUser(givenUsername, givenPassword))
                {
                    btnLogInWindowLogIn_ClickHandler(sender, e);

                }


            }

        }

        private bool CheckUser(string username, string password)
        {
            User selectedUser = Users.FirstOrDefault(u => u.Username == username); //ar First vietoj FirstOrDefault
           
            if (selectedUser.Username != username)
            {
                errorMessage.Text = "Incorrect Username";
                return false;
            }
            if (selectedUser.Password != password)
            {
                errorMessage.Text = "Incorrect password";
                return false;
            }
            errorMessage.Text = "Correct password";
            loggedUser = selectedUser;
            return true;

          
        }

        private void logInWindowClosing(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
