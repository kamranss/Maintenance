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
                    IsActive = table.Column<bool>(type: "boolean", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    RemovalDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
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
                    RemovalDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
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
                    RemovalDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
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
                    Description = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: true),
                    MetricType = table.Column<int>(type: "integer", nullable: true),
                    MetricTypeName = table.Column<string>(type: "text", nullable: true),
                    MPChecked = table.Column<bool>(type: "boolean", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    RemovalDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
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
                    RemovalDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
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
                    RemovalDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
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
                    RemovalDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
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
                name: "OperationSites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Code = table.Column<int>(type: "integer", nullable: false),
                    DepartmentId = table.Column<int>(type: "integer", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    RemovalDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
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
                    MaintenancePlanId = table.Column<int>(type: "integer", nullable: true),
                    PartId = table.Column<int>(type: "integer", nullable: true),
                    PartName = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    RemovalDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
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
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Services_Parts_PartId",
                        column: x => x.PartId,
                        principalTable: "Parts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Equipments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    IsIdle = table.Column<bool>(type: "boolean", nullable: true),
                    UnitNumber = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Color = table.Column<string>(type: "text", nullable: true),
                    Identification = table.Column<string>(type: "text", nullable: true),
                    ModelId = table.Column<int>(type: "integer", nullable: true),
                    ImagUrl = table.Column<string>(type: "text", nullable: true),
                    OperationSiteid = table.Column<int>(type: "integer", nullable: true),
                    ProductionYear = table.Column<int>(type: "integer", nullable: true),
                    ManufactureId = table.Column<int>(type: "integer", nullable: true),
                    SeriaNumber = table.Column<string>(type: "text", nullable: true),
                    Capacity = table.Column<string>(type: "text", nullable: true),
                    EquipmentTypeId = table.Column<int>(type: "integer", nullable: true),
                    IsNotified = table.Column<bool>(type: "boolean", nullable: true),
                    MpCompleted = table.Column<bool>(type: "boolean", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: true),
                    usageLocation = table.Column<int>(type: "integer", nullable: true),
                    LastMaintenaceDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CurrentValue = table.Column<decimal>(type: "numeric", nullable: true),
                    ResetValue = table.Column<decimal>(type: "numeric", nullable: true),
                    SquenceValue = table.Column<decimal>(type: "numeric", nullable: true),
                    DepartmentId = table.Column<int>(type: "integer", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    RemovalDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
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
                        name: "FK_Equipments_EquipmentType_EquipmentTypeId",
                        column: x => x.EquipmentTypeId,
                        principalTable: "EquipmentType",
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
                    table.ForeignKey(
                        name: "FK_Equipments_OperationSites_OperationSiteid",
                        column: x => x.OperationSiteid,
                        principalTable: "OperationSites",
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
                    RemovalDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
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
                name: "MaintenanceSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StartValue = table.Column<decimal>(type: "numeric", nullable: true),
                    UpdatedValue = table.Column<decimal>(type: "numeric", nullable: true),
                    SequenceValue = table.Column<decimal>(type: "numeric", nullable: true),
                    SsequencePeriod = table.Column<decimal>(type: "numeric", nullable: true),
                    ResetDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    SequenceDateValue = table.Column<int>(type: "integer", nullable: true),
                    DatePeriod = table.Column<int>(type: "integer", nullable: true),
                    EquipmentId = table.Column<int>(type: "integer", nullable: true),
                    MaintenancePlanId = table.Column<int>(type: "integer", nullable: true),
                    IsMpCompleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    RemovalDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintenanceSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MaintenanceSettings_Equipments_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MaintenanceSettings_MaintenancePlan_MaintenancePlanId",
                        column: x => x.MaintenancePlanId,
                        principalTable: "MaintenancePlan",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UsageHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EquipmentId = table.Column<int>(type: "integer", nullable: true),
                    EquipmentName = table.Column<string>(type: "text", nullable: true),
                    OperationName = table.Column<int>(type: "integer", nullable: true),
                    StartUsageHourValue = table.Column<decimal>(type: "numeric", nullable: true),
                    EndUsageHourValue = table.Column<decimal>(type: "numeric", nullable: true),
                    OperationNameValue = table.Column<string>(type: "text", nullable: true),
                    OperatorName = table.Column<string>(type: "text", nullable: true),
                    TotalUsageValue = table.Column<decimal>(type: "numeric", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    TotalUsageTime = table.Column<decimal>(type: "numeric", nullable: true),
                    Remark = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    RemovalDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
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
                    { 1, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9522), "User1", "Unknown", true, false, null, "Planning", null, null },
                    { 2, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9528), "User1", "Unknown", true, false, null, "Takelaj", null, null },
                    { 3, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9529), "User1", "Unknown", true, false, null, "Operation", null, null },
                    { 4, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9530), "User1", "Unknown", true, false, null, "Electrical", null, null },
                    { 5, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9531), "User1", "Unknown", true, false, null, "MarineFleet", null, null },
                    { 6, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9532), "User1", "Unknown", true, false, null, "Mechanical", null, null },
                    { 7, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9534), "User1", "Unknown", true, false, null, "Cranes", null, null },
                    { 8, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9538), "User1", "Unknown", true, false, null, "Railway", null, null },
                    { 9, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9540), "User1", "Unknown", true, false, null, "Transport", null, null },
                    { 10, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9541), "User1", "Unknown", true, false, null, "Engineering", null, null },
                    { 11, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9542), "User1", "Unknown", true, false, null, "Berth", null, null }
                });

            migrationBuilder.InsertData(
                table: "EquipmentType",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsActive", "IsDeleted", "ModifiedBy", "Name", "RemovalDate", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9937), true, false, null, "Forklift 1.5", null, null },
                    { 2, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9938), true, false, null, "Forklift 2.5", null, null },
                    { 3, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9939), true, false, null, "Forklift 4", null, null },
                    { 4, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9942), true, false, null, "Forklift 10", null, null },
                    { 5, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9943), true, false, null, "Forklift 20", null, null },
                    { 6, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9944), true, false, null, "Reach Stacker 45", null, null },
                    { 7, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9945), true, false, null, "Portal Crane 80T", null, null },
                    { 8, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9946), true, false, null, "Portal Crane 40T", null, null },
                    { 9, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9947), true, false, null, "Loader 25", null, null },
                    { 10, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9947), true, false, null, "GC_Berth", null, null },
                    { 11, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9948), true, false, null, "Ferry_Berth", null, null },
                    { 12, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9949), true, false, null, "Ro-Ro_Berth", null, null },
                    { 13, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9950), true, false, null, "Tug_Boat", null, null },
                    { 14, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9951), true, false, null, "Mobile_Crane 220T", null, null },
                    { 15, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9952), true, false, null, "Building", null, null },
                    { 16, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9953), true, false, null, "Container_Spreader", null, null },
                    { 17, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9954), true, false, null, "Terminal_Tractor", null, null },
                    { 18, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9955), true, false, null, "Oil_Cleaner_Boat", null, null },
                    { 19, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9956), true, false, null, "Greifer", null, null },
                    { 20, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9956), true, false, null, "Lifting_Magnet", null, null },
                    { 21, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9957), true, false, null, "Fender", null, null },
                    { 22, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9958), true, false, null, "Railway", null, null },
                    { 23, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9959), true, false, null, "Wire_Rope_Sling", null, null },
                    { 24, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9960), true, false, null, "Chain_Connector", null, null },
                    { 25, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9961), true, false, null, "Lifting_Lug", null, null },
                    { 26, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9962), true, false, null, "Hook", null, null },
                    { 27, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9963), true, false, null, "Websling", null, null },
                    { 28, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9964), true, false, null, "Bunker", null, null },
                    { 29, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9964), true, false, null, "Generator", null, null },
                    { 30, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9965), true, false, null, "Shalves", null, null },
                    { 31, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9990), true, false, null, "Plate_Clamp", null, null },
                    { 32, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9991), true, false, null, "Harness", null, null },
                    { 33, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9992), true, false, null, "Roads", null, null },
                    { 34, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9993), true, false, null, "Drum_Lifter", null, null },
                    { 35, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9994), true, false, null, "Working_Platform", null, null },
                    { 36, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9994), true, false, null, "Single leg chain sling", null, null },
                    { 37, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9995), true, false, null, "Portal Crane 32T", null, null }
                });

            migrationBuilder.InsertData(
                table: "MaintenancePlan",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Description", "IsActive", "IsDeleted", "MPChecked", "MetricType", "MetricTypeName", "ModifiedBy", "Name", "RemovalDate", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "POCR-1", "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(767), "Vizual Inspection", true, false, null, 1, "Period", null, "Portal Crane", null, null, null },
                    { 2, "POCR-2", "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(768), "Profilaktik Inspection", true, false, null, 2, "MotoHour", null, "Portal Crane Prof", null, null, null },
                    { 3, "FRKL-1", "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(769), "Vizual Inspection", true, false, null, 1, "Period", null, "Fork Lift", null, null, null },
                    { 4, "RAIL-1", "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(770), "Vizual Inspection of Railway", true, false, null, 1, "Period", null, "Railway", null, null, null },
                    { 5, "FRKL-2", "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(771), "Engine Oil Change", true, false, null, 1, "Period", null, "Fork Lift", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Manufactures",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "IsActive", "IsDeleted", "ModifiedBy", "Name", "RemovalDate", "RemovalReason", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(85), true, false, null, "Single leg chain sling", null, null, null },
                    { 2, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(86), true, false, null, "Working platform", null, null, null },
                    { 3, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(87), true, false, null, "Hangcha", null, null, null },
                    { 4, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(88), true, false, null, "XCMG", null, null, null },
                    { 5, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(89), true, false, null, "Kalmar", null, null, null },
                    { 6, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(90), true, false, null, "Terberq", null, null, null },
                    { 7, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(91), true, false, null, "Sisu", null, null, null },
                    { 8, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(92), true, false, null, "Toyoto", null, null, null },
                    { 9, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(92), true, false, null, "Bobkat", null, null, null },
                    { 10, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(93), true, false, null, "Hyster", null, null, null },
                    { 11, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(94), true, false, null, "Boss", null, null, null },
                    { 12, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(95), true, false, null, "Ardelt", null, null, null },
                    { 13, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(99), true, false, null, "None", null, null, null },
                    { 14, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(100), true, false, null, "VDL", null, null, null },
                    { 15, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(100), true, false, null, "Sunny", null, null, null },
                    { 16, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(101), true, false, null, "Camry", null, null, null },
                    { 17, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(102), true, false, null, "Engine", null, null, null },
                    { 18, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(103), true, false, null, "023-2 №-li dizel generator", null, null, null },
                    { 19, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(104), true, false, null, "022-1 №-li dizel generator", null, null, null },
                    { 20, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(106), true, false, null, "021-TQM 23 B48-754", null, null, null },
                    { 21, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(107), true, false, null, "Service berth-N4", null, null, null },
                    { 22, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(107), true, false, null, "Molino", null, null, null },
                    { 23, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(108), true, false, null, "Service berth-N3 ", null, null, null },
                    { 24, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(109), true, false, null, "Shackle", null, null, null },
                    { 25, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(110), true, false, null, "County", null, null, null },
                    { 26, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(111), true, false, null, "Santafe", null, null, null },
                    { 27, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(112), true, false, null, "Sonata", null, null, null },
                    { 28, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(112), true, false, null, "Kartal SLX", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "IsActive", "IsDeleted", "ModifiedBy", "Name", "RemovalDate", "RemovalReason", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(242), true, false, null, "RS45-31CH", null, null, null },
                    { 2, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(243), true, false, null, "CPCD200-W36", null, null, null },
                    { 3, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(244), true, false, null, "CPCD100-W17", null, null, null },
                    { 4, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(245), true, false, null, "CPCD40-RC24", null, null, null },
                    { 5, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(246), true, false, null, "CPCD25N-RC2", null, null, null },
                    { 6, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(247), true, false, null, "CPCD15N-RC26", null, null, null },
                    { 7, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(248), true, false, null, "XT760", null, null, null },
                    { 8, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(249), true, false, null, "DRD420-60S5", null, null, null },
                    { 9, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(249), true, false, null, "DSD420-12CSG", null, null, null },
                    { 10, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(253), true, false, null, "T-1", null, null, null },
                    { 11, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(254), true, false, null, "TV-10EIT-4x4/2600", null, null, null },
                    { 12, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(255), true, false, null, "FD-100F50", null, null, null },
                    { 13, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(256), true, false, null, "843", null, null, null },
                    { 14, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(257), true, false, null, "HS1", null, null, null },
                    { 15, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(257), true, false, null, "B1", null, null, null },
                    { 16, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(258), true, false, null, "FD-15", null, null, null },
                    { 17, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(259), true, false, null, "Kondor 1500", null, null, null },
                    { 18, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(260), true, false, null, "QAY220 All Terrain Crane", null, null, null },
                    { 19, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(261), true, false, null, "None", null, null, null },
                    { 20, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(262), true, false, null, "Sokol 500", null, null, null },
                    { 21, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(262), true, false, null, "Mobil Pnevmatik Transporter", null, null, null },
                    { 22, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(263), true, false, null, "ST 1", null, null, null },
                    { 23, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(264), true, false, null, "ST 2", null, null, null },
                    { 24, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(265), true, false, null, "ST 3", null, null, null },
                    { 25, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(266), true, false, null, "ST 4", null, null, null },
                    { 26, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(267), true, false, null, "ST 4", null, null, null },
                    { 27, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(267), true, false, null, "ST 5", null, null, null },
                    { 28, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(268), true, false, null, "ST 6", null, null, null },
                    { 29, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(269), true, false, null, "ST 7", null, null, null },
                    { 30, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(270), true, false, null, "ST 8", null, null, null },
                    { 31, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(271), true, false, null, "ST 8", null, null, null },
                    { 32, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(272), true, false, null, "ST 9", null, null, null },
                    { 33, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(272), true, false, null, "ST 10", null, null, null },
                    { 34, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(273), true, false, null, "Ferry Terminal", null, null, null },
                    { 35, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(274), true, false, null, "YT180-04", null, null, null },
                    { 36, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(275), true, false, null, "CH 6600", null, null, null },
                    { 37, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(276), true, false, null, "AM 140/76/36", null, null, null },
                    { 38, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(277), true, false, null, "VSG/020.0-2.2-6400", null, null, null },
                    { 39, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(277), true, false, null, "VSG/015.0.07.13500", null, null, null },
                    { 40, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(278), true, false, null, "VSG/016.0-2.2-5000", null, null, null },
                    { 41, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(279), true, false, null, "VSG/020.0-0.7-17500", null, null, null },
                    { 42, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(280), true, false, null, "Sabir Babayev yedək gəmisi", null, null, null },
                    { 43, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(281), true, false, null, "Ələt yedək gəmisi", null, null, null },
                    { 44, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(282), true, false, null, "Silkway yedək gəmisi", null, null, null },
                    { 45, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(282), true, false, null, "045-TQM 23 B - 48", null, null, null },
                    { 46, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(283), true, false, null, "046-MNMS-73", null, null, null },
                    { 47, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(284), true, false, null, "047-Şəfəq", null, null, null },
                    { 48, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(285), true, false, null, "048-Kür", null, null, null },
                    { 49, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(286), true, false, null, "049-Günəşli", null, null, null },
                    { 50, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(287), true, false, null, "050-Nüsrət Şirinov", null, null, null },
                    { 51, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(291), true, false, null, "051-Elxan Kazımov", null, null, null },
                    { 52, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(292), true, false, null, "052-Limançı", null, null, null },
                    { 53, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(293), true, false, null, "053-TQM 23 B48 - 2494", null, null, null },
                    { 54, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(294), true, false, null, "Nissan", null, null, null },
                    { 55, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(295), true, false, null, "Toyota", null, null, null },
                    { 56, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(295), true, false, null, "QAZ", null, null, null },
                    { 57, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(296), true, false, null, "HOWO", null, null, null },
                    { 58, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(297), true, false, null, "Fiat", null, null, null },
                    { 59, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(298), true, false, null, "111111", null, null, null },
                    { 60, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(319), true, false, null, "Vaz", null, null, null },
                    { 61, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(319), true, false, null, "Tofash", null, null, null },
                    { 62, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(320), true, false, null, "Volkswagen", null, null, null },
                    { 63, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(321), true, false, null, "Hyundai", null, null, null },
                    { 64, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(323), true, false, null, "Mersedes Benz", null, null, null },
                    { 65, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(324), true, false, null, "5 Tonne 5mtr x 26mm dia", null, null, null },
                    { 66, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(324), true, false, null, "5 Tonne 4mtr x 26mm dia", null, null, null },
                    { 67, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(325), true, false, null, "10 Tonne 5.5mtr x 32mm dia", null, null, null },
                    { 68, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(326), true, false, null, "15 Tonne 4mtr x 38mm dia", null, null, null },
                    { 69, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(327), true, false, null, "5 Tonne 3mtr x 26mm dia", null, null, null },
                    { 70, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(328), true, false, null, "8.6 Tonne 1.9mtr x26mm dia", null, null, null },
                    { 71, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(329), true, false, null, "8.6 Tonne 10 mtr x 26mm dia", null, null, null },
                    { 72, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(329), true, false, null, "6.2 Tonne 11.06mtr x 22mm dia", null, null, null },
                    { 73, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(330), true, false, null, "8.6 Tonne 10 mtr x 26mm dia", null, null, null },
                    { 74, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(331), true, false, null, "6.2 Tonne 11.06mtr x 22mm dia", null, null, null },
                    { 75, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(332), true, false, null, "6.2 Tonne 10 mtr x 22mm dia", null, null, null },
                    { 76, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(333), true, false, null, "6.2 Tonne 6 mtr x 22 mm dia", null, null, null },
                    { 77, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(336), true, false, null, "077-5.1 6 mtr x 22 mm dia", null, null, null },
                    { 78, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(337), true, false, null, "078-5.1 Tonne 1.3 mtr x 20 mm dia", null, null, null },
                    { 79, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(338), true, false, null, "079-5.1 Tonne 2.93 mtr x 20 mm dia", null, null, null },
                    { 80, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(340), true, false, null, "080-10.1 Tonne 12 mtr x 28 mm dia", null, null, null },
                    { 81, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(341), true, false, null, "081-5 Tonne 8 mtr x 20 mm dia", null, null, null },
                    { 82, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(341), true, false, null, "082-8 Tonne 8 mtr x 26 mm dia", null, null, null },
                    { 83, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(342), true, false, null, "083-10 Tonne 10 mtr x 28 mm dia", null, null, null },
                    { 84, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(343), true, false, null, "084-10.1 Tonne 6 mtr x 28 mm dia", null, null, null },
                    { 85, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(344), true, false, null, "085-10.1 Tonne 6 mtr x 28 mm dia", null, null, null },
                    { 86, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(345), true, false, null, "086-12 Tonne", null, null, null },
                    { 87, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(346), true, false, null, "087-25 Tonne", null, null, null },
                    { 88, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(347), true, false, null, "6.5 Tonne", null, null, null },
                    { 89, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(348), true, false, null, "4.75 Tonne", null, null, null },
                    { 90, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(349), true, false, null, "3.25 Tonne", null, null, null },
                    { 91, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(349), true, false, null, "8.5 Tonne", null, null, null },
                    { 92, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(350), true, false, null, "12 Tonne", null, null, null },
                    { 93, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(351), true, false, null, "12.5 Tonne", null, null, null },
                    { 94, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(352), true, false, null, "8 Tonne", null, null, null },
                    { 95, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(353), true, false, null, "3 Tonne", null, null, null },
                    { 96, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(354), true, false, null, "10 Tonne", null, null, null },
                    { 97, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(354), true, false, null, "4064 Kgs", null, null, null },
                    { 98, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(355), true, false, null, "5 Tonne", null, null, null },
                    { 99, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(356), true, false, null, "3 Tonne 1 mtr", null, null, null },
                    { 100, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(357), true, false, null, "3 Tonne 2 mtr", null, null, null },
                    { 101, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(359), true, false, null, "3 Tonne 2 mtr", null, null, null },
                    { 102, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(360), true, false, null, "3 Tonne 3 mtr", null, null, null },
                    { 103, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(360), true, false, null, "3 Tonne 5 mtr", null, null, null },
                    { 104, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(361), true, false, null, "3 Tonne 6 mtr", null, null, null },
                    { 105, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(362), true, false, null, "3 Tonne 10 mtr", null, null, null },
                    { 106, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(363), true, false, null, "106-5 tonne 3 mtr", null, null, null },
                    { 107, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(364), true, false, null, "107-5 Tonne 5 mtr", null, null, null },
                    { 108, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(365), true, false, null, "108-5 Tonne 6 mtr", null, null, null },
                    { 109, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(366), true, false, null, "109-10 Tonne 5 mtr", null, null, null },
                    { 110, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(366), true, false, null, "110-6 Tonne 4 mtr", null, null, null },
                    { 111, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(369), true, false, null, "6 Tonne 6 mtr", null, null, null },
                    { 112, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(370), true, false, null, "112-6 Tonne 10mtr", null, null, null },
                    { 113, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(373), true, false, null, "113-14 Tonne", null, null, null },
                    { 114, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(374), true, false, null, "114-15 Tonne", null, null, null },
                    { 115, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(375), true, false, null, "115-136 kgs", null, null, null },
                    { 116, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(376), true, false, null, "116-30 Tonne", null, null, null },
                    { 117, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(377), true, false, null, "117-Model: H2000/3 MFB", null, null, null },
                    { 118, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(378), true, false, null, "118-Model: KP 25", null, null, null },
                    { 119, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(378), true, false, null, "119-Model: 71022", null, null, null },
                    { 120, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(379), true, false, null, "120-2250 kgs", null, null, null },
                    { 121, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(380), true, false, null, "121-1.5 Tonne", null, null, null },
                    { 122, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(381), true, false, null, "122-SİNGLE LİNE LANYARD", null, null, null },
                    { 123, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(382), true, false, null, "123-Takelaj sahəsi", null, null, null },
                    { 124, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(383), true, false, null, "8 Tonne 8 mtr", null, null, null },
                    { 125, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(384), true, false, null, "8 Tonne 6mtr", null, null, null },
                    { 126, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(385), true, false, null, "126- Qarmaq   KE-40", null, null, null },
                    { 127, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(385), true, false, null, "127-Qarmaq    KE-80", null, null, null },
                    { 128, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(386), true, false, null, "128-Qarmaq   KE-32", null, null, null },
                    { 129, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(387), true, false, null, "10 Tonee x 3 mtr x 28 dia", null, null, null },
                    { 130, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(388), true, false, null, "3 tonne x 1.5 mtr x 20 mm", null, null, null },
                    { 131, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(389), true, false, null, "7 Tonne", null, null, null },
                    { 132, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(389), true, false, null, "3 tonne x 1 mtr", null, null, null },
                    { 133, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(412), true, false, null, "10 Tonne 6 mtr", null, null, null },
                    { 134, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(413), true, false, null, "10 tonne 4 mtr", null, null, null },
                    { 135, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(414), true, false, null, "1 tonne 2mtr", null, null, null },
                    { 136, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(415), true, false, null, "5 tonne 10 mtr", null, null, null },
                    { 137, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(415), true, false, null, "8 Tonne 2mtr", null, null, null },
                    { 138, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(417), true, false, null, "10 Tonne 10 mtr", null, null, null },
                    { 139, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(418), true, false, null, "17 Tonne", null, null, null },
                    { 140, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(419), true, false, null, "3.2 tonne x  3 mtr x 16 mm", null, null, null },
                    { 141, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(419), true, false, null, "10 tonne x 5.5 mtr x 28 mm", null, null, null },
                    { 142, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(420), true, false, null, "10 tonne x 5 mtr x 28 mm", null, null, null },
                    { 143, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(421), true, false, null, "10 tonne x 4 mtr x 28 mm", null, null, null },
                    { 144, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(422), true, false, null, "10 Tonne x 6 mtr x 28 mm", null, null, null },
                    { 145, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(423), true, false, null, "6.2 Tonne x 3mtr x 22mm", null, null, null },
                    { 146, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(423), true, false, null, "6.2 Tonne x 5 mtr x 22mm", null, null, null },
                    { 147, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(424), true, false, null, "18.5 Tonne x 3 mtr x 38 mm", null, null, null },
                    { 148, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(425), true, false, null, "18.5 Tonne x 5 mtr x 38 mm", null, null, null },
                    { 149, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(426), true, false, null, "2 tonne 2 mtr", null, null, null },
                    { 150, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(427), true, false, null, "1.74mtr x 4.24mtr x 1.32mtr - 300kgs", null, null, null },
                    { 151, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(428), true, false, null, "400 kgs", null, null, null },
                    { 152, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(428), true, false, null, "18.5 Tonne x 8 mtr x 38 mm", null, null, null },
                    { 153, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(429), true, false, null, "10 Tonne x 12 mtr x 28 mm", null, null, null },
                    { 154, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(430), true, false, null, "5.3  Tonne x 15 mtr x 13 mm", null, null, null },
                    { 155, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(431), true, false, null, "8 tonne 4 mtr", null, null, null },
                    { 156, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(432), true, false, null, "85 Tonne", null, null, null },
                    { 157, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(433), true, false, null, "35 Tonne", null, null, null },
                    { 158, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(434), true, false, null, "9.5 Tonne", null, null, null },
                    { 159, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(434), true, false, null, "13.5 tonne", null, null, null },
                    { 160, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(435), true, false, null, "10 Tonne x 8 mtr x 28 mm", null, null, null },
                    { 161, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(436), true, false, null, "161-İnzibati bina CR-2 və qazanxan HB-1", null, null, null },
                    { 162, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(437), true, false, null, "162-Ümumi yük terminalı binaları CR-7 , CR-9 , CR-8", null, null, null },
                    { 163, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(438), true, false, null, "163-Texniki xidmət binaları CR-3, CR-4, CR-10, CR-15, CR-16, WS-3", null, null, null },
                    { 164, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(438), true, false, null, "164-RO-RO terminalı binaları CR-17, FS-5 , FS-10, FS-11, FS-16, FS-17, FS-18", null, null, null },
                    { 165, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(439), true, false, null, "165-BƏRƏ terminalı binaları FS-3, FS-9, FS-12, FS-13, FS-14 , FS-19", null, null, null },
                    { 166, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(440), true, false, null, "166-DƏMİRYOLU binaları RM-1, RM-2 ,RM-4 ,RM-5, RM-6, RM- 7, RM-8, RM-13, RM-14, RM15, RM-16", null, null, null },
                    { 167, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(441), true, false, null, "167-Mühafizə xidməti binaları AB-1, AB-2, AB-7", null, null, null },
                    { 168, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(442), true, false, null, "142 tonne x 3,4 mtr x 56 mm", null, null, null },
                    { 169, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(443), true, false, null, "50 Tonne", null, null, null },
                    { 170, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(444), true, false, null, "300 kgs", null, null, null },
                    { 171, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(444), true, false, null, "4 tonne 2 mtr", null, null, null },
                    { 172, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(445), true, false, null, "172-Abşeron Neft Terminalı binaları", null, null, null },
                    { 173, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(446), true, false, null, "173-Abşeron Neft Terminalı hidrotexniki qurğuları 1 saylı körpü", null, null, null },
                    { 174, null, null, null, true, false, null, "174-Abşeron Neft Terminalı hidrotexniki qurğuları 3 saylı körpü", null, null, null },
                    { 175, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(447), true, false, null, "175-Dəniz vağzalı binası", null, null, null },
                    { 176, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(448), true, false, null, "176-Dəniz vağzalı hidrotexniki qurğuları", null, null, null },
                    { 177, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(449), true, false, null, "177-İdarə binası və mədəniyyət evi", null, null, null },
                    { 178, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(450), true, false, null, "178-Qaradağ mülki-müdafiə binaları", null, null, null },
                    { 179, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(451), true, false, null, "179-Liman ərazisi yollar (Kargo , Ro-Ro , Bərə terminal)", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Parts",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "IsActive", "IsDeleted", "ModifiedBy", "Name", "RemovalDate", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(677), true, false, null, "Oil Filter", null, null },
                    { 2, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(678), true, false, null, "Air Filter", null, null },
                    { 3, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(679), true, false, null, "Engine Oil", null, null },
                    { 4, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(680), true, false, null, "TransMission Oil", null, null },
                    { 5, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(681), true, false, null, "Gear_Box Oil", null, null },
                    { 6, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(684), true, false, null, "Wheels", null, null },
                    { 7, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(684), true, false, null, "Antifiriz", null, null },
                    { 8, null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(685), true, false, null, "Break pads", null, null }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsActive", "IsDeleted", "MaintenancePlanId", "ModifiedBy", "Name", "PartId", "PartName", "RemovalDate", "ServiceDescription", "ServiceType", "UpdatedDate" },
                values: new object[,]
                {
                    { 3, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(849), true, false, null, null, "Engine Oil Change", null, null, null, "Engine Oil change", "Refill", null },
                    { 4, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(850), true, false, null, null, "Engine Oil Change", null, null, null, "Engine Oil change", "Refill", null }
                });

            migrationBuilder.InsertData(
                table: "OperationSites",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "DepartmentId", "IsActive", "IsDeleted", "ModifiedBy", "Name", "RemovalDate", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 0, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9847), 1, true, false, null, "Building_1", null, null },
                    { 2, 0, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9848), 1, true, false, null, "Building_2", null, null },
                    { 3, 0, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9849), 1, true, false, null, "OperationArea_1", null, null },
                    { 4, 0, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9850), 5, true, false, null, "WareHause_1", null, null },
                    { 5, 0, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9851), 5, true, false, null, "WareHause_2", null, null },
                    { 6, 0, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9852), 6, true, false, null, "WareHause_3", null, null },
                    { 7, 0, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9853), 3, true, false, null, "OperationArea_2", null, null },
                    { 8, 0, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9854), 2, true, false, null, "ST-1", null, null },
                    { 9, 0, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9855), 2, true, false, null, "ST-2", null, null },
                    { 10, 0, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9856), 3, true, false, null, "ST-3", null, null },
                    { 11, 0, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9857), 3, true, false, null, "ST-4", null, null },
                    { 12, 0, "System", new DateTime(2023, 9, 4, 12, 5, 37, 260, DateTimeKind.Utc).AddTicks(9858), 4, true, false, null, "ST-5", null, null }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsActive", "IsDeleted", "MaintenancePlanId", "ModifiedBy", "Name", "PartId", "PartName", "RemovalDate", "ServiceDescription", "ServiceType", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(846), true, false, 5, null, "Engine Oil ", null, null, null, "Engine Oil change", "Refill", null },
                    { 2, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(848), true, false, 5, null, "Engine Oil Filter", null, null, null, "Engine Oil filter change", "Replace", null }
                });

            migrationBuilder.InsertData(
                table: "Equipments",
                columns: new[] { "Id", "Capacity", "Color", "CreatedBy", "CreatedDate", "CurrentValue", "DepartmentId", "Description", "EquipmentTypeId", "Identification", "ImagUrl", "IsActive", "IsDeleted", "IsIdle", "IsNotified", "LastMaintenaceDate", "ManufactureId", "ModelId", "ModifiedBy", "MpCompleted", "Name", "OperationSiteid", "ProductionYear", "RemovalDate", "ResetValue", "SeriaNumber", "SquenceValue", "Status", "UnitNumber", "UpdatedDate", "usageLocation" },
                values: new object[,]
                {
                    { 1, "2000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(960), 145m, 1, "Cargo Handling equipment", 1, "no", "forklift.jpeg", true, false, true, false, null, 10, 14, null, true, "ForkLift-1 ", 4, 1998, null, null, null, null, 1, "FK-100000", null, 2 },
                    { 2, "4000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(967), 450m, 1, "Cargo Handling equipment", 2, "no", "forklift.jpeg", true, false, true, false, null, 9, 13, null, true, "ForkLift-2", 3, 2004, null, null, null, null, 1, "FK-100001", null, 2 },
                    { 3, "40000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(970), 500m, 1, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "Crane-3 ", 3, 2003, null, null, null, null, 1, "CR-100003", null, 6 },
                    { 4, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(972), 320m, 1, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "Buldozer-4 ", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 5, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(974), 320m, 1, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "Buldozer-5 ", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 6, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(977), 320m, 1, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "Buldozer-6 ", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 7, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(979), 320m, 1, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "ReachStacker-7", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 8, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(981), 320m, 1, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "ReachStacker-8", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 9, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(984), 320m, 1, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "ReachStacker-9", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 10, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(986), 320m, 1, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "ReachStacker-10", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 11, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(988), 320m, 2, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "Truck-11", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 12, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(991), 320m, 2, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "Truck-12", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 13, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(993), 320m, 2, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "Truck-13", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 14, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(995), 320m, 2, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "Truck-14", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 15, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(997), 320m, 2, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "Platform-15", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 16, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1003), 320m, 2, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "MiniBus-16", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 17, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1026), 320m, 6, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "Minibus-17", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 18, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1028), 320m, 6, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "Tractor-18", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 19, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1031), 320m, 6, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "Tractor-19", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 20, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1036), 320m, 2, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "Spreider-20", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 21, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1039), 320m, 3, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "Building001-21", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 22, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1041), 320m, 3, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "Building002-22", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 23, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1044), 320m, 3, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "Building003-23", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 24, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1046), 320m, 5, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "Car-24", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 25, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1048), 320m, 5, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "Car-25", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 26, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1050), 320m, 5, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "Car-26", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 27, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1053), 320m, 3, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "Station-27", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 28, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1056), 320m, 3, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "Station-28", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 29, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1058), 320m, 3, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "ElectroCar-29", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 30, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1060), 320m, 5, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "ElectroCar-30", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 31, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1063), 320m, 3, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "ElectroCar-31", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 32, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1065), 320m, 3, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "ElectroCar-32", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 33, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1067), 320m, 5, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "ElectroCar-33", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 34, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1069), 320m, 6, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "ElectroCar-34", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 35, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1076), 320m, 6, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "ElectroCar-35", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 36, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1078), 320m, 4, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "Crane-36", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 37, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1100), 320m, 4, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "Crane-37", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 38, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1102), 320m, 4, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "Crane-38", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 39, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1104), 320m, 4, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "Crane-39", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 40, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1106), 320m, 4, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "Crane-40", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 41, "2000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1108), 145m, 7, "Cargo Handling equipment", 1, "no", "forklift.jpeg", true, false, true, false, null, 10, 14, null, true, "ForkLift-41 ", 4, 1998, null, null, null, null, 1, "FK-100000", null, 2 },
                    { 42, "4000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1111), 450m, 7, "Cargo Handling equipment", 2, "no", "forklift.jpeg", true, false, true, false, null, 9, 13, null, true, "ForkLift-42", 3, 2004, null, null, null, null, 1, "FK-100001", null, 2 },
                    { 43, "40000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1114), 500m, 7, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "Crane-43 ", 3, 2003, null, null, null, null, 1, "CR-100003", null, 6 },
                    { 44, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1116), 320m, 8, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "Buldozer-44 ", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 45, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1118), 320m, 8, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "Buldozer-45 ", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 46, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1121), 320m, 8, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "Buldozer-46 ", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 47, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1127), 320m, 8, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "ReachStacker-47", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 48, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1129), 320m, 8, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "ReachStacker-48", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 49, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1133), 320m, 8, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "ReachStacker-49", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 50, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1135), 320m, 9, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "ReachStacker-50", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 51, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1137), 320m, 9, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "Truck-51", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 52, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1139), 320m, 9, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "Truck-52", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 53, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1143), 320m, 9, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "Truck-53", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 54, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1145), 320m, 9, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "Truck-54", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 55, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1147), 320m, 9, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "Platform-55", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 56, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1149), 320m, 10, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "MiniBus-56", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 57, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1171), 320m, 10, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "Minibus-57", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 58, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1174), 320m, 10, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "Tractor-58", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 59, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1176), 320m, 10, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "Tractor-59", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 60, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1179), 320m, 10, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "Spreider-60", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 61, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1181), 320m, 10, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "Building001-61", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 62, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1183), 320m, 10, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "Building002-62", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 63, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1186), 320m, 10, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "Building003-63", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 64, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1192), 320m, 1, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "Car-64", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 65, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1194), 320m, 1, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "Car-65", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 66, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1196), 320m, 1, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "Car-66", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 67, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1199), 320m, 3, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "Station-67", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 68, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1201), 320m, 3, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "Station-68", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 69, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1204), 320m, 2, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "ElectroCar-69", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 70, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1206), 320m, 2, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "ElectroCar-70", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 71, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1209), 320m, 2, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "ElectroCar-71", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 72, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1211), 320m, 2, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "ElectroCar-72", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 73, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1213), 320m, 11, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "ElectroCar-73", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 74, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1215), 320m, 11, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "ElectroCar-74", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 75, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1219), 320m, 11, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "ElectroCar-75", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 76, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1221), 320m, 11, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "Crane-76", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 77, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1255), 320m, 11, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "Crane-77", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 78, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1257), 320m, 11, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "Crane-78", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 79, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1260), 320m, 11, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "Crane-79", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 },
                    { 80, "80000 ton", null, "System", new DateTime(2023, 9, 4, 12, 5, 37, 261, DateTimeKind.Utc).AddTicks(1262), 320m, 4, "Cargo Lifting equipment", 4, "no", "forklift.jpeg", true, false, true, false, null, 4, 17, null, true, "Crane-80", 6, 2010, null, null, null, null, 1, "CR-100004", null, 6 }
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
                name: "IX_Equipments_EquipmentTypeId",
                table: "Equipments",
                column: "EquipmentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_ManufactureId",
                table: "Equipments",
                column: "ManufactureId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_ModelId",
                table: "Equipments",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_OperationSiteid",
                table: "Equipments",
                column: "OperationSiteid");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceSettings_EquipmentId",
                table: "MaintenanceSettings",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceSettings_MaintenancePlanId",
                table: "MaintenanceSettings",
                column: "MaintenancePlanId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationSites_DepartmentId",
                table: "OperationSites",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_MaintenancePlanId",
                table: "Services",
                column: "MaintenancePlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_PartId",
                table: "Services",
                column: "PartId");

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
                name: "MaintenanceAct");

            migrationBuilder.DropTable(
                name: "MaintenanceSettings");

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
                name: "MaintenancePlan");

            migrationBuilder.DropTable(
                name: "Parts");

            migrationBuilder.DropTable(
                name: "Equipments");

            migrationBuilder.DropTable(
                name: "EquipmentType");

            migrationBuilder.DropTable(
                name: "Manufactures");

            migrationBuilder.DropTable(
                name: "Models");

            migrationBuilder.DropTable(
                name: "OperationSites");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
