using Employees.Data.Entities;
using ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employees.Data.EntityFramework.SqlServer
{
    public class EntityRegistrar : IEntityRegistrar
    {
        public void RegisterEntities(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Employee>(etb => {
                etb.ToTable("Employees");
                etb.HasKey(e => e.Id);
                etb.Property(e => e.Id).ValueGeneratedOnAdd();

                etb.Property(e => e.FirstName).HasMaxLength(64).IsRequired();
                etb.Property(e => e.Username).HasMaxLength(25).IsRequired();
                etb.Property(e => e.Password).HasMaxLength(25).IsRequired();
                etb.Property(e => e.FullName).HasMaxLength(64).IsRequired();
                etb.Property(e => e.LastName).HasMaxLength(64).IsRequired();
                etb.Property(e => e.InitialName).HasMaxLength(3).IsRequired();

                //Personal Data
                etb.Property(e => e.KTPAddress).HasMaxLength(225).IsRequired();
                etb.Property(e => e.CurrentAddress).HasMaxLength(225).IsRequired();
                etb.Property(e => e.Gender).HasMaxLength(30).IsRequired();
                etb.Property(e => e.MaritalStatus).HasMaxLength(20).IsRequired();
                etb.Property(e => e.PhoneNumber).HasMaxLength(25).IsRequired();
                etb.Property(e => e.TelephoneNumber).HasMaxLength(25).IsRequired();
                etb.Property(e => e.EmergencyContact).HasMaxLength(64).IsRequired();
                etb.Property(e => e.Religion).HasMaxLength(25).IsRequired();
                etb.Property(e => e.BirthLocation).HasMaxLength(64).IsRequired();
                etb.Property(e => e.LastEducation).HasMaxLength(20).IsRequired();
                etb.Property(e => e.PersonalEmail).HasMaxLength(64).IsRequired();
                etb.Property(e => e.OfficeEmail).HasMaxLength(64).IsRequired();

                //Worker Status
                etb.Property(e => e.StatusWorker).HasMaxLength(25).IsRequired();
                etb.Property(e => e.LineManager).HasMaxLength(64).IsRequired();
                etb.Property(e => e.DepartmentName).HasMaxLength(64).IsRequired();
                etb.Property(e => e.GradingTitle).HasMaxLength(64).IsRequired();
                etb.Property(e => e.ReasonLeaving).HasMaxLength(225).IsRequired();
                etb.Property(e => e.SpecialNotes).HasMaxLength(225).IsRequired();
                etb.Property(e => e.WorkLocation).HasMaxLength(225).IsRequired();
                etb.Property(e => e.OfficeAddress).HasMaxLength(225).IsRequired();
                etb.Property(e => e.Salary).HasMaxLength(64).IsRequired();
                etb.Property(e => e.NoSurat).HasMaxLength(64).IsRequired();



                etb.HasQueryFilter(m => m.IsDeleted == false);
            });

            modelbuilder.Entity<Group>(etb =>
            {
                etb.ToTable("Groups");
                etb.HasKey(g => g.Id);
                etb.Property(g => g.Id).ValueGeneratedOnAdd();

                etb.Property(g => g.GroupName).HasMaxLength(50).IsRequired();

                etb.HasMany(r => r.EmployeeRoles).WithOne(g => g.Group).HasForeignKey(f => f.GroupId);

               
            });

            modelbuilder.Entity<EmployeeRole>(etb =>
            {
                etb.ToTable("Roles");
                etb.HasKey(r => r.Id);
                etb.Property(r => r.Id).ValueGeneratedOnAdd();

                etb.HasMany(e => e.Employees).WithOne(r => r.EmployeeRole).HasForeignKey(h => h.EmployeeRoleId);

                etb.Property(r => r.PositionName).HasMaxLength(50).IsRequired();

            });
        }
    }
}
