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
        private LoginWindow loginWindow;
        public MenuUserControl()
        {
            InitializeComponent();

            loginWindow = new LoginWindow();
        }

        private void btnLogInAndOut_Click(object sender, RoutedEventArgs e)
        {
            loginWindow.Visibility = Visibility.Visible;
        }

        private void btnFindReagent_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnFindInLab_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAllReagents_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
