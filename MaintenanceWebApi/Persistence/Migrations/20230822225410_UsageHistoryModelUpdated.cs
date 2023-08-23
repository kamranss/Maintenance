using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class UsageHistoryModelUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "UsageHistories",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PartId",
                table: "Services",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PartName",
                table: "Services",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsMpCompleted",
                table: "MaintenanceSettings",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(6984));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(6989));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(6991));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(6993));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(6996));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(6997));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(6998));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(6999));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7001));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7313));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7314));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7315));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7344));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7346));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7348));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7349));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7351));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7353));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7353));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7354));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7355));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7363));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7364));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7365));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7366));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7367));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7368));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7369));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7371));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7372));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7373));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7374));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7375));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7376));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7377));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7378));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7379));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(8305), 1 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(8311), 1 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(8313), 1 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(8316), 1 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(8318), 1 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(8321), 1 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(8323), 1 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(8327), 1 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(8329), 1 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(8331), 1 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(8381), 1 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(8385), 1 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(8387), 1 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(8390), 1 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(8392), 1 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(8394), 1 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(8397), 1 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(8399), 1 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(8402), 1 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(8404), 1 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(8406), 1 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(8434), 1 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(8436), 1 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(8439), 1 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(8442), 1 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(8444), 1 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(8447), 1 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(8449), 1 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(8454), 1 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(8457), 1 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(8460), 1 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(8486), 1 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(8491), 1 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(8495), 1 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(8497), 1 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(8499), 1 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(8501), 1 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(8504), 1 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(8506), 1 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(8508), 1 });

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7486));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7487));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7488));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7489));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7489));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7490));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7491));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7492));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7493));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7494));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7495));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7496));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7497));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7498));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7499));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7527));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7529));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7529));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7531));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7532));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7533));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7534));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7535));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7537));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7538));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7539));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7211));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7212));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7213));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7214));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7216));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7218));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7221));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 22, 54, 9, 564, DateTimeKind.Utc).AddTicks(7222));

            migrationBuilder.CreateIndex(
                name: "IX_Services_PartId",
                table: "Services",
                column: "PartId");

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Parts_PartId",
                table: "Services",
                column: "PartId",
                principalTable: "Parts",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_Parts_PartId",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Services_PartId",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "UsageHistories");

            migrationBuilder.DropColumn(
                name: "PartId",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "PartName",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "IsMpCompleted",
                table: "MaintenanceSettings");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 865, DateTimeKind.Utc).AddTicks(9792));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 865, DateTimeKind.Utc).AddTicks(9797));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 865, DateTimeKind.Utc).AddTicks(9798));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 865, DateTimeKind.Utc).AddTicks(9799));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 865, DateTimeKind.Utc).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 865, DateTimeKind.Utc).AddTicks(9801));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 865, DateTimeKind.Utc).AddTicks(9802));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 865, DateTimeKind.Utc).AddTicks(9803));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 865, DateTimeKind.Utc).AddTicks(9803));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 865, DateTimeKind.Utc).AddTicks(9804));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 865, DateTimeKind.Utc).AddTicks(9805));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(79));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(80));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(81));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(81));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(82));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(83));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(84));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(84));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(85));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(86));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(87));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(87));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(88));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(89));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(89));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(90));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(91));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(93));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(94));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(94));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(95));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(96));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(97));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(97));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(98));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(99));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(99));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(100));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(101));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(102));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(102));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(103));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(104));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(104));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(105));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(814), 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(819), 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(844), 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(846), 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(849), 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(851), 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(852), 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(854), 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(857), 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(859), 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(861), 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(863), 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(865), 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(867), 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(868), 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(870), 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(872), 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(874), 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(876), 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(881), 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(883), 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(886), 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(887), 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(910), 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(913), 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(915), 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(919), 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(922), 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(924), 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(925), 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(927), 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(929), 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(931), 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(933), 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(935), 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(936), 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(938), 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(940), 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(942), 0 });

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "Status" },
                values: new object[] { new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(943), 0 });

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(209));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(210));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(211));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(212));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(212));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(213));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(214));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(215));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(215));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(216));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(217));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(217));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(218));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(219));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(220));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(220));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(224));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(225));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(226));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(227));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(228));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(229));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(229));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(231));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(231));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(232));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(233));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 865, DateTimeKind.Utc).AddTicks(9962));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 865, DateTimeKind.Utc).AddTicks(9963));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 865, DateTimeKind.Utc).AddTicks(9964));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 865, DateTimeKind.Utc).AddTicks(9965));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(5));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(6));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(7));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(8));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(9));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(9));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(10));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 22, 12, 39, 8, 866, DateTimeKind.Utc).AddTicks(11));
        }
    }
}
