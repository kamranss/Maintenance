using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class usageHistoryUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "TotalUsageValue",
                table: "UsageHistories",
                type: "numeric",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "StartUsageHourValue",
                table: "UsageHistories",
                type: "numeric",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "EndUsageHourValue",
                table: "UsageHistories",
                type: "numeric",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TotalUsageValue",
                table: "UsageHistories",
                type: "integer",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "numeric",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StartUsageHourValue",
                table: "UsageHistories",
                type: "integer",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "numeric",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EndUsageHourValue",
                table: "UsageHistories",
                type: "integer",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "numeric",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 21, 40, 10, 952, DateTimeKind.Utc).AddTicks(7707));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 21, 40, 10, 952, DateTimeKind.Utc).AddTicks(7720));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 21, 40, 10, 952, DateTimeKind.Utc).AddTicks(7722));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 21, 40, 10, 952, DateTimeKind.Utc).AddTicks(7723));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 21, 40, 10, 952, DateTimeKind.Utc).AddTicks(7726));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 21, 40, 10, 952, DateTimeKind.Utc).AddTicks(7727));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 21, 40, 10, 952, DateTimeKind.Utc).AddTicks(7728));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 21, 40, 10, 952, DateTimeKind.Utc).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 21, 40, 10, 952, DateTimeKind.Utc).AddTicks(7731));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 21, 40, 10, 952, DateTimeKind.Utc).AddTicks(7732));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 21, 40, 10, 952, DateTimeKind.Utc).AddTicks(7733));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 21, 40, 10, 952, DateTimeKind.Utc).AddTicks(9215));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 21, 40, 10, 952, DateTimeKind.Utc).AddTicks(9223));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 21, 40, 10, 952, DateTimeKind.Utc).AddTicks(9226));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 21, 40, 10, 952, DateTimeKind.Utc).AddTicks(9228));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 21, 40, 10, 952, DateTimeKind.Utc).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 21, 40, 10, 952, DateTimeKind.Utc).AddTicks(9234));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 21, 40, 10, 952, DateTimeKind.Utc).AddTicks(9236));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 21, 40, 10, 952, DateTimeKind.Utc).AddTicks(9239));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 21, 40, 10, 952, DateTimeKind.Utc).AddTicks(9241));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 21, 40, 10, 952, DateTimeKind.Utc).AddTicks(9243));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 21, 40, 10, 952, DateTimeKind.Utc).AddTicks(9246));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 21, 40, 10, 952, DateTimeKind.Utc).AddTicks(9252));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 21, 40, 10, 952, DateTimeKind.Utc).AddTicks(9254));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 21, 40, 10, 952, DateTimeKind.Utc).AddTicks(9257));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 21, 40, 10, 952, DateTimeKind.Utc).AddTicks(9259));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 21, 40, 10, 952, DateTimeKind.Utc).AddTicks(9261));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 21, 40, 10, 952, DateTimeKind.Utc).AddTicks(9294));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 21, 40, 10, 952, DateTimeKind.Utc).AddTicks(9297));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 21, 40, 10, 952, DateTimeKind.Utc).AddTicks(9301));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 21, 40, 10, 952, DateTimeKind.Utc).AddTicks(9303));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 21, 40, 10, 952, DateTimeKind.Utc).AddTicks(9306));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 21, 40, 10, 952, DateTimeKind.Utc).AddTicks(9308));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 21, 40, 10, 952, DateTimeKind.Utc).AddTicks(9310));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 21, 40, 10, 952, DateTimeKind.Utc).AddTicks(9313));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 21, 40, 10, 952, DateTimeKind.Utc).AddTicks(9316));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 21, 40, 10, 952, DateTimeKind.Utc).AddTicks(9321));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 21, 40, 10, 952, DateTimeKind.Utc).AddTicks(9323));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 21, 40, 10, 952, DateTimeKind.Utc).AddTicks(9325));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 21, 40, 10, 952, DateTimeKind.Utc).AddTicks(9328));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 21, 40, 10, 952, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 21, 40, 10, 952, DateTimeKind.Utc).AddTicks(9333));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 21, 40, 10, 952, DateTimeKind.Utc).AddTicks(9336));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 21, 40, 10, 952, DateTimeKind.Utc).AddTicks(9338));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 21, 40, 10, 952, DateTimeKind.Utc).AddTicks(9341));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 21, 40, 10, 952, DateTimeKind.Utc).AddTicks(9343));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 21, 40, 10, 952, DateTimeKind.Utc).AddTicks(9346));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 21, 40, 10, 952, DateTimeKind.Utc).AddTicks(9349));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 21, 40, 10, 952, DateTimeKind.Utc).AddTicks(9351));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 21, 40, 10, 952, DateTimeKind.Utc).AddTicks(9353));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 19, 21, 40, 10, 952, DateTimeKind.Utc).AddTicks(9359));
        }
    }
}
