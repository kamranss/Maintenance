using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class equipment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastMaintenaceTime",
                table: "Equipments",
                newName: "LastMaintenaceDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastMaintenaceDate",
                table: "Equipments",
                newName: "LastMaintenaceTime");
        }
    }
}
