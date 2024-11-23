using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using sotr_ktk_363.Models;

namespace sotr_ktk_363.ViewModels;

public class EmployeeListViewModel
{
    public ObservableCollection<Employee> Employees { get; set; }
    
    public Employee? SelectedEmployee { get; set; }
    
    public EmployeeListViewModel()
    {
        Employees = new ObservableCollection<Employee>()
        {
            new Employee() { Name = "Сергей Духота", Post = "Тренер", WorkExperience = 20 },
            new Employee() { Name = "Александр Никулин", Post = "Тренер", WorkExperience = 20 },
            new Employee() { Name = "Бамстед Йоу", Post = "Тренер", WorkExperience = 99 },
            new Employee() { Name = "Дмитрий Пухович", Post = "Менеджер", WorkExperience = 4 },
            new Employee() { Name = "Маркоша Худощаев", Post = "Маркетолог", WorkExperience = 3 }
        };
        
        SelectedEmployee = Employees[0];
    }
}