using LaboratoryReagents.BL.Services;
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
    /// Interaction logic for AddDeleteUserControl.xaml
    /// </summary>
    public partial class AddDeleteUserControl : UserControl
    {
        public event RoutedEventHandler btnSave_ClickHandler;
        public event RoutedEventHandler btnCancel_ClickHandler;
        public event RoutedEventHandler btnDelete_ClickHandler;

        public IReagentEntryManager reagentEntryManager;
        private ReagentEntry reagentEntry;
        private List<ReagentName> reagentNames;
        private IReagentNameManager reagentNameManager;
        private ILocationManager locationManager;
        private List<Location> locations;
        private ReagentName selectedReagentName;
        private Location selectedLocation;
        public ReagentEntry SelectedReagentEntry { get; set; }
        public User UserOn { get; set; }

        public AddDeleteUserControl()
        {
            InitializeComponent();
            HideAddButtons();
            reagentEntryManager = new ReagentEntryManager();
        }

        private void btnAddReagent_Click(object sender, RoutedEventArgs e)
        {
            ShowAddButtons();
        }

        private void btnDeleteReagent_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedReagentEntry == null) MessageBox.Show("Reagent entry was not selected!");
            else if (MessageBox.Show("Delete reagent entry?", "Question", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                reagentEntryManager.DeleteEntry(SelectedReagentEntry.ReagentId);
                btnDelete_ClickHandler(sender, e);
            }
        }

        private void comboBoxReagentName_DropDownOpened(object sender, EventArgs e)
        {
            reagentNameManager = new ReagentNameManager();
            reagentNames = reagentNameManager.GetAll();
            comboBoxReagentName.ItemsSource = reagentNames.Select(x => x.Name);

        }

        private void comboBoxLocation_DropDownOpened(object sender, EventArgs e)
        {
            locationManager = new LocationManager();
            locations = locationManager.GetAll();
            comboBoxLocation.ItemsSource = locations.Select(x => x.LocationName);
        }
        private void comboBoxReagentName_DropDownClosed(object sender, EventArgs e)
        {
            if (comboBoxReagentName.SelectedItem == null) MessageBox.Show("Reagent was not selected");
            else selectedReagentName = reagentNameManager.GetByName(comboBoxReagentName.SelectedItem.ToString());
        }
        private void comboBoxLocation_DropDownClosed(object sender, EventArgs e)
        {
            if (comboBoxLocation.SelectedItem == null) MessageBox.Show("Location was not selected");
            else selectedLocation = locationManager.GetByLocation(comboBoxLocation.SelectedItem.ToString());
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (comboBoxLocation.SelectedItem == null) MessageBox.Show("Location was not selected ");
            else if (!int.TryParse(textBoxQuantity.Text, out int a)) MessageBox.Show("Quantity is not valid");
            else
            {
                reagentEntryManager = new ReagentEntryManager();
                reagentEntry = new ReagentEntry()
                {
                    ReagentNameId = selectedReagentName.ReagentNameId,
                    InsertionDate = DateTime.Now,
                    LocationId = selectedLocation.LocationId,
                    Quantity = Convert.ToInt32(textBoxQuantity.Text),
                    Comments = textBoxComments.Text,

                };
                reagentEntryManager.AddEntry(reagentEntry);
                comboBoxReagentName.SelectedItem = null;
                comboBoxLocation.SelectedItem = null;
                textBoxQuantity.Text = string.Empty;
                HideAddButtons();
                btnSave_ClickHandler(sender, e);
            }
            
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            comboBoxReagentName.SelectedItem = null;
            comboBoxLocation.SelectedItem = null;
            textBoxQuantity.Text = string.Empty;
            HideAddButtons();
        }

        private void ShowAddButtons()
        {
            comboBoxLocation.Visibility = Visibility.Visible;
            comboBoxReagentName.Visibility = Visibility.Visible;
            textBoxQuantity.Visibility = Visibility.Visible;
            btnSave.Visibility = Visibility.Visible;
            btnCancel.Visibility = Visibility.Visible;
            textBlock_ReagentName.Visibility = Visibility.Visible;
            textBlock_Location.Visibility = Visibility.Visible;
            textBlock_Quantity.Visibility = Visibility.Visible;
            textBlock_Comments.Visibility = Visibility.Visible;
            textBoxComments.Visibility = Visibility.Visible;
        }

        private void HideAddButtons()
        {
            comboBoxLocation.Visibility = Visibility.Hidden;
            comboBoxReagentName.Visibility = Visibility.Hidden;
            textBoxQuantity.Visibility = Visibility.Hidden;
            btnSave.Visibility = Visibility.Hidden;
            btnCancel.Visibility = Visibility.Hidden;
            textBlock_ReagentName.Visibility = Visibility.Hidden;
            textBlock_Location.Visibility = Visibility.Hidden;
            textBlock_Quantity.Visibility = Visibility.Hidden;
            textBlock_Comments.Visibility = Visibility.Hidden;
            textBoxComments.Visibility = Visibility.Hidden;
        }
       


    }
}
