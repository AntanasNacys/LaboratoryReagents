﻿using LaboratoryReagents.BL.Services;
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
    /// Interaction logic for FindInLabUserControl.xaml
    /// </summary>
    public partial class FindInLabUserControl : UserControl
    {
        public event EventHandler comboBoxChooseLab_DropDownClosedHandler;
        private List<ReagentEntry> reagentEntries;
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
            selectedLocation = comboBoxChooseLab.SelectedItem.ToString();
            comboBoxChooseLab_DropDownClosedHandler(sender, e);

        }


    }
}
