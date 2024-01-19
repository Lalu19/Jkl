using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class Floos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PatientMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 29, 18, 21, 25, 426, DateTimeKind.Local).AddTicks(3168),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 29, 18, 18, 37, 854, DateTimeKind.Local).AddTicks(2113));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "HospitalMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 29, 18, 21, 25, 422, DateTimeKind.Local).AddTicks(9784),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 29, 18, 18, 37, 843, DateTimeKind.Local).AddTicks(9154));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodTypeMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 29, 18, 21, 25, 427, DateTimeKind.Local).AddTicks(1622),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 29, 18, 18, 37, 857, DateTimeKind.Local).AddTicks(3029));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodProviderLogins",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 29, 18, 21, 25, 427, DateTimeKind.Local).AddTicks(4085),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 29, 18, 18, 37, 858, DateTimeKind.Local).AddTicks(2171));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FloorMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 29, 18, 21, 25, 427, DateTimeKind.Local).AddTicks(6078),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 29, 18, 18, 37, 858, DateTimeKind.Local).AddTicks(9782));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DIETMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 29, 18, 21, 25, 426, DateTimeKind.Local).AddTicks(9519),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 29, 18, 18, 37, 856, DateTimeKind.Local).AddTicks(5479));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DieticianMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 29, 18, 21, 25, 426, DateTimeKind.Local).AddTicks(7440),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 29, 18, 18, 37, 855, DateTimeKind.Local).AddTicks(8021));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedPatientMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 29, 18, 21, 25, 426, DateTimeKind.Local).AddTicks(5265),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 29, 18, 18, 37, 855, DateTimeKind.Local).AddTicks(33));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 29, 18, 21, 25, 426, DateTimeKind.Local).AddTicks(709),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 29, 18, 18, 37, 853, DateTimeKind.Local).AddTicks(227));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 21, 25, 420, DateTimeKind.Local).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 21, 25, 420, DateTimeKind.Local).AddTicks(9803));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 21, 25, 420, DateTimeKind.Local).AddTicks(9861));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 21, 25, 420, DateTimeKind.Local).AddTicks(9863));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 21, 25, 420, DateTimeKind.Local).AddTicks(9865));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 21, 25, 420, DateTimeKind.Local).AddTicks(9866));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 21, 25, 420, DateTimeKind.Local).AddTicks(9868));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 21, 25, 420, DateTimeKind.Local).AddTicks(9870));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 21, 25, 420, DateTimeKind.Local).AddTicks(9872));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 21, 25, 420, DateTimeKind.Local).AddTicks(9874));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 21, 25, 415, DateTimeKind.Local).AddTicks(805));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 21, 25, 415, DateTimeKind.Local).AddTicks(9636));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 21, 25, 422, DateTimeKind.Local).AddTicks(3625));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 21, 25, 422, DateTimeKind.Local).AddTicks(4481));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 21, 25, 422, DateTimeKind.Local).AddTicks(4511));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 21, 25, 422, DateTimeKind.Local).AddTicks(4513));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 21, 25, 422, DateTimeKind.Local).AddTicks(4514));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 21, 25, 422, DateTimeKind.Local).AddTicks(4516));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 21, 25, 422, DateTimeKind.Local).AddTicks(4517));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 21, 25, 422, DateTimeKind.Local).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 21, 25, 422, DateTimeKind.Local).AddTicks(4520));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 21, 25, 422, DateTimeKind.Local).AddTicks(4522));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 21, 25, 418, DateTimeKind.Local).AddTicks(569));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 21, 25, 418, DateTimeKind.Local).AddTicks(1375));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 21, 25, 419, DateTimeKind.Local).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 21, 25, 419, DateTimeKind.Local).AddTicks(2597));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PatientMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 29, 18, 18, 37, 854, DateTimeKind.Local).AddTicks(2113),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 10, 29, 18, 21, 25, 426, DateTimeKind.Local).AddTicks(3168));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "HospitalMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 29, 18, 18, 37, 843, DateTimeKind.Local).AddTicks(9154),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 10, 29, 18, 21, 25, 422, DateTimeKind.Local).AddTicks(9784));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodTypeMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 29, 18, 18, 37, 857, DateTimeKind.Local).AddTicks(3029),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 10, 29, 18, 21, 25, 427, DateTimeKind.Local).AddTicks(1622));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodProviderLogins",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 29, 18, 18, 37, 858, DateTimeKind.Local).AddTicks(2171),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 10, 29, 18, 21, 25, 427, DateTimeKind.Local).AddTicks(4085));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FloorMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 29, 18, 18, 37, 858, DateTimeKind.Local).AddTicks(9782),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 10, 29, 18, 21, 25, 427, DateTimeKind.Local).AddTicks(6078));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DIETMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 29, 18, 18, 37, 856, DateTimeKind.Local).AddTicks(5479),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 10, 29, 18, 21, 25, 426, DateTimeKind.Local).AddTicks(9519));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DieticianMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 29, 18, 18, 37, 855, DateTimeKind.Local).AddTicks(8021),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 10, 29, 18, 21, 25, 426, DateTimeKind.Local).AddTicks(7440));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedPatientMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 29, 18, 18, 37, 855, DateTimeKind.Local).AddTicks(33),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 10, 29, 18, 21, 25, 426, DateTimeKind.Local).AddTicks(5265));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 29, 18, 18, 37, 853, DateTimeKind.Local).AddTicks(227),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 10, 29, 18, 21, 25, 426, DateTimeKind.Local).AddTicks(709));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 18, 37, 838, DateTimeKind.Local).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 18, 37, 839, DateTimeKind.Local).AddTicks(2631));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 18, 37, 839, DateTimeKind.Local).AddTicks(2708));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 18, 37, 839, DateTimeKind.Local).AddTicks(2714));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 18, 37, 839, DateTimeKind.Local).AddTicks(2718));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 18, 37, 839, DateTimeKind.Local).AddTicks(2724));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 18, 37, 839, DateTimeKind.Local).AddTicks(2728));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 18, 37, 839, DateTimeKind.Local).AddTicks(2733));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 18, 37, 839, DateTimeKind.Local).AddTicks(2739));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 18, 37, 839, DateTimeKind.Local).AddTicks(2743));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 18, 37, 821, DateTimeKind.Local).AddTicks(7696));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 18, 37, 824, DateTimeKind.Local).AddTicks(3241));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 18, 37, 842, DateTimeKind.Local).AddTicks(3046));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 18, 37, 842, DateTimeKind.Local).AddTicks(5467));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 18, 37, 842, DateTimeKind.Local).AddTicks(5574));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 18, 37, 842, DateTimeKind.Local).AddTicks(5581));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 18, 37, 842, DateTimeKind.Local).AddTicks(5586));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 18, 37, 842, DateTimeKind.Local).AddTicks(5596));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 18, 37, 842, DateTimeKind.Local).AddTicks(5607));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 18, 37, 842, DateTimeKind.Local).AddTicks(5611));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 18, 37, 842, DateTimeKind.Local).AddTicks(5616));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 18, 37, 842, DateTimeKind.Local).AddTicks(5621));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 18, 37, 829, DateTimeKind.Local).AddTicks(9596));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 18, 37, 830, DateTimeKind.Local).AddTicks(2820));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 18, 37, 833, DateTimeKind.Local).AddTicks(5109));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 18, 37, 833, DateTimeKind.Local).AddTicks(8313));
        }
    }
}
