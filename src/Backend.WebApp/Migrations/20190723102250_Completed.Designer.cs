﻿// <auto-generated />
using System;
using ExtCore.Data.EntityFramework.SqlServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Backend.WebApp.Migrations
{
    [DbContext(typeof(StorageContext))]
    [Migration("20190723102250_Completed")]
    partial class Completed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Employees.Data.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountNumber");

                    b.Property<string>("BankName");

                    b.Property<DateTimeOffset>("BirthDate");

                    b.Property<string>("BirthLocation")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("BranchName");

                    b.Property<double>("CashOutLeave");

                    b.Property<DateTimeOffset>("Created");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("CurrentAddress")
                        .IsRequired()
                        .HasMaxLength(225);

                    b.Property<string>("DeleteBy");

                    b.Property<DateTimeOffset?>("Deleted");

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("EmergencyContact")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<int>("EmployeeRoleId");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<int>("Grading");

                    b.Property<string>("GradingTitle")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<int>("IdentityCardNumber");

                    b.Property<string>("InitialName")
                        .IsRequired()
                        .HasMaxLength(3);

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTimeOffset>("JoinDate");

                    b.Property<string>("KTPAddress")
                        .IsRequired()
                        .HasMaxLength(225);

                    b.Property<string>("LastEducation")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("LineManager")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("MaritalStatus")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<DateTimeOffset?>("Modified");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(64);

                    b.Property<string>("NPWP");

                    b.Property<string>("NPWPAddress");

                    b.Property<string>("NoSurat")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("OfficeAddress")
                        .IsRequired()
                        .HasMaxLength(225);

                    b.Property<string>("OfficeEmail")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<DateTimeOffset>("PassProbation");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("PersonalEmail")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("ReasonLeaving")
                        .IsRequired()
                        .HasMaxLength(225);

                    b.Property<string>("ReceiverName");

                    b.Property<string>("Religion")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<DateTimeOffset>("ResignationDate");

                    b.Property<string>("Salary")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("SpecialNotes")
                        .IsRequired()
                        .HasMaxLength(225);

                    b.Property<string>("StatusWorker")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("TelephoneNumber")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<DateTimeOffset>("TransferDate");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("WorkLocation")
                        .IsRequired()
                        .HasMaxLength(225);

                    b.HasKey("Id");

                    b.HasIndex("EmployeeRoleId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Employees.Data.Entities.EmployeeRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("Created");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<int>("GroupId");

                    b.Property<DateTimeOffset?>("Modified");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(64);

                    b.Property<string>("PositionName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Employees.Data.Entities.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("Created");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTimeOffset?>("Modified");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("Employees.Data.Entities.Employee", b =>
                {
                    b.HasOne("Employees.Data.Entities.EmployeeRole", "EmployeeRole")
                        .WithMany("Employees")
                        .HasForeignKey("EmployeeRoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Employees.Data.Entities.EmployeeRole", b =>
                {
                    b.HasOne("Employees.Data.Entities.Group", "Group")
                        .WithMany("EmployeeRoles")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
