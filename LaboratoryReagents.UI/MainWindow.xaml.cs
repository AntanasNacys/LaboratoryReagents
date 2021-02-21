using LaboratoryReagents.BL.Models;
using LaboratoryReagents.DL.Models;
using System.Windows;
using System.Windows.Controls;

namespace LaboratoryReagents.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private User UserOn { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            AllReagentUserControl.Visibility = Visibility.Hidden;
            FindReagentUserControl.Visibility = Visibility.Hidden;
            FindInLabUserControl.Visibility = Visibility.Hidden;
            AddDeleteUserControl.Visibility = Visibility.Hidden;
            ChangeQtyLocUserControl.Visibility = Visibility.Hidden;

            
            MenuUserControl.btnLogOut_ClickHandler += btnLogOut_Click;
            MenuUserControl.btnAllReagents_ClickHandler += btnAllReagents_Click;
            MenuUserControl.btnFindInLab_ClickHandler += btnFindInLab_Click;
            MenuUserControl.btnFindReagent_ClickHandler += btnFindReagent_Click;
            AddDeleteUserControl.btnSave_ClickHandler += RefreshTable;
            AddDeleteUserControl.btnDelete_ClickHandler += RefreshTable;
            AllReagentUserControl.dataGridReagents_SelectionChangedClickHandler += SelectionChanged;
            FindInLabUserControl.comboBoxChooseLab_DropDownClosedHandler += ShowInLab;





        }

        private void btnFindReagent_Click(object sender, RoutedEventArgs e)
        {
            FindReagentUserControl.Visibility = Visibility.Visible;
            AllReagentUserControl.Visibility = Visibility.Visible;
            FindInLabUserControl.Visibility = Visibility.Hidden;
            AddDeleteUserControl.Visibility = Visibility.Hidden;
            ChangeQtyLocUserControl.Visibility = Visibility.Hidden;
            

            
        }

        private void btnFindInLab_Click(object sender, RoutedEventArgs e)
        {
            FindInLabUserControl.Visibility = Visibility.Visible;
            AllReagentUserControl.Visibility = Visibility.Visible;
            FindReagentUserControl.Visibility = Visibility.Hidden;
            AddDeleteUserControl.Visibility = Visibility.Hidden;
            ChangeQtyLocUserControl.Visibility = Visibility.Hidden;
        }

        private void btnAllReagents_Click(object sender, RoutedEventArgs e)
        {
            UserOn = MenuUserControl.UserOn;
            if (UserOn.IsAdmin)
            {
                AllReagentUserControl.Visibility = Visibility.Visible;
                AddDeleteUserControl.Visibility = Visibility.Visible;
                ChangeQtyLocUserControl.Visibility = Visibility.Visible;
                FindReagentUserControl.Visibility = Visibility.Hidden;
                FindInLabUserControl.Visibility = Visibility.Hidden;
                //padaryti kad refreshintu datagrid 
                AllReagentUserControl.SetDataGridValues();

            }
            else
            {
                AllReagentUserControl.Visibility = Visibility.Visible;
                ChangeQtyLocUserControl.Visibility = Visibility.Visible;
                FindReagentUserControl.Visibility = Visibility.Hidden;
                FindInLabUserControl.Visibility = Visibility.Hidden;
                AddDeleteUserControl.Visibility = Visibility.Hidden;

            }
        }
        private void RefreshTable(object sender, RoutedEventArgs e)

        {
            AllReagentUserControl.SetDataGridValues();

        }

        private void SelectionChanged (object sender, SelectionChangedEventArgs e)
        {
            if (AllReagentUserControl.dataGridReagents.SelectedItem != null)
            {
                AddDeleteUserControl.SelectedReagentEntry = AddDeleteUserControl.reagentEntryManager.GetReagent(((ReagentUIView)AllReagentUserControl.dataGridReagents.SelectedItem).ReagentId);
                RefreshTable(sender,e);
            }
        }
        private void btnLogOut_Click(object sender, RoutedEventArgs e)
        {
            MenuUserControl.UserOn = null;
            AllReagentUserControl.Visibility = Visibility.Hidden;
            FindInLabUserControl.Visibility = Visibility.Hidden;
            FindReagentUserControl.Visibility = Visibility.Hidden;
            AddDeleteUserControl.Visibility = Visibility.Hidden;
            ChangeQtyLocUserControl.Visibility = Visibility.Hidden;
            

        }
        private void ShowInLab(object sender, RoutedEventArgs e)
        {
            Location location = (Location)sender;
            AllReagentUserControl.SetDataGridValuesForLab(location);
        }
    }
}
