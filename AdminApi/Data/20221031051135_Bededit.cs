using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class Bededit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PricePerHour",
                table: "BedMasters");

            migrationBuilder.DropColumn(
                name: "RoomNo",
                table: "BedMasters");

            migrationBuilder.DropColumn(
                name: "WordNo",
                table: "BedMasters");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PatientMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 10, 41, 34, 562, DateTimeKind.Local).AddTicks(6427),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 29, 19, 5, 30, 11, DateTimeKind.Local).AddTicks(4033));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "HospitalMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 10, 41, 34, 559, DateTimeKind.Local).AddTicks(5856),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 29, 19, 5, 30, 8, DateTimeKind.Local).AddTicks(4177));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodTypeMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 10, 41, 34, 563, DateTimeKind.Local).AddTicks(5167),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 29, 19, 5, 30, 12, DateTimeKind.Local).AddTicks(2816));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodProviderLogins",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 10, 41, 34, 563, DateTimeKind.Local).AddTicks(7523),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 29, 19, 5, 30, 12, DateTimeKind.Local).AddTicks(5187));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FloorMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 10, 41, 34, 563, DateTimeKind.Local).AddTicks(9525),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 29, 19, 5, 30, 12, DateTimeKind.Local).AddTicks(7297));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DIETMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 10, 41, 34, 563, DateTimeKind.Local).AddTicks(2890),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 29, 19, 5, 30, 12, DateTimeKind.Local).AddTicks(661));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DieticianMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 10, 41, 34, 563, DateTimeKind.Local).AddTicks(805),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 29, 19, 5, 30, 11, DateTimeKind.Local).AddTicks(8513));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedPatientMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 10, 41, 34, 562, DateTimeKind.Local).AddTicks(8573),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 29, 19, 5, 30, 11, DateTimeKind.Local).AddTicks(6311));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 31, 10, 41, 34, 562, DateTimeKind.Local).AddTicks(4100),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 29, 19, 5, 30, 11, DateTimeKind.Local).AddTicks(1662));

            migrationBuilder.AddColumn<int>(
                name: "FloorMasterId",
                table: "BedMasters",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FloorMasterId",
                table: "BedMasters");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PatientMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 29, 19, 5, 30, 11, DateTimeKind.Local).AddTicks(4033),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 10, 31, 10, 41, 34, 562, DateTimeKind.Local).AddTicks(6427));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "HospitalMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 29, 19, 5, 30, 8, DateTimeKind.Local).AddTicks(4177),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 10, 31, 10, 41, 34, 559, DateTimeKind.Local).AddTicks(5856));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodTypeMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 29, 19, 5, 30, 12, DateTimeKind.Local).AddTicks(2816),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 10, 31, 10, 41, 34, 563, DateTimeKind.Local).AddTicks(5167));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodProviderLogins",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 29, 19, 5, 30, 12, DateTimeKind.Local).AddTicks(5187),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 10, 31, 10, 41, 34, 563, DateTimeKind.Local).AddTicks(7523));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FloorMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 29, 19, 5, 30, 12, DateTimeKind.Local).AddTicks(7297),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 10, 31, 10, 41, 34, 563, DateTimeKind.Local).AddTicks(9525));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DIETMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 29, 19, 5, 30, 12, DateTimeKind.Local).AddTicks(661),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 10, 31, 10, 41, 34, 563, DateTimeKind.Local).AddTicks(2890));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DieticianMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 29, 19, 5, 30, 11, DateTimeKind.Local).AddTicks(8513),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 10, 31, 10, 41, 34, 563, DateTimeKind.Local).AddTicks(805));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedPatientMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 29, 19, 5, 30, 11, DateTimeKind.Local).AddTicks(6311),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 10, 31, 10, 41, 34, 562, DateTimeKind.Local).AddTicks(8573));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 29, 19, 5, 30, 11, DateTimeKind.Local).AddTicks(1662),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 10, 31, 10, 41, 34, 562, DateTimeKind.Local).AddTicks(4100));

            migrationBuilder.AddColumn<string>(
                name: "PricePerHour",
                table: "BedMasters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RoomNo",
                table: "BedMasters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WordNo",
                table: "BedMasters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 19, 5, 30, 6, DateTimeKind.Local).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 19, 5, 30, 6, DateTimeKind.Local).AddTicks(7543));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 19, 5, 30, 6, DateTimeKind.Local).AddTicks(7587));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 19, 5, 30, 6, DateTimeKind.Local).AddTicks(7590));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 19, 5, 30, 6, DateTimeKind.Local).AddTicks(7592));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 19, 5, 30, 6, DateTimeKind.Local).AddTicks(7593));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 19, 5, 30, 6, DateTimeKind.Local).AddTicks(7595));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 19, 5, 30, 6, DateTimeKind.Local).AddTicks(7597));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 19, 5, 30, 6, DateTimeKind.Local).AddTicks(7647));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 19, 5, 30, 6, DateTimeKind.Local).AddTicks(7650));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 19, 5, 30, 1, DateTimeKind.Local).AddTicks(756));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 19, 5, 30, 1, DateTimeKind.Local).AddTicks(9898));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 19, 5, 30, 7, DateTimeKind.Local).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 19, 5, 30, 7, DateTimeKind.Local).AddTicks(9682));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 19, 5, 30, 7, DateTimeKind.Local).AddTicks(9711));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 19, 5, 30, 7, DateTimeKind.Local).AddTicks(9712));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 19, 5, 30, 7, DateTimeKind.Local).AddTicks(9714));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 19, 5, 30, 7, DateTimeKind.Local).AddTicks(9716));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 19, 5, 30, 7, DateTimeKind.Local).AddTicks(9717));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 19, 5, 30, 7, DateTimeKind.Local).AddTicks(9719));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 19, 5, 30, 7, DateTimeKind.Local).AddTicks(9720));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 19, 5, 30, 7, DateTimeKind.Local).AddTicks(9722));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 19, 5, 30, 4, DateTimeKind.Local).AddTicks(516));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 19, 5, 30, 4, DateTimeKind.Local).AddTicks(1292));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 19, 5, 30, 5, DateTimeKind.Local).AddTicks(1333));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 19, 5, 30, 5, DateTimeKind.Local).AddTicks(2442));
        }
    }
}
