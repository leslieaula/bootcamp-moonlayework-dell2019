using System.Collections.Generic;
using Employees.Data.Entities;

namespace Employees.ViewModels.Employee
{
    public class EmployeeRoleIndexViewModel
    {
        public EmployeeRoleIndexViewModel(IEnumerable<Data.Entities.EmployeeRole> data)
        {
            Roles = data ?? new List<Data.Entities.EmployeeRole>();
        }

        public IEnumerable<Data.Entities.EmployeeRole> Roles { get; }
    }
}