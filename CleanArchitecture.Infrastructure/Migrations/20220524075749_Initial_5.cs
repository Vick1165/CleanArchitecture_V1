using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchitecture.Infrastructure.Migrations
{
    public partial class Initial_5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "Department",
                value: "IT");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "Department",
                value: "Accounts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Department" },
                values: new object[,]
                {
                    { 4, "Accounts" },
                    { 5, "Staff" }
                });
        }
    }
}
