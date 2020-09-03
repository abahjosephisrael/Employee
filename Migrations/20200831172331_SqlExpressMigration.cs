using Microsoft.EntityFrameworkCore.Migrations;

namespace Employee.Migrations
{
    public partial class SqlExpressMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 2,
                column: "Email",
                value: "tosin@abahtech.ng");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 2,
                column: "Email",
                value: "joseph@abahtech.ng");
        }
    }
}
