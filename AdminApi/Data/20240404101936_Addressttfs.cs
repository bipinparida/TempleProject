using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.data
{
    public partial class Addressttfs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BhaktaId",
                table: "Addresss");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Temples",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 503, DateTimeKind.Local).AddTicks(4201),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 14, 57, 5, 922, DateTimeKind.Local).AddTicks(8739));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "States",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 503, DateTimeKind.Local).AddTicks(1718),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 14, 57, 5, 922, DateTimeKind.Local).AddTicks(6601));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Questions",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 504, DateTimeKind.Local).AddTicks(2325),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 14, 57, 5, 923, DateTimeKind.Local).AddTicks(5782));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "QuestionMappings",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 504, DateTimeKind.Local).AddTicks(4123),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 14, 57, 5, 923, DateTimeKind.Local).AddTicks(6743));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PushNotifications",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 505, DateTimeKind.Local).AddTicks(1134),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 14, 57, 5, 924, DateTimeKind.Local).AddTicks(2432));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Products",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 505, DateTimeKind.Local).AddTicks(4158),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 14, 57, 5, 924, DateTimeKind.Local).AddTicks(5428));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryTypes",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 503, DateTimeKind.Local).AddTicks(8942),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 14, 57, 5, 923, DateTimeKind.Local).AddTicks(2854));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryMappings",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 503, DateTimeKind.Local).AddTicks(9956),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 14, 57, 5, 923, DateTimeKind.Local).AddTicks(3872));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryItems",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 504, DateTimeKind.Local).AddTicks(7658),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 14, 57, 5, 923, DateTimeKind.Local).AddTicks(9671));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategories",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 503, DateTimeKind.Local).AddTicks(7729),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 14, 57, 5, 923, DateTimeKind.Local).AddTicks(1784));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Pandits",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 503, DateTimeKind.Local).AddTicks(5454),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 14, 57, 5, 922, DateTimeKind.Local).AddTicks(9845));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Orders",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 505, DateTimeKind.Local).AddTicks(6604),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 14, 57, 5, 924, DateTimeKind.Local).AddTicks(8531));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "OrderItems",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 505, DateTimeKind.Local).AddTicks(7627),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 14, 57, 5, 924, DateTimeKind.Local).AddTicks(9809));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "LiveTests",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 504, DateTimeKind.Local).AddTicks(5512),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 14, 57, 5, 923, DateTimeKind.Local).AddTicks(7798));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Horoscopes",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 505, DateTimeKind.Local).AddTicks(9703),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 14, 57, 5, 925, DateTimeKind.Local).AddTicks(1754));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Feedbacks",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 504, DateTimeKind.Local).AddTicks(1026),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 14, 57, 5, 923, DateTimeKind.Local).AddTicks(4818));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Countries",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 500, DateTimeKind.Local).AddTicks(7622),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 14, 57, 5, 919, DateTimeKind.Local).AddTicks(3811));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 503, DateTimeKind.Local).AddTicks(3068),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 14, 57, 5, 922, DateTimeKind.Local).AddTicks(7688));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Checkouts",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 505, DateTimeKind.Local).AddTicks(5509),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 14, 57, 5, 924, DateTimeKind.Local).AddTicks(6935));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Categories",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 505, DateTimeKind.Local).AddTicks(3060),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 14, 57, 5, 924, DateTimeKind.Local).AddTicks(3853));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bookings",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 504, DateTimeKind.Local).AddTicks(6741),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 14, 57, 5, 923, DateTimeKind.Local).AddTicks(8787));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bhaktas",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 503, DateTimeKind.Local).AddTicks(6664),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 14, 57, 5, 923, DateTimeKind.Local).AddTicks(904));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Banners",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 505, DateTimeKind.Local).AddTicks(8579),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 14, 57, 5, 925, DateTimeKind.Local).AddTicks(720));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Addresss",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 506, DateTimeKind.Local).AddTicks(761),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 14, 57, 5, 925, DateTimeKind.Local).AddTicks(2697));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Addresss",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Addresss");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Temples",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 14, 57, 5, 922, DateTimeKind.Local).AddTicks(8739),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 503, DateTimeKind.Local).AddTicks(4201));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "States",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 14, 57, 5, 922, DateTimeKind.Local).AddTicks(6601),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 503, DateTimeKind.Local).AddTicks(1718));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Questions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 14, 57, 5, 923, DateTimeKind.Local).AddTicks(5782),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 504, DateTimeKind.Local).AddTicks(2325));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "QuestionMappings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 14, 57, 5, 923, DateTimeKind.Local).AddTicks(6743),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 504, DateTimeKind.Local).AddTicks(4123));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PushNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 14, 57, 5, 924, DateTimeKind.Local).AddTicks(2432),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 505, DateTimeKind.Local).AddTicks(1134));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Products",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 14, 57, 5, 924, DateTimeKind.Local).AddTicks(5428),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 505, DateTimeKind.Local).AddTicks(4158));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 14, 57, 5, 923, DateTimeKind.Local).AddTicks(2854),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 503, DateTimeKind.Local).AddTicks(8942));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryMappings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 14, 57, 5, 923, DateTimeKind.Local).AddTicks(3872),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 503, DateTimeKind.Local).AddTicks(9956));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 14, 57, 5, 923, DateTimeKind.Local).AddTicks(9671),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 504, DateTimeKind.Local).AddTicks(7658));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 14, 57, 5, 923, DateTimeKind.Local).AddTicks(1784),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 503, DateTimeKind.Local).AddTicks(7729));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Pandits",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 14, 57, 5, 922, DateTimeKind.Local).AddTicks(9845),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 503, DateTimeKind.Local).AddTicks(5454));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Orders",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 14, 57, 5, 924, DateTimeKind.Local).AddTicks(8531),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 505, DateTimeKind.Local).AddTicks(6604));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "OrderItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 14, 57, 5, 924, DateTimeKind.Local).AddTicks(9809),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 505, DateTimeKind.Local).AddTicks(7627));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "LiveTests",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 14, 57, 5, 923, DateTimeKind.Local).AddTicks(7798),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 504, DateTimeKind.Local).AddTicks(5512));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Horoscopes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 14, 57, 5, 925, DateTimeKind.Local).AddTicks(1754),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 505, DateTimeKind.Local).AddTicks(9703));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Feedbacks",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 14, 57, 5, 923, DateTimeKind.Local).AddTicks(4818),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 504, DateTimeKind.Local).AddTicks(1026));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Countries",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 14, 57, 5, 919, DateTimeKind.Local).AddTicks(3811),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 500, DateTimeKind.Local).AddTicks(7622));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 14, 57, 5, 922, DateTimeKind.Local).AddTicks(7688),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 503, DateTimeKind.Local).AddTicks(3068));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Checkouts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 14, 57, 5, 924, DateTimeKind.Local).AddTicks(6935),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 505, DateTimeKind.Local).AddTicks(5509));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 14, 57, 5, 924, DateTimeKind.Local).AddTicks(3853),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 505, DateTimeKind.Local).AddTicks(3060));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bookings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 14, 57, 5, 923, DateTimeKind.Local).AddTicks(8787),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 504, DateTimeKind.Local).AddTicks(6741));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bhaktas",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 14, 57, 5, 923, DateTimeKind.Local).AddTicks(904),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 503, DateTimeKind.Local).AddTicks(6664));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Banners",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 14, 57, 5, 925, DateTimeKind.Local).AddTicks(720),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 505, DateTimeKind.Local).AddTicks(8579));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Addresss",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 14, 57, 5, 925, DateTimeKind.Local).AddTicks(2697),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 15, 49, 35, 506, DateTimeKind.Local).AddTicks(761));

            migrationBuilder.AddColumn<int>(
                name: "BhaktaId",
                table: "Addresss",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 14, 57, 5, 917, DateTimeKind.Local).AddTicks(9653));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 14, 57, 5, 918, DateTimeKind.Local).AddTicks(183));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 14, 57, 5, 918, DateTimeKind.Local).AddTicks(188));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 14, 57, 5, 918, DateTimeKind.Local).AddTicks(190));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 14, 57, 5, 918, DateTimeKind.Local).AddTicks(192));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 14, 57, 5, 918, DateTimeKind.Local).AddTicks(194));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 14, 57, 5, 918, DateTimeKind.Local).AddTicks(196));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 14, 57, 5, 918, DateTimeKind.Local).AddTicks(198));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 14, 57, 5, 918, DateTimeKind.Local).AddTicks(209));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 14, 57, 5, 918, DateTimeKind.Local).AddTicks(211));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 14, 57, 5, 911, DateTimeKind.Local).AddTicks(205));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 14, 57, 5, 913, DateTimeKind.Local).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 14, 57, 5, 918, DateTimeKind.Local).AddTicks(9790));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 14, 57, 5, 919, DateTimeKind.Local).AddTicks(246));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 14, 57, 5, 919, DateTimeKind.Local).AddTicks(250));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 14, 57, 5, 919, DateTimeKind.Local).AddTicks(251));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 14, 57, 5, 919, DateTimeKind.Local).AddTicks(253));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 14, 57, 5, 919, DateTimeKind.Local).AddTicks(254));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 14, 57, 5, 919, DateTimeKind.Local).AddTicks(256));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 14, 57, 5, 919, DateTimeKind.Local).AddTicks(257));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 14, 57, 5, 919, DateTimeKind.Local).AddTicks(259));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 14, 57, 5, 919, DateTimeKind.Local).AddTicks(260));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 14, 57, 5, 915, DateTimeKind.Local).AddTicks(8902));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 14, 57, 5, 915, DateTimeKind.Local).AddTicks(9315));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 14, 57, 5, 916, DateTimeKind.Local).AddTicks(7549));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 14, 57, 5, 916, DateTimeKind.Local).AddTicks(8110));
        }
    }
}
