using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class UsageHistoryUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Remark",
                table: "UsageHistories",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DepartmentHead", "Description" },
                values: new object[] { new DateTime(2023, 8, 16, 17, 39, 9, 49, DateTimeKind.Utc).AddTicks(8829), "User1", "Unknown" });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DepartmentHead", "Description" },
                values: new object[] { new DateTime(2023, 8, 16, 17, 39, 9, 49, DateTimeKind.Utc).AddTicks(8835), "User1", "Unknown" });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "DepartmentHead", "Description" },
                values: new object[] { new DateTime(2023, 8, 16, 17, 39, 9, 49, DateTimeKind.Utc).AddTicks(8837), "User1", "Unknown" });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "DepartmentHead", "Description" },
                values: new object[] { new DateTime(2023, 8, 16, 17, 39, 9, 49, DateTimeKind.Utc).AddTicks(8838), "User1", "Unknown" });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "DepartmentHead", "Description" },
                values: new object[] { new DateTime(2023, 8, 16, 17, 39, 9, 49, DateTimeKind.Utc).AddTicks(8839), "User1", "Unknown" });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "DepartmentHead", "Description" },
                values: new object[] { new DateTime(2023, 8, 16, 17, 39, 9, 49, DateTimeKind.Utc).AddTicks(8840), "User1", "Unknown" });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "DepartmentHead", "Description" },
                values: new object[] { new DateTime(2023, 8, 16, 17, 39, 9, 49, DateTimeKind.Utc).AddTicks(8841), "User1", "Unknown" });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "DepartmentHead", "Description" },
                values: new object[] { new DateTime(2023, 8, 16, 17, 39, 9, 49, DateTimeKind.Utc).AddTicks(8843), "User1", "Unknown" });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "DepartmentHead", "Description" },
                values: new object[] { new DateTime(2023, 8, 16, 17, 39, 9, 49, DateTimeKind.Utc).AddTicks(8844), "User1", "Unknown" });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "DepartmentHead", "Description" },
                values: new object[] { new DateTime(2023, 8, 16, 17, 39, 9, 49, DateTimeKind.Utc).AddTicks(8845), "User1", "Unknown" });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "DepartmentHead", "Description" },
                values: new object[] { new DateTime(2023, 8, 16, 17, 39, 9, 49, DateTimeKind.Utc).AddTicks(8846), "User1", "Unknown" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Remark",
                table: "UsageHistories");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DepartmentHead", "Description" },
                values: new object[] { new DateTime(2023, 8, 15, 18, 55, 57, 217, DateTimeKind.Utc).AddTicks(117), null, null });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DepartmentHead", "Description" },
                values: new object[] { new DateTime(2023, 8, 15, 18, 55, 57, 217, DateTimeKind.Utc).AddTicks(124), null, null });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "DepartmentHead", "Description" },
                values: new object[] { new DateTime(2023, 8, 15, 18, 55, 57, 217, DateTimeKind.Utc).AddTicks(125), null, null });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "DepartmentHead", "Description" },
                values: new object[] { new DateTime(2023, 8, 15, 18, 55, 57, 217, DateTimeKind.Utc).AddTicks(126), null, null });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "DepartmentHead", "Description" },
                values: new object[] { new DateTime(2023, 8, 15, 18, 55, 57, 217, DateTimeKind.Utc).AddTicks(127), null, null });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "DepartmentHead", "Description" },
                values: new object[] { new DateTime(2023, 8, 15, 18, 55, 57, 217, DateTimeKind.Utc).AddTicks(130), null, null });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "DepartmentHead", "Description" },
                values: new object[] { new DateTime(2023, 8, 15, 18, 55, 57, 217, DateTimeKind.Utc).AddTicks(131), null, null });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "DepartmentHead", "Description" },
                values: new object[] { new DateTime(2023, 8, 15, 18, 55, 57, 217, DateTimeKind.Utc).AddTicks(132), null, null });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "DepartmentHead", "Description" },
                values: new object[] { new DateTime(2023, 8, 15, 18, 55, 57, 217, DateTimeKind.Utc).AddTicks(133), null, null });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "DepartmentHead", "Description" },
                values: new object[] { new DateTime(2023, 8, 15, 18, 55, 57, 217, DateTimeKind.Utc).AddTicks(134), null, null });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "DepartmentHead", "Description" },
                values: new object[] { new DateTime(2023, 8, 15, 18, 55, 57, 217, DateTimeKind.Utc).AddTicks(135), null, null });
        }
    }
}
