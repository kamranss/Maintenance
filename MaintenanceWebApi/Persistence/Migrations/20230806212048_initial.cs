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
                    RemovalDate = table.Column<int>(type: "integer", nullable: true),
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
                    RemovalDate = table.Column<int>(type: "integer", nullable: true),
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
                    RemovalDate = table.Column<int>(type: "integer", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintenancePlan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manufactures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Code = table.Column<int>(type: "integer", nullable: true),
                    RemovalReason = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    RemovalDate = table.Column<int>(type: "integer", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufactures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Models",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Code = table.Column<int>(type: "integer", nullable: true),
                    RemovalReason = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    RemovalDate = table.Column<int>(type: "integer", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models", x => x.Id);
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
                    RemovalDate = table.Column<int>(type: "integer", nullable: true),
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
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    ServiceType = table.Column<string>(type: "text", nullable: true),
                    ServiceDescription = table.Column<string>(type: "text", nullable: true),
                    MaintenancePlanId = table.Column<int>(type: "integer", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    RemovalDate = table.Column<int>(type: "integer", nullable: true),
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
                    ModelId = table.Column<int>(type: "integer", nullable: true),
                    isDeleted = table.Column<bool>(type: "boolean", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: true),
                    ImagUrl = table.Column<string>(type: "text", nullable: true),
                    OperationSiteid = table.Column<int>(type: "integer", nullable: true),
                    ProductionYear = table.Column<int>(type: "integer", nullable: true),
                    ManufactureId = table.Column<int>(type: "integer", nullable: true),
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
                    RemovalDate = table.Column<int>(type: "integer", nullable: true),
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
                    table.ForeignKey(
                        name: "FK_Equipments_Manufactures_ManufactureId",
                        column: x => x.ManufactureId,
                        principalTable: "Manufactures",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Equipments_Models_ModelId",
                        column: x => x.ModelId,
                        principalTable: "Models",
                        principalColumn: "Id");
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
                    RemovalDate = table.Column<int>(type: "integer", nullable: true),
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
                    Code = table.Column<int>(type: "integer", nullable: false),
                    DepartmentId = table.Column<int>(type: "integer", nullable: true),
                    EquipmentId = table.Column<int>(type: "integer", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    RemovalDate = table.Column<int>(type: "integer", nullable: true),
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
                    RemovalDate = table.Column<int>(type: "integer", nullable: true),
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
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsActive", "IsDeleted", "ModifiedBy", "Name", "RemovalDate", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, null, true, false, null, "Forklift 1.5", null, null },
                    { 2, null, null, true, false, null, "Forklift 2.5", null, null },
                    { 3, null, null, true, false, null, "Forklift 4", null, null },
                    { 4, null, null, true, false, null, "Forklift 10", null, null },
                    { 5, null, null, true, false, null, "Forklift 20", null, null },
                    { 6, null, null, true, false, null, "Reach Stacker 45", null, null },
                    { 7, null, null, true, false, null, "Portal Crane 80T", null, null },
                    { 8, null, null, true, false, null, "Portal Crane 40T", null, null },
                    { 9, null, null, true, false, null, "Loader 25", null, null },
                    { 10, null, null, true, false, null, "GC_Berth", null, null },
                    { 11, null, null, true, false, null, "Ferry_Berth", null, null },
                    { 12, null, null, true, false, null, "Ro-Ro_Berth", null, null },
                    { 13, null, null, true, false, null, "Tug_Boat", null, null },
                    { 14, null, null, true, false, null, "Mobile_Crane 220T", null, null },
                    { 15, null, null, true, false, null, "Building", null, null },
                    { 16, null, null, true, false, null, "Container_Spreader", null, null },
                    { 17, null, null, true, false, null, "Terminal_Tractor", null, null },
                    { 18, null, null, true, false, null, "Oil_Cleaner_Boat", null, null },
                    { 19, null, null, true, false, null, "Greifer", null, null },
                    { 20, null, null, true, false, null, "Lifting_Magnet", null, null },
                    { 21, null, null, true, false, null, "Fender", null, null },
                    { 22, null, null, true, false, null, "Railway", null, null },
                    { 23, null, null, true, false, null, "Wire_Rope_Sling", null, null },
                    { 24, null, null, true, false, null, "Chain_Connector", null, null },
                    { 25, null, null, true, false, null, "Lifting_Lug", null, null },
                    { 26, null, null, true, false, null, "Hook", null, null },
                    { 27, null, null, true, false, null, "Websling", null, null },
                    { 28, null, null, true, false, null, "Bunker", null, null },
                    { 29, null, null, true, false, null, "Generator", null, null },
                    { 30, null, null, true, false, null, "Shalves", null, null },
                    { 31, null, null, true, false, null, "Plate_Clamp", null, null },
                    { 32, null, null, true, false, null, "Harness", null, null },
                    { 33, null, null, true, false, null, "Roads", null, null },
                    { 34, null, null, true, false, null, "Drum_Lifter", null, null },
                    { 35, null, null, true, false, null, "Working_Platform", null, null },
                    { 36, null, null, true, false, null, "Single leg chain sling", null, null },
                    { 37, null, null, true, false, null, "Portal Crane 32T", null, null }
                });

            migrationBuilder.InsertData(
                table: "Manufactures",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "IsActive", "IsDeleted", "ModifiedBy", "Name", "RemovalDate", "RemovalReason", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, null, null, true, false, null, "Single leg chain sling", null, null, null },
                    { 2, null, null, null, true, false, null, "Working platform", null, null, null },
                    { 3, null, null, null, true, false, null, "Hangcha", null, null, null },
                    { 4, null, null, null, true, false, null, "XCMG", null, null, null },
                    { 5, null, null, null, true, false, null, "Kalmar", null, null, null },
                    { 6, null, null, null, true, false, null, "Terberq", null, null, null },
                    { 7, null, null, null, true, false, null, "Sisu", null, null, null },
                    { 8, null, null, null, true, false, null, "Toyoto", null, null, null },
                    { 9, null, null, null, true, false, null, "Bobkat", null, null, null },
                    { 10, null, null, null, true, false, null, "Hyster", null, null, null },
                    { 11, null, null, null, true, false, null, "Boss", null, null, null },
                    { 12, null, null, null, true, false, null, "Ardelt", null, null, null },
                    { 13, null, null, null, true, false, null, "None", null, null, null },
                    { 14, null, null, null, true, false, null, "VDL", null, null, null },
                    { 15, null, null, null, true, false, null, "Sunny", null, null, null },
                    { 16, null, null, null, true, false, null, "Camry", null, null, null },
                    { 17, null, null, null, true, false, null, "Engine", null, null, null },
                    { 18, null, null, null, true, false, null, "023-2 №-li dizel generator", null, null, null },
                    { 19, null, null, null, true, false, null, "022-1 №-li dizel generator", null, null, null },
                    { 20, null, null, null, true, false, null, "021-TQM 23 B48-754", null, null, null },
                    { 21, null, null, null, true, false, null, "Service berth-N4", null, null, null },
                    { 22, null, null, null, true, false, null, "Molino", null, null, null },
                    { 23, null, null, null, true, false, null, "Service berth-N3 ", null, null, null },
                    { 24, null, null, null, true, false, null, "Shackle", null, null, null },
                    { 25, null, null, null, true, false, null, "County", null, null, null },
                    { 26, null, null, null, true, false, null, "Santafe", null, null, null },
                    { 27, null, null, null, true, false, null, "Sonata", null, null, null },
                    { 28, null, null, null, true, false, null, "Kartal SLX", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "IsActive", "IsDeleted", "ModifiedBy", "Name", "RemovalDate", "RemovalReason", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, null, null, true, false, null, "RS45-31CH", null, null, null },
                    { 2, null, null, null, true, false, null, "CPCD200-W36", null, null, null },
                    { 3, null, null, null, true, false, null, "CPCD100-W17", null, null, null },
                    { 4, null, null, null, true, false, null, "CPCD40-RC24", null, null, null },
                    { 5, null, null, null, true, false, null, "CPCD25N-RC2", null, null, null },
                    { 6, null, null, null, true, false, null, "CPCD15N-RC26", null, null, null },
                    { 7, null, null, null, true, false, null, "XT760", null, null, null },
                    { 8, null, null, null, true, false, null, "DRD420-60S5", null, null, null },
                    { 9, null, null, null, true, false, null, "DSD420-12CSG", null, null, null },
                    { 10, null, null, null, true, false, null, "T-1", null, null, null },
                    { 11, null, null, null, true, false, null, "TV-10EIT-4x4/2600", null, null, null },
                    { 12, null, null, null, true, false, null, "FD-100F50", null, null, null },
                    { 13, null, null, null, true, false, null, "843", null, null, null },
                    { 14, null, null, null, true, false, null, "HS1", null, null, null },
                    { 15, null, null, null, true, false, null, "B1", null, null, null },
                    { 16, null, null, null, true, false, null, "FD-15", null, null, null },
                    { 17, null, null, null, true, false, null, "Kondor 1500", null, null, null },
                    { 18, null, null, null, true, false, null, "QAY220 All Terrain Crane", null, null, null },
                    { 19, null, null, null, true, false, null, "None", null, null, null },
                    { 20, null, null, null, true, false, null, "Sokol 500", null, null, null },
                    { 21, null, null, null, true, false, null, "Mobil Pnevmatik Transporter", null, null, null },
                    { 22, null, null, null, true, false, null, "ST 1", null, null, null },
                    { 23, null, null, null, true, false, null, "ST 2", null, null, null },
                    { 24, null, null, null, true, false, null, "ST 3", null, null, null },
                    { 25, null, null, null, true, false, null, "ST 4", null, null, null },
                    { 26, null, null, null, true, false, null, "ST 4", null, null, null },
                    { 27, null, null, null, true, false, null, "ST 5", null, null, null },
                    { 28, null, null, null, true, false, null, "ST 6", null, null, null },
                    { 29, null, null, null, true, false, null, "ST 7", null, null, null },
                    { 30, null, null, null, true, false, null, "ST 8", null, null, null },
                    { 31, null, null, null, true, false, null, "ST 8", null, null, null },
                    { 32, null, null, null, true, false, null, "ST 9", null, null, null },
                    { 33, null, null, null, true, false, null, "ST 10", null, null, null },
                    { 34, null, null, null, true, false, null, "Ferry Terminal", null, null, null },
                    { 35, null, null, null, true, false, null, "YT180-04", null, null, null },
                    { 36, null, null, null, true, false, null, "CH 6600", null, null, null },
                    { 37, null, null, null, true, false, null, "AM 140/76/36", null, null, null },
                    { 38, null, null, null, true, false, null, "VSG/020.0-2.2-6400", null, null, null },
                    { 39, null, null, null, true, false, null, "VSG/015.0.07.13500", null, null, null },
                    { 40, null, null, null, true, false, null, "VSG/016.0-2.2-5000", null, null, null },
                    { 41, null, null, null, true, false, null, "VSG/020.0-0.7-17500", null, null, null },
                    { 42, null, null, null, true, false, null, "Sabir Babayev yedək gəmisi", null, null, null },
                    { 43, null, null, null, true, false, null, "Ələt yedək gəmisi", null, null, null },
                    { 44, null, null, null, true, false, null, "Silkway yedək gəmisi", null, null, null },
                    { 45, null, null, null, true, false, null, "045-TQM 23 B - 48", null, null, null },
                    { 46, null, null, null, true, false, null, "046-MNMS-73", null, null, null },
                    { 47, null, null, null, true, false, null, "047-Şəfəq", null, null, null },
                    { 48, null, null, null, true, false, null, "048-Kür", null, null, null },
                    { 49, null, null, null, true, false, null, "049-Günəşli", null, null, null },
                    { 50, null, null, null, true, false, null, "050-Nüsrət Şirinov", null, null, null },
                    { 51, null, null, null, true, false, null, "051-Elxan Kazımov", null, null, null },
                    { 52, null, null, null, true, false, null, "052-Limançı", null, null, null },
                    { 53, null, null, null, true, false, null, "053-TQM 23 B48 - 2494", null, null, null },
                    { 54, null, null, null, true, false, null, "Nissan", null, null, null },
                    { 55, null, null, null, true, false, null, "Toyota", null, null, null },
                    { 56, null, null, null, true, false, null, "QAZ", null, null, null },
                    { 57, null, null, null, true, false, null, "HOWO", null, null, null },
                    { 58, null, null, null, true, false, null, "Fiat", null, null, null },
                    { 59, null, null, null, true, false, null, "111111", null, null, null },
                    { 60, null, null, null, true, false, null, "Vaz", null, null, null },
                    { 61, null, null, null, true, false, null, "Tofash", null, null, null },
                    { 62, null, null, null, true, false, null, "Volkswagen", null, null, null },
                    { 63, null, null, null, true, false, null, "Hyundai", null, null, null },
                    { 64, null, null, null, true, false, null, "Mersedes Benz", null, null, null },
                    { 65, null, null, null, true, false, null, "5 Tonne 5mtr x 26mm dia", null, null, null },
                    { 66, null, null, null, true, false, null, "5 Tonne 4mtr x 26mm dia", null, null, null },
                    { 67, null, null, null, true, false, null, "10 Tonne 5.5mtr x 32mm dia", null, null, null },
                    { 68, null, null, null, true, false, null, "15 Tonne 4mtr x 38mm dia", null, null, null },
                    { 69, null, null, null, true, false, null, "5 Tonne 3mtr x 26mm dia", null, null, null },
                    { 70, null, null, null, true, false, null, "8.6 Tonne 1.9mtr x26mm dia", null, null, null },
                    { 71, null, null, null, true, false, null, "8.6 Tonne 10 mtr x 26mm dia", null, null, null },
                    { 72, null, null, null, true, false, null, "6.2 Tonne 11.06mtr x 22mm dia", null, null, null },
                    { 73, null, null, null, true, false, null, "8.6 Tonne 10 mtr x 26mm dia", null, null, null },
                    { 74, null, null, null, true, false, null, "6.2 Tonne 11.06mtr x 22mm dia", null, null, null },
                    { 75, null, null, null, true, false, null, "6.2 Tonne 10 mtr x 22mm dia", null, null, null },
                    { 76, null, null, null, true, false, null, "6.2 Tonne 6 mtr x 22 mm dia", null, null, null },
                    { 77, null, null, null, true, false, null, "077-5.1 6 mtr x 22 mm dia", null, null, null },
                    { 78, null, null, null, true, false, null, "078-5.1 Tonne 1.3 mtr x 20 mm dia", null, null, null },
                    { 79, null, null, null, true, false, null, "079-5.1 Tonne 2.93 mtr x 20 mm dia", null, null, null },
                    { 80, null, null, null, true, false, null, "080-10.1 Tonne 12 mtr x 28 mm dia", null, null, null },
                    { 81, null, null, null, true, false, null, "081-5 Tonne 8 mtr x 20 mm dia", null, null, null },
                    { 82, null, null, null, true, false, null, "082-8 Tonne 8 mtr x 26 mm dia", null, null, null },
                    { 83, null, null, null, true, false, null, "083-10 Tonne 10 mtr x 28 mm dia", null, null, null },
                    { 84, null, null, null, true, false, null, "084-10.1 Tonne 6 mtr x 28 mm dia", null, null, null },
                    { 85, null, null, null, true, false, null, "085-10.1 Tonne 6 mtr x 28 mm dia", null, null, null },
                    { 86, null, null, null, true, false, null, "086-12 Tonne", null, null, null },
                    { 87, null, null, null, true, false, null, "087-25 Tonne", null, null, null },
                    { 88, null, null, null, true, false, null, "6.5 Tonne", null, null, null },
                    { 89, null, null, null, true, false, null, "4.75 Tonne", null, null, null },
                    { 90, null, null, null, true, false, null, "3.25 Tonne", null, null, null },
                    { 91, null, null, null, true, false, null, "8.5 Tonne", null, null, null },
                    { 92, null, null, null, true, false, null, "12 Tonne", null, null, null },
                    { 93, null, null, null, true, false, null, "12.5 Tonne", null, null, null },
                    { 94, null, null, null, true, false, null, "8 Tonne", null, null, null },
                    { 95, null, null, null, true, false, null, "3 Tonne", null, null, null },
                    { 96, null, null, null, true, false, null, "10 Tonne", null, null, null },
                    { 97, null, null, null, true, false, null, "4064 Kgs", null, null, null },
                    { 98, null, null, null, true, false, null, "5 Tonne", null, null, null },
                    { 99, null, null, null, true, false, null, "3 Tonne 1 mtr", null, null, null },
                    { 100, null, null, null, true, false, null, "3 Tonne 2 mtr", null, null, null },
                    { 101, null, null, null, true, false, null, "3 Tonne 2 mtr", null, null, null },
                    { 102, null, null, null, true, false, null, "3 Tonne 3 mtr", null, null, null },
                    { 103, null, null, null, true, false, null, "3 Tonne 5 mtr", null, null, null },
                    { 104, null, null, null, true, false, null, "3 Tonne 6 mtr", null, null, null },
                    { 105, null, null, null, true, false, null, "3 Tonne 10 mtr", null, null, null },
                    { 106, null, null, null, true, false, null, "106-5 tonne 3 mtr", null, null, null },
                    { 107, null, null, null, true, false, null, "107-5 Tonne 5 mtr", null, null, null },
                    { 108, null, null, null, true, false, null, "108-5 Tonne 6 mtr", null, null, null },
                    { 109, null, null, null, true, false, null, "109-10 Tonne 5 mtr", null, null, null },
                    { 110, null, null, null, true, false, null, "110-6 Tonne 4 mtr", null, null, null },
                    { 111, null, null, null, true, false, null, "6 Tonne 6 mtr", null, null, null },
                    { 112, null, null, null, true, false, null, "112-6 Tonne 10mtr", null, null, null },
                    { 113, null, null, null, true, false, null, "113-14 Tonne", null, null, null },
                    { 114, null, null, null, true, false, null, "114-15 Tonne", null, null, null },
                    { 115, null, null, null, true, false, null, "115-136 kgs", null, null, null },
                    { 116, null, null, null, true, false, null, "116-30 Tonne", null, null, null },
                    { 117, null, null, null, true, false, null, "117-Model: H2000/3 MFB", null, null, null },
                    { 118, null, null, null, true, false, null, "118-Model: KP 25", null, null, null },
                    { 119, null, null, null, true, false, null, "119-Model: 71022", null, null, null },
                    { 120, null, null, null, true, false, null, "120-2250 kgs", null, null, null },
                    { 121, null, null, null, true, false, null, "121-1.5 Tonne", null, null, null },
                    { 122, null, null, null, true, false, null, "122-SİNGLE LİNE LANYARD", null, null, null },
                    { 123, null, null, null, true, false, null, "123-Takelaj sahəsi", null, null, null },
                    { 124, null, null, null, true, false, null, "8 Tonne 8 mtr", null, null, null },
                    { 125, null, null, null, true, false, null, "8 Tonne 6mtr", null, null, null },
                    { 126, null, null, null, true, false, null, "126- Qarmaq   KE-40", null, null, null },
                    { 127, null, null, null, true, false, null, "127-Qarmaq    KE-80", null, null, null },
                    { 128, null, null, null, true, false, null, "128-Qarmaq   KE-32", null, null, null },
                    { 129, null, null, null, true, false, null, "10 Tonee x 3 mtr x 28 dia", null, null, null },
                    { 130, null, null, null, true, false, null, "3 tonne x 1.5 mtr x 20 mm", null, null, null },
                    { 131, null, null, null, true, false, null, "7 Tonne", null, null, null },
                    { 132, null, null, null, true, false, null, "3 tonne x 1 mtr", null, null, null },
                    { 133, null, null, null, true, false, null, "10 Tonne 6 mtr", null, null, null },
                    { 134, null, null, null, true, false, null, "10 tonne 4 mtr", null, null, null },
                    { 135, null, null, null, true, false, null, "1 tonne 2mtr", null, null, null },
                    { 136, null, null, null, true, false, null, "5 tonne 10 mtr", null, null, null },
                    { 137, null, null, null, true, false, null, "8 Tonne 2mtr", null, null, null },
                    { 138, null, null, null, true, false, null, "10 Tonne 10 mtr", null, null, null },
                    { 139, null, null, null, true, false, null, "17 Tonne", null, null, null },
                    { 140, null, null, null, true, false, null, "3.2 tonne x  3 mtr x 16 mm", null, null, null },
                    { 141, null, null, null, true, false, null, "10 tonne x 5.5 mtr x 28 mm", null, null, null },
                    { 142, null, null, null, true, false, null, "10 tonne x 5 mtr x 28 mm", null, null, null },
                    { 143, null, null, null, true, false, null, "10 tonne x 4 mtr x 28 mm", null, null, null },
                    { 144, null, null, null, true, false, null, "10 Tonne x 6 mtr x 28 mm", null, null, null },
                    { 145, null, null, null, true, false, null, "6.2 Tonne x 3mtr x 22mm", null, null, null },
                    { 146, null, null, null, true, false, null, "6.2 Tonne x 5 mtr x 22mm", null, null, null },
                    { 147, null, null, null, true, false, null, "18.5 Tonne x 3 mtr x 38 mm", null, null, null },
                    { 148, null, null, null, true, false, null, "18.5 Tonne x 5 mtr x 38 mm", null, null, null },
                    { 149, null, null, null, true, false, null, "2 tonne 2 mtr", null, null, null },
                    { 150, null, null, null, true, false, null, "1.74mtr x 4.24mtr x 1.32mtr - 300kgs", null, null, null },
                    { 151, null, null, null, true, false, null, "400 kgs", null, null, null },
                    { 152, null, null, null, true, false, null, "18.5 Tonne x 8 mtr x 38 mm", null, null, null },
                    { 153, null, null, null, true, false, null, "10 Tonne x 12 mtr x 28 mm", null, null, null },
                    { 154, null, null, null, true, false, null, "5.3  Tonne x 15 mtr x 13 mm", null, null, null },
                    { 155, null, null, null, true, false, null, "8 tonne 4 mtr", null, null, null },
                    { 156, null, null, null, true, false, null, "85 Tonne", null, null, null },
                    { 157, null, null, null, true, false, null, "35 Tonne", null, null, null },
                    { 158, null, null, null, true, false, null, "9.5 Tonne", null, null, null },
                    { 159, null, null, null, true, false, null, "13.5 tonne", null, null, null },
                    { 160, null, null, null, true, false, null, "10 Tonne x 8 mtr x 28 mm", null, null, null },
                    { 161, null, null, null, true, false, null, "161-İnzibati bina CR-2 və qazanxan HB-1", null, null, null },
                    { 162, null, null, null, true, false, null, "162-Ümumi yük terminalı binaları CR-7 , CR-9 , CR-8", null, null, null },
                    { 163, null, null, null, true, false, null, "163-Texniki xidmət binaları CR-3, CR-4, CR-10, CR-15, CR-16, WS-3", null, null, null },
                    { 164, null, null, null, true, false, null, "164-RO-RO terminalı binaları CR-17, FS-5 , FS-10, FS-11, FS-16, FS-17, FS-18", null, null, null },
                    { 165, null, null, null, true, false, null, "165-BƏRƏ terminalı binaları FS-3, FS-9, FS-12, FS-13, FS-14 , FS-19", null, null, null },
                    { 166, null, null, null, true, false, null, "166-DƏMİRYOLU binaları RM-1, RM-2 ,RM-4 ,RM-5, RM-6, RM- 7, RM-8, RM-13, RM-14, RM15, RM-16", null, null, null },
                    { 167, null, null, null, true, false, null, "167-Mühafizə xidməti binaları AB-1, AB-2, AB-7", null, null, null },
                    { 168, null, null, null, true, false, null, "142 tonne x 3,4 mtr x 56 mm", null, null, null },
                    { 169, null, null, null, true, false, null, "50 Tonne", null, null, null },
                    { 170, null, null, null, true, false, null, "300 kgs", null, null, null },
                    { 171, null, null, null, true, false, null, "4 tonne 2 mtr", null, null, null },
                    { 172, null, null, null, true, false, null, "172-Abşeron Neft Terminalı binaları", null, null, null },
                    { 173, null, null, null, true, false, null, "173-Abşeron Neft Terminalı hidrotexniki qurğuları 1 saylı körpü", null, null, null },
                    { 174, null, null, null, true, false, null, "174-Abşeron Neft Terminalı hidrotexniki qurğuları 3 saylı körpü", null, null, null },
                    { 175, null, null, null, true, false, null, "175-Dəniz vağzalı binası", null, null, null },
                    { 176, null, null, null, true, false, null, "176-Dəniz vağzalı hidrotexniki qurğuları", null, null, null },
                    { 177, null, null, null, true, false, null, "177-İdarə binası və mədəniyyət evi", null, null, null },
                    { 178, null, null, null, true, false, null, "178-Qaradağ mülki-müdafiə binaları", null, null, null },
                    { 179, null, null, null, true, false, null, "179-Liman ərazisi yollar (Kargo , Ro-Ro , Bərə terminal)", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "OperationSites",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "DepartmentId", "EquipmentId", "IsActive", "IsDeleted", "ModifiedBy", "Name", "RemovalDate", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 0, null, null, null, null, true, false, null, "Building_1", null, null },
                    { 2, 0, null, null, null, null, true, false, null, "Building_2", null, null },
                    { 3, 0, null, null, null, null, true, false, null, "OperationArea_1", null, null },
                    { 4, 0, null, null, null, null, true, false, null, "WareHause_1", null, null },
                    { 5, 0, null, null, null, null, true, false, null, "WareHause_2", null, null },
                    { 6, 0, null, null, null, null, true, false, null, "WareHause_3", null, null },
                    { 7, 0, null, null, null, null, true, false, null, "OperationArea_2", null, null },
                    { 8, 0, null, null, null, null, true, false, null, "ST-1", null, null },
                    { 9, 0, null, null, null, null, true, false, null, "ST-2", null, null },
                    { 10, 0, null, null, null, null, true, false, null, "ST-3", null, null },
                    { 11, 0, null, null, null, null, true, false, null, "ST-4", null, null },
                    { 12, 0, null, null, null, null, true, false, null, "ST-5", null, null }
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
                name: "IX_Equipments_ManufactureId",
                table: "Equipments",
                column: "ManufactureId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_ModelId",
                table: "Equipments",
                column: "ModelId");

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

            migrationBuilder.DropTable(
                name: "Manufactures");

            migrationBuilder.DropTable(
                name: "Models");
        }
    }
}
