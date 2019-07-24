using Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employees.Data.Entities
{
    public class Group : Entity
    {

        public string GroupName { get; set; }

        //Entity Relational
        public ICollection<EmployeeRole> EmployeeRoles { get; set; }
    }
}
