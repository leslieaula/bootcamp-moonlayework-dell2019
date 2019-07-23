using System;
using Employees.Data.Entities;

namespace Employees.ViewModels.Employee
{
    public class EmployeeRoleUpdateViewModel
    {
        public EmployeeRoleUpdateViewModel() { }

        public string PositionName { get; set; }

        internal Data.Entities.EmployeeRole ToRoleEntity(Data.Entities.EmployeeRole role)
        {
            role.PositionName = PositionName;

            return role;
        }
    }
}