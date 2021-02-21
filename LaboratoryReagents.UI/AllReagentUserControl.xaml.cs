using LaboratoryReagents.BL.Models;
using LaboratoryReagents.BL.Services;
using LaboratoryReagents.DL;
using LaboratoryReagents.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Interaction logic for ReagentUserControl.xaml
    /// </summary>
    public partial class AllReagentUserControl : UserControl
    {
        public event SelectionChangedEventHandler dataGridReagents_SelectionChangedClickHandler;
        //private List<ReagentEntry> dataGridReagents;

        private IReagentUIViewManager reagentUIViewManager;
        private List<ReagentUIView> reagentUIViews;
        public AllReagentUserControl()
        {
            InitializeComponent();
            



        }
        public void SetDataGridValues()
        {
            reagentUIViewManager = new ReagentUIViewManager();
            reagentUIViews = reagentUIViewManager.GetAll();
            dataGridReagents.ItemsSource = reagentUIViews;
            //priskirt datagridui reiksmes
            //reikes issikviest, kad visas reiksmes is duombazes perverstu i reagentUIView.
            //dgBudget.ItemsSource = _transactionViewModels;

            /*using (var ctx = new ReagentContext())
            {
                var list = reagentEntryManager.GetAllReagents();
                dataGridReagents.ItemsSource = list
                    .Select(x => new {DateTime = DateTime.Now,
                    ReagentName = x.ReagentName.Name,
                    Location = x.Location.LocationName,
                    Quantity = x.Quantity,
                    Comments = x.Comments});

                dataGridReagents.Items.Refresh();

            }*/

        }

        public void SetDataGridValuesForLab(string location)
        {
            reagentUIViewManager = new ReagentUIViewManager();
            reagentUIViews = reagentUIViewManager.GetReagentsByLocation(location);
            dataGridReagents.ItemsSource = reagentUIViews;
        }
        public void SetDataGridValuesForReagent(string reagentName)
        {
            reagentUIViewManager = new ReagentUIViewManager();
            reagentUIViews = reagentUIViewManager.GetReagentsByName(reagentName);
            dataGridReagents.ItemsSource = reagentUIViews;
        }
        public void dataGridReagents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            dataGridReagents_SelectionChangedClickHandler(sender, e);
        }

    }
}
