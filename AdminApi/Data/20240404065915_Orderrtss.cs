using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.data
{
    public partial class Orderrtss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Temples",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 108, DateTimeKind.Local).AddTicks(3334),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 11, 50, 45, 330, DateTimeKind.Local).AddTicks(9203));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "States",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 107, DateTimeKind.Local).AddTicks(4127),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 11, 50, 45, 330, DateTimeKind.Local).AddTicks(5244));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Questions",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 109, DateTimeKind.Local).AddTicks(7361),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 11, 50, 45, 332, DateTimeKind.Local).AddTicks(1606));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "QuestionMappings",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 109, DateTimeKind.Local).AddTicks(9329),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 11, 50, 45, 332, DateTimeKind.Local).AddTicks(3259));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PushNotifications",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 110, DateTimeKind.Local).AddTicks(9915),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 11, 50, 45, 333, DateTimeKind.Local).AddTicks(2728));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Products",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 111, DateTimeKind.Local).AddTicks(4342),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 11, 50, 45, 333, DateTimeKind.Local).AddTicks(7292));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryTypes",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 109, DateTimeKind.Local).AddTicks(1642),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 11, 50, 45, 331, DateTimeKind.Local).AddTicks(6489));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryMappings",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 109, DateTimeKind.Local).AddTicks(3731),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 11, 50, 45, 331, DateTimeKind.Local).AddTicks(8236));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryItems",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 110, DateTimeKind.Local).AddTicks(5052),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 11, 50, 45, 332, DateTimeKind.Local).AddTicks(8454));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategories",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 108, DateTimeKind.Local).AddTicks(9325),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 11, 50, 45, 331, DateTimeKind.Local).AddTicks(4651));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Pandits",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 108, DateTimeKind.Local).AddTicks(5498),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 11, 50, 45, 331, DateTimeKind.Local).AddTicks(1098));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Orders",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 111, DateTimeKind.Local).AddTicks(7785),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 11, 50, 45, 334, DateTimeKind.Local).AddTicks(1132));

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "Orders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "OrderItems",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 111, DateTimeKind.Local).AddTicks(9699),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 11, 50, 45, 334, DateTimeKind.Local).AddTicks(2922));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "LiveTests",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 110, DateTimeKind.Local).AddTicks(1169),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 11, 50, 45, 332, DateTimeKind.Local).AddTicks(5069));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Horoscopes",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 112, DateTimeKind.Local).AddTicks(3367),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 11, 50, 45, 334, DateTimeKind.Local).AddTicks(6449));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Feedbacks",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 109, DateTimeKind.Local).AddTicks(5484),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 11, 50, 45, 331, DateTimeKind.Local).AddTicks(9952));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Countries",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 104, DateTimeKind.Local).AddTicks(6261),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 11, 50, 45, 326, DateTimeKind.Local).AddTicks(4566));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 108, DateTimeKind.Local).AddTicks(229),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 11, 50, 45, 330, DateTimeKind.Local).AddTicks(7660));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Checkouts",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 111, DateTimeKind.Local).AddTicks(6155),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 11, 50, 45, 333, DateTimeKind.Local).AddTicks(9232));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Categories",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 111, DateTimeKind.Local).AddTicks(2443),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 11, 50, 45, 333, DateTimeKind.Local).AddTicks(5411));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bookings",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 110, DateTimeKind.Local).AddTicks(3241),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 11, 50, 45, 332, DateTimeKind.Local).AddTicks(6749));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bhaktas",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 108, DateTimeKind.Local).AddTicks(7495),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 11, 50, 45, 331, DateTimeKind.Local).AddTicks(2931));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Banners",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 112, DateTimeKind.Local).AddTicks(1369),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 11, 50, 45, 334, DateTimeKind.Local).AddTicks(4704));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Addresss",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 112, DateTimeKind.Local).AddTicks(5304),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 11, 50, 45, 334, DateTimeKind.Local).AddTicks(8643));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 12, 29, 14, 103, DateTimeKind.Local).AddTicks(804));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 12, 29, 14, 103, DateTimeKind.Local).AddTicks(1424));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 12, 29, 14, 103, DateTimeKind.Local).AddTicks(1428));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 12, 29, 14, 103, DateTimeKind.Local).AddTicks(1429));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 12, 29, 14, 103, DateTimeKind.Local).AddTicks(1431));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 12, 29, 14, 103, DateTimeKind.Local).AddTicks(1433));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 12, 29, 14, 103, DateTimeKind.Local).AddTicks(1435));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 12, 29, 14, 103, DateTimeKind.Local).AddTicks(1499));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 12, 29, 14, 103, DateTimeKind.Local).AddTicks(1501));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 12, 29, 14, 103, DateTimeKind.Local).AddTicks(1503));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 12, 29, 14, 95, DateTimeKind.Local).AddTicks(9365));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 12, 29, 14, 98, DateTimeKind.Local).AddTicks(7182));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 12, 29, 14, 104, DateTimeKind.Local).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 12, 29, 14, 104, DateTimeKind.Local).AddTicks(2587));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 12, 29, 14, 104, DateTimeKind.Local).AddTicks(2591));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 12, 29, 14, 104, DateTimeKind.Local).AddTicks(2593));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 12, 29, 14, 104, DateTimeKind.Local).AddTicks(2595));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 12, 29, 14, 104, DateTimeKind.Local).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 12, 29, 14, 104, DateTimeKind.Local).AddTicks(2598));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 12, 29, 14, 104, DateTimeKind.Local).AddTicks(2599));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 12, 29, 14, 104, DateTimeKind.Local).AddTicks(2601));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 12, 29, 14, 104, DateTimeKind.Local).AddTicks(2602));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 12, 29, 14, 100, DateTimeKind.Local).AddTicks(5565));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 12, 29, 14, 100, DateTimeKind.Local).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 12, 29, 14, 101, DateTimeKind.Local).AddTicks(5900));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 12, 29, 14, 101, DateTimeKind.Local).AddTicks(6672));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Orders");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Temples",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 11, 50, 45, 330, DateTimeKind.Local).AddTicks(9203),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 108, DateTimeKind.Local).AddTicks(3334));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "States",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 11, 50, 45, 330, DateTimeKind.Local).AddTicks(5244),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 107, DateTimeKind.Local).AddTicks(4127));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Questions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 11, 50, 45, 332, DateTimeKind.Local).AddTicks(1606),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 109, DateTimeKind.Local).AddTicks(7361));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "QuestionMappings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 11, 50, 45, 332, DateTimeKind.Local).AddTicks(3259),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 109, DateTimeKind.Local).AddTicks(9329));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PushNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 11, 50, 45, 333, DateTimeKind.Local).AddTicks(2728),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 110, DateTimeKind.Local).AddTicks(9915));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Products",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 11, 50, 45, 333, DateTimeKind.Local).AddTicks(7292),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 111, DateTimeKind.Local).AddTicks(4342));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 11, 50, 45, 331, DateTimeKind.Local).AddTicks(6489),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 109, DateTimeKind.Local).AddTicks(1642));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryMappings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 11, 50, 45, 331, DateTimeKind.Local).AddTicks(8236),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 109, DateTimeKind.Local).AddTicks(3731));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 11, 50, 45, 332, DateTimeKind.Local).AddTicks(8454),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 110, DateTimeKind.Local).AddTicks(5052));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 11, 50, 45, 331, DateTimeKind.Local).AddTicks(4651),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 108, DateTimeKind.Local).AddTicks(9325));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Pandits",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 11, 50, 45, 331, DateTimeKind.Local).AddTicks(1098),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 108, DateTimeKind.Local).AddTicks(5498));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Orders",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 11, 50, 45, 334, DateTimeKind.Local).AddTicks(1132),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 111, DateTimeKind.Local).AddTicks(7785));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "OrderItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 11, 50, 45, 334, DateTimeKind.Local).AddTicks(2922),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 111, DateTimeKind.Local).AddTicks(9699));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "LiveTests",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 11, 50, 45, 332, DateTimeKind.Local).AddTicks(5069),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 110, DateTimeKind.Local).AddTicks(1169));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Horoscopes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 11, 50, 45, 334, DateTimeKind.Local).AddTicks(6449),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 112, DateTimeKind.Local).AddTicks(3367));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Feedbacks",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 11, 50, 45, 331, DateTimeKind.Local).AddTicks(9952),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 109, DateTimeKind.Local).AddTicks(5484));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Countries",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 11, 50, 45, 326, DateTimeKind.Local).AddTicks(4566),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 104, DateTimeKind.Local).AddTicks(6261));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 11, 50, 45, 330, DateTimeKind.Local).AddTicks(7660),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 108, DateTimeKind.Local).AddTicks(229));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Checkouts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 11, 50, 45, 333, DateTimeKind.Local).AddTicks(9232),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 111, DateTimeKind.Local).AddTicks(6155));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 11, 50, 45, 333, DateTimeKind.Local).AddTicks(5411),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 111, DateTimeKind.Local).AddTicks(2443));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bookings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 11, 50, 45, 332, DateTimeKind.Local).AddTicks(6749),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 110, DateTimeKind.Local).AddTicks(3241));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bhaktas",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 11, 50, 45, 331, DateTimeKind.Local).AddTicks(2931),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 108, DateTimeKind.Local).AddTicks(7495));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Banners",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 11, 50, 45, 334, DateTimeKind.Local).AddTicks(4704),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 112, DateTimeKind.Local).AddTicks(1369));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Addresss",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 11, 50, 45, 334, DateTimeKind.Local).AddTicks(8643),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 112, DateTimeKind.Local).AddTicks(5304));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 11, 50, 45, 323, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 11, 50, 45, 323, DateTimeKind.Local).AddTicks(9373));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 11, 50, 45, 323, DateTimeKind.Local).AddTicks(9379));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 11, 50, 45, 323, DateTimeKind.Local).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 11, 50, 45, 323, DateTimeKind.Local).AddTicks(9385));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 11, 50, 45, 323, DateTimeKind.Local).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 11, 50, 45, 323, DateTimeKind.Local).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 11, 50, 45, 323, DateTimeKind.Local).AddTicks(9393));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 11, 50, 45, 323, DateTimeKind.Local).AddTicks(9395));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 11, 50, 45, 323, DateTimeKind.Local).AddTicks(9398));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 11, 50, 45, 315, DateTimeKind.Local).AddTicks(1889));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 11, 50, 45, 317, DateTimeKind.Local).AddTicks(1847));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 11, 50, 45, 325, DateTimeKind.Local).AddTicks(6672));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 11, 50, 45, 325, DateTimeKind.Local).AddTicks(7642));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 11, 50, 45, 325, DateTimeKind.Local).AddTicks(7649));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 11, 50, 45, 325, DateTimeKind.Local).AddTicks(7651));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 11, 50, 45, 325, DateTimeKind.Local).AddTicks(7786));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 11, 50, 45, 325, DateTimeKind.Local).AddTicks(7789));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 11, 50, 45, 325, DateTimeKind.Local).AddTicks(7791));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 11, 50, 45, 325, DateTimeKind.Local).AddTicks(7794));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 11, 50, 45, 325, DateTimeKind.Local).AddTicks(7796));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 11, 50, 45, 325, DateTimeKind.Local).AddTicks(7799));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 11, 50, 45, 319, DateTimeKind.Local).AddTicks(6983));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 11, 50, 45, 319, DateTimeKind.Local).AddTicks(8163));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 11, 50, 45, 321, DateTimeKind.Local).AddTicks(4398));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 11, 50, 45, 321, DateTimeKind.Local).AddTicks(5341));
        }
    }
}
