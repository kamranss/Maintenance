using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class usageHistoryOperationName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OperatorName",
                table: "UsageHistories",
                newName: "OperatorNameValue");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 15, 11, 2, DateTimeKind.Utc).AddTicks(3196));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 15, 11, 2, DateTimeKind.Utc).AddTicks(3203));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 15, 11, 2, DateTimeKind.Utc).AddTicks(3205));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 15, 11, 2, DateTimeKind.Utc).AddTicks(3207));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 15, 11, 2, DateTimeKind.Utc).AddTicks(3208));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 15, 11, 2, DateTimeKind.Utc).AddTicks(3209));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 15, 11, 2, DateTimeKind.Utc).AddTicks(3211));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 15, 11, 2, DateTimeKind.Utc).AddTicks(3212));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 15, 11, 2, DateTimeKind.Utc).AddTicks(3215));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 15, 11, 2, DateTimeKind.Utc).AddTicks(3216));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 15, 11, 2, DateTimeKind.Utc).AddTicks(3221));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 15, 11, 2, DateTimeKind.Utc).AddTicks(5054));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 15, 11, 2, DateTimeKind.Utc).AddTicks(5061));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 15, 11, 2, DateTimeKind.Utc).AddTicks(5067));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 15, 11, 2, DateTimeKind.Utc).AddTicks(5071));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 15, 11, 2, DateTimeKind.Utc).AddTicks(5075));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 15, 11, 2, DateTimeKind.Utc).AddTicks(5078));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 15, 11, 2, DateTimeKind.Utc).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 15, 11, 2, DateTimeKind.Utc).AddTicks(5084));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 15, 11, 2, DateTimeKind.Utc).AddTicks(5088));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 15, 11, 2, DateTimeKind.Utc).AddTicks(5091));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 15, 11, 2, DateTimeKind.Utc).AddTicks(5094));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 15, 11, 2, DateTimeKind.Utc).AddTicks(5101));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 15, 11, 2, DateTimeKind.Utc).AddTicks(5105));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 15, 11, 2, DateTimeKind.Utc).AddTicks(5109));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 15, 11, 2, DateTimeKind.Utc).AddTicks(5112));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 15, 11, 2, DateTimeKind.Utc).AddTicks(5144));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 15, 11, 2, DateTimeKind.Utc).AddTicks(5148));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 15, 11, 2, DateTimeKind.Utc).AddTicks(5151));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 15, 11, 2, DateTimeKind.Utc).AddTicks(5154));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 15, 11, 2, DateTimeKind.Utc).AddTicks(5158));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 15, 11, 2, DateTimeKind.Utc).AddTicks(5161));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 15, 11, 2, DateTimeKind.Utc).AddTicks(5165));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 15, 11, 2, DateTimeKind.Utc).AddTicks(5168));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 15, 11, 2, DateTimeKind.Utc).AddTicks(5171));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 15, 11, 2, DateTimeKind.Utc).AddTicks(5178));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 15, 11, 2, DateTimeKind.Utc).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 15, 11, 2, DateTimeKind.Utc).AddTicks(5183));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 15, 11, 2, DateTimeKind.Utc).AddTicks(5186));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 15, 11, 2, DateTimeKind.Utc).AddTicks(5189));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 15, 11, 2, DateTimeKind.Utc).AddTicks(5192));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 15, 11, 2, DateTimeKind.Utc).AddTicks(5195));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 15, 11, 2, DateTimeKind.Utc).AddTicks(5197));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 15, 11, 2, DateTimeKind.Utc).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 15, 11, 2, DateTimeKind.Utc).AddTicks(5204));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 15, 11, 2, DateTimeKind.Utc).AddTicks(5208));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 15, 11, 2, DateTimeKind.Utc).AddTicks(5211));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 15, 11, 2, DateTimeKind.Utc).AddTicks(5214));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 15, 11, 2, DateTimeKind.Utc).AddTicks(5216));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 15, 11, 2, DateTimeKind.Utc).AddTicks(5219));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 15, 11, 2, DateTimeKind.Utc).AddTicks(5225));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OperatorNameValue",
                table: "UsageHistories",
                newName: "OperatorName");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 5, 15, 875, DateTimeKind.Utc).AddTicks(366));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 5, 15, 875, DateTimeKind.Utc).AddTicks(370));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 5, 15, 875, DateTimeKind.Utc).AddTicks(371));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 5, 15, 875, DateTimeKind.Utc).AddTicks(373));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 5, 15, 875, DateTimeKind.Utc).AddTicks(375));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 5, 15, 875, DateTimeKind.Utc).AddTicks(377));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 5, 15, 875, DateTimeKind.Utc).AddTicks(378));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 5, 15, 875, DateTimeKind.Utc).AddTicks(381));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 5, 15, 875, DateTimeKind.Utc).AddTicks(382));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 5, 15, 875, DateTimeKind.Utc).AddTicks(383));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 5, 15, 875, DateTimeKind.Utc).AddTicks(384));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 5, 15, 875, DateTimeKind.Utc).AddTicks(1638));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 5, 15, 875, DateTimeKind.Utc).AddTicks(1644));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 5, 15, 875, DateTimeKind.Utc).AddTicks(1646));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 5, 15, 875, DateTimeKind.Utc).AddTicks(1648));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 5, 15, 875, DateTimeKind.Utc).AddTicks(1652));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 5, 15, 875, DateTimeKind.Utc).AddTicks(1654));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 5, 15, 875, DateTimeKind.Utc).AddTicks(1656));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 5, 15, 875, DateTimeKind.Utc).AddTicks(1659));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 5, 15, 875, DateTimeKind.Utc).AddTicks(1661));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 5, 15, 875, DateTimeKind.Utc).AddTicks(1664));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 5, 15, 875, DateTimeKind.Utc).AddTicks(1666));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 5, 15, 875, DateTimeKind.Utc).AddTicks(1671));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 5, 15, 875, DateTimeKind.Utc).AddTicks(1698));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 5, 15, 875, DateTimeKind.Utc).AddTicks(1700));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 5, 15, 875, DateTimeKind.Utc).AddTicks(1703));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 5, 15, 875, DateTimeKind.Utc).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 5, 15, 875, DateTimeKind.Utc).AddTicks(1707));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 5, 15, 875, DateTimeKind.Utc).AddTicks(1714));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 5, 15, 875, DateTimeKind.Utc).AddTicks(1716));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 5, 15, 875, DateTimeKind.Utc).AddTicks(1718));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 5, 15, 875, DateTimeKind.Utc).AddTicks(1720));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 5, 15, 875, DateTimeKind.Utc).AddTicks(1722));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 5, 15, 875, DateTimeKind.Utc).AddTicks(1725));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 5, 15, 875, DateTimeKind.Utc).AddTicks(1728));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 5, 15, 875, DateTimeKind.Utc).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 5, 15, 875, DateTimeKind.Utc).AddTicks(1732));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 5, 15, 875, DateTimeKind.Utc).AddTicks(1735));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 5, 15, 875, DateTimeKind.Utc).AddTicks(1737));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 5, 15, 875, DateTimeKind.Utc).AddTicks(1739));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 5, 15, 875, DateTimeKind.Utc).AddTicks(1741));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 5, 15, 875, DateTimeKind.Utc).AddTicks(1743));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 5, 15, 875, DateTimeKind.Utc).AddTicks(1746));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 5, 15, 875, DateTimeKind.Utc).AddTicks(1751));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 5, 15, 875, DateTimeKind.Utc).AddTicks(1753));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 5, 15, 875, DateTimeKind.Utc).AddTicks(1757));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 5, 15, 875, DateTimeKind.Utc).AddTicks(1759));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 5, 15, 875, DateTimeKind.Utc).AddTicks(1761));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 5, 15, 875, DateTimeKind.Utc).AddTicks(1788));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 5, 15, 875, DateTimeKind.Utc).AddTicks(1791));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 5, 15, 875, DateTimeKind.Utc).AddTicks(1793));
        }
    }
}
