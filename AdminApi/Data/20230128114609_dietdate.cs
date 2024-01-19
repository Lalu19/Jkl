using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class dietdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Supervisor",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 28, 17, 16, 7, 996, DateTimeKind.Local).AddTicks(5624),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 27, 14, 4, 27, 671, DateTimeKind.Local).AddTicks(9253));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PatientType",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 28, 17, 16, 7, 995, DateTimeKind.Local).AddTicks(7774),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 27, 14, 4, 27, 671, DateTimeKind.Local).AddTicks(2208));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "HospitalMasters",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 28, 17, 16, 7, 989, DateTimeKind.Local).AddTicks(356),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 27, 14, 4, 27, 667, DateTimeKind.Local).AddTicks(3533));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodServiceType",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 28, 17, 16, 7, 996, DateTimeKind.Local).AddTicks(565),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 27, 14, 4, 27, 671, DateTimeKind.Local).AddTicks(4451));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodProviderLogins",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 28, 17, 16, 7, 995, DateTimeKind.Local).AddTicks(5004),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 27, 14, 4, 27, 670, DateTimeKind.Local).AddTicks(9749));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DietType",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 28, 17, 16, 7, 996, DateTimeKind.Local).AddTicks(3147),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 27, 14, 4, 27, 671, DateTimeKind.Local).AddTicks(6922));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DIETMasters",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 28, 17, 16, 7, 995, DateTimeKind.Local).AddTicks(2214),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 27, 14, 4, 27, 670, DateTimeKind.Local).AddTicks(7309));

            migrationBuilder.AddColumn<DateTime>(
                name: "DietDate",
                table: "DIETMasters",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DieticianMasters",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 28, 17, 16, 7, 994, DateTimeKind.Local).AddTicks(9451),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 27, 14, 4, 27, 670, DateTimeKind.Local).AddTicks(4833));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedMasters",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 28, 17, 16, 7, 994, DateTimeKind.Local).AddTicks(6682),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 27, 14, 4, 27, 670, DateTimeKind.Local).AddTicks(2389));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 1, 28, 17, 16, 7, 985, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 1, 28, 17, 16, 7, 985, DateTimeKind.Local).AddTicks(8095));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 1, 28, 17, 16, 7, 985, DateTimeKind.Local).AddTicks(8109));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 1, 28, 17, 16, 7, 985, DateTimeKind.Local).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 1, 28, 17, 16, 7, 985, DateTimeKind.Local).AddTicks(8238));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 1, 28, 17, 16, 7, 985, DateTimeKind.Local).AddTicks(8242));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 1, 28, 17, 16, 7, 985, DateTimeKind.Local).AddTicks(8247));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 1, 28, 17, 16, 7, 985, DateTimeKind.Local).AddTicks(8251));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 1, 28, 17, 16, 7, 985, DateTimeKind.Local).AddTicks(8255));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 1, 28, 17, 16, 7, 985, DateTimeKind.Local).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 1, 28, 17, 16, 7, 974, DateTimeKind.Local).AddTicks(2905));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 1, 28, 17, 16, 7, 976, DateTimeKind.Local).AddTicks(2550));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 1, 28, 17, 16, 7, 988, DateTimeKind.Local).AddTicks(797));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 1, 28, 17, 16, 7, 988, DateTimeKind.Local).AddTicks(2571));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 1, 28, 17, 16, 7, 988, DateTimeKind.Local).AddTicks(2582));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 1, 28, 17, 16, 7, 988, DateTimeKind.Local).AddTicks(2586));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 1, 28, 17, 16, 7, 988, DateTimeKind.Local).AddTicks(2590));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 1, 28, 17, 16, 7, 988, DateTimeKind.Local).AddTicks(2593));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 1, 28, 17, 16, 7, 988, DateTimeKind.Local).AddTicks(2597));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 1, 28, 17, 16, 7, 988, DateTimeKind.Local).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 1, 28, 17, 16, 7, 988, DateTimeKind.Local).AddTicks(2604));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 1, 28, 17, 16, 7, 988, DateTimeKind.Local).AddTicks(2607));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 1, 28, 17, 16, 7, 980, DateTimeKind.Local).AddTicks(2705));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 1, 28, 17, 16, 7, 980, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 1, 28, 17, 16, 7, 982, DateTimeKind.Local).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 1, 28, 17, 16, 7, 982, DateTimeKind.Local).AddTicks(6388));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DietDate",
                table: "DIETMasters");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 27, 14, 4, 27, 671, DateTimeKind.Local).AddTicks(9253),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 1, 28, 17, 16, 7, 996, DateTimeKind.Local).AddTicks(5624));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PatientType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 27, 14, 4, 27, 671, DateTimeKind.Local).AddTicks(2208),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 1, 28, 17, 16, 7, 995, DateTimeKind.Local).AddTicks(7774));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "HospitalMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 27, 14, 4, 27, 667, DateTimeKind.Local).AddTicks(3533),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 1, 28, 17, 16, 7, 989, DateTimeKind.Local).AddTicks(356));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodServiceType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 27, 14, 4, 27, 671, DateTimeKind.Local).AddTicks(4451),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 1, 28, 17, 16, 7, 996, DateTimeKind.Local).AddTicks(565));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodProviderLogins",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 27, 14, 4, 27, 670, DateTimeKind.Local).AddTicks(9749),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 1, 28, 17, 16, 7, 995, DateTimeKind.Local).AddTicks(5004));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DietType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 27, 14, 4, 27, 671, DateTimeKind.Local).AddTicks(6922),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 1, 28, 17, 16, 7, 996, DateTimeKind.Local).AddTicks(3147));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DIETMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 27, 14, 4, 27, 670, DateTimeKind.Local).AddTicks(7309),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 1, 28, 17, 16, 7, 995, DateTimeKind.Local).AddTicks(2214));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DieticianMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 27, 14, 4, 27, 670, DateTimeKind.Local).AddTicks(4833),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 1, 28, 17, 16, 7, 994, DateTimeKind.Local).AddTicks(9451));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 27, 14, 4, 27, 670, DateTimeKind.Local).AddTicks(2389),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 1, 28, 17, 16, 7, 994, DateTimeKind.Local).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 1, 27, 14, 4, 27, 665, DateTimeKind.Local).AddTicks(5104));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 1, 27, 14, 4, 27, 665, DateTimeKind.Local).AddTicks(5929));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 1, 27, 14, 4, 27, 665, DateTimeKind.Local).AddTicks(5972));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 1, 27, 14, 4, 27, 665, DateTimeKind.Local).AddTicks(5975));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 1, 27, 14, 4, 27, 665, DateTimeKind.Local).AddTicks(5977));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 1, 27, 14, 4, 27, 665, DateTimeKind.Local).AddTicks(5980));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 1, 27, 14, 4, 27, 665, DateTimeKind.Local).AddTicks(5982));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 1, 27, 14, 4, 27, 665, DateTimeKind.Local).AddTicks(5984));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 1, 27, 14, 4, 27, 665, DateTimeKind.Local).AddTicks(5986));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 1, 27, 14, 4, 27, 665, DateTimeKind.Local).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 1, 27, 14, 4, 27, 659, DateTimeKind.Local).AddTicks(6136));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 1, 27, 14, 4, 27, 660, DateTimeKind.Local).AddTicks(7065));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 1, 27, 14, 4, 27, 666, DateTimeKind.Local).AddTicks(7225));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 1, 27, 14, 4, 27, 666, DateTimeKind.Local).AddTicks(8114));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 1, 27, 14, 4, 27, 666, DateTimeKind.Local).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 1, 27, 14, 4, 27, 666, DateTimeKind.Local).AddTicks(8186));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 1, 27, 14, 4, 27, 666, DateTimeKind.Local).AddTicks(8188));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 1, 27, 14, 4, 27, 666, DateTimeKind.Local).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 1, 27, 14, 4, 27, 666, DateTimeKind.Local).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 1, 27, 14, 4, 27, 666, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 1, 27, 14, 4, 27, 666, DateTimeKind.Local).AddTicks(8195));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 1, 27, 14, 4, 27, 666, DateTimeKind.Local).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 1, 27, 14, 4, 27, 662, DateTimeKind.Local).AddTicks(8227));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 1, 27, 14, 4, 27, 662, DateTimeKind.Local).AddTicks(8979));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 1, 27, 14, 4, 27, 663, DateTimeKind.Local).AddTicks(9061));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 1, 27, 14, 4, 27, 664, DateTimeKind.Local).AddTicks(68));
        }
    }
}
