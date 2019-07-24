using System;
using System.ComponentModel.DataAnnotations;
using Employees.Data.Entities;

namespace Employees.ViewModels.Employee
{
    public class EmployeeCreateViewModel
    {
        [Display(Name = "First Name")]
        [Required()]
        public string FirstName { get; set; }
        public string FullName { get; set; }
        public string InitialName { get; set; }
        public int IdentityCardNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string TelephoneNumber { get; set; }
        public string CurrentAddress { get; set; }
        public string PersonalEmail { get; set; }

        // Employment Information
        public DateTimeOffset JoinDate { get; set; }
        public DateTimeOffset PassProbation { get; set; }
        public string DepartmentName { get; set; }
        public string LineManager { get; set; }
        public string Salary { get; set; }
        public string EmergencyContact { get; set; }
        public string StatusWorker { get; set; }

        //Bank Account
        public string BankName { get; set; }
        public int AccountNumber { get; set; }
        public string BranchName { get; set; }
        public string ReceiverName { get; set; }
        public int EmployeeRoleId { get; set; }
        internal Data.Entities.Employee ToEntity()
        {
            return new Data.Entities.Employee
            {
                EmployeeRoleId = this.EmployeeRoleId,
                Username = "",
                FirstName = this.FirstName,
                FullName = this.FullName,
                InitialName = this.InitialName,
                IdentityCardNumber = this.IdentityCardNumber,
                PhoneNumber = this.PhoneNumber,
                TelephoneNumber = this.TelephoneNumber,
                CurrentAddress = this.CurrentAddress,
                PersonalEmail = this.PersonalEmail,
                JoinDate = this.JoinDate,
                PassProbation = this.PassProbation,
                DepartmentName = this.DepartmentName,
                LineManager = this.LineManager,
                Salary = this.Salary,
                EmergencyContact = this.EmergencyContact,
                StatusWorker = this.StatusWorker,
                BankName = this.BankName,
                AccountNumber = this.AccountNumber,
                BranchName = this.BranchName,
                ReceiverName = this.ReceiverName,
                BirthLocation = "",
                Gender = "",
                GradingTitle = "",
                KTPAddress = "",
                LastEducation = "",
                LastName = "",
                MaritalStatus = "",
                NPWP = "",
                NPWPAddress = "",
                NoSurat = "",
                OfficeAddress = "",
                OfficeEmail = "",
                Password = "",
                ReasonLeaving = "",
                Religion = "",
                SpecialNotes = "",
                WorkLocation = ""
            };
        }
    }
}
