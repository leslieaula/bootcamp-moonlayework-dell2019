using Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employees.Data.Entities
{
    public class EmployeeRole : Entity
    {

        public string PositionName { get; set; }


        //Database Relational
        public int GroupId { get; set; }
        public virtual Group Group { get; set; }
        public ICollection<Employee> Employees { get; set; }

    }
}
