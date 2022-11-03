using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mvcfull_operation.Migrations
{
    public partial class AddMvcScafoldModelToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmpoyeeName",
                table: "EmployeeLogin");

            migrationBuilder.RenameColumn(
                name: "LoginId",
                table: "UserLogins",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "LoginId",
                table: "EmployeeLogin",
                newName: "Email");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Email",
                table: "UserLogins",
                newName: "LoginId");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "EmployeeLogin",
                newName: "LoginId");

            migrationBuilder.AddColumn<string>(
                name: "EmpoyeeName",
                table: "EmployeeLogin",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
