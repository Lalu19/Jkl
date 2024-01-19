using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class PatientType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PatientMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 7, 15, 22, 13, 27, DateTimeKind.Local).AddTicks(1880),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 10, 10, 15, 7, 653, DateTimeKind.Local).AddTicks(3467));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "HospitalMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 7, 15, 22, 13, 24, DateTimeKind.Local).AddTicks(1775),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 10, 10, 15, 7, 644, DateTimeKind.Local).AddTicks(7975));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodTypeMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 7, 15, 22, 13, 28, DateTimeKind.Local).AddTicks(460),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 10, 10, 15, 7, 655, DateTimeKind.Local).AddTicks(8396));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodProviderLogins",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 7, 15, 22, 13, 28, DateTimeKind.Local).AddTicks(2647),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 10, 10, 15, 7, 656, DateTimeKind.Local).AddTicks(3513));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FloorMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 7, 15, 22, 13, 28, DateTimeKind.Local).AddTicks(4700),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 10, 10, 15, 7, 656, DateTimeKind.Local).AddTicks(8432));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DIETMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 7, 15, 22, 13, 27, DateTimeKind.Local).AddTicks(8246),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 10, 10, 15, 7, 655, DateTimeKind.Local).AddTicks(3624));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DieticianMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 7, 15, 22, 13, 27, DateTimeKind.Local).AddTicks(6120),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 10, 10, 15, 7, 654, DateTimeKind.Local).AddTicks(8586));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedPatientMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 7, 15, 22, 13, 27, DateTimeKind.Local).AddTicks(3996),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 10, 10, 15, 7, 654, DateTimeKind.Local).AddTicks(1506));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 7, 15, 22, 13, 26, DateTimeKind.Local).AddTicks(9559),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 10, 10, 15, 7, 652, DateTimeKind.Local).AddTicks(5137));

            migrationBuilder.CreateTable(
                name: "PatientType",
                columns: table => new
                {
                    PatientTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeOfPatient = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2022, 12, 7, 15, 22, 13, 28, DateTimeKind.Local).AddTicks(6725)),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientType", x => x.PatientTypeId);
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 22, 13, 22, DateTimeKind.Local).AddTicks(4397));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 22, 13, 22, DateTimeKind.Local).AddTicks(5239));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 22, 13, 22, DateTimeKind.Local).AddTicks(5282));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 22, 13, 22, DateTimeKind.Local).AddTicks(5284));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 22, 13, 22, DateTimeKind.Local).AddTicks(5286));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 22, 13, 22, DateTimeKind.Local).AddTicks(5288));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 22, 13, 22, DateTimeKind.Local).AddTicks(5289));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 22, 13, 22, DateTimeKind.Local).AddTicks(5291));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 22, 13, 22, DateTimeKind.Local).AddTicks(5293));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 22, 13, 22, DateTimeKind.Local).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 22, 13, 16, DateTimeKind.Local).AddTicks(8065));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 22, 13, 17, DateTimeKind.Local).AddTicks(6787));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 22, 13, 23, DateTimeKind.Local).AddTicks(6329));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 22, 13, 23, DateTimeKind.Local).AddTicks(7232));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 22, 13, 23, DateTimeKind.Local).AddTicks(7261));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 22, 13, 23, DateTimeKind.Local).AddTicks(7263));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 22, 13, 23, DateTimeKind.Local).AddTicks(7265));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 22, 13, 23, DateTimeKind.Local).AddTicks(7266));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 22, 13, 23, DateTimeKind.Local).AddTicks(7268));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 22, 13, 23, DateTimeKind.Local).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 22, 13, 23, DateTimeKind.Local).AddTicks(7271));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 22, 13, 23, DateTimeKind.Local).AddTicks(7273));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 22, 13, 19, DateTimeKind.Local).AddTicks(6526));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 22, 13, 19, DateTimeKind.Local).AddTicks(7286));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 22, 13, 20, DateTimeKind.Local).AddTicks(8092));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 12, 7, 15, 22, 13, 20, DateTimeKind.Local).AddTicks(9237));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PatientType");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PatientMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 10, 10, 15, 7, 653, DateTimeKind.Local).AddTicks(3467),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 7, 15, 22, 13, 27, DateTimeKind.Local).AddTicks(1880));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "HospitalMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 10, 10, 15, 7, 644, DateTimeKind.Local).AddTicks(7975),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 7, 15, 22, 13, 24, DateTimeKind.Local).AddTicks(1775));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodTypeMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 10, 10, 15, 7, 655, DateTimeKind.Local).AddTicks(8396),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 7, 15, 22, 13, 28, DateTimeKind.Local).AddTicks(460));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodProviderLogins",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 10, 10, 15, 7, 656, DateTimeKind.Local).AddTicks(3513),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 7, 15, 22, 13, 28, DateTimeKind.Local).AddTicks(2647));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FloorMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 10, 10, 15, 7, 656, DateTimeKind.Local).AddTicks(8432),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 7, 15, 22, 13, 28, DateTimeKind.Local).AddTicks(4700));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DIETMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 10, 10, 15, 7, 655, DateTimeKind.Local).AddTicks(3624),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 7, 15, 22, 13, 27, DateTimeKind.Local).AddTicks(8246));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DieticianMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 10, 10, 15, 7, 654, DateTimeKind.Local).AddTicks(8586),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 7, 15, 22, 13, 27, DateTimeKind.Local).AddTicks(6120));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedPatientMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 10, 10, 15, 7, 654, DateTimeKind.Local).AddTicks(1506),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 7, 15, 22, 13, 27, DateTimeKind.Local).AddTicks(3996));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 10, 10, 15, 7, 652, DateTimeKind.Local).AddTicks(5137),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 7, 15, 22, 13, 26, DateTimeKind.Local).AddTicks(9559));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 11, 10, 10, 15, 7, 641, DateTimeKind.Local).AddTicks(714));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 11, 10, 10, 15, 7, 641, DateTimeKind.Local).AddTicks(2485));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 11, 10, 10, 15, 7, 641, DateTimeKind.Local).AddTicks(2539));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2022, 11, 10, 10, 15, 7, 641, DateTimeKind.Local).AddTicks(2543));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2022, 11, 10, 10, 15, 7, 641, DateTimeKind.Local).AddTicks(2549));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2022, 11, 10, 10, 15, 7, 641, DateTimeKind.Local).AddTicks(2555));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2022, 11, 10, 10, 15, 7, 641, DateTimeKind.Local).AddTicks(2560));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2022, 11, 10, 10, 15, 7, 641, DateTimeKind.Local).AddTicks(2564));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2022, 11, 10, 10, 15, 7, 641, DateTimeKind.Local).AddTicks(2683));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2022, 11, 10, 10, 15, 7, 641, DateTimeKind.Local).AddTicks(2689));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 11, 10, 10, 15, 7, 627, DateTimeKind.Local).AddTicks(8403));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 11, 10, 10, 15, 7, 629, DateTimeKind.Local).AddTicks(7822));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 11, 10, 10, 15, 7, 643, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 11, 10, 10, 15, 7, 643, DateTimeKind.Local).AddTicks(8188));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 11, 10, 10, 15, 7, 643, DateTimeKind.Local).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2022, 11, 10, 10, 15, 7, 643, DateTimeKind.Local).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2022, 11, 10, 10, 15, 7, 643, DateTimeKind.Local).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2022, 11, 10, 10, 15, 7, 643, DateTimeKind.Local).AddTicks(8261));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2022, 11, 10, 10, 15, 7, 643, DateTimeKind.Local).AddTicks(8265));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2022, 11, 10, 10, 15, 7, 643, DateTimeKind.Local).AddTicks(8268));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2022, 11, 10, 10, 15, 7, 643, DateTimeKind.Local).AddTicks(8271));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2022, 11, 10, 10, 15, 7, 643, DateTimeKind.Local).AddTicks(8275));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 11, 10, 10, 15, 7, 634, DateTimeKind.Local).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 11, 10, 10, 15, 7, 634, DateTimeKind.Local).AddTicks(9478));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 11, 10, 10, 15, 7, 637, DateTimeKind.Local).AddTicks(7353));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 11, 10, 10, 15, 7, 637, DateTimeKind.Local).AddTicks(9505));
        }
    }
}
