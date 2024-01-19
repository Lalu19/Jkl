using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class PatientTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PatientMasters");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PatientType",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 7, 15, 28, 42, 305, DateTimeKind.Local).AddTicks(9470),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 7, 15, 22, 13, 28, DateTimeKind.Local).AddTicks(6725));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "HospitalMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 7, 15, 28, 42, 296, DateTimeKind.Local).AddTicks(1458),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 7, 15, 22, 13, 24, DateTimeKind.Local).AddTicks(1775));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodTypeMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 7, 15, 28, 42, 304, DateTimeKind.Local).AddTicks(4310),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 7, 15, 22, 13, 28, DateTimeKind.Local).AddTicks(460));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodProviderLogins",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 7, 15, 28, 42, 304, DateTimeKind.Local).AddTicks(9264),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 7, 15, 22, 13, 28, DateTimeKind.Local).AddTicks(2647));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FloorMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 7, 15, 28, 42, 305, DateTimeKind.Local).AddTicks(4473),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 7, 15, 22, 13, 28, DateTimeKind.Local).AddTicks(4700));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DIETMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 7, 15, 28, 42, 303, DateTimeKind.Local).AddTicks(9654),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 7, 15, 22, 13, 27, DateTimeKind.Local).AddTicks(8246));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DieticianMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 7, 15, 28, 42, 303, DateTimeKind.Local).AddTicks(4720),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 7, 15, 22, 13, 27, DateTimeKind.Local).AddTicks(6120));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedPatientMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 7, 15, 28, 42, 303, DateTimeKind.Local).AddTicks(30),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 7, 15, 22, 13, 27, DateTimeKind.Local).AddTicks(3996));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 7, 15, 28, 42, 302, DateTimeKind.Local).AddTicks(4951),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 7, 15, 22, 13, 26, DateTimeKind.Local).AddTicks(9559));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 28, 42, 291, DateTimeKind.Local).AddTicks(7989));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 28, 42, 292, DateTimeKind.Local).AddTicks(131));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 28, 42, 292, DateTimeKind.Local).AddTicks(233));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 28, 42, 292, DateTimeKind.Local).AddTicks(240));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 28, 42, 292, DateTimeKind.Local).AddTicks(245));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 28, 42, 292, DateTimeKind.Local).AddTicks(250));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 28, 42, 292, DateTimeKind.Local).AddTicks(256));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 28, 42, 292, DateTimeKind.Local).AddTicks(261));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 28, 42, 292, DateTimeKind.Local).AddTicks(266));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 28, 42, 292, DateTimeKind.Local).AddTicks(270));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 28, 42, 279, DateTimeKind.Local).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 28, 42, 281, DateTimeKind.Local).AddTicks(3443));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 28, 42, 294, DateTimeKind.Local).AddTicks(7275));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 28, 42, 294, DateTimeKind.Local).AddTicks(9662));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 28, 42, 294, DateTimeKind.Local).AddTicks(9727));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 28, 42, 294, DateTimeKind.Local).AddTicks(9732));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 28, 42, 294, DateTimeKind.Local).AddTicks(9735));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 28, 42, 294, DateTimeKind.Local).AddTicks(9739));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 28, 42, 294, DateTimeKind.Local).AddTicks(9742));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 28, 42, 294, DateTimeKind.Local).AddTicks(9745));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 28, 42, 294, DateTimeKind.Local).AddTicks(9748));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 28, 42, 294, DateTimeKind.Local).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 28, 42, 285, DateTimeKind.Local).AddTicks(9035));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 28, 42, 286, DateTimeKind.Local).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 28, 42, 288, DateTimeKind.Local).AddTicks(3327));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 28, 42, 288, DateTimeKind.Local).AddTicks(5710));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PatientType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 7, 15, 22, 13, 28, DateTimeKind.Local).AddTicks(6725),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 7, 15, 28, 42, 305, DateTimeKind.Local).AddTicks(9470));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "HospitalMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 7, 15, 22, 13, 24, DateTimeKind.Local).AddTicks(1775),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 7, 15, 28, 42, 296, DateTimeKind.Local).AddTicks(1458));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodTypeMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 7, 15, 22, 13, 28, DateTimeKind.Local).AddTicks(460),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 7, 15, 28, 42, 304, DateTimeKind.Local).AddTicks(4310));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodProviderLogins",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 7, 15, 22, 13, 28, DateTimeKind.Local).AddTicks(2647),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 7, 15, 28, 42, 304, DateTimeKind.Local).AddTicks(9264));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FloorMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 7, 15, 22, 13, 28, DateTimeKind.Local).AddTicks(4700),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 7, 15, 28, 42, 305, DateTimeKind.Local).AddTicks(4473));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DIETMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 7, 15, 22, 13, 27, DateTimeKind.Local).AddTicks(8246),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 7, 15, 28, 42, 303, DateTimeKind.Local).AddTicks(9654));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DieticianMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 7, 15, 22, 13, 27, DateTimeKind.Local).AddTicks(6120),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 7, 15, 28, 42, 303, DateTimeKind.Local).AddTicks(4720));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedPatientMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 7, 15, 22, 13, 27, DateTimeKind.Local).AddTicks(3996),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 7, 15, 28, 42, 303, DateTimeKind.Local).AddTicks(30));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 7, 15, 22, 13, 26, DateTimeKind.Local).AddTicks(9559),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 7, 15, 28, 42, 302, DateTimeKind.Local).AddTicks(4951));

            migrationBuilder.CreateTable(
                name: "PatientMasters",
                columns: table => new
                {
                    PatientMasterid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Age = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 12, 7, 15, 22, 13, 27, DateTimeKind.Local).AddTicks(1880)),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    MobileNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OutTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientMasters", x => x.PatientMasterid);
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 22, 13, 22, DateTimeKind.Local).AddTicks(4397));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 22, 13, 22, DateTimeKind.Local).AddTicks(5239));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 22, 13, 22, DateTimeKind.Local).AddTicks(5282));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 22, 13, 22, DateTimeKind.Local).AddTicks(5284));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 22, 13, 22, DateTimeKind.Local).AddTicks(5286));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 22, 13, 22, DateTimeKind.Local).AddTicks(5288));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 22, 13, 22, DateTimeKind.Local).AddTicks(5289));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 22, 13, 22, DateTimeKind.Local).AddTicks(5291));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 22, 13, 22, DateTimeKind.Local).AddTicks(5293));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 22, 13, 22, DateTimeKind.Local).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 22, 13, 16, DateTimeKind.Local).AddTicks(8065));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 22, 13, 17, DateTimeKind.Local).AddTicks(6787));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 22, 13, 23, DateTimeKind.Local).AddTicks(6329));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 22, 13, 23, DateTimeKind.Local).AddTicks(7232));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 22, 13, 23, DateTimeKind.Local).AddTicks(7261));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 22, 13, 23, DateTimeKind.Local).AddTicks(7263));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 22, 13, 23, DateTimeKind.Local).AddTicks(7265));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 22, 13, 23, DateTimeKind.Local).AddTicks(7266));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 22, 13, 23, DateTimeKind.Local).AddTicks(7268));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 22, 13, 23, DateTimeKind.Local).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 22, 13, 23, DateTimeKind.Local).AddTicks(7271));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 22, 13, 23, DateTimeKind.Local).AddTicks(7273));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 22, 13, 19, DateTimeKind.Local).AddTicks(6526));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 22, 13, 19, DateTimeKind.Local).AddTicks(7286));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 22, 13, 20, DateTimeKind.Local).AddTicks(8092));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 22, 13, 20, DateTimeKind.Local).AddTicks(9237));
        }
    }
}
