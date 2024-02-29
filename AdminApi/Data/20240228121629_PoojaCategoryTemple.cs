using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class PoojaCategoryTemple : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Temples",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 17, 46, 28, 218, DateTimeKind.Local).AddTicks(8278),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 138, DateTimeKind.Local).AddTicks(8225));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "States",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 17, 46, 28, 218, DateTimeKind.Local).AddTicks(4069),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 138, DateTimeKind.Local).AddTicks(3517));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Questions",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 17, 46, 28, 220, DateTimeKind.Local).AddTicks(9365),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 140, DateTimeKind.Local).AddTicks(460));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "QuestionMappings",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 17, 46, 28, 221, DateTimeKind.Local).AddTicks(2166),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 140, DateTimeKind.Local).AddTicks(2402));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryTypes",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 17, 46, 28, 220, DateTimeKind.Local).AddTicks(261),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 139, DateTimeKind.Local).AddTicks(5371));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryMappings",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 17, 46, 28, 220, DateTimeKind.Local).AddTicks(2654),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 139, DateTimeKind.Local).AddTicks(7116));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryItems",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 17, 46, 28, 221, DateTimeKind.Local).AddTicks(7465),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 140, DateTimeKind.Local).AddTicks(8891));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategories",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 17, 46, 28, 219, DateTimeKind.Local).AddTicks(6919),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 139, DateTimeKind.Local).AddTicks(3690));

            migrationBuilder.AddColumn<int>(
                name: "TempleId",
                table: "PoojaCategories",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Pandits",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 17, 46, 28, 219, DateTimeKind.Local).AddTicks(131),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 139, DateTimeKind.Local).AddTicks(204));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "LiveTests",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 17, 46, 28, 221, DateTimeKind.Local).AddTicks(3908),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 140, DateTimeKind.Local).AddTicks(5296));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Feedbacks",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 17, 46, 28, 220, DateTimeKind.Local).AddTicks(6094),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 139, DateTimeKind.Local).AddTicks(8761));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Countries",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 17, 46, 28, 212, DateTimeKind.Local).AddTicks(9076),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 133, DateTimeKind.Local).AddTicks(1861));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 17, 46, 28, 218, DateTimeKind.Local).AddTicks(6448),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 138, DateTimeKind.Local).AddTicks(5868));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bookings",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 17, 46, 28, 221, DateTimeKind.Local).AddTicks(5770),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 140, DateTimeKind.Local).AddTicks(7162));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bhaktas",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 28, 17, 46, 28, 219, DateTimeKind.Local).AddTicks(1834),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 139, DateTimeKind.Local).AddTicks(2010));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 28, 17, 46, 28, 209, DateTimeKind.Local).AddTicks(2679));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 28, 17, 46, 28, 209, DateTimeKind.Local).AddTicks(4713));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 28, 17, 46, 28, 209, DateTimeKind.Local).AddTicks(4725));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 28, 17, 46, 28, 209, DateTimeKind.Local).AddTicks(4728));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 28, 17, 46, 28, 209, DateTimeKind.Local).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 28, 17, 46, 28, 209, DateTimeKind.Local).AddTicks(4734));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 28, 17, 46, 28, 209, DateTimeKind.Local).AddTicks(4737));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 28, 17, 46, 28, 209, DateTimeKind.Local).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 28, 17, 46, 28, 209, DateTimeKind.Local).AddTicks(4743));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 28, 17, 46, 28, 209, DateTimeKind.Local).AddTicks(4745));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 28, 17, 46, 28, 198, DateTimeKind.Local).AddTicks(8062));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 28, 17, 46, 28, 201, DateTimeKind.Local).AddTicks(5930));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 28, 17, 46, 28, 211, DateTimeKind.Local).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 28, 17, 46, 28, 212, DateTimeKind.Local).AddTicks(655));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 28, 17, 46, 28, 212, DateTimeKind.Local).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 28, 17, 46, 28, 212, DateTimeKind.Local).AddTicks(675));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 28, 17, 46, 28, 212, DateTimeKind.Local).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 28, 17, 46, 28, 212, DateTimeKind.Local).AddTicks(682));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 28, 17, 46, 28, 212, DateTimeKind.Local).AddTicks(686));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 28, 17, 46, 28, 212, DateTimeKind.Local).AddTicks(689));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 28, 17, 46, 28, 212, DateTimeKind.Local).AddTicks(692));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 28, 17, 46, 28, 212, DateTimeKind.Local).AddTicks(695));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 28, 17, 46, 28, 205, DateTimeKind.Local).AddTicks(2010));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 28, 17, 46, 28, 205, DateTimeKind.Local).AddTicks(3655));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 28, 17, 46, 28, 206, DateTimeKind.Local).AddTicks(8701));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 28, 17, 46, 28, 207, DateTimeKind.Local).AddTicks(233));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TempleId",
                table: "PoojaCategories");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Temples",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 138, DateTimeKind.Local).AddTicks(8225),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 17, 46, 28, 218, DateTimeKind.Local).AddTicks(8278));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "States",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 138, DateTimeKind.Local).AddTicks(3517),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 17, 46, 28, 218, DateTimeKind.Local).AddTicks(4069));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Questions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 140, DateTimeKind.Local).AddTicks(460),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 17, 46, 28, 220, DateTimeKind.Local).AddTicks(9365));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "QuestionMappings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 140, DateTimeKind.Local).AddTicks(2402),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 17, 46, 28, 221, DateTimeKind.Local).AddTicks(2166));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 139, DateTimeKind.Local).AddTicks(5371),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 17, 46, 28, 220, DateTimeKind.Local).AddTicks(261));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryMappings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 139, DateTimeKind.Local).AddTicks(7116),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 17, 46, 28, 220, DateTimeKind.Local).AddTicks(2654));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 140, DateTimeKind.Local).AddTicks(8891),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 17, 46, 28, 221, DateTimeKind.Local).AddTicks(7465));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 139, DateTimeKind.Local).AddTicks(3690),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 17, 46, 28, 219, DateTimeKind.Local).AddTicks(6919));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Pandits",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 139, DateTimeKind.Local).AddTicks(204),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 17, 46, 28, 219, DateTimeKind.Local).AddTicks(131));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "LiveTests",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 140, DateTimeKind.Local).AddTicks(5296),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 17, 46, 28, 221, DateTimeKind.Local).AddTicks(3908));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Feedbacks",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 139, DateTimeKind.Local).AddTicks(8761),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 17, 46, 28, 220, DateTimeKind.Local).AddTicks(6094));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Countries",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 133, DateTimeKind.Local).AddTicks(1861),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 17, 46, 28, 212, DateTimeKind.Local).AddTicks(9076));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 138, DateTimeKind.Local).AddTicks(5868),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 17, 46, 28, 218, DateTimeKind.Local).AddTicks(6448));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bookings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 140, DateTimeKind.Local).AddTicks(7162),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 17, 46, 28, 221, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bhaktas",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 139, DateTimeKind.Local).AddTicks(2010),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 28, 17, 46, 28, 219, DateTimeKind.Local).AddTicks(1834));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 17, 20, 52, 130, DateTimeKind.Local).AddTicks(6367));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 17, 20, 52, 130, DateTimeKind.Local).AddTicks(7569));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 17, 20, 52, 130, DateTimeKind.Local).AddTicks(7579));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 17, 20, 52, 130, DateTimeKind.Local).AddTicks(7582));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 17, 20, 52, 130, DateTimeKind.Local).AddTicks(7585));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 17, 20, 52, 130, DateTimeKind.Local).AddTicks(7588));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 17, 20, 52, 130, DateTimeKind.Local).AddTicks(7591));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 17, 20, 52, 130, DateTimeKind.Local).AddTicks(7593));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 17, 20, 52, 130, DateTimeKind.Local).AddTicks(7596));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 17, 20, 52, 130, DateTimeKind.Local).AddTicks(7598));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 17, 20, 52, 121, DateTimeKind.Local).AddTicks(273));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 17, 20, 52, 123, DateTimeKind.Local).AddTicks(184));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 17, 20, 52, 132, DateTimeKind.Local).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 17, 20, 52, 132, DateTimeKind.Local).AddTicks(5388));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 17, 20, 52, 132, DateTimeKind.Local).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 17, 20, 52, 132, DateTimeKind.Local).AddTicks(5403));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 17, 20, 52, 132, DateTimeKind.Local).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 17, 20, 52, 132, DateTimeKind.Local).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 17, 20, 52, 132, DateTimeKind.Local).AddTicks(5411));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 17, 20, 52, 132, DateTimeKind.Local).AddTicks(5414));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 17, 20, 52, 132, DateTimeKind.Local).AddTicks(5416));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 17, 20, 52, 132, DateTimeKind.Local).AddTicks(5419));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 17, 20, 52, 126, DateTimeKind.Local).AddTicks(5386));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 17, 20, 52, 126, DateTimeKind.Local).AddTicks(6574));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 17, 20, 52, 128, DateTimeKind.Local).AddTicks(2683));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 17, 20, 52, 128, DateTimeKind.Local).AddTicks(4242));
        }
    }
}
