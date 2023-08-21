using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class usageHistoryDateUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TotalTime",
                table: "UsageHistories",
                newName: "TotalUsageTime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "UsageHistories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "UsageHistories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TotalUsageTime",
                table: "UsageHistories",
                newName: "TotalTime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "UsageHistories",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "UsageHistories",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 18, 28, 27, 607, DateTimeKind.Utc).AddTicks(8244));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 18, 28, 27, 607, DateTimeKind.Utc).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 18, 28, 27, 607, DateTimeKind.Utc).AddTicks(8255));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 18, 28, 27, 607, DateTimeKind.Utc).AddTicks(8257));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 18, 28, 27, 607, DateTimeKind.Utc).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 18, 28, 27, 607, DateTimeKind.Utc).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 18, 28, 27, 607, DateTimeKind.Utc).AddTicks(8264));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 18, 28, 27, 607, DateTimeKind.Utc).AddTicks(8266));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 18, 28, 27, 607, DateTimeKind.Utc).AddTicks(8268));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 18, 28, 27, 607, DateTimeKind.Utc).AddTicks(8269));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 18, 28, 27, 607, DateTimeKind.Utc).AddTicks(8271));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 18, 28, 27, 608, DateTimeKind.Utc).AddTicks(468));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 18, 28, 27, 608, DateTimeKind.Utc).AddTicks(479));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 18, 28, 27, 608, DateTimeKind.Utc).AddTicks(538));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 18, 28, 27, 608, DateTimeKind.Utc).AddTicks(542));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 18, 28, 27, 608, DateTimeKind.Utc).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 18, 28, 27, 608, DateTimeKind.Utc).AddTicks(556));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 18, 28, 27, 608, DateTimeKind.Utc).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 18, 28, 27, 608, DateTimeKind.Utc).AddTicks(564));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 18, 28, 27, 608, DateTimeKind.Utc).AddTicks(568));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 18, 28, 27, 608, DateTimeKind.Utc).AddTicks(572));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 18, 28, 27, 608, DateTimeKind.Utc).AddTicks(577));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 18, 28, 27, 608, DateTimeKind.Utc).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 18, 28, 27, 608, DateTimeKind.Utc).AddTicks(584));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 18, 28, 27, 608, DateTimeKind.Utc).AddTicks(590));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 18, 28, 27, 608, DateTimeKind.Utc).AddTicks(594));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 18, 28, 27, 608, DateTimeKind.Utc).AddTicks(598));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 18, 28, 27, 608, DateTimeKind.Utc).AddTicks(602));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 18, 28, 27, 608, DateTimeKind.Utc).AddTicks(606));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 18, 28, 27, 608, DateTimeKind.Utc).AddTicks(611));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 18, 28, 27, 608, DateTimeKind.Utc).AddTicks(615));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 18, 28, 27, 608, DateTimeKind.Utc).AddTicks(619));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 18, 28, 27, 608, DateTimeKind.Utc).AddTicks(623));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 18, 28, 27, 608, DateTimeKind.Utc).AddTicks(629));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 18, 28, 27, 608, DateTimeKind.Utc).AddTicks(635));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 18, 28, 27, 608, DateTimeKind.Utc).AddTicks(639));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 18, 28, 27, 608, DateTimeKind.Utc).AddTicks(643));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 18, 28, 27, 608, DateTimeKind.Utc).AddTicks(697));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 18, 28, 27, 608, DateTimeKind.Utc).AddTicks(702));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 18, 28, 27, 608, DateTimeKind.Utc).AddTicks(706));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 18, 28, 27, 608, DateTimeKind.Utc).AddTicks(711));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 18, 28, 27, 608, DateTimeKind.Utc).AddTicks(715));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 18, 28, 27, 608, DateTimeKind.Utc).AddTicks(720));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 18, 28, 27, 608, DateTimeKind.Utc).AddTicks(724));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 18, 28, 27, 608, DateTimeKind.Utc).AddTicks(728));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 18, 28, 27, 608, DateTimeKind.Utc).AddTicks(732));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 18, 28, 27, 608, DateTimeKind.Utc).AddTicks(736));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 18, 28, 27, 608, DateTimeKind.Utc).AddTicks(741));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 18, 28, 27, 608, DateTimeKind.Utc).AddTicks(744));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 18, 28, 27, 608, DateTimeKind.Utc).AddTicks(748));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 18, 28, 27, 608, DateTimeKind.Utc).AddTicks(752));
        }
    }
}
