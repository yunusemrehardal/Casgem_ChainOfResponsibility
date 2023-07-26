using Microsoft.EntityFrameworkCore.Migrations;

namespace Casgem_ChainOfResponsibility.Migrations
{
    public partial class _mig_first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerProcesses",
                columns: table => new
                {
                    CustomerProcessID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(nullable: false),
                    EmployeeName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerProcesses", x => x.CustomerProcessID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerProcesses");
        }
    }
}
