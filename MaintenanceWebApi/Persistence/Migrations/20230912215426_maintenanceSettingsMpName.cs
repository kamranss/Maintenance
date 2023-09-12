using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class maintenanceSettingsMpName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MpName",
                table: "MaintenanceSettings",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7300));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7307));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7309));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7310));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7311));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7312));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7313));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7315));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7316));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7317));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7318));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7666));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7668));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7670));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7671));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7672));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7673));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7674));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7679));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7693));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7694));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7695));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7696));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7697));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7698));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7699));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7701));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7702));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7703));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7704));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7705));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7706));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7707));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7708));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7711));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7715));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7716));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7720));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7728));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7729));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7731));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7732));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8792));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8811));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8853));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8857));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8871));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8874));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8876));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8879));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8882));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8885));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8888));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8892));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8904));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8906));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8909));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8912));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8914));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8917));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8944));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8951));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8954));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8963));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8966));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8968));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8972));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8977));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8983));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8989));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8991));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8995));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8997));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(9028));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(9031));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(9034));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(9037));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(9039));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(9042));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(9045));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(9048));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(9054));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(9059));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(9063));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(9071));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(9074));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(9077));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(9082));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(9085));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(9117));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(9121));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(9124));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(9127));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(9136));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(9139));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(9142));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(9145));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(9147));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(9150));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(9153));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(9159));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "MaintenancePlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "MaintenancePlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8612));

            migrationBuilder.UpdateData(
                table: "MaintenancePlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "MaintenancePlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "MaintenancePlan",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8616));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7844));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7845));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7846));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7847));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7848));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7849));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7877));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7879));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7880));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7881));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7882));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7883));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7888));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7889));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7890));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7892));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7893));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7894));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7895));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7896));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7897));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7898));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7900));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7901));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7902));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7903));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8005));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8007));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8008));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8009));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8010));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8011));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8012));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8013));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8014));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8015));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8016));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8017));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8018));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8020));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8021));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8022));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8023));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8024));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8025));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8026));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8028));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8028));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8030));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8031));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8071));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8073));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8074));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8075));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8076));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8077));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8081));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8083));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8085));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8086));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8087));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8088));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8089));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8092));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8093));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8094));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8095));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8096));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8097));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8098));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8101));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8102));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8102));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8103));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8104));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8105));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8106));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8107));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8108));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8109));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8111));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8112));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8113));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8114));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8115));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8118));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8119));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8122));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8123));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8124));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8125));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8126));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8127));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8128));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8129));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8131));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8132));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8133));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8134));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8135));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8138));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8139));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8141));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8142));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8143));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8144));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8145));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8146));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8147));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8151));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8178));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8181));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8182));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8184));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8184));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8188));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8192));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8194));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8195));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8198));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8199));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8201));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8202));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8204));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8205));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8207));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8209));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8211));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8213));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8214));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8216));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8218));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8221));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8222));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8223));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8225));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8226));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8227));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8231));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8233));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8234));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8236));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8237));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8238));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8241));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8242));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8243));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8244));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8247));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8248));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8251));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8256));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8257));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8285));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8286));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8287));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8288));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8289));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8291));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8292));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8293));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7529));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7532));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7533));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7535));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7536));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7537));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7538));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7539));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7541));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(7542));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8484));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8485));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8486));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8487));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8488));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8489));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8698));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8701));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 21, 54, 25, 200, DateTimeKind.Utc).AddTicks(8702));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MpName",
                table: "MaintenanceSettings",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2068));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2074));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2075));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2076));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2080));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2081));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2082));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2083));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2085));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2087));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2598));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2601));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2602));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2603));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2604));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2605));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2606));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2607));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2608));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2609));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2610));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2611));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2612));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2613));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2614));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2615));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2616));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2617));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2618));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2619));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2619));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2621));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2622));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2623));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2631));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2632));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2633));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2634));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2635));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2636));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2637));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2638));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2639));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2640));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2641));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2642));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3629));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3632));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3635));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3638));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3641));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3643));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3646));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3650));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3653));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3656));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3659));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3667));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3672));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3676));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3679));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3684));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3688));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3697));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3702));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3705));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3708));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3711));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3717));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3723));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3733));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3736));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3742));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3745));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3747));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3750));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3753));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3756));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3758));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3761));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3763));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3768));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3773));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3777));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3779));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3783));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3792));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3795));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3804));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3807));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3809));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3812));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3815));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3819));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3821));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3824));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3827));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3843));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3846));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3856));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3859));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3862));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3865));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3871));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3877));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3882));

            migrationBuilder.UpdateData(
                table: "MaintenancePlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "MaintenancePlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3422));

            migrationBuilder.UpdateData(
                table: "MaintenancePlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3424));

            migrationBuilder.UpdateData(
                table: "MaintenancePlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3425));

            migrationBuilder.UpdateData(
                table: "MaintenancePlan",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3427));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2736));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2737));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2738));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2739));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2743));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2744));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2745));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2747));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2748));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2749));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2750));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2751));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2752));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2753));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2754));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2755));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2756));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2757));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2758));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2759));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2761));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2761));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2763));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2764));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2764));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2765));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2868));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2869));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2871));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2872));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2873));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2874));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2875));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2876));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2877));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2878));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2879));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2880));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2881));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2882));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2883));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2884));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2885));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2887));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2888));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2889));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2890));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2891));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2892));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2893));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2894));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2895));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2896));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2897));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2898));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2901));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2902));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2903));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2904));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2905));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2906));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2907));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2908));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2909));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2912));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2913));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2914));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2915));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2916));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2917));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2918));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2919));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2920));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2921));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2922));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2923));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2924));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2925));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2930));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2931));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2932));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2933));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2934));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2935));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2936));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2937));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2938));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2939));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2945));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2945));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2947));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2947));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2948));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2949));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2950));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2951));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2952));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2953));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2954));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2955));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2956));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2957));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2958));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2959));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2960));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2961));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2962));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2963));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2964));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2965));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2966));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2967));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2969));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2969));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2971));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2971));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2972));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2973));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2974));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2975));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2976));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2977));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2978));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2979));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2980));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2981));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2982));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2983));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2984));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2987));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2988));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2989));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2991));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2992));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2994));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2995));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2996));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2997));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2998));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2999));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3001));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3002));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3003));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3004));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3005));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3006));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3007));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3008));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3009));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3014));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3015));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3016));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3017));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3018));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3019));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3021));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3022));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3025));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3026));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3029));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3030));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3031));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3032));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3033));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3034));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3035));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3036));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3037));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3038));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3039));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3040));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3041));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3042));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3043));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3044));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3045));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3046));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3047));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3048));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3049));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3050));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3051));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3052));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3054));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3058));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3059));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3061));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3062));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3063));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3064));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3064));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3065));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3066));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3068));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3069));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3071));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3072));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2461));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2463));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2464));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2495));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2496));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2497));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2499));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2500));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2501));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2502));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2503));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(2504));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3253));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3254));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3256));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3257));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3258));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3259));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3260));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3522));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3524));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3525));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 19, 24, 14, 815, DateTimeKind.Utc).AddTicks(3526));
        }
    }
}
