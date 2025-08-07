using System.Windows;
using FilterLifecycleTrackerAdmin.Data;

namespace FilterLifecycleTrackerAdmin
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            filtersDataGrid.ItemsSource = FilterRepository.GetFilters();
        }
    }
}