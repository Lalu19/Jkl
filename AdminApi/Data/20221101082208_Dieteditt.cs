using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class Dieteditt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FloorMasterId",
                table: "DIETMasters");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PatientMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 13, 52, 7, 672, DateTimeKind.Local).AddTicks(9824),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 1, 1, 4, 6, 312, DateTimeKind.Local).AddTicks(2483));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "HospitalMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 13, 52, 7, 669, DateTimeKind.Local).AddTicks(8035),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 1, 1, 4, 6, 305, DateTimeKind.Local).AddTicks(1380));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodTypeMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 13, 52, 7, 673, DateTimeKind.Local).AddTicks(8389),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 1, 1, 4, 6, 314, DateTimeKind.Local).AddTicks(757));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodProviderLogins",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 13, 52, 7, 674, DateTimeKind.Local).AddTicks(734),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 1, 1, 4, 6, 314, DateTimeKind.Local).AddTicks(5736));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FloorMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 13, 52, 7, 674, DateTimeKind.Local).AddTicks(2695),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 1, 1, 4, 6, 315, DateTimeKind.Local).AddTicks(105));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DIETMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 13, 52, 7, 673, DateTimeKind.Local).AddTicks(6288),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 1, 1, 4, 6, 313, DateTimeKind.Local).AddTicks(6229));

            migrationBuilder.AddColumn<string>(
                name: "FloorsName",
                table: "DIETMasters",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FoodProviderLoginId",
                table: "DIETMasters",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DieticianMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 13, 52, 7, 673, DateTimeKind.Local).AddTicks(4180),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 1, 1, 4, 6, 313, DateTimeKind.Local).AddTicks(1711));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedPatientMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 13, 52, 7, 673, DateTimeKind.Local).AddTicks(1919),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 1, 1, 4, 6, 312, DateTimeKind.Local).AddTicks(7077));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 13, 52, 7, 672, DateTimeKind.Local).AddTicks(7373),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 1, 1, 4, 6, 311, DateTimeKind.Local).AddTicks(7389));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 13, 52, 7, 667, DateTimeKind.Local).AddTicks(9640));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 13, 52, 7, 668, DateTimeKind.Local).AddTicks(527));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 13, 52, 7, 668, DateTimeKind.Local).AddTicks(596));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 13, 52, 7, 668, DateTimeKind.Local).AddTicks(599));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 13, 52, 7, 668, DateTimeKind.Local).AddTicks(603));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 13, 52, 7, 668, DateTimeKind.Local).AddTicks(605));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 13, 52, 7, 668, DateTimeKind.Local).AddTicks(609));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 13, 52, 7, 668, DateTimeKind.Local).AddTicks(612));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 13, 52, 7, 668, DateTimeKind.Local).AddTicks(614));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 13, 52, 7, 668, DateTimeKind.Local).AddTicks(616));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 13, 52, 7, 661, DateTimeKind.Local).AddTicks(8098));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 13, 52, 7, 662, DateTimeKind.Local).AddTicks(7271));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 13, 52, 7, 669, DateTimeKind.Local).AddTicks(2339));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 13, 52, 7, 669, DateTimeKind.Local).AddTicks(3177));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 13, 52, 7, 669, DateTimeKind.Local).AddTicks(3203));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 13, 52, 7, 669, DateTimeKind.Local).AddTicks(3204));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 13, 52, 7, 669, DateTimeKind.Local).AddTicks(3206));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 13, 52, 7, 669, DateTimeKind.Local).AddTicks(3208));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 13, 52, 7, 669, DateTimeKind.Local).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 13, 52, 7, 669, DateTimeKind.Local).AddTicks(3211));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 13, 52, 7, 669, DateTimeKind.Local).AddTicks(3213));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 13, 52, 7, 669, DateTimeKind.Local).AddTicks(3215));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 13, 52, 7, 664, DateTimeKind.Local).AddTicks(8759));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 13, 52, 7, 664, DateTimeKind.Local).AddTicks(9531));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 13, 52, 7, 665, DateTimeKind.Local).AddTicks(9956));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 13, 52, 7, 666, DateTimeKind.Local).AddTicks(957));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FloorsName",
                table: "DIETMasters");

            migrationBuilder.DropColumn(
                name: "FoodProviderLoginId",
                table: "DIETMasters");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PatientMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 1, 4, 6, 312, DateTimeKind.Local).AddTicks(2483),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 11, 1, 13, 52, 7, 672, DateTimeKind.Local).AddTicks(9824));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "HospitalMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 1, 4, 6, 305, DateTimeKind.Local).AddTicks(1380),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 11, 1, 13, 52, 7, 669, DateTimeKind.Local).AddTicks(8035));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodTypeMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 1, 4, 6, 314, DateTimeKind.Local).AddTicks(757),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 11, 1, 13, 52, 7, 673, DateTimeKind.Local).AddTicks(8389));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodProviderLogins",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 1, 4, 6, 314, DateTimeKind.Local).AddTicks(5736),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 11, 1, 13, 52, 7, 674, DateTimeKind.Local).AddTicks(734));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FloorMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 1, 4, 6, 315, DateTimeKind.Local).AddTicks(105),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 11, 1, 13, 52, 7, 674, DateTimeKind.Local).AddTicks(2695));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DIETMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 1, 4, 6, 313, DateTimeKind.Local).AddTicks(6229),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 11, 1, 13, 52, 7, 673, DateTimeKind.Local).AddTicks(6288));

            migrationBuilder.AddColumn<int>(
                name: "FloorMasterId",
                table: "DIETMasters",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DieticianMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 1, 4, 6, 313, DateTimeKind.Local).AddTicks(1711),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 11, 1, 13, 52, 7, 673, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedPatientMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 1, 4, 6, 312, DateTimeKind.Local).AddTicks(7077),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 11, 1, 13, 52, 7, 673, DateTimeKind.Local).AddTicks(1919));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 1, 4, 6, 311, DateTimeKind.Local).AddTicks(7389),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 11, 1, 13, 52, 7, 672, DateTimeKind.Local).AddTicks(7373));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 1, 4, 6, 301, DateTimeKind.Local).AddTicks(4742));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 1, 4, 6, 301, DateTimeKind.Local).AddTicks(6463));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 1, 4, 6, 301, DateTimeKind.Local).AddTicks(6544));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 1, 4, 6, 301, DateTimeKind.Local).AddTicks(6549));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 1, 4, 6, 301, DateTimeKind.Local).AddTicks(6553));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 1, 4, 6, 301, DateTimeKind.Local).AddTicks(6557));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 1, 4, 6, 301, DateTimeKind.Local).AddTicks(6562));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 1, 4, 6, 301, DateTimeKind.Local).AddTicks(6566));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 1, 4, 6, 301, DateTimeKind.Local).AddTicks(6569));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 1, 4, 6, 301, DateTimeKind.Local).AddTicks(6573));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 1, 4, 6, 289, DateTimeKind.Local).AddTicks(6957));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 1, 4, 6, 291, DateTimeKind.Local).AddTicks(5874));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 1, 4, 6, 303, DateTimeKind.Local).AddTicks(9815));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 1, 4, 6, 304, DateTimeKind.Local).AddTicks(1642));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 1, 4, 6, 304, DateTimeKind.Local).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 1, 4, 6, 304, DateTimeKind.Local).AddTicks(1708));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 1, 4, 6, 304, DateTimeKind.Local).AddTicks(1712));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 1, 4, 6, 304, DateTimeKind.Local).AddTicks(1715));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 1, 4, 6, 304, DateTimeKind.Local).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 1, 4, 6, 304, DateTimeKind.Local).AddTicks(1722));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 1, 4, 6, 304, DateTimeKind.Local).AddTicks(1725));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 1, 4, 6, 304, DateTimeKind.Local).AddTicks(1728));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 1, 4, 6, 295, DateTimeKind.Local).AddTicks(9281));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 1, 4, 6, 296, DateTimeKind.Local).AddTicks(923));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 1, 4, 6, 298, DateTimeKind.Local).AddTicks(2109));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 1, 4, 6, 298, DateTimeKind.Local).AddTicks(4275));
        }
    }
}
