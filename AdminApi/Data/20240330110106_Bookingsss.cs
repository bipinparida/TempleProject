using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class Bookingsss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Temples",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 30, 16, 31, 5, 593, DateTimeKind.Local).AddTicks(9923),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 30, 11, 38, 10, 125, DateTimeKind.Local).AddTicks(3983));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "States",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 30, 16, 31, 5, 593, DateTimeKind.Local).AddTicks(5751),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 30, 11, 38, 10, 124, DateTimeKind.Local).AddTicks(9867));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Questions",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 30, 16, 31, 5, 595, DateTimeKind.Local).AddTicks(3279),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 30, 11, 38, 10, 126, DateTimeKind.Local).AddTicks(6170));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "QuestionMappings",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 30, 16, 31, 5, 595, DateTimeKind.Local).AddTicks(7923),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 30, 11, 38, 10, 126, DateTimeKind.Local).AddTicks(7651));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PushNotifications",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 30, 16, 31, 5, 597, DateTimeKind.Local).AddTicks(6172),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 30, 11, 38, 10, 127, DateTimeKind.Local).AddTicks(5413));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Products",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 30, 16, 31, 5, 598, DateTimeKind.Local).AddTicks(4312),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 30, 11, 38, 10, 127, DateTimeKind.Local).AddTicks(9050));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryTypes",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 30, 16, 31, 5, 594, DateTimeKind.Local).AddTicks(7635),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 30, 11, 38, 10, 126, DateTimeKind.Local).AddTicks(1150));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryMappings",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 30, 16, 31, 5, 594, DateTimeKind.Local).AddTicks(9478),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 30, 11, 38, 10, 126, DateTimeKind.Local).AddTicks(2875));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryItems",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 30, 16, 31, 5, 596, DateTimeKind.Local).AddTicks(8704),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 30, 11, 38, 10, 127, DateTimeKind.Local).AddTicks(1792));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategories",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 30, 16, 31, 5, 594, DateTimeKind.Local).AddTicks(5917),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 30, 11, 38, 10, 125, DateTimeKind.Local).AddTicks(9238));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Pandits",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 30, 16, 31, 5, 594, DateTimeKind.Local).AddTicks(2089),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 30, 11, 38, 10, 125, DateTimeKind.Local).AddTicks(5881));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Orders",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 30, 16, 31, 5, 599, DateTimeKind.Local).AddTicks(745),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 30, 11, 38, 10, 128, DateTimeKind.Local).AddTicks(1995));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "OrderItems",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 30, 16, 31, 5, 599, DateTimeKind.Local).AddTicks(3691),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 30, 11, 38, 10, 128, DateTimeKind.Local).AddTicks(3165));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "LiveTests",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 30, 16, 31, 5, 596, DateTimeKind.Local).AddTicks(1734),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 30, 11, 38, 10, 126, DateTimeKind.Local).AddTicks(9063));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Feedbacks",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 30, 16, 31, 5, 595, DateTimeKind.Local).AddTicks(1488),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 30, 11, 38, 10, 126, DateTimeKind.Local).AddTicks(4533));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Countries",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 30, 16, 31, 5, 589, DateTimeKind.Local).AddTicks(4513),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 30, 11, 38, 10, 121, DateTimeKind.Local).AddTicks(354));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 30, 16, 31, 5, 593, DateTimeKind.Local).AddTicks(7787),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 30, 11, 38, 10, 125, DateTimeKind.Local).AddTicks(1878));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Checkouts",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 30, 16, 31, 5, 598, DateTimeKind.Local).AddTicks(7611),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 30, 11, 38, 10, 128, DateTimeKind.Local).AddTicks(551));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Categories",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 30, 16, 31, 5, 598, DateTimeKind.Local).AddTicks(899),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 30, 11, 38, 10, 127, DateTimeKind.Local).AddTicks(7732));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bookings",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 30, 16, 31, 5, 596, DateTimeKind.Local).AddTicks(5577),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 30, 11, 38, 10, 127, DateTimeKind.Local).AddTicks(378));

            migrationBuilder.AddColumn<bool>(
                name: "IsComplete",
                table: "Bookings",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bhaktas",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 30, 16, 31, 5, 594, DateTimeKind.Local).AddTicks(3961),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 30, 11, 38, 10, 125, DateTimeKind.Local).AddTicks(7545));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Banners",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 30, 16, 31, 5, 599, DateTimeKind.Local).AddTicks(7279),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 30, 11, 38, 10, 128, DateTimeKind.Local).AddTicks(4453));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 30, 16, 31, 5, 586, DateTimeKind.Local).AddTicks(6758));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 30, 16, 31, 5, 586, DateTimeKind.Local).AddTicks(9307));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 30, 16, 31, 5, 586, DateTimeKind.Local).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 30, 16, 31, 5, 586, DateTimeKind.Local).AddTicks(9336));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 30, 16, 31, 5, 586, DateTimeKind.Local).AddTicks(9344));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 30, 16, 31, 5, 586, DateTimeKind.Local).AddTicks(9351));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 30, 16, 31, 5, 586, DateTimeKind.Local).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 30, 16, 31, 5, 586, DateTimeKind.Local).AddTicks(9365));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 30, 16, 31, 5, 586, DateTimeKind.Local).AddTicks(9371));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 30, 16, 31, 5, 586, DateTimeKind.Local).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 30, 16, 31, 5, 577, DateTimeKind.Local).AddTicks(6101));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 30, 16, 31, 5, 579, DateTimeKind.Local).AddTicks(1428));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 30, 16, 31, 5, 588, DateTimeKind.Local).AddTicks(7222));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 30, 16, 31, 5, 588, DateTimeKind.Local).AddTicks(8488));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 30, 16, 31, 5, 588, DateTimeKind.Local).AddTicks(8498));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 30, 16, 31, 5, 588, DateTimeKind.Local).AddTicks(8500));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 30, 16, 31, 5, 588, DateTimeKind.Local).AddTicks(8503));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 30, 16, 31, 5, 588, DateTimeKind.Local).AddTicks(8506));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 30, 16, 31, 5, 588, DateTimeKind.Local).AddTicks(8508));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 30, 16, 31, 5, 588, DateTimeKind.Local).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 30, 16, 31, 5, 588, DateTimeKind.Local).AddTicks(8513));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 30, 16, 31, 5, 588, DateTimeKind.Local).AddTicks(8515));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 30, 16, 31, 5, 582, DateTimeKind.Local).AddTicks(2581));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 30, 16, 31, 5, 582, DateTimeKind.Local).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 30, 16, 31, 5, 584, DateTimeKind.Local).AddTicks(437));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 30, 16, 31, 5, 584, DateTimeKind.Local).AddTicks(2055));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsComplete",
                table: "Bookings");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Temples",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 30, 11, 38, 10, 125, DateTimeKind.Local).AddTicks(3983),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 30, 16, 31, 5, 593, DateTimeKind.Local).AddTicks(9923));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "States",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 30, 11, 38, 10, 124, DateTimeKind.Local).AddTicks(9867),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 30, 16, 31, 5, 593, DateTimeKind.Local).AddTicks(5751));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Questions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 30, 11, 38, 10, 126, DateTimeKind.Local).AddTicks(6170),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 30, 16, 31, 5, 595, DateTimeKind.Local).AddTicks(3279));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "QuestionMappings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 30, 11, 38, 10, 126, DateTimeKind.Local).AddTicks(7651),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 30, 16, 31, 5, 595, DateTimeKind.Local).AddTicks(7923));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PushNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 30, 11, 38, 10, 127, DateTimeKind.Local).AddTicks(5413),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 30, 16, 31, 5, 597, DateTimeKind.Local).AddTicks(6172));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Products",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 30, 11, 38, 10, 127, DateTimeKind.Local).AddTicks(9050),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 30, 16, 31, 5, 598, DateTimeKind.Local).AddTicks(4312));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 30, 11, 38, 10, 126, DateTimeKind.Local).AddTicks(1150),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 30, 16, 31, 5, 594, DateTimeKind.Local).AddTicks(7635));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryMappings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 30, 11, 38, 10, 126, DateTimeKind.Local).AddTicks(2875),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 30, 16, 31, 5, 594, DateTimeKind.Local).AddTicks(9478));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 30, 11, 38, 10, 127, DateTimeKind.Local).AddTicks(1792),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 30, 16, 31, 5, 596, DateTimeKind.Local).AddTicks(8704));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 30, 11, 38, 10, 125, DateTimeKind.Local).AddTicks(9238),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 30, 16, 31, 5, 594, DateTimeKind.Local).AddTicks(5917));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Pandits",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 30, 11, 38, 10, 125, DateTimeKind.Local).AddTicks(5881),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 30, 16, 31, 5, 594, DateTimeKind.Local).AddTicks(2089));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Orders",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 30, 11, 38, 10, 128, DateTimeKind.Local).AddTicks(1995),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 30, 16, 31, 5, 599, DateTimeKind.Local).AddTicks(745));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "OrderItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 30, 11, 38, 10, 128, DateTimeKind.Local).AddTicks(3165),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 30, 16, 31, 5, 599, DateTimeKind.Local).AddTicks(3691));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "LiveTests",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 30, 11, 38, 10, 126, DateTimeKind.Local).AddTicks(9063),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 30, 16, 31, 5, 596, DateTimeKind.Local).AddTicks(1734));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Feedbacks",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 30, 11, 38, 10, 126, DateTimeKind.Local).AddTicks(4533),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 30, 16, 31, 5, 595, DateTimeKind.Local).AddTicks(1488));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Countries",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 30, 11, 38, 10, 121, DateTimeKind.Local).AddTicks(354),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 30, 16, 31, 5, 589, DateTimeKind.Local).AddTicks(4513));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 30, 11, 38, 10, 125, DateTimeKind.Local).AddTicks(1878),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 30, 16, 31, 5, 593, DateTimeKind.Local).AddTicks(7787));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Checkouts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 30, 11, 38, 10, 128, DateTimeKind.Local).AddTicks(551),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 30, 16, 31, 5, 598, DateTimeKind.Local).AddTicks(7611));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 30, 11, 38, 10, 127, DateTimeKind.Local).AddTicks(7732),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 30, 16, 31, 5, 598, DateTimeKind.Local).AddTicks(899));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bookings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 30, 11, 38, 10, 127, DateTimeKind.Local).AddTicks(378),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 30, 16, 31, 5, 596, DateTimeKind.Local).AddTicks(5577));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bhaktas",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 30, 11, 38, 10, 125, DateTimeKind.Local).AddTicks(7545),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 30, 16, 31, 5, 594, DateTimeKind.Local).AddTicks(3961));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Banners",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 30, 11, 38, 10, 128, DateTimeKind.Local).AddTicks(4453),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 30, 16, 31, 5, 599, DateTimeKind.Local).AddTicks(7279));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 30, 11, 38, 10, 118, DateTimeKind.Local).AddTicks(3263));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 30, 11, 38, 10, 118, DateTimeKind.Local).AddTicks(4207));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 30, 11, 38, 10, 118, DateTimeKind.Local).AddTicks(4213));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 30, 11, 38, 10, 118, DateTimeKind.Local).AddTicks(4216));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 30, 11, 38, 10, 118, DateTimeKind.Local).AddTicks(4221));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 30, 11, 38, 10, 118, DateTimeKind.Local).AddTicks(4223));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 30, 11, 38, 10, 118, DateTimeKind.Local).AddTicks(4226));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 30, 11, 38, 10, 118, DateTimeKind.Local).AddTicks(4229));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 30, 11, 38, 10, 118, DateTimeKind.Local).AddTicks(4232));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 30, 11, 38, 10, 118, DateTimeKind.Local).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 30, 11, 38, 10, 108, DateTimeKind.Local).AddTicks(8771));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 30, 11, 38, 10, 111, DateTimeKind.Local).AddTicks(8843));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 30, 11, 38, 10, 120, DateTimeKind.Local).AddTicks(3636));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 30, 11, 38, 10, 120, DateTimeKind.Local).AddTicks(4448));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 30, 11, 38, 10, 120, DateTimeKind.Local).AddTicks(4453));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 30, 11, 38, 10, 120, DateTimeKind.Local).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 30, 11, 38, 10, 120, DateTimeKind.Local).AddTicks(4458));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 30, 11, 38, 10, 120, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 30, 11, 38, 10, 120, DateTimeKind.Local).AddTicks(4462));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 30, 11, 38, 10, 120, DateTimeKind.Local).AddTicks(4465));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 30, 11, 38, 10, 120, DateTimeKind.Local).AddTicks(4467));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 30, 11, 38, 10, 120, DateTimeKind.Local).AddTicks(4469));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 30, 11, 38, 10, 114, DateTimeKind.Local).AddTicks(5310));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 30, 11, 38, 10, 114, DateTimeKind.Local).AddTicks(5982));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 30, 11, 38, 10, 116, DateTimeKind.Local).AddTicks(338));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 30, 11, 38, 10, 116, DateTimeKind.Local).AddTicks(1234));
        }
    }
}
