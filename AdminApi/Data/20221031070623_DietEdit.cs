using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class DietEdit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DoctorName",
                table: "DIETMasters");

            migrationBuilder.DropColumn(
                name: "FoodType",
                table: "DIETMasters");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PatientMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 12, 36, 22, 304, DateTimeKind.Local).AddTicks(6665),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 31, 10, 41, 34, 562, DateTimeKind.Local).AddTicks(6427));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "HospitalMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 12, 36, 22, 298, DateTimeKind.Local).AddTicks(2507),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 31, 10, 41, 34, 559, DateTimeKind.Local).AddTicks(5856));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodTypeMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 12, 36, 22, 306, DateTimeKind.Local).AddTicks(5207),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 31, 10, 41, 34, 563, DateTimeKind.Local).AddTicks(5167));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodProviderLogins",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 12, 36, 22, 307, DateTimeKind.Local).AddTicks(238),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 31, 10, 41, 34, 563, DateTimeKind.Local).AddTicks(7523));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FloorMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 12, 36, 22, 307, DateTimeKind.Local).AddTicks(4633),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 31, 10, 41, 34, 563, DateTimeKind.Local).AddTicks(9525));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DIETMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 12, 36, 22, 306, DateTimeKind.Local).AddTicks(684),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 31, 10, 41, 34, 563, DateTimeKind.Local).AddTicks(2890));

            migrationBuilder.AddColumn<int>(
                name: "FloorMasterId",
                table: "DIETMasters",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ServiceType",
                table: "DIETMasters",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TypeOfPatient",
                table: "DIETMasters",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DieticianMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 12, 36, 22, 305, DateTimeKind.Local).AddTicks(6188),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 31, 10, 41, 34, 563, DateTimeKind.Local).AddTicks(805));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedPatientMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 12, 36, 22, 305, DateTimeKind.Local).AddTicks(1374),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 31, 10, 41, 34, 562, DateTimeKind.Local).AddTicks(8573));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 12, 36, 22, 304, DateTimeKind.Local).AddTicks(1564),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 31, 10, 41, 34, 562, DateTimeKind.Local).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 12, 36, 22, 294, DateTimeKind.Local).AddTicks(5258));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 12, 36, 22, 294, DateTimeKind.Local).AddTicks(7001));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 12, 36, 22, 294, DateTimeKind.Local).AddTicks(7097));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 12, 36, 22, 294, DateTimeKind.Local).AddTicks(7102));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 12, 36, 22, 294, DateTimeKind.Local).AddTicks(7106));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 12, 36, 22, 294, DateTimeKind.Local).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 12, 36, 22, 294, DateTimeKind.Local).AddTicks(7113));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 12, 36, 22, 294, DateTimeKind.Local).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 12, 36, 22, 294, DateTimeKind.Local).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 12, 36, 22, 294, DateTimeKind.Local).AddTicks(7124));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 12, 36, 22, 282, DateTimeKind.Local).AddTicks(5745));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 12, 36, 22, 284, DateTimeKind.Local).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 12, 36, 22, 297, DateTimeKind.Local).AddTicks(826));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 12, 36, 22, 297, DateTimeKind.Local).AddTicks(2604));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 12, 36, 22, 297, DateTimeKind.Local).AddTicks(2665));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 12, 36, 22, 297, DateTimeKind.Local).AddTicks(2669));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 12, 36, 22, 297, DateTimeKind.Local).AddTicks(2672));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 12, 36, 22, 297, DateTimeKind.Local).AddTicks(2676));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 12, 36, 22, 297, DateTimeKind.Local).AddTicks(2679));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 12, 36, 22, 297, DateTimeKind.Local).AddTicks(2682));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 12, 36, 22, 297, DateTimeKind.Local).AddTicks(2685));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 12, 36, 22, 297, DateTimeKind.Local).AddTicks(2689));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 12, 36, 22, 288, DateTimeKind.Local).AddTicks(7377));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 12, 36, 22, 288, DateTimeKind.Local).AddTicks(9115));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 12, 36, 22, 291, DateTimeKind.Local).AddTicks(563));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 12, 36, 22, 291, DateTimeKind.Local).AddTicks(2796));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FloorMasterId",
                table: "DIETMasters");

            migrationBuilder.DropColumn(
                name: "ServiceType",
                table: "DIETMasters");

            migrationBuilder.DropColumn(
                name: "TypeOfPatient",
                table: "DIETMasters");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PatientMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 10, 41, 34, 562, DateTimeKind.Local).AddTicks(6427),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 10, 31, 12, 36, 22, 304, DateTimeKind.Local).AddTicks(6665));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "HospitalMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 10, 41, 34, 559, DateTimeKind.Local).AddTicks(5856),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 10, 31, 12, 36, 22, 298, DateTimeKind.Local).AddTicks(2507));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodTypeMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 10, 41, 34, 563, DateTimeKind.Local).AddTicks(5167),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 10, 31, 12, 36, 22, 306, DateTimeKind.Local).AddTicks(5207));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodProviderLogins",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 10, 41, 34, 563, DateTimeKind.Local).AddTicks(7523),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 10, 31, 12, 36, 22, 307, DateTimeKind.Local).AddTicks(238));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FloorMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 10, 41, 34, 563, DateTimeKind.Local).AddTicks(9525),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 10, 31, 12, 36, 22, 307, DateTimeKind.Local).AddTicks(4633));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DIETMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 10, 41, 34, 563, DateTimeKind.Local).AddTicks(2890),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 10, 31, 12, 36, 22, 306, DateTimeKind.Local).AddTicks(684));

            migrationBuilder.AddColumn<string>(
                name: "DoctorName",
                table: "DIETMasters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FoodType",
                table: "DIETMasters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DieticianMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 10, 41, 34, 563, DateTimeKind.Local).AddTicks(805),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 10, 31, 12, 36, 22, 305, DateTimeKind.Local).AddTicks(6188));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedPatientMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 10, 41, 34, 562, DateTimeKind.Local).AddTicks(8573),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 10, 31, 12, 36, 22, 305, DateTimeKind.Local).AddTicks(1374));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 10, 41, 34, 562, DateTimeKind.Local).AddTicks(4100),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 10, 31, 12, 36, 22, 304, DateTimeKind.Local).AddTicks(1564));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 10, 41, 34, 557, DateTimeKind.Local).AddTicks(8169));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 10, 41, 34, 557, DateTimeKind.Local).AddTicks(9031));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 10, 41, 34, 557, DateTimeKind.Local).AddTicks(9072));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 10, 41, 34, 557, DateTimeKind.Local).AddTicks(9074));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 10, 41, 34, 557, DateTimeKind.Local).AddTicks(9076));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 10, 41, 34, 557, DateTimeKind.Local).AddTicks(9078));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 10, 41, 34, 557, DateTimeKind.Local).AddTicks(9079));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 10, 41, 34, 557, DateTimeKind.Local).AddTicks(9081));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 10, 41, 34, 557, DateTimeKind.Local).AddTicks(9083));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 10, 41, 34, 557, DateTimeKind.Local).AddTicks(9085));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 10, 41, 34, 552, DateTimeKind.Local).AddTicks(941));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 10, 41, 34, 553, DateTimeKind.Local).AddTicks(128));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 10, 41, 34, 559, DateTimeKind.Local).AddTicks(346));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 10, 41, 34, 559, DateTimeKind.Local).AddTicks(1198));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 10, 41, 34, 559, DateTimeKind.Local).AddTicks(1225));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 10, 41, 34, 559, DateTimeKind.Local).AddTicks(1227));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 10, 41, 34, 559, DateTimeKind.Local).AddTicks(1229));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 10, 41, 34, 559, DateTimeKind.Local).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 10, 41, 34, 559, DateTimeKind.Local).AddTicks(1232));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 10, 41, 34, 559, DateTimeKind.Local).AddTicks(1234));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 10, 41, 34, 559, DateTimeKind.Local).AddTicks(1235));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 10, 41, 34, 559, DateTimeKind.Local).AddTicks(1237));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 10, 41, 34, 555, DateTimeKind.Local).AddTicks(594));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 10, 41, 34, 555, DateTimeKind.Local).AddTicks(1377));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 10, 41, 34, 556, DateTimeKind.Local).AddTicks(1476));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 10, 41, 34, 556, DateTimeKind.Local).AddTicks(2498));
        }
    }
}
