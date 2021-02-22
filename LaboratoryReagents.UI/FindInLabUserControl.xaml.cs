using LaboratoryReagents.BL.Services;
using LaboratoryReagents.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace LaboratoryReagents.UI
{
    /// <summary>
    /// Interaction logic for FindInLabUserControl.xaml
    /// </summary>
    public partial class FindInLabUserControl : UserControl
    {
        public event EventHandler comboBoxChooseLab_DropDownClosedHandler;
        private List<Location> locations;
        private ILocationManager locationManager;
        public string selectedLocation;

        public FindInLabUserControl()
        {
            InitializeComponent();
        }

        private void comboBoxChooseLab_DropDownOpened(object sender, EventArgs e)
        {
            locationManager = new LocationManager();
            locations = locationManager.GetAll();
            comboBoxChooseLab.ItemsSource = locations.Select(x => x.LocationName);
        }

        private void comboBoxChooseLab_DropDownClosed(object sender, EventArgs e)
        {
            if (comboBoxChooseLab.SelectedItem == null) MessageBox.Show("Laboratory was not selected!");
            else selectedLocation = comboBoxChooseLab.SelectedItem.ToString();
            comboBoxChooseLab_DropDownClosedHandler(sender, e);


        }


    }
}
