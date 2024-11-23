using sotr_ktk_363.Models;

namespace sotr_ktk_363.ViewModels
{
    public class ChangeEmployeeViewModel
    {
        public Employee Employee { get; set; }

        public ChangeEmployeeViewModel(Employee employee)
        {
            Employee = employee;
        }
    }
}