using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class HospitatClmRemove : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FloorMasterId",
                table: "HospitalMasters");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PatientMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 13, 27, 5, 614, DateTimeKind.Local).AddTicks(1746),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 31, 13, 16, 22, 468, DateTimeKind.Local).AddTicks(5666));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "HospitalMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 13, 27, 5, 607, DateTimeKind.Local).AddTicks(4296),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 31, 13, 16, 22, 461, DateTimeKind.Local).AddTicks(9184));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodTypeMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 13, 27, 5, 616, DateTimeKind.Local).AddTicks(544),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 31, 13, 16, 22, 470, DateTimeKind.Local).AddTicks(3913));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodProviderLogins",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 13, 27, 5, 616, DateTimeKind.Local).AddTicks(5688),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 31, 13, 16, 22, 470, DateTimeKind.Local).AddTicks(8870));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FloorMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 13, 27, 5, 617, DateTimeKind.Local).AddTicks(229),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 31, 13, 16, 22, 471, DateTimeKind.Local).AddTicks(3363));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DIETMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 13, 27, 5, 615, DateTimeKind.Local).AddTicks(5778),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 31, 13, 16, 22, 469, DateTimeKind.Local).AddTicks(9415));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DieticianMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 13, 27, 5, 615, DateTimeKind.Local).AddTicks(1139),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 31, 13, 16, 22, 469, DateTimeKind.Local).AddTicks(5023));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedPatientMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 13, 27, 5, 614, DateTimeKind.Local).AddTicks(6468),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 31, 13, 16, 22, 469, DateTimeKind.Local).AddTicks(425));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 13, 27, 5, 613, DateTimeKind.Local).AddTicks(6583),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 31, 13, 16, 22, 468, DateTimeKind.Local).AddTicks(314));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PatientMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 13, 16, 22, 468, DateTimeKind.Local).AddTicks(5666),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 10, 31, 13, 27, 5, 614, DateTimeKind.Local).AddTicks(1746));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "HospitalMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 13, 16, 22, 461, DateTimeKind.Local).AddTicks(9184),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 10, 31, 13, 27, 5, 607, DateTimeKind.Local).AddTicks(4296));

            migrationBuilder.AddColumn<int>(
                name: "FloorMasterId",
                table: "HospitalMasters",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodTypeMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 13, 16, 22, 470, DateTimeKind.Local).AddTicks(3913),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 10, 31, 13, 27, 5, 616, DateTimeKind.Local).AddTicks(544));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodProviderLogins",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 13, 16, 22, 470, DateTimeKind.Local).AddTicks(8870),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 10, 31, 13, 27, 5, 616, DateTimeKind.Local).AddTicks(5688));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FloorMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 13, 16, 22, 471, DateTimeKind.Local).AddTicks(3363),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 10, 31, 13, 27, 5, 617, DateTimeKind.Local).AddTicks(229));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DIETMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 13, 16, 22, 469, DateTimeKind.Local).AddTicks(9415),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 10, 31, 13, 27, 5, 615, DateTimeKind.Local).AddTicks(5778));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DieticianMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 13, 16, 22, 469, DateTimeKind.Local).AddTicks(5023),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 10, 31, 13, 27, 5, 615, DateTimeKind.Local).AddTicks(1139));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedPatientMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 13, 16, 22, 469, DateTimeKind.Local).AddTicks(425),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 10, 31, 13, 27, 5, 614, DateTimeKind.Local).AddTicks(6468));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 13, 16, 22, 468, DateTimeKind.Local).AddTicks(314),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 10, 31, 13, 27, 5, 613, DateTimeKind.Local).AddTicks(6583));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 13, 16, 22, 458, DateTimeKind.Local).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 13, 16, 22, 458, DateTimeKind.Local).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 13, 16, 22, 458, DateTimeKind.Local).AddTicks(4282));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 13, 16, 22, 458, DateTimeKind.Local).AddTicks(4287));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 13, 16, 22, 458, DateTimeKind.Local).AddTicks(4291));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 13, 16, 22, 458, DateTimeKind.Local).AddTicks(4295));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 13, 16, 22, 458, DateTimeKind.Local).AddTicks(4299));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 13, 16, 22, 458, DateTimeKind.Local).AddTicks(4302));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 13, 16, 22, 458, DateTimeKind.Local).AddTicks(4306));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 13, 16, 22, 458, DateTimeKind.Local).AddTicks(4309));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 13, 16, 22, 446, DateTimeKind.Local).AddTicks(2902));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 13, 16, 22, 448, DateTimeKind.Local).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 13, 16, 22, 460, DateTimeKind.Local).AddTicks(7694));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 13, 16, 22, 460, DateTimeKind.Local).AddTicks(9479));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 13, 16, 22, 460, DateTimeKind.Local).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 13, 16, 22, 460, DateTimeKind.Local).AddTicks(9544));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 13, 16, 22, 460, DateTimeKind.Local).AddTicks(9547));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 13, 16, 22, 460, DateTimeKind.Local).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 13, 16, 22, 460, DateTimeKind.Local).AddTicks(9554));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 13, 16, 22, 460, DateTimeKind.Local).AddTicks(9557));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 13, 16, 22, 460, DateTimeKind.Local).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 13, 16, 22, 460, DateTimeKind.Local).AddTicks(9563));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 13, 16, 22, 452, DateTimeKind.Local).AddTicks(7001));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 13, 16, 22, 452, DateTimeKind.Local).AddTicks(8653));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 13, 16, 22, 454, DateTimeKind.Local).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 10, 31, 13, 16, 22, 455, DateTimeKind.Local).AddTicks(1989));
        }
    }
}
