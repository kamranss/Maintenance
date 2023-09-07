using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class userOtpTypechanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "OTP",
                table: "Users",
                type: "text",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(5910));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(5919));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(5920));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(5922));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(5923));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(5924));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(5926));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(5927));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(5929));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(5930));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(5932));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(6835));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(6836));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(6837));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(6838));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(6839));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(6839));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(6841));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(6846));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(6846));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(6847));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(6848));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(6849));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(6851));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(6851));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(6853));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(6857));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(6859));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(6863));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(6864));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(6865));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(6866));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(6869));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(6871));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(6873));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(6874));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7932));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7939));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7942));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7949));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7951));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7954));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7956));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7958));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7961));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7963));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7965));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7968));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7970));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7972));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7975));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7977));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7980));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7982));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7984));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7987));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7993));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7995));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7998));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8000));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8002));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8004));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8011));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8014));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8016));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8022));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8027));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8029));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8031));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8034));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8044));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8046));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8048));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8054));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8059));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8061));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8063));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8066));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8068));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8073));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8075));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8077));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8083));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8085));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8088));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8092));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8094));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8102));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8105));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8112));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8115));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8118));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8122));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8125));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8131));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8136));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8139));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8141));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8143));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8145));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8153));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8160));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(8162));

            migrationBuilder.UpdateData(
                table: "MaintenancePlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "MaintenancePlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7757));

            migrationBuilder.UpdateData(
                table: "MaintenancePlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7759));

            migrationBuilder.UpdateData(
                table: "MaintenancePlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "MaintenancePlan",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7761));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(6993));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(6994));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7001));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7003));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7005));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7007));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7008));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7009));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7011));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7011));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7012));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7013));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7014));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7015));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7015));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7016));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7017));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7018));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7019));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7019));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7233));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7236));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7237));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7239));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7241));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7242));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7248));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7249));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7250));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7251));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7252));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7255));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7256));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7257));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7258));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7259));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7260));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7261));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7262));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7263));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7265));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7266));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7268));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7269));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7275));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7276));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7279));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7281));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7282));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7283));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7287));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7288));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7291));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7292));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7293));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7294));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7297));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7298));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7299));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7300));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7301));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7302));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7304));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7305));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7306));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7307));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7309));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7309));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7314));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7319));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7322));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7322));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7323));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7324));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7325));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7326));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7326));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7327));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7328));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7329));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7331));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7332));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7333));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7335));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7335));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7337));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7339));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7346));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7346));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7348));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7349));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7351));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7352));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7353));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7354));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7354));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7355));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7356));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7358));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7358));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7363));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7364));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7365));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7366));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7367));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7367));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7368));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7369));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7371));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7372));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7372));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7373));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7374));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7375));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7376));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7376));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7377));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7378));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7379));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7380));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7380));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7381));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7382));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7383));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7384));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7384));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7385));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7386));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7387));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7388));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7388));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7389));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7390));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7391));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7392));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7392));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7393));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7394));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7395));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7396));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7396));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7397));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7398));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7399));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7401));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7408));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7408));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7409));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7414));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7415));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7416));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7416));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7422));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7423));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7423));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7427));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7428));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7429));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7431));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7432));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7433));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7434));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7435));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7438));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7439));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7441));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7442));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7443));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7443));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(6320));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(6322));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(6323));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(6325));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(6328));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(6331));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(6336));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(6338));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(6339));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(6341));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(6342));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(6343));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7614));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7615));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7616));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7617));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7618));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7618));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7619));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7620));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7838));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7839));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7840));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 11, 12, 11, 623, DateTimeKind.Utc).AddTicks(7841));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "OTP",
                table: "Users",
                type: "integer",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(5739));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(5745));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(5746));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(5747));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(5748));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(5749));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(5751));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(5752));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(5753));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(5754));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6376));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6378));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6379));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6379));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6381));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6382));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6383));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6384));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6384));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6385));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6386));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6387));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6388));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6388));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6389));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6393));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6393));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6395));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6396));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6397));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6398));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6399));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6399));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6401));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6402));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6404));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6407));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6407));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6408));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6409));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6410));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6411));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6412));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7461));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7468));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7471));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7473));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7478));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7480));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7483));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7485));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7487));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7490));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7492));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7494));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7497));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7502));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7504));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7520));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7522));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7525));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7535));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7537));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7542));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7547));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7552));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7554));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7556));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7562));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7564));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7567));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7569));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7572));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7580));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7582));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7585));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7587));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7589));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7592));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7595));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7597));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7599));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7602));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7604));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7606));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7609));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7614));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7616));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7619));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7622));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7624));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7626));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7629));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7635));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7643));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7645));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7647));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7650));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7652));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7654));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7660));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7662));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7664));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7666));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7672));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7677));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7679));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7682));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7684));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "MaintenancePlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7239));

            migrationBuilder.UpdateData(
                table: "MaintenancePlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7241));

            migrationBuilder.UpdateData(
                table: "MaintenancePlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7242));

            migrationBuilder.UpdateData(
                table: "MaintenancePlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7243));

            migrationBuilder.UpdateData(
                table: "MaintenancePlan",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7244));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6513));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6514));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6515));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6518));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6518));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6519));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6520));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6521));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6522));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6527));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6528));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6528));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6529));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6530));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6531));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6532));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6533));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6534));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6535));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6535));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6536));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6537));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6538));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6539));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6541));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6697));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6698));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6699));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6701));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6704));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6707));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6708));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6709));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6711));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6712));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6713));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6718));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6719));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6719));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6722));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6725));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6731));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6732));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6733));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6734));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6735));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6736));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6737));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6738));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6738));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6739));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6742));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6743));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6743));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6744));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6748));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6751));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6752));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6754));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6755));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6755));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6756));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6757));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6758));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6759));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6761));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6762));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6763));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6763));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6765));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6767));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6768));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6768));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6769));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6771));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6772));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6773));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6774));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6774));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6775));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6776));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6777));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6778));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6779));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6779));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6781));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6786));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6787));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6788));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6788));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6789));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6791));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6793));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6804));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6805));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6806));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6807));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6808));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6809));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6811));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6811));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6812));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6813));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6814));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6815));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6815));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6816));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6817));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6818));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6824));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6825));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6827));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6832));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6833));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6833));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6834));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6835));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6836));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6837));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6837));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6838));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6839));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6841));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6842));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6842));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6843));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6844));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6845));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6846));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6847));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6848));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6849));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6851));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6853));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6857));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6863));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6864));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6865));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6866));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6866));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6868));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6869));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6871));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6873));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6874));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6875));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6875));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6876));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6877));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6878));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6882));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6883));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6884));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6892));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6079));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6081));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6083));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6084));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6086));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6086));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6087));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(6089));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7115));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7116));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7118));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7119));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7119));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7324));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7326));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7327));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 10, 11, 4, 569, DateTimeKind.Utc).AddTicks(7328));
        }
    }
}
