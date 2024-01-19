using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class Floors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BarcodeMasters");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PatientMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 29, 18, 18, 37, 854, DateTimeKind.Local).AddTicks(2113),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 29, 18, 8, 54, 403, DateTimeKind.Local).AddTicks(1005));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "HospitalMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 29, 18, 18, 37, 843, DateTimeKind.Local).AddTicks(9154),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 29, 18, 8, 54, 399, DateTimeKind.Local).AddTicks(1872));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodTypeMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 29, 18, 18, 37, 857, DateTimeKind.Local).AddTicks(3029),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 29, 18, 8, 54, 404, DateTimeKind.Local).AddTicks(6188));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodProviderLogins",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 29, 18, 18, 37, 858, DateTimeKind.Local).AddTicks(2171),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 29, 18, 8, 54, 404, DateTimeKind.Local).AddTicks(8732));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "FloorMasters",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FloorMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 29, 18, 18, 37, 858, DateTimeKind.Local).AddTicks(9782),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DIETMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 29, 18, 18, 37, 856, DateTimeKind.Local).AddTicks(5479),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 29, 18, 8, 54, 404, DateTimeKind.Local).AddTicks(394));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DieticianMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 29, 18, 18, 37, 855, DateTimeKind.Local).AddTicks(8021),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 29, 18, 8, 54, 403, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedPatientMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 29, 18, 18, 37, 855, DateTimeKind.Local).AddTicks(33),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 29, 18, 8, 54, 403, DateTimeKind.Local).AddTicks(4086));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 29, 18, 18, 37, 853, DateTimeKind.Local).AddTicks(227),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 29, 18, 8, 54, 402, DateTimeKind.Local).AddTicks(7734));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PatientMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 29, 18, 8, 54, 403, DateTimeKind.Local).AddTicks(1005),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 10, 29, 18, 18, 37, 854, DateTimeKind.Local).AddTicks(2113));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "HospitalMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 29, 18, 8, 54, 399, DateTimeKind.Local).AddTicks(1872),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 10, 29, 18, 18, 37, 843, DateTimeKind.Local).AddTicks(9154));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodTypeMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 29, 18, 8, 54, 404, DateTimeKind.Local).AddTicks(6188),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 10, 29, 18, 18, 37, 857, DateTimeKind.Local).AddTicks(3029));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodProviderLogins",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 29, 18, 8, 54, 404, DateTimeKind.Local).AddTicks(8732),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 10, 29, 18, 18, 37, 858, DateTimeKind.Local).AddTicks(2171));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "FloorMasters",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FloorMasters",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 10, 29, 18, 18, 37, 858, DateTimeKind.Local).AddTicks(9782));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DIETMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 29, 18, 8, 54, 404, DateTimeKind.Local).AddTicks(394),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 10, 29, 18, 18, 37, 856, DateTimeKind.Local).AddTicks(5479));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DieticianMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 29, 18, 8, 54, 403, DateTimeKind.Local).AddTicks(7308),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 10, 29, 18, 18, 37, 855, DateTimeKind.Local).AddTicks(8021));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedPatientMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 29, 18, 8, 54, 403, DateTimeKind.Local).AddTicks(4086),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 10, 29, 18, 18, 37, 855, DateTimeKind.Local).AddTicks(33));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 29, 18, 8, 54, 402, DateTimeKind.Local).AddTicks(7734),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 10, 29, 18, 18, 37, 853, DateTimeKind.Local).AddTicks(227));

            migrationBuilder.CreateTable(
                name: "BarcodeMasters",
                columns: table => new
                {
                    BarcodeMasterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 10, 29, 18, 8, 54, 404, DateTimeKind.Local).AddTicks(3261)),
                    GenerateQRCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    QRCodeImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BarcodeMasters", x => x.BarcodeMasterId);
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 8, 54, 396, DateTimeKind.Local).AddTicks(6258));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 8, 54, 396, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 8, 54, 396, DateTimeKind.Local).AddTicks(7543));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 8, 54, 396, DateTimeKind.Local).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 8, 54, 396, DateTimeKind.Local).AddTicks(7548));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 8, 54, 396, DateTimeKind.Local).AddTicks(7549));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 8, 54, 396, DateTimeKind.Local).AddTicks(7551));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 8, 54, 396, DateTimeKind.Local).AddTicks(7553));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 8, 54, 396, DateTimeKind.Local).AddTicks(7555));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 8, 54, 396, DateTimeKind.Local).AddTicks(7557));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 8, 54, 388, DateTimeKind.Local).AddTicks(8966));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 8, 54, 390, DateTimeKind.Local).AddTicks(2387));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 8, 54, 398, DateTimeKind.Local).AddTicks(3875));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 8, 54, 398, DateTimeKind.Local).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 8, 54, 398, DateTimeKind.Local).AddTicks(5185));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 8, 54, 398, DateTimeKind.Local).AddTicks(5187));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 8, 54, 398, DateTimeKind.Local).AddTicks(5189));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 8, 54, 398, DateTimeKind.Local).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 8, 54, 398, DateTimeKind.Local).AddTicks(5192));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 8, 54, 398, DateTimeKind.Local).AddTicks(5193));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 8, 54, 398, DateTimeKind.Local).AddTicks(5195));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 8, 54, 398, DateTimeKind.Local).AddTicks(5197));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 8, 54, 392, DateTimeKind.Local).AddTicks(7956));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 8, 54, 392, DateTimeKind.Local).AddTicks(8903));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 8, 54, 394, DateTimeKind.Local).AddTicks(2574));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 10, 29, 18, 8, 54, 394, DateTimeKind.Local).AddTicks(3994));
        }
    }
}
