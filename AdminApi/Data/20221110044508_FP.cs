using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class FP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PatientMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 10, 10, 15, 7, 653, DateTimeKind.Local).AddTicks(3467),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 1, 13, 52, 7, 672, DateTimeKind.Local).AddTicks(9824));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "HospitalMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 10, 10, 15, 7, 644, DateTimeKind.Local).AddTicks(7975),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 1, 13, 52, 7, 669, DateTimeKind.Local).AddTicks(8035));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodTypeMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 10, 10, 15, 7, 655, DateTimeKind.Local).AddTicks(8396),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 1, 13, 52, 7, 673, DateTimeKind.Local).AddTicks(8389));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodProviderLogins",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 10, 10, 15, 7, 656, DateTimeKind.Local).AddTicks(3513),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 1, 13, 52, 7, 674, DateTimeKind.Local).AddTicks(734));

            migrationBuilder.AddColumn<int>(
                name: "HospitalMasterid",
                table: "FoodProviderLogins",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FloorMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 10, 10, 15, 7, 656, DateTimeKind.Local).AddTicks(8432),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 1, 13, 52, 7, 674, DateTimeKind.Local).AddTicks(2695));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DIETMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 10, 10, 15, 7, 655, DateTimeKind.Local).AddTicks(3624),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 1, 13, 52, 7, 673, DateTimeKind.Local).AddTicks(6288));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DieticianMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 10, 10, 15, 7, 654, DateTimeKind.Local).AddTicks(8586),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 1, 13, 52, 7, 673, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedPatientMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 10, 10, 15, 7, 654, DateTimeKind.Local).AddTicks(1506),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 1, 13, 52, 7, 673, DateTimeKind.Local).AddTicks(1919));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 10, 10, 15, 7, 652, DateTimeKind.Local).AddTicks(5137),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 1, 13, 52, 7, 672, DateTimeKind.Local).AddTicks(7373));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HospitalMasterid",
                table: "FoodProviderLogins");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PatientMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 13, 52, 7, 672, DateTimeKind.Local).AddTicks(9824),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 11, 10, 10, 15, 7, 653, DateTimeKind.Local).AddTicks(3467));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "HospitalMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 13, 52, 7, 669, DateTimeKind.Local).AddTicks(8035),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 11, 10, 10, 15, 7, 644, DateTimeKind.Local).AddTicks(7975));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodTypeMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 13, 52, 7, 673, DateTimeKind.Local).AddTicks(8389),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 11, 10, 10, 15, 7, 655, DateTimeKind.Local).AddTicks(8396));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodProviderLogins",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 13, 52, 7, 674, DateTimeKind.Local).AddTicks(734),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 11, 10, 10, 15, 7, 656, DateTimeKind.Local).AddTicks(3513));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FloorMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 13, 52, 7, 674, DateTimeKind.Local).AddTicks(2695),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 11, 10, 10, 15, 7, 656, DateTimeKind.Local).AddTicks(8432));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DIETMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 13, 52, 7, 673, DateTimeKind.Local).AddTicks(6288),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 11, 10, 10, 15, 7, 655, DateTimeKind.Local).AddTicks(3624));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DieticianMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 13, 52, 7, 673, DateTimeKind.Local).AddTicks(4180),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 11, 10, 10, 15, 7, 654, DateTimeKind.Local).AddTicks(8586));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedPatientMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 13, 52, 7, 673, DateTimeKind.Local).AddTicks(1919),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 11, 10, 10, 15, 7, 654, DateTimeKind.Local).AddTicks(1506));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 1, 13, 52, 7, 672, DateTimeKind.Local).AddTicks(7373),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 11, 10, 10, 15, 7, 652, DateTimeKind.Local).AddTicks(5137));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 13, 52, 7, 667, DateTimeKind.Local).AddTicks(9640));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 13, 52, 7, 668, DateTimeKind.Local).AddTicks(527));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 13, 52, 7, 668, DateTimeKind.Local).AddTicks(596));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 13, 52, 7, 668, DateTimeKind.Local).AddTicks(599));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 13, 52, 7, 668, DateTimeKind.Local).AddTicks(603));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 13, 52, 7, 668, DateTimeKind.Local).AddTicks(605));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 13, 52, 7, 668, DateTimeKind.Local).AddTicks(609));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 13, 52, 7, 668, DateTimeKind.Local).AddTicks(612));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 13, 52, 7, 668, DateTimeKind.Local).AddTicks(614));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 13, 52, 7, 668, DateTimeKind.Local).AddTicks(616));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 13, 52, 7, 661, DateTimeKind.Local).AddTicks(8098));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 13, 52, 7, 662, DateTimeKind.Local).AddTicks(7271));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 13, 52, 7, 669, DateTimeKind.Local).AddTicks(2339));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 13, 52, 7, 669, DateTimeKind.Local).AddTicks(3177));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 13, 52, 7, 669, DateTimeKind.Local).AddTicks(3203));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 13, 52, 7, 669, DateTimeKind.Local).AddTicks(3204));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 13, 52, 7, 669, DateTimeKind.Local).AddTicks(3206));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 13, 52, 7, 669, DateTimeKind.Local).AddTicks(3208));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 13, 52, 7, 669, DateTimeKind.Local).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 13, 52, 7, 669, DateTimeKind.Local).AddTicks(3211));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 13, 52, 7, 669, DateTimeKind.Local).AddTicks(3213));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 13, 52, 7, 669, DateTimeKind.Local).AddTicks(3215));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 13, 52, 7, 664, DateTimeKind.Local).AddTicks(8759));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 13, 52, 7, 664, DateTimeKind.Local).AddTicks(9531));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 13, 52, 7, 665, DateTimeKind.Local).AddTicks(9956));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 11, 1, 13, 52, 7, 666, DateTimeKind.Local).AddTicks(957));
        }
    }
}
