using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class Supervisor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PatientType",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 10, 13, 11, 16, 224, DateTimeKind.Local).AddTicks(7353),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 10, 11, 4, 16, 925, DateTimeKind.Local).AddTicks(4548));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "HospitalMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 10, 13, 11, 16, 221, DateTimeKind.Local).AddTicks(371),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 10, 11, 4, 16, 921, DateTimeKind.Local).AddTicks(6603));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodServiceType",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 10, 13, 11, 16, 224, DateTimeKind.Local).AddTicks(9452),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 10, 11, 4, 16, 925, DateTimeKind.Local).AddTicks(6571));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodProviderLogins",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 10, 13, 11, 16, 224, DateTimeKind.Local).AddTicks(5362),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 10, 11, 4, 16, 925, DateTimeKind.Local).AddTicks(2494));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DietType",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 10, 13, 11, 16, 225, DateTimeKind.Local).AddTicks(1755),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 10, 11, 4, 16, 925, DateTimeKind.Local).AddTicks(8620));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DIETMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 10, 13, 11, 16, 224, DateTimeKind.Local).AddTicks(3253),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 10, 11, 4, 16, 925, DateTimeKind.Local).AddTicks(397));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DieticianMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 10, 13, 11, 16, 224, DateTimeKind.Local).AddTicks(982),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 10, 11, 4, 16, 924, DateTimeKind.Local).AddTicks(8130));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 10, 13, 11, 16, 223, DateTimeKind.Local).AddTicks(8642),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 10, 11, 4, 16, 924, DateTimeKind.Local).AddTicks(5666));

            migrationBuilder.CreateTable(
                name: "Supervisor",
                columns: table => new
                {
                    SupervisorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HospitalMasterid = table.Column<int>(nullable: false),
                    SupervisorName = table.Column<string>(nullable: true),
                    MobileNo = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    EmployeeId = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    RePassword = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2022, 12, 10, 13, 11, 16, 225, DateTimeKind.Local).AddTicks(3813)),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supervisor", x => x.SupervisorId);
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 12, 10, 13, 11, 16, 219, DateTimeKind.Local).AddTicks(1538));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 12, 10, 13, 11, 16, 219, DateTimeKind.Local).AddTicks(2373));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 12, 10, 13, 11, 16, 219, DateTimeKind.Local).AddTicks(2428));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2022, 12, 10, 13, 11, 16, 219, DateTimeKind.Local).AddTicks(2431));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2022, 12, 10, 13, 11, 16, 219, DateTimeKind.Local).AddTicks(2433));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2022, 12, 10, 13, 11, 16, 219, DateTimeKind.Local).AddTicks(2435));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2022, 12, 10, 13, 11, 16, 219, DateTimeKind.Local).AddTicks(2437));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2022, 12, 10, 13, 11, 16, 219, DateTimeKind.Local).AddTicks(2439));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2022, 12, 10, 13, 11, 16, 219, DateTimeKind.Local).AddTicks(2441));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2022, 12, 10, 13, 11, 16, 219, DateTimeKind.Local).AddTicks(2443));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 12, 10, 13, 11, 16, 212, DateTimeKind.Local).AddTicks(9848));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 12, 10, 13, 11, 16, 213, DateTimeKind.Local).AddTicks(9538));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 12, 10, 13, 11, 16, 220, DateTimeKind.Local).AddTicks(4702));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 12, 10, 13, 11, 16, 220, DateTimeKind.Local).AddTicks(5602));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 12, 10, 13, 11, 16, 220, DateTimeKind.Local).AddTicks(5637));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2022, 12, 10, 13, 11, 16, 220, DateTimeKind.Local).AddTicks(5639));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2022, 12, 10, 13, 11, 16, 220, DateTimeKind.Local).AddTicks(5640));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2022, 12, 10, 13, 11, 16, 220, DateTimeKind.Local).AddTicks(5642));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2022, 12, 10, 13, 11, 16, 220, DateTimeKind.Local).AddTicks(5643));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2022, 12, 10, 13, 11, 16, 220, DateTimeKind.Local).AddTicks(5645));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2022, 12, 10, 13, 11, 16, 220, DateTimeKind.Local).AddTicks(5646));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2022, 12, 10, 13, 11, 16, 220, DateTimeKind.Local).AddTicks(5648));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 12, 10, 13, 11, 16, 216, DateTimeKind.Local).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 12, 10, 13, 11, 16, 216, DateTimeKind.Local).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 12, 10, 13, 11, 16, 217, DateTimeKind.Local).AddTicks(5179));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 12, 10, 13, 11, 16, 217, DateTimeKind.Local).AddTicks(6235));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Supervisor");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PatientType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 10, 11, 4, 16, 925, DateTimeKind.Local).AddTicks(4548),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 10, 13, 11, 16, 224, DateTimeKind.Local).AddTicks(7353));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "HospitalMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 10, 11, 4, 16, 921, DateTimeKind.Local).AddTicks(6603),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 10, 13, 11, 16, 221, DateTimeKind.Local).AddTicks(371));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodServiceType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 10, 11, 4, 16, 925, DateTimeKind.Local).AddTicks(6571),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 10, 13, 11, 16, 224, DateTimeKind.Local).AddTicks(9452));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodProviderLogins",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 10, 11, 4, 16, 925, DateTimeKind.Local).AddTicks(2494),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 10, 13, 11, 16, 224, DateTimeKind.Local).AddTicks(5362));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DietType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 10, 11, 4, 16, 925, DateTimeKind.Local).AddTicks(8620),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 10, 13, 11, 16, 225, DateTimeKind.Local).AddTicks(1755));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DIETMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 10, 11, 4, 16, 925, DateTimeKind.Local).AddTicks(397),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 10, 13, 11, 16, 224, DateTimeKind.Local).AddTicks(3253));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DieticianMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 10, 11, 4, 16, 924, DateTimeKind.Local).AddTicks(8130),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 10, 13, 11, 16, 224, DateTimeKind.Local).AddTicks(982));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 10, 11, 4, 16, 924, DateTimeKind.Local).AddTicks(5666),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 10, 13, 11, 16, 223, DateTimeKind.Local).AddTicks(8642));

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
    }
}
