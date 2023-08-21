using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class usageHistoryOperatorName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OperatorName",
                table: "UsageHistories",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 19, 24, 782, DateTimeKind.Utc).AddTicks(6806));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 19, 24, 782, DateTimeKind.Utc).AddTicks(6814));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 19, 24, 782, DateTimeKind.Utc).AddTicks(6816));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 19, 24, 782, DateTimeKind.Utc).AddTicks(6817));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 19, 24, 782, DateTimeKind.Utc).AddTicks(6818));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 19, 24, 782, DateTimeKind.Utc).AddTicks(6819));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 19, 24, 782, DateTimeKind.Utc).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 19, 24, 782, DateTimeKind.Utc).AddTicks(6821));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 19, 24, 782, DateTimeKind.Utc).AddTicks(6822));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 19, 24, 782, DateTimeKind.Utc).AddTicks(6823));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 19, 24, 782, DateTimeKind.Utc).AddTicks(6824));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 19, 24, 782, DateTimeKind.Utc).AddTicks(8082));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 19, 24, 782, DateTimeKind.Utc).AddTicks(8088));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 19, 24, 782, DateTimeKind.Utc).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 19, 24, 782, DateTimeKind.Utc).AddTicks(8093));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 19, 24, 782, DateTimeKind.Utc).AddTicks(8099));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 19, 24, 782, DateTimeKind.Utc).AddTicks(8101));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 19, 24, 782, DateTimeKind.Utc).AddTicks(8136));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 19, 24, 782, DateTimeKind.Utc).AddTicks(8139));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 19, 24, 782, DateTimeKind.Utc).AddTicks(8141));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 19, 24, 782, DateTimeKind.Utc).AddTicks(8144));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 19, 24, 782, DateTimeKind.Utc).AddTicks(8146));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 19, 24, 782, DateTimeKind.Utc).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 19, 24, 782, DateTimeKind.Utc).AddTicks(8151));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 19, 24, 782, DateTimeKind.Utc).AddTicks(8153));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 19, 24, 782, DateTimeKind.Utc).AddTicks(8156));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 19, 24, 782, DateTimeKind.Utc).AddTicks(8158));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 19, 24, 782, DateTimeKind.Utc).AddTicks(8160));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 19, 24, 782, DateTimeKind.Utc).AddTicks(8163));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 19, 24, 782, DateTimeKind.Utc).AddTicks(8165));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 19, 24, 782, DateTimeKind.Utc).AddTicks(8167));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 19, 24, 782, DateTimeKind.Utc).AddTicks(8169));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 19, 24, 782, DateTimeKind.Utc).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 19, 24, 782, DateTimeKind.Utc).AddTicks(8177));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 19, 24, 782, DateTimeKind.Utc).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 19, 24, 782, DateTimeKind.Utc).AddTicks(8182));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 19, 24, 782, DateTimeKind.Utc).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 19, 24, 782, DateTimeKind.Utc).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 19, 24, 782, DateTimeKind.Utc).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 19, 24, 782, DateTimeKind.Utc).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 19, 24, 782, DateTimeKind.Utc).AddTicks(8194));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 19, 24, 782, DateTimeKind.Utc).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 19, 24, 782, DateTimeKind.Utc).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 19, 24, 782, DateTimeKind.Utc).AddTicks(8231));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 19, 24, 782, DateTimeKind.Utc).AddTicks(8234));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 19, 24, 782, DateTimeKind.Utc).AddTicks(8237));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 19, 24, 782, DateTimeKind.Utc).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 19, 24, 782, DateTimeKind.Utc).AddTicks(8241));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 19, 24, 782, DateTimeKind.Utc).AddTicks(8243));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 19, 24, 782, DateTimeKind.Utc).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 20, 19, 19, 24, 782, DateTimeKind.Utc).AddTicks(8248));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OperatorName",
                table: "UsageHistories");

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
    }
}
