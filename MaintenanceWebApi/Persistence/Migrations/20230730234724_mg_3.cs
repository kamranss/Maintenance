using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class mg_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatedByid",
                table: "EquipmentParts",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "EquipmentParts",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedById",
                table: "EquipmentParts",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "EquipmentParts",
                type: "timestamp with time zone",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedByid",
                table: "EquipmentParts");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "EquipmentParts");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "EquipmentParts");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "EquipmentParts");
        }
    }
}
