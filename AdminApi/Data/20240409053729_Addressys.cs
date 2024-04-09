using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.data
{
    public partial class Addressys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Addresss");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Addresss");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Temples",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 9, 11, 7, 29, 385, DateTimeKind.Local).AddTicks(4452),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 503, DateTimeKind.Local).AddTicks(4201));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "States",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 9, 11, 7, 29, 385, DateTimeKind.Local).AddTicks(1941),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 503, DateTimeKind.Local).AddTicks(1718));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Questions",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 9, 11, 7, 29, 387, DateTimeKind.Local).AddTicks(1492),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 504, DateTimeKind.Local).AddTicks(2325));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "QuestionMappings",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 9, 11, 7, 29, 387, DateTimeKind.Local).AddTicks(3026),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 504, DateTimeKind.Local).AddTicks(4123));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PushNotifications",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 9, 11, 7, 29, 388, DateTimeKind.Local).AddTicks(2200),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 505, DateTimeKind.Local).AddTicks(1134));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Products",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 9, 11, 7, 29, 388, DateTimeKind.Local).AddTicks(6113),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 505, DateTimeKind.Local).AddTicks(4158));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryTypes",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 9, 11, 7, 29, 386, DateTimeKind.Local).AddTicks(6694),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 503, DateTimeKind.Local).AddTicks(8942));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryMappings",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 9, 11, 7, 29, 386, DateTimeKind.Local).AddTicks(8484),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 503, DateTimeKind.Local).AddTicks(9956));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryItems",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 9, 11, 7, 29, 387, DateTimeKind.Local).AddTicks(7504),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 504, DateTimeKind.Local).AddTicks(7658));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategories",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 9, 11, 7, 29, 386, DateTimeKind.Local).AddTicks(4910),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 503, DateTimeKind.Local).AddTicks(7729));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Pandits",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 9, 11, 7, 29, 385, DateTimeKind.Local).AddTicks(9687),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 503, DateTimeKind.Local).AddTicks(5454));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Orders",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 9, 11, 7, 29, 388, DateTimeKind.Local).AddTicks(9444),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 505, DateTimeKind.Local).AddTicks(6604));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "OrderItems",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 9, 11, 7, 29, 389, DateTimeKind.Local).AddTicks(936),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 505, DateTimeKind.Local).AddTicks(7627));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "LiveTests",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 9, 11, 7, 29, 387, DateTimeKind.Local).AddTicks(4451),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 504, DateTimeKind.Local).AddTicks(5512));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Horoscopes",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 9, 11, 7, 29, 389, DateTimeKind.Local).AddTicks(4757),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 505, DateTimeKind.Local).AddTicks(9703));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Feedbacks",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 9, 11, 7, 29, 387, DateTimeKind.Local).AddTicks(116),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 504, DateTimeKind.Local).AddTicks(1026));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Countries",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 9, 11, 7, 29, 382, DateTimeKind.Local).AddTicks(5090),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 500, DateTimeKind.Local).AddTicks(7622));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 9, 11, 7, 29, 385, DateTimeKind.Local).AddTicks(3285),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 503, DateTimeKind.Local).AddTicks(3068));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Checkouts",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 9, 11, 7, 29, 388, DateTimeKind.Local).AddTicks(7640),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 505, DateTimeKind.Local).AddTicks(5509));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Categories",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 9, 11, 7, 29, 388, DateTimeKind.Local).AddTicks(4547),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 505, DateTimeKind.Local).AddTicks(3060));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bookings",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 9, 11, 7, 29, 387, DateTimeKind.Local).AddTicks(6016),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 504, DateTimeKind.Local).AddTicks(6741));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bhaktas",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 9, 11, 7, 29, 386, DateTimeKind.Local).AddTicks(2902),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 503, DateTimeKind.Local).AddTicks(6664));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Banners",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 9, 11, 7, 29, 389, DateTimeKind.Local).AddTicks(2877),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 505, DateTimeKind.Local).AddTicks(8579));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Addresss",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 9, 11, 7, 29, 389, DateTimeKind.Local).AddTicks(6594),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 506, DateTimeKind.Local).AddTicks(761));

            migrationBuilder.AddColumn<string>(
                name: "AddressLine1",
                table: "Addresss",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CityName",
                table: "Addresss",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Addresss",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LandMark",
                table: "Addresss",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 4, 9, 11, 7, 29, 380, DateTimeKind.Local).AddTicks(4361));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 4, 9, 11, 7, 29, 380, DateTimeKind.Local).AddTicks(5122));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 4, 9, 11, 7, 29, 380, DateTimeKind.Local).AddTicks(5128));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 4, 9, 11, 7, 29, 380, DateTimeKind.Local).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 4, 9, 11, 7, 29, 380, DateTimeKind.Local).AddTicks(5134));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 4, 9, 11, 7, 29, 380, DateTimeKind.Local).AddTicks(5137));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 4, 9, 11, 7, 29, 380, DateTimeKind.Local).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 4, 9, 11, 7, 29, 380, DateTimeKind.Local).AddTicks(5143));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 4, 9, 11, 7, 29, 380, DateTimeKind.Local).AddTicks(5146));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 4, 9, 11, 7, 29, 380, DateTimeKind.Local).AddTicks(5149));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 4, 9, 11, 7, 29, 369, DateTimeKind.Local).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 4, 9, 11, 7, 29, 373, DateTimeKind.Local).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 4, 9, 11, 7, 29, 382, DateTimeKind.Local).AddTicks(85));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 4, 9, 11, 7, 29, 382, DateTimeKind.Local).AddTicks(715));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 4, 9, 11, 7, 29, 382, DateTimeKind.Local).AddTicks(720));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 4, 9, 11, 7, 29, 382, DateTimeKind.Local).AddTicks(722));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 4, 9, 11, 7, 29, 382, DateTimeKind.Local).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 4, 9, 11, 7, 29, 382, DateTimeKind.Local).AddTicks(725));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 4, 9, 11, 7, 29, 382, DateTimeKind.Local).AddTicks(727));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 4, 9, 11, 7, 29, 382, DateTimeKind.Local).AddTicks(728));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 4, 9, 11, 7, 29, 382, DateTimeKind.Local).AddTicks(730));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 4, 9, 11, 7, 29, 382, DateTimeKind.Local).AddTicks(732));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 4, 9, 11, 7, 29, 377, DateTimeKind.Local).AddTicks(797));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 4, 9, 11, 7, 29, 377, DateTimeKind.Local).AddTicks(1491));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 4, 9, 11, 7, 29, 378, DateTimeKind.Local).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 4, 9, 11, 7, 29, 378, DateTimeKind.Local).AddTicks(5713));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressLine1",
                table: "Addresss");

            migrationBuilder.DropColumn(
                name: "CityName",
                table: "Addresss");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Addresss");

            migrationBuilder.DropColumn(
                name: "LandMark",
                table: "Addresss");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Temples",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 503, DateTimeKind.Local).AddTicks(4201),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 9, 11, 7, 29, 385, DateTimeKind.Local).AddTicks(4452));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "States",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 503, DateTimeKind.Local).AddTicks(1718),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 9, 11, 7, 29, 385, DateTimeKind.Local).AddTicks(1941));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Questions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 504, DateTimeKind.Local).AddTicks(2325),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 9, 11, 7, 29, 387, DateTimeKind.Local).AddTicks(1492));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "QuestionMappings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 504, DateTimeKind.Local).AddTicks(4123),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 9, 11, 7, 29, 387, DateTimeKind.Local).AddTicks(3026));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PushNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 505, DateTimeKind.Local).AddTicks(1134),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 9, 11, 7, 29, 388, DateTimeKind.Local).AddTicks(2200));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Products",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 505, DateTimeKind.Local).AddTicks(4158),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 9, 11, 7, 29, 388, DateTimeKind.Local).AddTicks(6113));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 503, DateTimeKind.Local).AddTicks(8942),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 9, 11, 7, 29, 386, DateTimeKind.Local).AddTicks(6694));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryMappings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 503, DateTimeKind.Local).AddTicks(9956),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 9, 11, 7, 29, 386, DateTimeKind.Local).AddTicks(8484));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 504, DateTimeKind.Local).AddTicks(7658),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 9, 11, 7, 29, 387, DateTimeKind.Local).AddTicks(7504));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 503, DateTimeKind.Local).AddTicks(7729),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 9, 11, 7, 29, 386, DateTimeKind.Local).AddTicks(4910));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Pandits",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 503, DateTimeKind.Local).AddTicks(5454),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 9, 11, 7, 29, 385, DateTimeKind.Local).AddTicks(9687));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Orders",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 505, DateTimeKind.Local).AddTicks(6604),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 9, 11, 7, 29, 388, DateTimeKind.Local).AddTicks(9444));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "OrderItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 505, DateTimeKind.Local).AddTicks(7627),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 9, 11, 7, 29, 389, DateTimeKind.Local).AddTicks(936));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "LiveTests",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 504, DateTimeKind.Local).AddTicks(5512),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 9, 11, 7, 29, 387, DateTimeKind.Local).AddTicks(4451));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Horoscopes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 505, DateTimeKind.Local).AddTicks(9703),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 9, 11, 7, 29, 389, DateTimeKind.Local).AddTicks(4757));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Feedbacks",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 504, DateTimeKind.Local).AddTicks(1026),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 9, 11, 7, 29, 387, DateTimeKind.Local).AddTicks(116));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Countries",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 500, DateTimeKind.Local).AddTicks(7622),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 9, 11, 7, 29, 382, DateTimeKind.Local).AddTicks(5090));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 503, DateTimeKind.Local).AddTicks(3068),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 9, 11, 7, 29, 385, DateTimeKind.Local).AddTicks(3285));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Checkouts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 505, DateTimeKind.Local).AddTicks(5509),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 9, 11, 7, 29, 388, DateTimeKind.Local).AddTicks(7640));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 505, DateTimeKind.Local).AddTicks(3060),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 9, 11, 7, 29, 388, DateTimeKind.Local).AddTicks(4547));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bookings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 504, DateTimeKind.Local).AddTicks(6741),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 9, 11, 7, 29, 387, DateTimeKind.Local).AddTicks(6016));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bhaktas",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 503, DateTimeKind.Local).AddTicks(6664),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 9, 11, 7, 29, 386, DateTimeKind.Local).AddTicks(2902));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Banners",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 505, DateTimeKind.Local).AddTicks(8579),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 9, 11, 7, 29, 389, DateTimeKind.Local).AddTicks(2877));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Addresss",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 506, DateTimeKind.Local).AddTicks(761),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 9, 11, 7, 29, 389, DateTimeKind.Local).AddTicks(6594));

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Addresss",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Addresss",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 15, 49, 35, 499, DateTimeKind.Local).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 15, 49, 35, 499, DateTimeKind.Local).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 15, 49, 35, 499, DateTimeKind.Local).AddTicks(3245));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 15, 49, 35, 499, DateTimeKind.Local).AddTicks(3247));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 15, 49, 35, 499, DateTimeKind.Local).AddTicks(3249));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 15, 49, 35, 499, DateTimeKind.Local).AddTicks(3250));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 15, 49, 35, 499, DateTimeKind.Local).AddTicks(3252));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 15, 49, 35, 499, DateTimeKind.Local).AddTicks(3323));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 15, 49, 35, 499, DateTimeKind.Local).AddTicks(3326));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 15, 49, 35, 499, DateTimeKind.Local).AddTicks(3327));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 15, 49, 35, 492, DateTimeKind.Local).AddTicks(9146));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 15, 49, 35, 494, DateTimeKind.Local).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 15, 49, 35, 500, DateTimeKind.Local).AddTicks(3287));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 15, 49, 35, 500, DateTimeKind.Local).AddTicks(3733));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 15, 49, 35, 500, DateTimeKind.Local).AddTicks(3737));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 15, 49, 35, 500, DateTimeKind.Local).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 15, 49, 35, 500, DateTimeKind.Local).AddTicks(3740));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 15, 49, 35, 500, DateTimeKind.Local).AddTicks(3742));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 15, 49, 35, 500, DateTimeKind.Local).AddTicks(3743));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 15, 49, 35, 500, DateTimeKind.Local).AddTicks(3745));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 15, 49, 35, 500, DateTimeKind.Local).AddTicks(3746));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 15, 49, 35, 500, DateTimeKind.Local).AddTicks(3748));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 15, 49, 35, 496, DateTimeKind.Local).AddTicks(3974));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 15, 49, 35, 496, DateTimeKind.Local).AddTicks(4585));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 15, 49, 35, 497, DateTimeKind.Local).AddTicks(3855));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 15, 49, 35, 497, DateTimeKind.Local).AddTicks(4427));
        }
    }
}
