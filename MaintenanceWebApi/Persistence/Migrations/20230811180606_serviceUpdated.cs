using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class serviceUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "OperationName",
                table: "UsageHistories",
                type: "text",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "MaintenancePlan",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "IsActive", "IsDeleted", "MetricType", "ModifiedBy", "Name", "RemovalDate", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "POCR-1", null, null, "Vizual Inspection", true, false, "Period", null, "Portal Crane", null, null },
                    { 2, "POCR-2", null, null, "Profilaktik Inspection", true, false, "Period", null, "Portal Crane Prof", null, null },
                    { 3, "FRKL-1", null, null, "Vizual Inspection", true, false, "Period", null, "Fork Lift", null, null },
                    { 4, "RAIL-1", null, null, "Vizual Inspection of Railway", true, false, "Period", null, "Railway", null, null },
                    { 5, "FRKL-2", null, null, "Engine Oil Change", true, false, "MotoHours", null, "Fork Lift", null, null }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsActive", "IsDeleted", "MaintenancePlanId", "ModifiedBy", "Name", "RemovalDate", "ServiceDescription", "ServiceType", "UpdatedDate" },
                values: new object[,]
                {
                    { 3, null, null, true, false, null, null, "Engine Oil Change", null, "Engine Oil change", "Refill", null },
                    { 4, null, null, true, false, null, null, "Engine Oil Change", null, "Engine Oil change", "Refill", null }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsActive", "IsDeleted", "MaintenancePlanId", "ModifiedBy", "Name", "RemovalDate", "ServiceDescription", "ServiceType", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, null, true, false, 5, null, "Engine Oil ", null, "Engine Oil change", "Refill", null },
                    { 2, null, null, true, false, 5, null, "Engine Oil Filter", null, "Engine Oil filter change", "Replace", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MaintenancePlan",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MaintenancePlan",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MaintenancePlan",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MaintenancePlan",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MaintenancePlan",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.AlterColumn<int>(
                name: "OperationName",
                table: "UsageHistories",
                type: "integer",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }
    }
}
