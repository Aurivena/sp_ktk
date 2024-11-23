using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.VisualTree;
using sotr_ktk_363.Models;
using sotr_ktk_363.ViewModels;

namespace sotr_ktk_363.Views
{
    public partial class ChangeEmployeePage : UserControl
    {
        private Employee _employee;
        
        public ChangeEmployeePage(Employee employee)
        {
            InitializeComponent();
            _employee = employee;
            
            DataContext = new ChangeEmployeeViewModel(employee);
        }

        private void UpdateDataEmployee(object? sender, RoutedEventArgs e)
        {

            var viewModel = (ChangeEmployeeViewModel)DataContext;

            viewModel.Employee.Name = _employee.Name;
            viewModel.Employee.Post = _employee.Post;
            viewModel.Employee.WorkExperience = _employee.WorkExperience;
            var parentWindow = this.FindAncestorOfType<Window>();
            if (parentWindow != null)
            {
                var mainViewModel = parentWindow.DataContext as MainViewModel;
                if (mainViewModel != null)
                {
                    mainViewModel.NavigateToEmployeeListPage();
                }
            }
        }

    }
}