using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class ditee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FoodTypeid",
                table: "DIETMasters");

            migrationBuilder.DropColumn(
                name: "ServiceType",
                table: "DIETMasters");

            migrationBuilder.DropColumn(
                name: "TypeOfPatient",
                table: "DIETMasters");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PatientType",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 10, 11, 4, 16, 925, DateTimeKind.Local).AddTicks(4548),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 8, 14, 50, 24, 502, DateTimeKind.Local).AddTicks(4783));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "HospitalMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 10, 11, 4, 16, 921, DateTimeKind.Local).AddTicks(6603),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 8, 14, 50, 24, 490, DateTimeKind.Local).AddTicks(5387));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodServiceType",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 10, 11, 4, 16, 925, DateTimeKind.Local).AddTicks(6571),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 8, 14, 50, 24, 503, DateTimeKind.Local).AddTicks(4632));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodProviderLogins",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 10, 11, 4, 16, 925, DateTimeKind.Local).AddTicks(2494),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 8, 14, 50, 24, 501, DateTimeKind.Local).AddTicks(5765));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DietType",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 10, 11, 4, 16, 925, DateTimeKind.Local).AddTicks(8620),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 8, 14, 50, 24, 504, DateTimeKind.Local).AddTicks(4806));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DIETMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 10, 11, 4, 16, 925, DateTimeKind.Local).AddTicks(397),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 8, 14, 50, 24, 500, DateTimeKind.Local).AddTicks(7731));

            migrationBuilder.AddColumn<int>(
                name: "DeletedBy",
                table: "DIETMasters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DietTypeId",
                table: "DIETMasters",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FoodServiceTypeId",
                table: "DIETMasters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PatientTypeId",
                table: "DIETMasters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DieticianMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 10, 11, 4, 16, 924, DateTimeKind.Local).AddTicks(8130),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 8, 14, 50, 24, 499, DateTimeKind.Local).AddTicks(8794));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 10, 11, 4, 16, 924, DateTimeKind.Local).AddTicks(5666),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 8, 14, 50, 24, 499, DateTimeKind.Local).AddTicks(1128));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 12, 10, 11, 4, 16, 919, DateTimeKind.Local).AddTicks(8763));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 12, 10, 11, 4, 16, 919, DateTimeKind.Local).AddTicks(9599));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 12, 10, 11, 4, 16, 919, DateTimeKind.Local).AddTicks(9646));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2022, 12, 10, 11, 4, 16, 919, DateTimeKind.Local).AddTicks(9648));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2022, 12, 10, 11, 4, 16, 919, DateTimeKind.Local).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2022, 12, 10, 11, 4, 16, 919, DateTimeKind.Local).AddTicks(9652));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2022, 12, 10, 11, 4, 16, 919, DateTimeKind.Local).AddTicks(9654));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2022, 12, 10, 11, 4, 16, 919, DateTimeKind.Local).AddTicks(9656));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2022, 12, 10, 11, 4, 16, 919, DateTimeKind.Local).AddTicks(9657));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2022, 12, 10, 11, 4, 16, 919, DateTimeKind.Local).AddTicks(9659));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 12, 10, 11, 4, 16, 912, DateTimeKind.Local).AddTicks(9831));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 12, 10, 11, 4, 16, 914, DateTimeKind.Local).AddTicks(1776));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 12, 10, 11, 4, 16, 921, DateTimeKind.Local).AddTicks(925));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 12, 10, 11, 4, 16, 921, DateTimeKind.Local).AddTicks(1810));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 12, 10, 11, 4, 16, 921, DateTimeKind.Local).AddTicks(1838));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2022, 12, 10, 11, 4, 16, 921, DateTimeKind.Local).AddTicks(1839));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2022, 12, 10, 11, 4, 16, 921, DateTimeKind.Local).AddTicks(1841));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2022, 12, 10, 11, 4, 16, 921, DateTimeKind.Local).AddTicks(1843));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2022, 12, 10, 11, 4, 16, 921, DateTimeKind.Local).AddTicks(1844));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2022, 12, 10, 11, 4, 16, 921, DateTimeKind.Local).AddTicks(1846));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2022, 12, 10, 11, 4, 16, 921, DateTimeKind.Local).AddTicks(1847));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2022, 12, 10, 11, 4, 16, 921, DateTimeKind.Local).AddTicks(1849));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 12, 10, 11, 4, 16, 917, DateTimeKind.Local).AddTicks(660));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 12, 10, 11, 4, 16, 917, DateTimeKind.Local).AddTicks(1512));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 12, 10, 11, 4, 16, 918, DateTimeKind.Local).AddTicks(2500));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 12, 10, 11, 4, 16, 918, DateTimeKind.Local).AddTicks(3505));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "DIETMasters");

            migrationBuilder.DropColumn(
                name: "DietTypeId",
                table: "DIETMasters");

            migrationBuilder.DropColumn(
                name: "FoodServiceTypeId",
                table: "DIETMasters");

            migrationBuilder.DropColumn(
                name: "PatientTypeId",
                table: "DIETMasters");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PatientType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 8, 14, 50, 24, 502, DateTimeKind.Local).AddTicks(4783),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 10, 11, 4, 16, 925, DateTimeKind.Local).AddTicks(4548));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "HospitalMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 8, 14, 50, 24, 490, DateTimeKind.Local).AddTicks(5387),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 10, 11, 4, 16, 921, DateTimeKind.Local).AddTicks(6603));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodServiceType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 8, 14, 50, 24, 503, DateTimeKind.Local).AddTicks(4632),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 10, 11, 4, 16, 925, DateTimeKind.Local).AddTicks(6571));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodProviderLogins",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 8, 14, 50, 24, 501, DateTimeKind.Local).AddTicks(5765),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 10, 11, 4, 16, 925, DateTimeKind.Local).AddTicks(2494));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DietType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 8, 14, 50, 24, 504, DateTimeKind.Local).AddTicks(4806),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 10, 11, 4, 16, 925, DateTimeKind.Local).AddTicks(8620));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DIETMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 8, 14, 50, 24, 500, DateTimeKind.Local).AddTicks(7731),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 10, 11, 4, 16, 925, DateTimeKind.Local).AddTicks(397));

            migrationBuilder.AddColumn<int>(
                name: "FoodTypeid",
                table: "DIETMasters",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ServiceType",
                table: "DIETMasters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TypeOfPatient",
                table: "DIETMasters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DieticianMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 8, 14, 50, 24, 499, DateTimeKind.Local).AddTicks(8794),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 10, 11, 4, 16, 924, DateTimeKind.Local).AddTicks(8130));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 8, 14, 50, 24, 499, DateTimeKind.Local).AddTicks(1128),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 10, 11, 4, 16, 924, DateTimeKind.Local).AddTicks(5666));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 14, 50, 24, 484, DateTimeKind.Local).AddTicks(1967));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 14, 50, 24, 484, DateTimeKind.Local).AddTicks(4730));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 14, 50, 24, 484, DateTimeKind.Local).AddTicks(4877));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 14, 50, 24, 484, DateTimeKind.Local).AddTicks(4884));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 14, 50, 24, 484, DateTimeKind.Local).AddTicks(5031));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 14, 50, 24, 484, DateTimeKind.Local).AddTicks(5044));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 14, 50, 24, 484, DateTimeKind.Local).AddTicks(5054));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 14, 50, 24, 484, DateTimeKind.Local).AddTicks(5065));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 14, 50, 24, 484, DateTimeKind.Local).AddTicks(5071));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 14, 50, 24, 484, DateTimeKind.Local).AddTicks(5078));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 14, 50, 24, 466, DateTimeKind.Local).AddTicks(3054));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 14, 50, 24, 468, DateTimeKind.Local).AddTicks(7838));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 14, 50, 24, 488, DateTimeKind.Local).AddTicks(2389));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 14, 50, 24, 488, DateTimeKind.Local).AddTicks(4978));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 14, 50, 24, 488, DateTimeKind.Local).AddTicks(5077));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 14, 50, 24, 488, DateTimeKind.Local).AddTicks(5088));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 14, 50, 24, 488, DateTimeKind.Local).AddTicks(5097));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 14, 50, 24, 488, DateTimeKind.Local).AddTicks(5107));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 14, 50, 24, 488, DateTimeKind.Local).AddTicks(5117));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 14, 50, 24, 488, DateTimeKind.Local).AddTicks(5122));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 14, 50, 24, 488, DateTimeKind.Local).AddTicks(5127));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 14, 50, 24, 488, DateTimeKind.Local).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 14, 50, 24, 475, DateTimeKind.Local).AddTicks(494));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 14, 50, 24, 475, DateTimeKind.Local).AddTicks(3253));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 14, 50, 24, 478, DateTimeKind.Local).AddTicks(8397));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 14, 50, 24, 479, DateTimeKind.Local).AddTicks(1841));
        }
    }
}
