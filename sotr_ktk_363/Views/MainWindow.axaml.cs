using Avalonia.Controls;
using Avalonia.Interactivity;
using sotr_ktk_363.ViewModels;

namespace sotr_ktk_363.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_NavigationToHomePage(object? sender, RoutedEventArgs e)
        {
            (DataContext as MainViewModel)?.NavigateToHomePage();
        }

        private void Button_NavigationToEmployeeListPage(object? sender, RoutedEventArgs e)
        {
            (DataContext as MainViewModel)?.NavigateToEmployeeListPage();
        }

        private void Button_NavigationToEmployeeChange(object? sender, RoutedEventArgs e)
        {
            (DataContext as MainViewModel)?.NavigateToEmployeeChange();
        }
    }
}