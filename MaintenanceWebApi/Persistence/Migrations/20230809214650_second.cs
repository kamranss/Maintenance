using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_MaintenancePlan_MaintenancePlanId",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "UsageHistories");

            migrationBuilder.DropColumn(
                name: "MetricTypeId",
                table: "MaintenancePlan");

            migrationBuilder.RenameColumn(
                name: "UsageHourValue",
                table: "UsageHistories",
                newName: "TotalUsageValue");

            migrationBuilder.RenameColumn(
                name: "Operator",
                table: "UsageHistories",
                newName: "OperatorName");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "UsageHistories",
                newName: "OperationName");

            migrationBuilder.RenameColumn(
                name: "LastMaintenace",
                table: "Equipments",
                newName: "LastMaintenaceTime");

            migrationBuilder.AddColumn<decimal>(
                name: "TotalTime",
                table: "UsageHistories",
                type: "numeric",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MaintenancePlanId",
                table: "Services",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.InsertData(
                table: "EquipmentParts",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "EquipmentId", "IsActive", "IsDeleted", "ModifiedBy", "PartId", "RemovalDate", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, null, null, true, false, null, null, null, null },
                    { 2, null, null, null, true, false, null, null, null, null },
                    { 3, null, null, null, true, false, null, null, null, null },
                    { 4, null, null, null, true, false, null, null, null, null },
                    { 5, null, null, null, true, false, null, null, null, null },
                    { 6, null, null, null, true, false, null, null, null, null },
                    { 7, null, null, null, true, false, null, null, null, null },
                    { 8, null, null, null, true, false, null, null, null, null }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Services_MaintenancePlan_MaintenancePlanId",
                table: "Services",
                column: "MaintenancePlanId",
                principalTable: "MaintenancePlan",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_MaintenancePlan_MaintenancePlanId",
                table: "Services");

            migrationBuilder.DeleteData(
                table: "EquipmentParts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EquipmentParts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EquipmentParts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EquipmentParts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EquipmentParts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EquipmentParts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "EquipmentParts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "EquipmentParts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DropColumn(
                name: "TotalTime",
                table: "UsageHistories");

            migrationBuilder.RenameColumn(
                name: "TotalUsageValue",
                table: "UsageHistories",
                newName: "UsageHourValue");

            migrationBuilder.RenameColumn(
                name: "OperatorName",
                table: "UsageHistories",
                newName: "Operator");

            migrationBuilder.RenameColumn(
                name: "OperationName",
                table: "UsageHistories",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "LastMaintenaceTime",
                table: "Equipments",
                newName: "LastMaintenace");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "UsageHistories",
                type: "text",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MaintenancePlanId",
                table: "Services",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MetricTypeId",
                table: "MaintenancePlan",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Services_MaintenancePlan_MaintenancePlanId",
                table: "Services",
                column: "MaintenancePlanId",
                principalTable: "MaintenancePlan",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
