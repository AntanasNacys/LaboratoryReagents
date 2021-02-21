using LaboratoryReagents.BL.Services;
using LaboratoryReagents.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

namespace LaboratoryReagents.UI
{
    /// <summary>
    /// Interaction logic for FindReagentUserControl.xaml
    /// </summary>
    public partial class FindReagentUserControl : UserControl
    {
        public event EventHandler comboBoxChooseReagent_DropDownClosedHandler;
        private List<ReagentName> reagentNames;
        private IReagentNameManager reagentNameManager;
        public string selectedReagent;

        public FindReagentUserControl()
        {
            InitializeComponent();
        }

        private void comboBoxChooseReagent_DropDownOpened(object sender, EventArgs e)
        {
            reagentNameManager = new ReagentNameManager();
            reagentNames = reagentNameManager.GetAll();
            comboBoxChooseReagent.ItemsSource = reagentNames.Select(x => x.Name);
        }

        private void comboBoxChooseReagent_DropDownClosed(object sender, EventArgs e)
        {
            selectedReagent = comboBoxChooseReagent.SelectedItem.ToString();
            comboBoxChooseReagent_DropDownClosedHandler(sender, e);
        }
    }
}
