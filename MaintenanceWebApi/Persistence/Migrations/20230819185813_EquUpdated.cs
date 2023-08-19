using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class EquUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OperationSites_Equipments_EquipmentId",
                table: "OperationSites");

            migrationBuilder.DropIndex(
                name: "IX_OperationSites_EquipmentId",
                table: "OperationSites");

            migrationBuilder.DropColumn(
                name: "EquipmentId",
                table: "OperationSites");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "OperationSites",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 18, 58, 11, 600, DateTimeKind.Utc).AddTicks(1394));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 18, 58, 11, 600, DateTimeKind.Utc).AddTicks(1412));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 18, 58, 11, 600, DateTimeKind.Utc).AddTicks(1417));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 18, 58, 11, 600, DateTimeKind.Utc).AddTicks(1421));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 18, 58, 11, 600, DateTimeKind.Utc).AddTicks(1424));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 18, 58, 11, 600, DateTimeKind.Utc).AddTicks(1427));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 18, 58, 11, 600, DateTimeKind.Utc).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 18, 58, 11, 600, DateTimeKind.Utc).AddTicks(1434));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 18, 58, 11, 600, DateTimeKind.Utc).AddTicks(1436));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 18, 58, 11, 600, DateTimeKind.Utc).AddTicks(1439));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 18, 58, 11, 600, DateTimeKind.Utc).AddTicks(1446));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 18, 58, 11, 600, DateTimeKind.Utc).AddTicks(5856));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 18, 58, 11, 600, DateTimeKind.Utc).AddTicks(5879));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 18, 58, 11, 600, DateTimeKind.Utc).AddTicks(5886));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 18, 58, 11, 600, DateTimeKind.Utc).AddTicks(5893));

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_OperationSiteid",
                table: "Equipments",
                column: "OperationSiteid");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipments_OperationSites_OperationSiteid",
                table: "Equipments",
                column: "OperationSiteid",
                principalTable: "OperationSites",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipments_OperationSites_OperationSiteid",
                table: "Equipments");

            migrationBuilder.DropIndex(
                name: "IX_Equipments_OperationSiteid",
                table: "Equipments");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "OperationSites",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EquipmentId",
                table: "OperationSites",
                type: "integer",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 15, 33, 30, 639, DateTimeKind.Utc).AddTicks(445));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 15, 33, 30, 639, DateTimeKind.Utc).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 15, 33, 30, 639, DateTimeKind.Utc).AddTicks(451));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 15, 33, 30, 639, DateTimeKind.Utc).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 15, 33, 30, 639, DateTimeKind.Utc).AddTicks(453));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 15, 33, 30, 639, DateTimeKind.Utc).AddTicks(454));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 15, 33, 30, 639, DateTimeKind.Utc).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 15, 33, 30, 639, DateTimeKind.Utc).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 15, 33, 30, 639, DateTimeKind.Utc).AddTicks(456));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 15, 33, 30, 639, DateTimeKind.Utc).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 15, 33, 30, 639, DateTimeKind.Utc).AddTicks(491));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 15, 33, 30, 639, DateTimeKind.Utc).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 15, 33, 30, 639, DateTimeKind.Utc).AddTicks(1866));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 15, 33, 30, 639, DateTimeKind.Utc).AddTicks(1868));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 17, 15, 33, 30, 639, DateTimeKind.Utc).AddTicks(1879));

            migrationBuilder.CreateIndex(
                name: "IX_OperationSites_EquipmentId",
                table: "OperationSites",
                column: "EquipmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_OperationSites_Equipments_EquipmentId",
                table: "OperationSites",
                column: "EquipmentId",
                principalTable: "Equipments",
                principalColumn: "Id");
        }
    }
}
