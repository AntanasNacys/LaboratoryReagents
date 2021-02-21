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
    /// Interaction logic for ChangeQtyLocUserControl.xaml
    /// </summary>
    public partial class ChangeQtyLocUserControl : UserControl
    {
        public event RoutedEventHandler btnSave_ClickHandler;
        private ILocationManager locationManager;
        private IReagentEntryManager reagentEntryManager;
        public ReagentEntry SelectedReagentEntry { get; set; }
        public ChangeQtyLocUserControl()
        {
            InitializeComponent();
            locationManager = new LocationManager();
            reagentEntryManager = new ReagentEntryManager();

        }
        public void SetValues()
        {
            comboBoxLocation.ItemsSource = locationManager.GetAll().Select(x => x.LocationName).ToList();
            comboBoxLocation.SelectedItem = SelectedReagentEntry.Location.LocationName;
            textBoxQuantity.Text = SelectedReagentEntry.Quantity.ToString();
        }
        private void btnChangeQty_Click(object sender, RoutedEventArgs e)
        {
            ShowPanel();
        }
        private void btnChangeLoc_Click(object sender, RoutedEventArgs e)
        {

        }


        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (comboBoxLocation.SelectedItem == null) MessageBox.Show("Location not selected");
            else if (!int.TryParse(textBoxQuantity.Text, out int a)) MessageBox.Show("Quantity is not valid");
            else
            {
                ReagentEntry newReagentEntry = new ReagentEntry()
                {
                    ReagentId = SelectedReagentEntry.ReagentId,
                    ReagentNameId = SelectedReagentEntry.ReagentNameId,
                    InsertionDate = SelectedReagentEntry.InsertionDate,
                    LocationId = locationManager.GetByLocation(comboBoxLocation.SelectedItem.ToString()).LocationId,
                    Quantity = Convert.ToInt32(textBoxQuantity.Text),
                    Comments = SelectedReagentEntry.Comments
                };
                reagentEntryManager.UpdateEntry(newReagentEntry);
                btnSave_ClickHandler(sender, e);
                HidePanel();
            };


        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            comboBoxLocation.SelectedItem = null;
            textBoxQuantity.Text = string.Empty;
            HidePanel();
        }
        private void ShowPanel()
        {
            comboBoxLocation.Visibility = Visibility.Visible;
            textBoxQuantity.Visibility = Visibility.Visible;
            btnSave.Visibility = Visibility.Visible;
            btnCancel.Visibility = Visibility.Visible;

        }
        private void HidePanel()
        {
            comboBoxLocation.Visibility = Visibility.Hidden;
            textBoxQuantity.Visibility = Visibility.Hidden;
            btnSave.Visibility = Visibility.Hidden;
            btnCancel.Visibility = Visibility.Hidden;
        }
    }

}
