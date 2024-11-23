using System;
using sotr_ktk_363.Views;
using System.ComponentModel;

namespace sotr_ktk_363.ViewModels;

public class MainViewModel : INotifyPropertyChanged
{
    private object _currentPage;
    public object CurrentPage
    {
        get => _currentPage;
        set
        {
            _currentPage = value;
            OnPropertyChanged(nameof(CurrentPage));
        }
    }

    public EmployeeListViewModel EmployeeListViewModel { get; private set; }

    public MainViewModel()
    {
        EmployeeListViewModel = new EmployeeListViewModel();
        CurrentPage = new HomePage();
    }

    public void NavigateToHomePage()
    {
        CurrentPage = new HomePage();
    }

    public void NavigateToEmployeeListPage()
    {
        CurrentPage = new EmployeeListPage { DataContext = EmployeeListViewModel };
    }

    public void NavigateToEmployeeChange()
    {
        var employee = EmployeeListViewModel.SelectedEmployee;
        if (employee != null)
        {
            CurrentPage = new ChangeEmployeePage(employee);
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}