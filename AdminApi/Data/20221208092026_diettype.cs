using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class diettype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PatientType",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 8, 14, 50, 24, 502, DateTimeKind.Local).AddTicks(4783),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 8, 12, 58, 13, 902, DateTimeKind.Local).AddTicks(1789));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "HospitalMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 8, 14, 50, 24, 490, DateTimeKind.Local).AddTicks(5387),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 8, 12, 58, 13, 898, DateTimeKind.Local).AddTicks(3735));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodServiceType",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 8, 14, 50, 24, 503, DateTimeKind.Local).AddTicks(4632),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 8, 12, 58, 13, 902, DateTimeKind.Local).AddTicks(3881));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodProviderLogins",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 8, 14, 50, 24, 501, DateTimeKind.Local).AddTicks(5765),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 8, 12, 58, 13, 901, DateTimeKind.Local).AddTicks(9552));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DIETMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 8, 14, 50, 24, 500, DateTimeKind.Local).AddTicks(7731),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 8, 12, 58, 13, 901, DateTimeKind.Local).AddTicks(7443));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DieticianMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 8, 14, 50, 24, 499, DateTimeKind.Local).AddTicks(8794),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 8, 12, 58, 13, 901, DateTimeKind.Local).AddTicks(5161));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedMasters",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 8, 14, 50, 24, 499, DateTimeKind.Local).AddTicks(1128),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 8, 12, 58, 13, 901, DateTimeKind.Local).AddTicks(2738));

            migrationBuilder.CreateTable(
                name: "DietType",
                columns: table => new
                {
                    DietTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DietTypeName = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2022, 12, 8, 14, 50, 24, 504, DateTimeKind.Local).AddTicks(4806)),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DietType", x => x.DietTypeId);
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 14, 50, 24, 484, DateTimeKind.Local).AddTicks(1967));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 14, 50, 24, 484, DateTimeKind.Local).AddTicks(4730));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 14, 50, 24, 484, DateTimeKind.Local).AddTicks(4877));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 14, 50, 24, 484, DateTimeKind.Local).AddTicks(4884));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 14, 50, 24, 484, DateTimeKind.Local).AddTicks(5031));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 14, 50, 24, 484, DateTimeKind.Local).AddTicks(5044));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 14, 50, 24, 484, DateTimeKind.Local).AddTicks(5054));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 14, 50, 24, 484, DateTimeKind.Local).AddTicks(5065));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 14, 50, 24, 484, DateTimeKind.Local).AddTicks(5071));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 14, 50, 24, 484, DateTimeKind.Local).AddTicks(5078));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 14, 50, 24, 466, DateTimeKind.Local).AddTicks(3054));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 14, 50, 24, 468, DateTimeKind.Local).AddTicks(7838));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 14, 50, 24, 488, DateTimeKind.Local).AddTicks(2389));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 14, 50, 24, 488, DateTimeKind.Local).AddTicks(4978));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 14, 50, 24, 488, DateTimeKind.Local).AddTicks(5077));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 14, 50, 24, 488, DateTimeKind.Local).AddTicks(5088));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 14, 50, 24, 488, DateTimeKind.Local).AddTicks(5097));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 14, 50, 24, 488, DateTimeKind.Local).AddTicks(5107));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 14, 50, 24, 488, DateTimeKind.Local).AddTicks(5117));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 14, 50, 24, 488, DateTimeKind.Local).AddTicks(5122));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 14, 50, 24, 488, DateTimeKind.Local).AddTicks(5127));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 14, 50, 24, 488, DateTimeKind.Local).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 14, 50, 24, 475, DateTimeKind.Local).AddTicks(494));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 14, 50, 24, 475, DateTimeKind.Local).AddTicks(3253));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 14, 50, 24, 478, DateTimeKind.Local).AddTicks(8397));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 14, 50, 24, 479, DateTimeKind.Local).AddTicks(1841));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DietType");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PatientType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 8, 12, 58, 13, 902, DateTimeKind.Local).AddTicks(1789),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 8, 14, 50, 24, 502, DateTimeKind.Local).AddTicks(4783));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "HospitalMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 8, 12, 58, 13, 898, DateTimeKind.Local).AddTicks(3735),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 8, 14, 50, 24, 490, DateTimeKind.Local).AddTicks(5387));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodServiceType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 8, 12, 58, 13, 902, DateTimeKind.Local).AddTicks(3881),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 8, 14, 50, 24, 503, DateTimeKind.Local).AddTicks(4632));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodProviderLogins",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 8, 12, 58, 13, 901, DateTimeKind.Local).AddTicks(9552),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 8, 14, 50, 24, 501, DateTimeKind.Local).AddTicks(5765));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DIETMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 8, 12, 58, 13, 901, DateTimeKind.Local).AddTicks(7443),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 8, 14, 50, 24, 500, DateTimeKind.Local).AddTicks(7731));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DieticianMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 8, 12, 58, 13, 901, DateTimeKind.Local).AddTicks(5161),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 8, 14, 50, 24, 499, DateTimeKind.Local).AddTicks(8794));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 8, 12, 58, 13, 901, DateTimeKind.Local).AddTicks(2738),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 12, 8, 14, 50, 24, 499, DateTimeKind.Local).AddTicks(1128));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 12, 58, 13, 896, DateTimeKind.Local).AddTicks(6111));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 12, 58, 13, 896, DateTimeKind.Local).AddTicks(6896));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 12, 58, 13, 896, DateTimeKind.Local).AddTicks(6943));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 12, 58, 13, 896, DateTimeKind.Local).AddTicks(6946));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 12, 58, 13, 896, DateTimeKind.Local).AddTicks(6948));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 12, 58, 13, 896, DateTimeKind.Local).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 12, 58, 13, 896, DateTimeKind.Local).AddTicks(6951));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 12, 58, 13, 896, DateTimeKind.Local).AddTicks(6953));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 12, 58, 13, 896, DateTimeKind.Local).AddTicks(6955));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 12, 58, 13, 896, DateTimeKind.Local).AddTicks(6957));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 12, 58, 13, 890, DateTimeKind.Local).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 12, 58, 13, 891, DateTimeKind.Local).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 12, 58, 13, 897, DateTimeKind.Local).AddTicks(8227));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 12, 58, 13, 897, DateTimeKind.Local).AddTicks(9063));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 12, 58, 13, 897, DateTimeKind.Local).AddTicks(9092));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 12, 58, 13, 897, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 12, 58, 13, 897, DateTimeKind.Local).AddTicks(9095));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 12, 58, 13, 897, DateTimeKind.Local).AddTicks(9097));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 12, 58, 13, 897, DateTimeKind.Local).AddTicks(9098));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 12, 58, 13, 897, DateTimeKind.Local).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 12, 58, 13, 897, DateTimeKind.Local).AddTicks(9101));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 12, 58, 13, 897, DateTimeKind.Local).AddTicks(9103));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 12, 58, 13, 893, DateTimeKind.Local).AddTicks(9378));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 12, 58, 13, 894, DateTimeKind.Local).AddTicks(126));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 12, 58, 13, 895, DateTimeKind.Local).AddTicks(425));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 12, 58, 13, 895, DateTimeKind.Local).AddTicks(1432));
        }
    }
}
