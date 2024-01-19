using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class IP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Supervisor",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 11, 13, 32, 52, 691, DateTimeKind.Local).AddTicks(2668),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 17, 11, 11, 39, 694, DateTimeKind.Local).AddTicks(3743));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PatientType",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 11, 13, 32, 52, 690, DateTimeKind.Local).AddTicks(6156),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 17, 11, 11, 39, 693, DateTimeKind.Local).AddTicks(7371));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "HospitalMasters",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 11, 13, 32, 52, 686, DateTimeKind.Local).AddTicks(9057),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 17, 11, 11, 39, 690, DateTimeKind.Local).AddTicks(322));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodServiceType",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 11, 13, 32, 52, 690, DateTimeKind.Local).AddTicks(8276),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 17, 11, 11, 39, 693, DateTimeKind.Local).AddTicks(9428));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodProviderLogins",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 11, 13, 32, 52, 690, DateTimeKind.Local).AddTicks(4022),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 17, 11, 11, 39, 693, DateTimeKind.Local).AddTicks(5280));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DietType",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 11, 13, 32, 52, 691, DateTimeKind.Local).AddTicks(573),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 17, 11, 11, 39, 694, DateTimeKind.Local).AddTicks(1741));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DIETMasters",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 11, 13, 32, 52, 690, DateTimeKind.Local).AddTicks(1748),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 17, 11, 11, 39, 693, DateTimeKind.Local).AddTicks(3075));

            migrationBuilder.AddColumn<string>(
                name: "IP",
                table: "DIETMasters",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DieticianMasters",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 11, 13, 32, 52, 689, DateTimeKind.Local).AddTicks(9556),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 17, 11, 11, 39, 693, DateTimeKind.Local).AddTicks(939));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedMasters",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 11, 13, 32, 52, 689, DateTimeKind.Local).AddTicks(7189),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 12, 17, 11, 11, 39, 692, DateTimeKind.Local).AddTicks(8655));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IP",
                table: "DIETMasters");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 17, 11, 11, 39, 694, DateTimeKind.Local).AddTicks(3743),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 1, 11, 13, 32, 52, 691, DateTimeKind.Local).AddTicks(2668));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PatientType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 17, 11, 11, 39, 693, DateTimeKind.Local).AddTicks(7371),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 1, 11, 13, 32, 52, 690, DateTimeKind.Local).AddTicks(6156));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "HospitalMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 17, 11, 11, 39, 690, DateTimeKind.Local).AddTicks(322),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 1, 11, 13, 32, 52, 686, DateTimeKind.Local).AddTicks(9057));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodServiceType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 17, 11, 11, 39, 693, DateTimeKind.Local).AddTicks(9428),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 1, 11, 13, 32, 52, 690, DateTimeKind.Local).AddTicks(8276));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FoodProviderLogins",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 17, 11, 11, 39, 693, DateTimeKind.Local).AddTicks(5280),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 1, 11, 13, 32, 52, 690, DateTimeKind.Local).AddTicks(4022));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DietType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 17, 11, 11, 39, 694, DateTimeKind.Local).AddTicks(1741),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 1, 11, 13, 32, 52, 691, DateTimeKind.Local).AddTicks(573));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DIETMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 17, 11, 11, 39, 693, DateTimeKind.Local).AddTicks(3075),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 1, 11, 13, 32, 52, 690, DateTimeKind.Local).AddTicks(1748));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DieticianMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 17, 11, 11, 39, 693, DateTimeKind.Local).AddTicks(939),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 1, 11, 13, 32, 52, 689, DateTimeKind.Local).AddTicks(9556));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "BedMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 12, 17, 11, 11, 39, 692, DateTimeKind.Local).AddTicks(8655),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 1, 11, 13, 32, 52, 689, DateTimeKind.Local).AddTicks(7189));

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
    }
}
