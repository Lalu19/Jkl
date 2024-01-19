using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class FeedbackColumadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Supervisor",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 17, 11, 11, 39, 694, DateTimeKind.Local).AddTicks(3743),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 12, 13, 5, 24, 105, DateTimeKind.Local).AddTicks(1943));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PatientType",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 17, 11, 11, 39, 693, DateTimeKind.Local).AddTicks(7371),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 12, 13, 5, 24, 103, DateTimeKind.Local).AddTicks(7369));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "HospitalMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 17, 11, 11, 39, 690, DateTimeKind.Local).AddTicks(322),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 12, 13, 5, 24, 95, DateTimeKind.Local).AddTicks(3947));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodServiceType",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 17, 11, 11, 39, 693, DateTimeKind.Local).AddTicks(9428),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 12, 13, 5, 24, 104, DateTimeKind.Local).AddTicks(2289));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodProviderLogins",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 17, 11, 11, 39, 693, DateTimeKind.Local).AddTicks(5280),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 12, 13, 5, 24, 103, DateTimeKind.Local).AddTicks(2291));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DietType",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 17, 11, 11, 39, 694, DateTimeKind.Local).AddTicks(1741),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 12, 13, 5, 24, 104, DateTimeKind.Local).AddTicks(7327));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DIETMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 17, 11, 11, 39, 693, DateTimeKind.Local).AddTicks(3075),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 12, 13, 5, 24, 102, DateTimeKind.Local).AddTicks(6459));

            migrationBuilder.AddColumn<string>(
                name: "Feedback",
                table: "DIETMasters",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DieticianMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 17, 11, 11, 39, 693, DateTimeKind.Local).AddTicks(939),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 12, 13, 5, 24, 102, DateTimeKind.Local).AddTicks(1494));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 17, 11, 11, 39, 692, DateTimeKind.Local).AddTicks(8655),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 12, 13, 5, 24, 101, DateTimeKind.Local).AddTicks(6340));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 12, 17, 11, 11, 39, 688, DateTimeKind.Local).AddTicks(1895));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 12, 17, 11, 11, 39, 688, DateTimeKind.Local).AddTicks(2707));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 12, 17, 11, 11, 39, 688, DateTimeKind.Local).AddTicks(2748));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2022, 12, 17, 11, 11, 39, 688, DateTimeKind.Local).AddTicks(2750));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2022, 12, 17, 11, 11, 39, 688, DateTimeKind.Local).AddTicks(2752));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2022, 12, 17, 11, 11, 39, 688, DateTimeKind.Local).AddTicks(2755));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2022, 12, 17, 11, 11, 39, 688, DateTimeKind.Local).AddTicks(2757));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2022, 12, 17, 11, 11, 39, 688, DateTimeKind.Local).AddTicks(2758));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2022, 12, 17, 11, 11, 39, 688, DateTimeKind.Local).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2022, 12, 17, 11, 11, 39, 688, DateTimeKind.Local).AddTicks(2762));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 12, 17, 11, 11, 39, 682, DateTimeKind.Local).AddTicks(4418));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 12, 17, 11, 11, 39, 683, DateTimeKind.Local).AddTicks(3942));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 12, 17, 11, 11, 39, 689, DateTimeKind.Local).AddTicks(4686));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 12, 17, 11, 11, 39, 689, DateTimeKind.Local).AddTicks(5511));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 12, 17, 11, 11, 39, 689, DateTimeKind.Local).AddTicks(5542));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2022, 12, 17, 11, 11, 39, 689, DateTimeKind.Local).AddTicks(5544));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2022, 12, 17, 11, 11, 39, 689, DateTimeKind.Local).AddTicks(5546));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2022, 12, 17, 11, 11, 39, 689, DateTimeKind.Local).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2022, 12, 17, 11, 11, 39, 689, DateTimeKind.Local).AddTicks(5549));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2022, 12, 17, 11, 11, 39, 689, DateTimeKind.Local).AddTicks(5551));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2022, 12, 17, 11, 11, 39, 689, DateTimeKind.Local).AddTicks(5552));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2022, 12, 17, 11, 11, 39, 689, DateTimeKind.Local).AddTicks(5554));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 12, 17, 11, 11, 39, 685, DateTimeKind.Local).AddTicks(5263));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 12, 17, 11, 11, 39, 685, DateTimeKind.Local).AddTicks(6024));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 12, 17, 11, 11, 39, 686, DateTimeKind.Local).AddTicks(5914));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 12, 17, 11, 11, 39, 686, DateTimeKind.Local).AddTicks(6896));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Feedback",
                table: "DIETMasters");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 12, 13, 5, 24, 105, DateTimeKind.Local).AddTicks(1943),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 17, 11, 11, 39, 694, DateTimeKind.Local).AddTicks(3743));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PatientType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 12, 13, 5, 24, 103, DateTimeKind.Local).AddTicks(7369),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 17, 11, 11, 39, 693, DateTimeKind.Local).AddTicks(7371));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "HospitalMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 12, 13, 5, 24, 95, DateTimeKind.Local).AddTicks(3947),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 17, 11, 11, 39, 690, DateTimeKind.Local).AddTicks(322));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodServiceType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 12, 13, 5, 24, 104, DateTimeKind.Local).AddTicks(2289),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 17, 11, 11, 39, 693, DateTimeKind.Local).AddTicks(9428));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodProviderLogins",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 12, 13, 5, 24, 103, DateTimeKind.Local).AddTicks(2291),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 17, 11, 11, 39, 693, DateTimeKind.Local).AddTicks(5280));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DietType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 12, 13, 5, 24, 104, DateTimeKind.Local).AddTicks(7327),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 17, 11, 11, 39, 694, DateTimeKind.Local).AddTicks(1741));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DIETMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 12, 13, 5, 24, 102, DateTimeKind.Local).AddTicks(6459),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 17, 11, 11, 39, 693, DateTimeKind.Local).AddTicks(3075));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DieticianMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 12, 13, 5, 24, 102, DateTimeKind.Local).AddTicks(1494),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 17, 11, 11, 39, 693, DateTimeKind.Local).AddTicks(939));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 12, 13, 5, 24, 101, DateTimeKind.Local).AddTicks(6340),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 17, 11, 11, 39, 692, DateTimeKind.Local).AddTicks(8655));

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
    }
}
