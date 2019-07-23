using Data.Entities;
using System;
using System.ComponentModel;

namespace Employees.Data.Entities
{
    public class Employee : Entity, ISoftDelete
    {
        public string FirstName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string LastName { get; set; }
        public string InitialName { get; set; }

        //Personal Data 
        public string KTPAddress { get; set; }
        public string CurrentAddress { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public string PhoneNumber { get; set; }
        public string TelephoneNumber { get; set; }
        public string EmergencyContact { get; set; }
        public string Religion { get; set; }
        public string BirthLocation { get; set; }
        public string LastEducation { get; set; }
        public string PersonalEmail { get; set; }
        public string OfficeEmail { get; set; }
        public DateTimeOffset BirthDate { get; set; }
        public int IdentityCardNumber { get; set; }

        //WorkerData
        public string StatusWorker { get; set; }
        public string LineManager { get; set; }
        public string DepartmentName { get; set; }
        public string GradingTitle { get; set; }
        public int Grading { get; set; }
        public string ReasonLeaving { get; set; }
        public string SpecialNotes { get; set; }
        public string WorkLocation { get; set; }
        public string OfficeAddress { get; set; }
        public string Salary { get; set; }
        public string NoSurat { get; set; }
        public DateTimeOffset JoinDate { get; set; }
        public DateTimeOffset PassProbation { get; set; }
        public DateTimeOffset TransferDate { get; set; }
        public DateTimeOffset ResignationDate { get; set; }
        public double CashOutLeave { get; set; }

        //NPWP
        public string NPWP { get; set; }
        public string NPWPAddress { get; set; }

        //Bank Account
        public string BankName { get; set; }
        public int AccountNumber { get; set; }
        public string BranchName { get; set; }
        public string ReceiverName { get; set; }


        // Database Relational
        public int EmployeeRoleId { get; set; }
        public virtual EmployeeRole EmployeeRole { get; set; }





        // Soft Delete
        [DefaultValue(false)]
        public bool IsDeleted { get; set; }

        public DateTimeOffset? Deleted { get; set; }

        public string DeleteBy { get; set; }
    }
}
