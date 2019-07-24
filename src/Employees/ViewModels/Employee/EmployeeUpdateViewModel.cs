using System;
using Employees.Data.Entities;

namespace Employees.ViewModels.Employee
{
    public class EmployeeUpdateViewModel
    {
        public EmployeeUpdateViewModel() { }

        public string FirstName { get; set; }

        internal Data.Entities.Employee ToEntity(Data.Entities.Employee employee)
        {
            employee.FirstName = FirstName;

            return employee;
        }
    }
}