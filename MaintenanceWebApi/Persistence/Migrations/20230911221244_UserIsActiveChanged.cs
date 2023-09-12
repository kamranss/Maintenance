using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class UserIsActiveChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Users",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldNullable: true);

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
                columns: new[] { "Code", "CreatedDate" },
                values: new object[] { "OFL", new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2606) });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "CreatedDate" },
                values: new object[] { "AFL", new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2610) });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "CreatedDate" },
                values: new object[] { "ENO", new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2613) });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "CreatedDate" },
                values: new object[] { "TRN", new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2615) });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Code", "CreatedDate" },
                values: new object[] { "GRB", new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2617) });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Code", "CreatedDate" },
                values: new object[] { "WHL", new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2619) });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Code", "CreatedDate" },
                values: new object[] { "ANF", new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2622) });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Code", "CreatedDate" },
                values: new object[] { "BRK", new DateTime(2023, 9, 11, 22, 12, 42, 884, DateTimeKind.Utc).AddTicks(2624) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Users",
                type: "boolean",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6231));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6236));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6237));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6238));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6239));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6241));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6242));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6242));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6243));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6247));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6553));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6554));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6555));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6558));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6559));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6559));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6561));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6562));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6562));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6563));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6564));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6564));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6565));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6566));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6567));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6567));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6568));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6569));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6571));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6572));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6573));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6573));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6574));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6575));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6576));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6576));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6577));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6578));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6579));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6579));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6582));

            migrationBuilder.UpdateData(
                table: "EquipmentType",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6582));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7507));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7551));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7554));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7557));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7561));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7563));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7565));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7567));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7569));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7575));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7578));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7580));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7582));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7584));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7586));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7588));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7590));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7593));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7595));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7597));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7639));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7641));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7643));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7645));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7647));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7650));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7652));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7654));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7660));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7662));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7664));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7666));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7671));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7673));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7677));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7679));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7681));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7684));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7738));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7745));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7747));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7749));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7751));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7754));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7762));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7764));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7766));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7768));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7772));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7779));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7816));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7818));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7821));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7823));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7825));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7828));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7832));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7834));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7837));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7840));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7844));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7852));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7854));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7856));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7858));

            migrationBuilder.UpdateData(
                table: "Equipments",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7860));

            migrationBuilder.UpdateData(
                table: "MaintenancePlan",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7356));

            migrationBuilder.UpdateData(
                table: "MaintenancePlan",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "MaintenancePlan",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7358));

            migrationBuilder.UpdateData(
                table: "MaintenancePlan",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "MaintenancePlan",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6731));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6732));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6733));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6734));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6735));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6735));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6736));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6737));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6738));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6739));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6739));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6742));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6742));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6743));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6744));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6745));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6745));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6748));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "Manufactures",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6834));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6835));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6836));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6837));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6837));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6873));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6874));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6875));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6875));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6876));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6878));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6879));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6879));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6881));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6881));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6882));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6883));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6884));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6884));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6892));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6894));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6896));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6897));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6898));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6898));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6899));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6901));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6901));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6902));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6905));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6906));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6908));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6916));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6917));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6919));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6921));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6921));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6923));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6924));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6924));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6926));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6927));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6927));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6929));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6962));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6963));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6964));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6965));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6965));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6966));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6967));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6968));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6969));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6971));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6971));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6973));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6974));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6974));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6975));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6976));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6977));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6977));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6978));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6979));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6981));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6982));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6983));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6983));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6984));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6985));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6986));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6987));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6991));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6993));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6993));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6994));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6996));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6997));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6997));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6998));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6999));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7001));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7003));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7003));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7005));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7007));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7008));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7009));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7009));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7011));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7011));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7012));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7013));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7014));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7014));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7015));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7016));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7017));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7017));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7018));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7019));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7021));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7021));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7022));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7073));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7074));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7074));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7075));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7077));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7077));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7078));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7079));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7081));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7081));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7082));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7083));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7084));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7084));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7085));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7086));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7087));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7087));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7088));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7089));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7091));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7091));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7092));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7093));

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6417));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6418));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6419));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6421));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6466));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6467));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6468));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6469));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "OperationSites",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(6471));

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7277) });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7278) });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7279) });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7280) });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Code", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7280) });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Code", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7281) });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Code", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7282) });

            migrationBuilder.UpdateData(
                table: "Parts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Code", "CreatedDate" },
                values: new object[] { null, new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7283) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7434));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7436));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7437));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 7, 13, 17, 27, 26, DateTimeKind.Utc).AddTicks(7437));
        }
    }
}
