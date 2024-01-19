using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class Beded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FloorMasterId",
                table: "BedMasters");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PatientMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 1, 4, 6, 312, DateTimeKind.Local).AddTicks(2483),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 31, 13, 27, 5, 614, DateTimeKind.Local).AddTicks(1746));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "HospitalMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 1, 4, 6, 305, DateTimeKind.Local).AddTicks(1380),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 31, 13, 27, 5, 607, DateTimeKind.Local).AddTicks(4296));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodTypeMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 1, 4, 6, 314, DateTimeKind.Local).AddTicks(757),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 31, 13, 27, 5, 616, DateTimeKind.Local).AddTicks(544));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodProviderLogins",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 1, 4, 6, 314, DateTimeKind.Local).AddTicks(5736),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 31, 13, 27, 5, 616, DateTimeKind.Local).AddTicks(5688));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FloorMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 1, 4, 6, 315, DateTimeKind.Local).AddTicks(105),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 31, 13, 27, 5, 617, DateTimeKind.Local).AddTicks(229));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DIETMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 1, 4, 6, 313, DateTimeKind.Local).AddTicks(6229),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 31, 13, 27, 5, 615, DateTimeKind.Local).AddTicks(5778));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DieticianMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 1, 4, 6, 313, DateTimeKind.Local).AddTicks(1711),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 31, 13, 27, 5, 615, DateTimeKind.Local).AddTicks(1139));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedPatientMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 1, 4, 6, 312, DateTimeKind.Local).AddTicks(7077),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 31, 13, 27, 5, 614, DateTimeKind.Local).AddTicks(6468));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 1, 4, 6, 311, DateTimeKind.Local).AddTicks(7389),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 31, 13, 27, 5, 613, DateTimeKind.Local).AddTicks(6583));

            migrationBuilder.AddColumn<string>(
                name: "FloorsName",
                table: "BedMasters",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FloorsName",
                table: "BedMasters");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PatientMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 13, 27, 5, 614, DateTimeKind.Local).AddTicks(1746),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 11, 1, 1, 4, 6, 312, DateTimeKind.Local).AddTicks(2483));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "HospitalMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 13, 27, 5, 607, DateTimeKind.Local).AddTicks(4296),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 11, 1, 1, 4, 6, 305, DateTimeKind.Local).AddTicks(1380));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodTypeMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 13, 27, 5, 616, DateTimeKind.Local).AddTicks(544),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 11, 1, 1, 4, 6, 314, DateTimeKind.Local).AddTicks(757));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodProviderLogins",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 13, 27, 5, 616, DateTimeKind.Local).AddTicks(5688),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 11, 1, 1, 4, 6, 314, DateTimeKind.Local).AddTicks(5736));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FloorMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 13, 27, 5, 617, DateTimeKind.Local).AddTicks(229),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 11, 1, 1, 4, 6, 315, DateTimeKind.Local).AddTicks(105));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DIETMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 13, 27, 5, 615, DateTimeKind.Local).AddTicks(5778),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 11, 1, 1, 4, 6, 313, DateTimeKind.Local).AddTicks(6229));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DieticianMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 13, 27, 5, 615, DateTimeKind.Local).AddTicks(1139),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 11, 1, 1, 4, 6, 313, DateTimeKind.Local).AddTicks(1711));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedPatientMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 13, 27, 5, 614, DateTimeKind.Local).AddTicks(6468),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 11, 1, 1, 4, 6, 312, DateTimeKind.Local).AddTicks(7077));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 13, 27, 5, 613, DateTimeKind.Local).AddTicks(6583),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 11, 1, 1, 4, 6, 311, DateTimeKind.Local).AddTicks(7389));

            migrationBuilder.AddColumn<int>(
                name: "FloorMasterId",
                table: "BedMasters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 13, 27, 5, 603, DateTimeKind.Local).AddTicks(4016));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 13, 27, 5, 603, DateTimeKind.Local).AddTicks(5787));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 13, 27, 5, 603, DateTimeKind.Local).AddTicks(5877));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 13, 27, 5, 603, DateTimeKind.Local).AddTicks(5881));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 13, 27, 5, 603, DateTimeKind.Local).AddTicks(5885));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 13, 27, 5, 603, DateTimeKind.Local).AddTicks(5889));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 13, 27, 5, 603, DateTimeKind.Local).AddTicks(5893));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 13, 27, 5, 603, DateTimeKind.Local).AddTicks(5896));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 13, 27, 5, 603, DateTimeKind.Local).AddTicks(5900));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 13, 27, 5, 603, DateTimeKind.Local).AddTicks(5904));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 13, 27, 5, 591, DateTimeKind.Local).AddTicks(7479));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 13, 27, 5, 593, DateTimeKind.Local).AddTicks(5374));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 13, 27, 5, 606, DateTimeKind.Local).AddTicks(1827));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 13, 27, 5, 606, DateTimeKind.Local).AddTicks(3661));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 13, 27, 5, 606, DateTimeKind.Local).AddTicks(3721));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 13, 27, 5, 606, DateTimeKind.Local).AddTicks(3725));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 13, 27, 5, 606, DateTimeKind.Local).AddTicks(3728));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 13, 27, 5, 606, DateTimeKind.Local).AddTicks(3731));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 13, 27, 5, 606, DateTimeKind.Local).AddTicks(3734));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 13, 27, 5, 606, DateTimeKind.Local).AddTicks(3738));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 13, 27, 5, 606, DateTimeKind.Local).AddTicks(3741));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 13, 27, 5, 606, DateTimeKind.Local).AddTicks(3744));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 13, 27, 5, 597, DateTimeKind.Local).AddTicks(7642));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 13, 27, 5, 597, DateTimeKind.Local).AddTicks(9361));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 13, 27, 5, 600, DateTimeKind.Local).AddTicks(211));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 13, 27, 5, 600, DateTimeKind.Local).AddTicks(2445));
        }
    }
}
