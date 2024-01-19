using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class DIETadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Supervisor",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 12, 13, 5, 24, 105, DateTimeKind.Local).AddTicks(1943),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 10, 13, 11, 16, 225, DateTimeKind.Local).AddTicks(3813));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PatientType",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 12, 13, 5, 24, 103, DateTimeKind.Local).AddTicks(7369),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 10, 13, 11, 16, 224, DateTimeKind.Local).AddTicks(7353));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "HospitalMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 12, 13, 5, 24, 95, DateTimeKind.Local).AddTicks(3947),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 10, 13, 11, 16, 221, DateTimeKind.Local).AddTicks(371));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodServiceType",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 12, 13, 5, 24, 104, DateTimeKind.Local).AddTicks(2289),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 10, 13, 11, 16, 224, DateTimeKind.Local).AddTicks(9452));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodProviderLogins",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 12, 13, 5, 24, 103, DateTimeKind.Local).AddTicks(2291),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 10, 13, 11, 16, 224, DateTimeKind.Local).AddTicks(5362));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DietType",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 12, 13, 5, 24, 104, DateTimeKind.Local).AddTicks(7327),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 10, 13, 11, 16, 225, DateTimeKind.Local).AddTicks(1755));

            migrationBuilder.AlterColumn<int>(
                name: "DeletedBy",
                table: "DIETMasters",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DIETMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 12, 13, 5, 24, 102, DateTimeKind.Local).AddTicks(6459),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 10, 13, 11, 16, 224, DateTimeKind.Local).AddTicks(3253));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "DIETMasters",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SupervisorId",
                table: "DIETMasters",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DieticianMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 12, 13, 5, 24, 102, DateTimeKind.Local).AddTicks(1494),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 10, 13, 11, 16, 224, DateTimeKind.Local).AddTicks(982));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 12, 13, 5, 24, 101, DateTimeKind.Local).AddTicks(6340),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 10, 13, 11, 16, 223, DateTimeKind.Local).AddTicks(8642));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 12, 12, 13, 5, 24, 91, DateTimeKind.Local).AddTicks(3043));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 12, 12, 13, 5, 24, 91, DateTimeKind.Local).AddTicks(5112));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 12, 12, 13, 5, 24, 91, DateTimeKind.Local).AddTicks(5175));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2022, 12, 12, 13, 5, 24, 91, DateTimeKind.Local).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2022, 12, 12, 13, 5, 24, 91, DateTimeKind.Local).AddTicks(5184));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2022, 12, 12, 13, 5, 24, 91, DateTimeKind.Local).AddTicks(5187));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2022, 12, 12, 13, 5, 24, 91, DateTimeKind.Local).AddTicks(5191));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2022, 12, 12, 13, 5, 24, 91, DateTimeKind.Local).AddTicks(5195));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2022, 12, 12, 13, 5, 24, 91, DateTimeKind.Local).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2022, 12, 12, 13, 5, 24, 91, DateTimeKind.Local).AddTicks(5202));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 12, 12, 13, 5, 24, 74, DateTimeKind.Local).AddTicks(5557));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 12, 12, 13, 5, 24, 76, DateTimeKind.Local).AddTicks(4752));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 12, 12, 13, 5, 24, 94, DateTimeKind.Local).AddTicks(1837));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 12, 12, 13, 5, 24, 94, DateTimeKind.Local).AddTicks(3598));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 12, 12, 13, 5, 24, 94, DateTimeKind.Local).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2022, 12, 12, 13, 5, 24, 94, DateTimeKind.Local).AddTicks(3661));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2022, 12, 12, 13, 5, 24, 94, DateTimeKind.Local).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2022, 12, 12, 13, 5, 24, 94, DateTimeKind.Local).AddTicks(3668));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2022, 12, 12, 13, 5, 24, 94, DateTimeKind.Local).AddTicks(3671));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2022, 12, 12, 13, 5, 24, 94, DateTimeKind.Local).AddTicks(3674));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2022, 12, 12, 13, 5, 24, 94, DateTimeKind.Local).AddTicks(3678));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2022, 12, 12, 13, 5, 24, 94, DateTimeKind.Local).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 12, 12, 13, 5, 24, 81, DateTimeKind.Local).AddTicks(1167));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 12, 12, 13, 5, 24, 81, DateTimeKind.Local).AddTicks(2840));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 12, 12, 13, 5, 24, 83, DateTimeKind.Local).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 12, 12, 13, 5, 24, 84, DateTimeKind.Local).AddTicks(1108));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "DIETMasters");

            migrationBuilder.DropColumn(
                name: "SupervisorId",
                table: "DIETMasters");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 10, 13, 11, 16, 225, DateTimeKind.Local).AddTicks(3813),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 12, 13, 5, 24, 105, DateTimeKind.Local).AddTicks(1943));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PatientType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 10, 13, 11, 16, 224, DateTimeKind.Local).AddTicks(7353),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 12, 13, 5, 24, 103, DateTimeKind.Local).AddTicks(7369));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "HospitalMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 10, 13, 11, 16, 221, DateTimeKind.Local).AddTicks(371),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 12, 13, 5, 24, 95, DateTimeKind.Local).AddTicks(3947));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodServiceType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 10, 13, 11, 16, 224, DateTimeKind.Local).AddTicks(9452),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 12, 13, 5, 24, 104, DateTimeKind.Local).AddTicks(2289));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodProviderLogins",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 10, 13, 11, 16, 224, DateTimeKind.Local).AddTicks(5362),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 12, 13, 5, 24, 103, DateTimeKind.Local).AddTicks(2291));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DietType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 10, 13, 11, 16, 225, DateTimeKind.Local).AddTicks(1755),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 12, 13, 5, 24, 104, DateTimeKind.Local).AddTicks(7327));

            migrationBuilder.AlterColumn<int>(
                name: "DeletedBy",
                table: "DIETMasters",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DIETMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 10, 13, 11, 16, 224, DateTimeKind.Local).AddTicks(3253),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 12, 13, 5, 24, 102, DateTimeKind.Local).AddTicks(6459));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DieticianMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 10, 13, 11, 16, 224, DateTimeKind.Local).AddTicks(982),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 12, 13, 5, 24, 102, DateTimeKind.Local).AddTicks(1494));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 10, 13, 11, 16, 223, DateTimeKind.Local).AddTicks(8642),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 12, 13, 5, 24, 101, DateTimeKind.Local).AddTicks(6340));

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
    }
}
