using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.WebApp.Migrations
{
    public partial class Entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccountNumber",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BankName",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "BirthDate",
                table: "Employees",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "BirthLocation",
                table: "Employees",
                maxLength: 64,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BranchName",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "CashOutLeave",
                table: "Employees",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "CurrentAddress",
                table: "Employees",
                maxLength: 225,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DepartmentName",
                table: "Employees",
                maxLength: 64,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmergencyContact",
                table: "Employees",
                maxLength: 64,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeRoleId",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Employees",
                maxLength: 64,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Employees",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Grading",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "GradingTitle",
                table: "Employees",
                maxLength: 64,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "IdentityCardNumber",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "InitialName",
                table: "Employees",
                maxLength: 3,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "JoinDate",
                table: "Employees",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "KTPAddress",
                table: "Employees",
                maxLength: 225,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastEducation",
                table: "Employees",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Employees",
                maxLength: 64,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LineManager",
                table: "Employees",
                maxLength: 64,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MaritalStatus",
                table: "Employees",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NPWP",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NPWPAddress",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NoSurat",
                table: "Employees",
                maxLength: 64,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OfficeAddress",
                table: "Employees",
                maxLength: 225,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OfficeEmail",
                table: "Employees",
                maxLength: 64,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "PassProbation",
                table: "Employees",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Employees",
                maxLength: 25,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PersonalEmail",
                table: "Employees",
                maxLength: 64,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Employees",
                maxLength: 25,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ReasonLeaving",
                table: "Employees",
                maxLength: 225,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ReceiverName",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Religion",
                table: "Employees",
                maxLength: 25,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ResignationDate",
                table: "Employees",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "Salary",
                table: "Employees",
                maxLength: 64,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SpecialNotes",
                table: "Employees",
                maxLength: 225,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StatusWorker",
                table: "Employees",
                maxLength: 25,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TelephoneNumber",
                table: "Employees",
                maxLength: 25,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "TransferDate",
                table: "Employees",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Employees",
                maxLength: 25,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WorkLocation",
                table: "Employees",
                maxLength: 225,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 64, nullable: false),
                    Modified = table.Column<DateTimeOffset>(nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 64, nullable: true),
                    GroupName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 64, nullable: false),
                    Modified = table.Column<DateTimeOffset>(nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 64, nullable: true),
                    PositionName = table.Column<string>(maxLength: 50, nullable: false),
                    GroupId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Roles_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmployeeRoleId",
                table: "Employees",
                column: "EmployeeRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_GroupId",
                table: "Roles",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Roles_EmployeeRoleId",
                table: "Employees",
                column: "EmployeeRoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Roles_EmployeeRoleId",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropIndex(
                name: "IX_Employees_EmployeeRoleId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "AccountNumber",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "BankName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "BirthLocation",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "BranchName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "CashOutLeave",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "CurrentAddress",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DepartmentName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmergencyContact",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmployeeRoleId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Grading",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "GradingTitle",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "IdentityCardNumber",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "InitialName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "JoinDate",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "KTPAddress",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "LastEducation",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "LineManager",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "MaritalStatus",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "NPWP",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "NPWPAddress",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "NoSurat",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "OfficeAddress",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "OfficeEmail",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PassProbation",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PersonalEmail",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ReasonLeaving",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ReceiverName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Religion",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ResignationDate",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Salary",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "SpecialNotes",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "StatusWorker",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "TelephoneNumber",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "TransferDate",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "WorkLocation",
                table: "Employees");
        }
    }
}
