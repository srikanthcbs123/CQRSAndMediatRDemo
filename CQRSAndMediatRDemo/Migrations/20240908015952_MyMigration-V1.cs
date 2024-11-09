using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CQRSAndMediatRDemo.Migrations
{
    public partial class MyMigrationV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "employeeDetails",
                columns: table => new
                {
                    employeeid = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    employeename = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    employeesalary = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employeeDetails", x => x.employeeid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employeeDetails");
        }
    }
}
