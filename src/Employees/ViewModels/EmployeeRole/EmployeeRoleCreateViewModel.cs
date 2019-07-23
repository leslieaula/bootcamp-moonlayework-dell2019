using System;
using System.ComponentModel.DataAnnotations;
using Employees.Data.Entities;

namespace Employees.ViewModels.EmployeeRole
{
    public class EmployeeRoleCreateViewModel
    {
        [Display(Name = "Roles")]
        [Required()]
        public string PositionName { get; set; }
        public int GroupId { get; set; }

        internal Data.Entities.EmployeeRole ToRoleEntity()
        {
            return new Data.Entities.EmployeeRole
            {
                PositionName = this.PositionName,
                GroupId = this.GroupId
            };
        }
    }
}
