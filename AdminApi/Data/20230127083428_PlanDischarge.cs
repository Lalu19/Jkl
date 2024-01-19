using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class PlanDischarge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Supervisor",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 27, 14, 4, 27, 671, DateTimeKind.Local).AddTicks(9253),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 11, 13, 32, 52, 691, DateTimeKind.Local).AddTicks(2668));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PatientType",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 27, 14, 4, 27, 671, DateTimeKind.Local).AddTicks(2208),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 11, 13, 32, 52, 690, DateTimeKind.Local).AddTicks(6156));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "HospitalMasters",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 27, 14, 4, 27, 667, DateTimeKind.Local).AddTicks(3533),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 11, 13, 32, 52, 686, DateTimeKind.Local).AddTicks(9057));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodServiceType",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 27, 14, 4, 27, 671, DateTimeKind.Local).AddTicks(4451),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 11, 13, 32, 52, 690, DateTimeKind.Local).AddTicks(8276));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodProviderLogins",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 27, 14, 4, 27, 670, DateTimeKind.Local).AddTicks(9749),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 11, 13, 32, 52, 690, DateTimeKind.Local).AddTicks(4022));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DietType",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 27, 14, 4, 27, 671, DateTimeKind.Local).AddTicks(6922),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 11, 13, 32, 52, 691, DateTimeKind.Local).AddTicks(573));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DIETMasters",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 27, 14, 4, 27, 670, DateTimeKind.Local).AddTicks(7309),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 11, 13, 32, 52, 690, DateTimeKind.Local).AddTicks(1748));

            migrationBuilder.AddColumn<string>(
                name: "PatientStatus",
                table: "DIETMasters",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DieticianMasters",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 27, 14, 4, 27, 670, DateTimeKind.Local).AddTicks(4833),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 11, 13, 32, 52, 689, DateTimeKind.Local).AddTicks(9556));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedMasters",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 27, 14, 4, 27, 670, DateTimeKind.Local).AddTicks(2389),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 11, 13, 32, 52, 689, DateTimeKind.Local).AddTicks(7189));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PatientStatus",
                table: "DIETMasters");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 11, 13, 32, 52, 691, DateTimeKind.Local).AddTicks(2668),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 1, 27, 14, 4, 27, 671, DateTimeKind.Local).AddTicks(9253));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PatientType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 11, 13, 32, 52, 690, DateTimeKind.Local).AddTicks(6156),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 1, 27, 14, 4, 27, 671, DateTimeKind.Local).AddTicks(2208));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "HospitalMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 11, 13, 32, 52, 686, DateTimeKind.Local).AddTicks(9057),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 1, 27, 14, 4, 27, 667, DateTimeKind.Local).AddTicks(3533));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodServiceType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 11, 13, 32, 52, 690, DateTimeKind.Local).AddTicks(8276),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 1, 27, 14, 4, 27, 671, DateTimeKind.Local).AddTicks(4451));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodProviderLogins",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 11, 13, 32, 52, 690, DateTimeKind.Local).AddTicks(4022),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 1, 27, 14, 4, 27, 670, DateTimeKind.Local).AddTicks(9749));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DietType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 11, 13, 32, 52, 691, DateTimeKind.Local).AddTicks(573),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 1, 27, 14, 4, 27, 671, DateTimeKind.Local).AddTicks(6922));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DIETMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 11, 13, 32, 52, 690, DateTimeKind.Local).AddTicks(1748),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 1, 27, 14, 4, 27, 670, DateTimeKind.Local).AddTicks(7309));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DieticianMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 11, 13, 32, 52, 689, DateTimeKind.Local).AddTicks(9556),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 1, 27, 14, 4, 27, 670, DateTimeKind.Local).AddTicks(4833));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 11, 13, 32, 52, 689, DateTimeKind.Local).AddTicks(7189),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 1, 27, 14, 4, 27, 670, DateTimeKind.Local).AddTicks(2389));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 1, 11, 13, 32, 52, 685, DateTimeKind.Local).AddTicks(2244));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 1, 11, 13, 32, 52, 685, DateTimeKind.Local).AddTicks(3091));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 1, 11, 13, 32, 52, 685, DateTimeKind.Local).AddTicks(3135));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 1, 11, 13, 32, 52, 685, DateTimeKind.Local).AddTicks(3137));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 1, 11, 13, 32, 52, 685, DateTimeKind.Local).AddTicks(3139));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 1, 11, 13, 32, 52, 685, DateTimeKind.Local).AddTicks(3141));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 1, 11, 13, 32, 52, 685, DateTimeKind.Local).AddTicks(3143));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 1, 11, 13, 32, 52, 685, DateTimeKind.Local).AddTicks(3144));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 1, 11, 13, 32, 52, 685, DateTimeKind.Local).AddTicks(3146));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 1, 11, 13, 32, 52, 685, DateTimeKind.Local).AddTicks(3148));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 1, 11, 13, 32, 52, 679, DateTimeKind.Local).AddTicks(7486));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 1, 11, 13, 32, 52, 680, DateTimeKind.Local).AddTicks(6357));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 1, 11, 13, 32, 52, 686, DateTimeKind.Local).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 1, 11, 13, 32, 52, 686, DateTimeKind.Local).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2023, 1, 11, 13, 32, 52, 686, DateTimeKind.Local).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2023, 1, 11, 13, 32, 52, 686, DateTimeKind.Local).AddTicks(4733));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2023, 1, 11, 13, 32, 52, 686, DateTimeKind.Local).AddTicks(4734));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2023, 1, 11, 13, 32, 52, 686, DateTimeKind.Local).AddTicks(4736));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2023, 1, 11, 13, 32, 52, 686, DateTimeKind.Local).AddTicks(4737));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2023, 1, 11, 13, 32, 52, 686, DateTimeKind.Local).AddTicks(4739));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2023, 1, 11, 13, 32, 52, 686, DateTimeKind.Local).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2023, 1, 11, 13, 32, 52, 686, DateTimeKind.Local).AddTicks(4742));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 1, 11, 13, 32, 52, 682, DateTimeKind.Local).AddTicks(6325));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 1, 11, 13, 32, 52, 682, DateTimeKind.Local).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 1, 11, 13, 32, 52, 683, DateTimeKind.Local).AddTicks(6704));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 1, 11, 13, 32, 52, 683, DateTimeKind.Local).AddTicks(7690));
        }
    }
}
