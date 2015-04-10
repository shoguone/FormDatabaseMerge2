using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using FormDatabasesMerge.EntityDataModel;
using FormDatabasesMerge.Utility;

namespace FormDatabasesMerge
{
    /// <summary>
    /// Логика взаимодействия для WindowWithGrid.xaml
    /// </summary>
    public partial class WindowWithGrid : Window
    {
        public WindowWithGrid()
        {
            InitializeComponent();
        }

        public void PopulateListView(List<DupToken> recruits)
        {
            RecruitsDataGrid.ItemsSource = recruits;
        }

        //public void PopulateListView(List<IGrouping<string, Recruit>> recruits)
        //{
        //    //GridListView.ItemsSource = recruits;
        //    RecruitsDataGrid.ItemsSource = recruits;
        //}

    }
}
