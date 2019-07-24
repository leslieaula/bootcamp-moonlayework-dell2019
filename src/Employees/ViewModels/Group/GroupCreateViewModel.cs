using System;
using System.ComponentModel.DataAnnotations;
using Employees.Data.Entities;

namespace Employees.ViewModels.Group
{
    public class GroupCreateViewModel
    {
        [Display(Name = "Group")]
        [Required()]
        public string GroupName { get; set; }

        internal Data.Entities.Group ToGroupEntity()
        {
            return new Data.Entities.Group
            {
                GroupName = GroupName
            };
        }
    }
}
