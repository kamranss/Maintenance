using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Persistence.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    DepartmentHead = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    RemovalDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaintenanceAct",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DocumentName = table.Column<string>(type: "text", nullable: true),
                    DocumentNumber = table.Column<string>(type: "text", nullable: true),
                    ConfirmedById = table.Column<int>(type: "integer", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintenanceAct", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaintenancePlan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    MetricTypeId = table.Column<int>(type: "integer", nullable: false),
                    MetricType = table.Column<string>(type: "text", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintenancePlan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: true),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    NormalizedName = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: true),
                    ProviderKey = table.Column<string>(type: "text", nullable: true),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: true),
                    RoleId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Surname = table.Column<string>(type: "text", nullable: true),
                    OTP = table.Column<int>(type: "integer", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: true),
                    IsOperator = table.Column<bool>(type: "boolean", nullable: true),
                    IsDivisionHead = table.Column<bool>(type: "boolean", nullable: true),
                    ConnectionId = table.Column<string>(type: "text", nullable: true),
                    RefreshTokenEndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UserName = table.Column<string>(type: "text", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "text", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: true),
                    LoginProvider = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Equipments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    UnitNumber = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Color = table.Column<string>(type: "text", nullable: true),
                    Identification = table.Column<string>(type: "text", nullable: true),
                    Model = table.Column<string>(type: "text", nullable: true),
                    isDeleted = table.Column<bool>(type: "boolean", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: true),
                    ImagUrl = table.Column<string>(type: "text", nullable: true),
                    OperationSiteid = table.Column<int>(type: "integer", nullable: true),
                    ProductionYear = table.Column<string>(type: "text", nullable: true),
                    MadeBy = table.Column<string>(type: "text", nullable: true),
                    SeriaNumber = table.Column<string>(type: "text", nullable: true),
                    Typeid = table.Column<int>(type: "integer", nullable: true),
                    Capacity = table.Column<string>(type: "text", nullable: true),
                    EquipmentType = table.Column<string>(type: "text", nullable: true),
                    usageLocation = table.Column<string>(type: "text", nullable: true),
                    LastMaintenace = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CurrentValue = table.Column<decimal>(type: "numeric", nullable: true),
                    DepartmentId = table.Column<int>(type: "integer", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Equipments_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    ServiceType = table.Column<string>(type: "text", nullable: true),
                    MaintenancePlanId = table.Column<int>(type: "integer", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Services_MaintenancePlan_MaintenancePlanId",
                        column: x => x.MaintenancePlanId,
                        principalTable: "MaintenancePlan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentMaintenancePlan",
                columns: table => new
                {
                    EquipmentsId = table.Column<int>(type: "integer", nullable: false),
                    MaintenancePlanId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentMaintenancePlan", x => new { x.EquipmentsId, x.MaintenancePlanId });
                    table.ForeignKey(
                        name: "FK_EquipmentMaintenancePlan_Equipments_EquipmentsId",
                        column: x => x.EquipmentsId,
                        principalTable: "Equipments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EquipmentMaintenancePlan_MaintenancePlan_MaintenancePlanId",
                        column: x => x.MaintenancePlanId,
                        principalTable: "MaintenancePlan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentPart",
                columns: table => new
                {
                    EquipmentsId = table.Column<int>(type: "integer", nullable: false),
                    PartId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentPart", x => new { x.EquipmentsId, x.PartId });
                    table.ForeignKey(
                        name: "FK_EquipmentPart_Equipments_EquipmentsId",
                        column: x => x.EquipmentsId,
                        principalTable: "Equipments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EquipmentPart_Parts_PartId",
                        column: x => x.PartId,
                        principalTable: "Parts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentParts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EquipmentId = table.Column<int>(type: "integer", nullable: true),
                    PartId = table.Column<int>(type: "integer", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentParts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EquipmentParts_Equipments_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EquipmentParts_Parts_PartId",
                        column: x => x.PartId,
                        principalTable: "Parts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OperationSites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    DepartmentId = table.Column<int>(type: "integer", nullable: true),
                    EquipmentId = table.Column<int>(type: "integer", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationSites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OperationSites_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OperationSites_Equipments_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UsageHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<int>(type: "integer", nullable: true),
                    StartUsageHourValue = table.Column<int>(type: "integer", nullable: true),
                    EndUsageHourValue = table.Column<int>(type: "integer", nullable: true),
                    Operator = table.Column<string>(type: "text", nullable: true),
                    UsageHourValue = table.Column<int>(type: "integer", nullable: true),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    EquipmentId = table.Column<int>(type: "integer", nullable: true),
                    EquipmentName = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsageHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsageHistories_Equipments_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipments",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DepartmentHead", "Description", "IsActive", "IsDeleted", "ModifiedBy", "Name", "RemovalDate", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, null, null, null, true, false, null, "Planning", null, null },
                    { 2, null, null, null, null, true, false, null, "Takelaj", null, null },
                    { 3, null, null, null, null, true, false, null, "Operation", null, null },
                    { 4, null, null, null, null, true, false, null, "Electrical", null, null },
                    { 5, null, null, null, null, true, false, null, "MarineFleet", null, null },
                    { 6, null, null, null, null, true, false, null, "Mechanical", null, null },
                    { 7, null, null, null, null, true, false, null, "Cranes", null, null },
                    { 8, null, null, null, null, true, false, null, "Railway", null, null },
                    { 9, null, null, null, null, true, false, null, "Transport", null, null },
                    { 10, null, null, null, null, true, false, null, "Engineering", null, null },
                    { 11, null, null, null, null, true, false, null, "Berth", null, null }
                });

            migrationBuilder.InsertData(
                table: "EquipmentType",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsActive", "IsDeleted", "ModifiedBy", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, null, true, false, null, "Forklift 1.5", null },
                    { 2, null, null, true, false, null, "Forklift 2.5", null },
                    { 3, null, null, true, false, null, "Forklift 4", null },
                    { 4, null, null, true, false, null, "Forklift 10", null },
                    { 5, null, null, true, false, null, "Forklift 20", null },
                    { 6, null, null, true, false, null, "Reach Stacker 45", null },
                    { 7, null, null, true, false, null, "Portal Crane 80T", null },
                    { 8, null, null, true, false, null, "Portal Crane 40T", null },
                    { 9, null, null, true, false, null, "Loader 25", null },
                    { 10, null, null, true, false, null, "GC_Berth", null },
                    { 11, null, null, true, false, null, "Ferry_Berth", null },
                    { 12, null, null, true, false, null, "Ro-Ro_Berth", null },
                    { 13, null, null, true, false, null, "Tug_Boat", null },
                    { 14, null, null, true, false, null, "Mobile_Crane 220T", null },
                    { 15, null, null, true, false, null, "Building", null },
                    { 16, null, null, true, false, null, "Container_Spreader", null },
                    { 17, null, null, true, false, null, "Terminal_Tractor", null },
                    { 18, null, null, true, false, null, "Oil_Cleaner_Boat", null },
                    { 19, null, null, true, false, null, "Greifer", null },
                    { 20, null, null, true, false, null, "Lifting_Magnet", null },
                    { 21, null, null, true, false, null, "Fender", null },
                    { 22, null, null, true, false, null, "Railway", null },
                    { 23, null, null, true, false, null, "Wire_Rope_Sling", null },
                    { 24, null, null, true, false, null, "Chain_Connector", null },
                    { 25, null, null, true, false, null, "Lifting_Lug", null },
                    { 26, null, null, true, false, null, "Hook", null },
                    { 27, null, null, true, false, null, "Websling", null },
                    { 28, null, null, true, false, null, "Bunker", null },
                    { 29, null, null, true, false, null, "Generator", null },
                    { 30, null, null, true, false, null, "Shalves", null },
                    { 31, null, null, true, false, null, "Plate_Clamp", null },
                    { 32, null, null, true, false, null, "Harness", null },
                    { 33, null, null, true, false, null, "Roads", null },
                    { 34, null, null, true, false, null, "Drum_Lifter", null },
                    { 35, null, null, true, false, null, "Working_Platform", null },
                    { 36, null, null, true, false, null, "Single leg chain sling", null },
                    { 37, null, null, true, false, null, "Portal Crane 32T", null }
                });

            migrationBuilder.InsertData(
                table: "OperationSites",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DepartmentId", "EquipmentId", "IsActive", "IsDeleted", "ModifiedBy", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, null, null, null, true, false, null, "Building_1", null },
                    { 2, null, null, null, null, true, false, null, "Building_2", null },
                    { 3, null, null, null, null, true, false, null, "OperationArea_1", null },
                    { 4, null, null, null, null, true, false, null, "WareHause_1", null },
                    { 5, null, null, null, null, true, false, null, "WareHause_2", null },
                    { 6, null, null, null, null, true, false, null, "WareHause_3", null },
                    { 7, null, null, null, null, true, false, null, "OperationArea_2", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentMaintenancePlan_MaintenancePlanId",
                table: "EquipmentMaintenancePlan",
                column: "MaintenancePlanId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentPart_PartId",
                table: "EquipmentPart",
                column: "PartId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentParts_EquipmentId",
                table: "EquipmentParts",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentParts_PartId",
                table: "EquipmentParts",
                column: "PartId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_DepartmentId",
                table: "Equipments",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationSites_DepartmentId",
                table: "OperationSites",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationSites_EquipmentId",
                table: "OperationSites",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_MaintenancePlanId",
                table: "Services",
                column: "MaintenancePlanId");

            migrationBuilder.CreateIndex(
                name: "IX_UsageHistories_EquipmentId",
                table: "UsageHistories",
                column: "EquipmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EquipmentMaintenancePlan");

            migrationBuilder.DropTable(
                name: "EquipmentPart");

            migrationBuilder.DropTable(
                name: "EquipmentParts");

            migrationBuilder.DropTable(
                name: "EquipmentType");

            migrationBuilder.DropTable(
                name: "MaintenanceAct");

            migrationBuilder.DropTable(
                name: "OperationSites");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "UsageHistories");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Parts");

            migrationBuilder.DropTable(
                name: "MaintenancePlan");

            migrationBuilder.DropTable(
                name: "Equipments");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
