using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class FloorsEd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BarcodeMasters",
                columns: table => new
                {
                    BarcodeMasterId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenerateQRCode = table.Column<string>(nullable: true),
                    QRCodeImage = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2022, 10, 29, 18, 8, 54, 404, DateTimeKind.Local).AddTicks(3261)),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BarcodeMasters", x => x.BarcodeMasterId);
                });

            migrationBuilder.CreateTable(
                name: "BedMasters",
                columns: table => new
                {
                    BedMasterId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FloorNoid = table.Column<int>(nullable: false),
                    WordNo = table.Column<string>(nullable: true),
                    RoomNo = table.Column<string>(nullable: true),
                    BedNo = table.Column<string>(nullable: true),
                    PricePerHour = table.Column<string>(nullable: true),
                    status = table.Column<string>(nullable: true),
                    OcupiedId = table.Column<int>(nullable: false),
                    HospitalMasterid = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2022, 10, 29, 18, 8, 54, 402, DateTimeKind.Local).AddTicks(7734)),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BedMasters", x => x.BedMasterId);
                });

            migrationBuilder.CreateTable(
                name: "BedPatientMasters",
                columns: table => new
                {
                    BedPatientMasterid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bedid = table.Column<int>(nullable: false),
                    PatientId = table.Column<int>(nullable: false),
                    EntryDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2022, 10, 29, 18, 8, 54, 403, DateTimeKind.Local).AddTicks(4086)),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BedPatientMasters", x => x.BedPatientMasterid);
                });

            migrationBuilder.CreateTable(
                name: "DieticianMasters",
                columns: table => new
                {
                    DieticianMasterId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HospitalMasterid = table.Column<int>(nullable: false),
                    DieticianName = table.Column<string>(nullable: true),
                    MobileNo = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    EmployeeId = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    RePassword = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2022, 10, 29, 18, 8, 54, 403, DateTimeKind.Local).AddTicks(7308)),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DieticianMasters", x => x.DieticianMasterId);
                });

            migrationBuilder.CreateTable(
                name: "DIETMasters",
                columns: table => new
                {
                    DIETMasterId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientName = table.Column<string>(nullable: true),
                    BedId = table.Column<int>(nullable: true),
                    FoodType = table.Column<string>(nullable: true),
                    SpecialInstruction = table.Column<string>(nullable: true),
                    HospitalMasterid = table.Column<int>(nullable: true),
                    FoodTypeid = table.Column<int>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2022, 10, 29, 18, 8, 54, 404, DateTimeKind.Local).AddTicks(394)),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    DoctorName = table.Column<string>(nullable: true),
                    status = table.Column<string>(nullable: true),
                    PlateReciveDate = table.Column<DateTime>(nullable: true),
                    PlateDeliverDate = table.Column<DateTime>(nullable: true),
                    PlateCollectionDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIETMasters", x => x.DIETMasterId);
                });

            migrationBuilder.CreateTable(
                name: "FloorMasters",
                columns: table => new
                {
                    FloorMasterId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FloorName = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FloorMasters", x => x.FloorMasterId);
                });

            migrationBuilder.CreateTable(
                name: "FoodProviderLogins",
                columns: table => new
                {
                    FoodProviderLoginId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodProviderName = table.Column<string>(nullable: true),
                    MobileNo = table.Column<string>(nullable: true),
                    EmpId = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    RePassword = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2022, 10, 29, 18, 8, 54, 404, DateTimeKind.Local).AddTicks(8732)),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodProviderLogins", x => x.FoodProviderLoginId);
                });

            migrationBuilder.CreateTable(
                name: "FoodTypeMasters",
                columns: table => new
                {
                    FoodTypeMasterId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodTypeName = table.Column<string>(nullable: true),
                    FoodType = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2022, 10, 29, 18, 8, 54, 404, DateTimeKind.Local).AddTicks(6188)),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodTypeMasters", x => x.FoodTypeMasterId);
                });

            migrationBuilder.CreateTable(
                name: "HospitalMasters",
                columns: table => new
                {
                    HospitalMasterid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HospitalName = table.Column<string>(nullable: true),
                    Address1 = table.Column<string>(nullable: true),
                    Address2 = table.Column<string>(nullable: true),
                    ContactPerson = table.Column<string>(nullable: true),
                    ContactPersonNo = table.Column<string>(nullable: true),
                    MobileNo = table.Column<string>(nullable: true),
                    FloorNo = table.Column<string>(nullable: true),
                    HospitalLogo = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2022, 10, 29, 18, 8, 54, 399, DateTimeKind.Local).AddTicks(1872)),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HospitalMasters", x => x.HospitalMasterid);
                });

            migrationBuilder.CreateTable(
                name: "LogHistory",
                columns: table => new
                {
                    LogId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogCode = table.Column<string>(nullable: true),
                    LogDate = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    LogInTime = table.Column<DateTime>(nullable: false),
                    LogOutTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogHistory", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    MenuID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentID = table.Column<int>(nullable: false),
                    MenuTitle = table.Column<string>(maxLength: 100, nullable: false),
                    URL = table.Column<string>(maxLength: 500, nullable: true),
                    IsSubMenu = table.Column<int>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    IconClass = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    AddedBy = table.Column<int>(nullable: false),
                    IsMigrationData = table.Column<bool>(nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(nullable: true),
                    LastUpdatedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.MenuID);
                });

            migrationBuilder.CreateTable(
                name: "MenuGroup",
                columns: table => new
                {
                    MenuGroupID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuGroupName = table.Column<string>(maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    AddedBy = table.Column<int>(nullable: false),
                    IsMigrationData = table.Column<bool>(nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(nullable: true),
                    LastUpdatedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuGroup", x => x.MenuGroupID);
                });

            migrationBuilder.CreateTable(
                name: "MenuGroupWiseMenuMapping",
                columns: table => new
                {
                    MenuGroupWiseMenuMappingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuGroupId = table.Column<int>(nullable: false),
                    MenuId = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsMigrationData = table.Column<bool>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    AddedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuGroupWiseMenuMapping", x => x.MenuGroupWiseMenuMappingId);
                });

            migrationBuilder.CreateTable(
                name: "PatientMasters",
                columns: table => new
                {
                    PatientMasterid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientName = table.Column<string>(nullable: true),
                    Age = table.Column<string>(nullable: true),
                    MobileNo = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    AdmissionDate = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    OutDate = table.Column<DateTime>(nullable: false),
                    OutTime = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2022, 10, 29, 18, 8, 54, 403, DateTimeKind.Local).AddTicks(1005)),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientMasters", x => x.PatientMasterid);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    UserRoleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(maxLength: 100, nullable: false),
                    RoleDesc = table.Column<string>(maxLength: 500, nullable: true),
                    MenuGroupId = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    AddedBy = table.Column<int>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    IsMigrationData = table.Column<bool>(nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(nullable: true),
                    LastUpdatedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => x.UserRoleId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserRoleId = table.Column<int>(nullable: false),
                    FullName = table.Column<string>(maxLength: 100, nullable: false),
                    Mobile = table.Column<string>(maxLength: 100, nullable: true),
                    Email = table.Column<string>(maxLength: 100, nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: true),
                    ImagePath = table.Column<string>(maxLength: 500, nullable: true),
                    UserName = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<string>(maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    AddedBy = table.Column<int>(nullable: false),
                    IsMigrationData = table.Column<bool>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    LastPasswordChangeDate = table.Column<DateTime>(nullable: true),
                    PasswordChangedBy = table.Column<int>(nullable: true),
                    IsPasswordChange = table.Column<bool>(nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(nullable: true),
                    LastUpdatedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "MenuID", "AddedBy", "DateAdded", "IconClass", "IsActive", "IsMigrationData", "IsSubMenu", "LastUpdatedBy", "LastUpdatedDate", "MenuTitle", "ParentID", "SortOrder", "URL" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 10, 29, 18, 8, 54, 396, DateTimeKind.Local).AddTicks(6258), "fas fa-home", true, true, 0, null, null, "Dashboard", 0, 1, "/DashBoard/Index" },
                    { 10, 1, new DateTime(2022, 10, 29, 18, 8, 54, 396, DateTimeKind.Local).AddTicks(7557), "", true, true, 0, null, null, "Change Password", 9, 0, "/User/ChangePassword" },
                    { 8, 1, new DateTime(2022, 10, 29, 18, 8, 54, 396, DateTimeKind.Local).AddTicks(7553), "", true, true, 0, null, null, "Profile", 5, 0, "/User/UserProfile" },
                    { 7, 1, new DateTime(2022, 10, 29, 18, 8, 54, 396, DateTimeKind.Local).AddTicks(7551), "", true, true, 0, null, null, "Role List", 5, 0, "/User/RoleList" },
                    { 6, 1, new DateTime(2022, 10, 29, 18, 8, 54, 396, DateTimeKind.Local).AddTicks(7549), "", true, true, 0, null, null, "User List", 5, 0, "/User/UserList" },
                    { 9, 1, new DateTime(2022, 10, 29, 18, 8, 54, 396, DateTimeKind.Local).AddTicks(7555), "fas fa-wrench", true, true, 1, null, null, "Settings", 0, 4, "" },
                    { 4, 1, new DateTime(2022, 10, 29, 18, 8, 54, 396, DateTimeKind.Local).AddTicks(7545), "", true, true, 0, null, null, "Menu Group List", 2, 0, "/Menu/MenuGroupList" },
                    { 3, 1, new DateTime(2022, 10, 29, 18, 8, 54, 396, DateTimeKind.Local).AddTicks(7543), "", true, true, 0, null, null, "Menu List", 2, 0, "/Menu/MenuList" },
                    { 2, 1, new DateTime(2022, 10, 29, 18, 8, 54, 396, DateTimeKind.Local).AddTicks(7484), "fas fa-ellipsis-v", true, true, 1, null, null, "Menu", 0, 2, "" },
                    { 5, 1, new DateTime(2022, 10, 29, 18, 8, 54, 396, DateTimeKind.Local).AddTicks(7548), "fas fa-user", true, true, 1, null, null, "User", 0, 3, "" }
                });

            migrationBuilder.InsertData(
                table: "MenuGroup",
                columns: new[] { "MenuGroupID", "AddedBy", "DateAdded", "IsActive", "IsMigrationData", "LastUpdatedBy", "LastUpdatedDate", "MenuGroupName" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 10, 29, 18, 8, 54, 388, DateTimeKind.Local).AddTicks(8966), true, true, null, null, "Super Admin Group" },
                    { 2, 1, new DateTime(2022, 10, 29, 18, 8, 54, 390, DateTimeKind.Local).AddTicks(2387), true, true, null, null, "User Group" }
                });

            migrationBuilder.InsertData(
                table: "MenuGroupWiseMenuMapping",
                columns: new[] { "MenuGroupWiseMenuMappingId", "AddedBy", "DateAdded", "IsActive", "IsMigrationData", "MenuGroupId", "MenuId" },
                values: new object[,]
                {
                    { 7, 1, new DateTime(2022, 10, 29, 18, 8, 54, 398, DateTimeKind.Local).AddTicks(5192), true, true, 1, 10 },
                    { 10, 1, new DateTime(2022, 10, 29, 18, 8, 54, 398, DateTimeKind.Local).AddTicks(5197), true, true, 2, 10 },
                    { 9, 1, new DateTime(2022, 10, 29, 18, 8, 54, 398, DateTimeKind.Local).AddTicks(5195), true, true, 2, 8 },
                    { 8, 1, new DateTime(2022, 10, 29, 18, 8, 54, 398, DateTimeKind.Local).AddTicks(5193), true, true, 2, 1 },
                    { 6, 1, new DateTime(2022, 10, 29, 18, 8, 54, 398, DateTimeKind.Local).AddTicks(5190), true, true, 1, 8 },
                    { 1, 1, new DateTime(2022, 10, 29, 18, 8, 54, 398, DateTimeKind.Local).AddTicks(3875), true, true, 1, 1 },
                    { 4, 1, new DateTime(2022, 10, 29, 18, 8, 54, 398, DateTimeKind.Local).AddTicks(5187), true, true, 1, 6 },
                    { 3, 1, new DateTime(2022, 10, 29, 18, 8, 54, 398, DateTimeKind.Local).AddTicks(5185), true, true, 1, 4 },
                    { 2, 1, new DateTime(2022, 10, 29, 18, 8, 54, 398, DateTimeKind.Local).AddTicks(5150), true, true, 1, 3 },
                    { 5, 1, new DateTime(2022, 10, 29, 18, 8, 54, 398, DateTimeKind.Local).AddTicks(5189), true, true, 1, 7 }
                });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "UserRoleId", "AddedBy", "DateAdded", "IsActive", "IsMigrationData", "LastUpdatedBy", "LastUpdatedDate", "MenuGroupId", "RoleDesc", "RoleName" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 10, 29, 18, 8, 54, 392, DateTimeKind.Local).AddTicks(7956), true, true, null, null, 1, null, "Admin" },
                    { 2, 1, new DateTime(2022, 10, 29, 18, 8, 54, 392, DateTimeKind.Local).AddTicks(8903), true, true, null, null, 2, null, "User" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "AddedBy", "DateAdded", "DateOfBirth", "Email", "FullName", "ImagePath", "IsActive", "IsMigrationData", "IsPasswordChange", "LastPasswordChangeDate", "LastUpdatedBy", "LastUpdatedDate", "Mobile", "Password", "PasswordChangedBy", "UserName", "UserRoleId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 10, 29, 18, 8, 54, 394, DateTimeKind.Local).AddTicks(2574), null, null, "Appman", null, true, true, false, null, null, null, null, "Appman@2019", null, "developer", 1 },
                    { 2, 1, new DateTime(2022, 10, 29, 18, 8, 54, 394, DateTimeKind.Local).AddTicks(3994), null, null, "Helen Smith", null, true, true, false, null, null, null, null, "user@2020", null, "user@2020", 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BarcodeMasters");

            migrationBuilder.DropTable(
                name: "BedMasters");

            migrationBuilder.DropTable(
                name: "BedPatientMasters");

            migrationBuilder.DropTable(
                name: "DieticianMasters");

            migrationBuilder.DropTable(
                name: "DIETMasters");

            migrationBuilder.DropTable(
                name: "FloorMasters");

            migrationBuilder.DropTable(
                name: "FoodProviderLogins");

            migrationBuilder.DropTable(
                name: "FoodTypeMasters");

            migrationBuilder.DropTable(
                name: "HospitalMasters");

            migrationBuilder.DropTable(
                name: "LogHistory");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "MenuGroup");

            migrationBuilder.DropTable(
                name: "MenuGroupWiseMenuMapping");

            migrationBuilder.DropTable(
                name: "PatientMasters");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
