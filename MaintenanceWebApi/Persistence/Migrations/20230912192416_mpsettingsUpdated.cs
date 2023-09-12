using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class mpsettingsUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MpName",
                table: "MaintenanceSettings",
                type: "text",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MpName",
                table: "MaintenanceSettings");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 883, DateTimeKind.Utc).AddTicks(9561));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 883, DateTimeKind.Utc).AddTicks(9572));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 883, DateTimeKind.Utc).AddTicks(9576));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 883, DateTimeKind.Utc).AddTicks(9656));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 883, DateTimeKind.Utc).AddTicks(9659));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 883, DateTimeKind.Utc).AddTicks(9661));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 883, DateTimeKind.Utc).AddTicks(9664));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 883, DateTimeKind.Utc).AddTicks(9668));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 883, DateTimeKind.Utc).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 883, DateTimeKind.Utc).AddTicks(9673));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 883, DateTimeKind.Utc).AddTicks(9675));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(659));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(662));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(664));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(666));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(669));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(671));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(673));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(675));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(682));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(684));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(747));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(749));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(752));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(754));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(757));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(759));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(761));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(767));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(773));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(775));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(777));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(779));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(781));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(783));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(786));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(788));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(790));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(792));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(794));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(796));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(798));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3383));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3406));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3412));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3421));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3427));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3433));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3538));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3545));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3556));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3562));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3569));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3588));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3599));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3607));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3613));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3619));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3625));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3630));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3637));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3645));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3652));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3659));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3726));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3732));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3738));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3745));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3750));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3759));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3772));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3778));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3784));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3797));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3806));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3815));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3821));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3828));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3834));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3846));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3852));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3857));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3921));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3933));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3945));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3967));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3973));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3978));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3984));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3997));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(4003));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(4009));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(4015));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(4022));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(4027));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(4035));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(4041));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(4121));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(4133));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(4139));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(4149));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(4154));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(4172));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(4177));

            migrationBuilder.UpdateData(
                table: "MaintenancePlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3001));

            migrationBuilder.UpdateData(
                table: "MaintenancePlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3006));

            migrationBuilder.UpdateData(
                table: "MaintenancePlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3009));

            migrationBuilder.UpdateData(
                table: "MaintenancePlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3012));

            migrationBuilder.UpdateData(
                table: "MaintenancePlan",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3016));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1034));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1037));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1039));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1043));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1045));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1047));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1052));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1054));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1056));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1058));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1060));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1062));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1066));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1071));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1073));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1075));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1077));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1079));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1081));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1083));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1086));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1149));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1151));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1154));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1645));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1648));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1651));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1654));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1656));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1658));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1660));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1662));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1664));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1667));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1669));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1671));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1673));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1675));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1677));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1679));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1682));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1684));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1686));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1688));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1692));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1694));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1696));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1698));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1700));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1702));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1704));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1707));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1709));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1711));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1713));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1715));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1717));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1781));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1784));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1786));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1788));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1790));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1792));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1794));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1797));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1799));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1801));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1803));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1805));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1807));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1810));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1812));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1814));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1816));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1818));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1821));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1823));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1825));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1827));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1829));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1831));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1834));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1836));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1838));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1840));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1842));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1844));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1846));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1849));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1851));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1853));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1855));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1857));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1862));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1864));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1866));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1868));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1873));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1875));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1877));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1879));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1881));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1883));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1885));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1887));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1889));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1892));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1896));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1899));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1901));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1903));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1905));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1907));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1909));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1912));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1914));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1916));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1918));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1920));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1922));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1924));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1926));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1929));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1931));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1933));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1935));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1937));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1997));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(1999));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2001));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2003));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2005));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2007));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2009));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2013));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2015));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2017));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2019));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2021));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2023));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2025));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2027));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2029));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2031));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2034));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2036));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2038));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2040));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2045));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2047));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2049));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2051));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2053));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2055));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2057));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2059));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2061));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2064));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2066));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2068));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2072));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2074));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2076));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2079));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2081));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2083));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2085));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2087));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2089));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2092));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2094));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2096));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2098));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2100));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2102));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2105));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2107));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2109));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2111));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2113));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2116));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2118));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2122));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2124));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2126));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2129));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2131));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2133));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2135));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2137));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2139));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2142));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2144));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2146));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2148));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2150));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(105));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(108));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(111));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(113));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(118));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(120));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(123));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(125));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(127));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(130));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(132));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2606));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2610));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2613));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2615));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2617));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2619));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2622));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2624));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3187));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3191));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3193));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(3196));
        }
    }
}
