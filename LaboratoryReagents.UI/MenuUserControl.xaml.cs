using LaboratoryReagents.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LaboratoryReagents.UI
{
    /// <summary>
    /// Interaction logic for MenuUserControl.xaml
    /// </summary>
    public partial class MenuUserControl : UserControl
    {
        public event RoutedEventHandler btnFindReagent_ClickHandler;
        public event RoutedEventHandler btnFindInLab_ClickHandler;
        public event RoutedEventHandler btnAllReagents_ClickHandler;
        public event RoutedEventHandler btnLogOut_ClickHandler;

        private LoginWindow loginWindow;
        private bool isUserLogged;
        public User UserOn { get; set; }

        public MenuUserControl()
        {
            InitializeComponent();

            loginWindow = new LoginWindow();
            isUserLogged = false;
            LockedMenuButtons();
        }

        private void btnLogInAndOut_Click(object sender, RoutedEventArgs e)
        {
            if (!isUserLogged)
            {
                if(loginWindow.IsActive)
                {
                    loginWindow.Visibility = Visibility.Visible;
                }
                else
                {
                    loginWindow.Show();
                    loginWindow.btnLogInWindowLogIn_ClickHandler += LoggedUser;

                }
            }
            else
            {
                isUserLogged = false;
                btnLogInAndOut.Content = "Log In";
                txtUserLogStatus.Text = "";
                LockedMenuButtons();
                btnLogOut_ClickHandler(sender, e);
            }
        }

        private void btnFindReagent_Click(object sender, RoutedEventArgs e)
        {
            btnFindReagent_ClickHandler(sender, e);
        }

        private void btnFindInLab_Click(object sender, RoutedEventArgs e)
        {
            btnFindInLab_ClickHandler(sender, e);
        }

        private void btnAllReagents_Click(object sender, RoutedEventArgs e)
        {
            btnAllReagents_ClickHandler(sender, e);

        }

        private void LoggedUser(object sender, RoutedEventArgs e)
        {
            btnLogInAndOut.Content = "Log Out";
            isUserLogged = true;
            loginWindow.Visibility = Visibility.Hidden;
            UserOn = loginWindow.loggedUser;
            txtUserLogStatus.Text = $"User: {UserOn.Username}";
            UnlockedMenuButtons();
        }
        private void LockedMenuButtons()
        {
            btnFindReagent.IsEnabled = false;
            btnFindInLab.IsEnabled = false;
            btnAllReagents.IsEnabled = false;
        }
        private void UnlockedMenuButtons()
        {
            btnFindReagent.IsEnabled = true;
            btnFindInLab.IsEnabled = true;
            btnAllReagents.IsEnabled = true;

        }
    }
}
