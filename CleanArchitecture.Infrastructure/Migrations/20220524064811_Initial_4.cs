using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchitecture.Infrastructure.Migrations
{
    public partial class Initial_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "department",
                table: "Departments",
                newName: "Department");

            migrationBuilder.AlterColumn<string>(
                name: "Department",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Department",
                value: "HR");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "Department",
                value: "SE");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "Department",
                value: "IT");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "Department",
                value: "Accounts");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "Department",
                value: "Staff");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Department",
                table: "Departments",
                newName: "department");

            migrationBuilder.AlterColumn<int>(
                name: "department",
                table: "Departments",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "department",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "department",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "department",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "department",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "department",
                value: 4);
        }
    }
}
