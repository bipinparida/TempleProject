using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.data
{
    public partial class Addresttts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Addresss");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Temples",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 52, 16, 508, DateTimeKind.Local).AddTicks(6752),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 108, DateTimeKind.Local).AddTicks(3334));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "States",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 52, 16, 508, DateTimeKind.Local).AddTicks(4432),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 107, DateTimeKind.Local).AddTicks(4127));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Questions",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 52, 16, 509, DateTimeKind.Local).AddTicks(5145),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 109, DateTimeKind.Local).AddTicks(7361));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "QuestionMappings",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 52, 16, 509, DateTimeKind.Local).AddTicks(6386),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 109, DateTimeKind.Local).AddTicks(9329));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PushNotifications",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 12, 52, 16, 510, DateTimeKind.Local).AddTicks(3239),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 110, DateTimeKind.Local).AddTicks(9915));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Products",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 52, 16, 510, DateTimeKind.Local).AddTicks(6362),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 111, DateTimeKind.Local).AddTicks(4342));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryTypes",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 52, 16, 509, DateTimeKind.Local).AddTicks(1202),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 109, DateTimeKind.Local).AddTicks(1642));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryMappings",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 52, 16, 509, DateTimeKind.Local).AddTicks(2431),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 109, DateTimeKind.Local).AddTicks(3731));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryItems",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 52, 16, 510, DateTimeKind.Local).AddTicks(405),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 110, DateTimeKind.Local).AddTicks(5052));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategories",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 52, 16, 508, DateTimeKind.Local).AddTicks(9802),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 108, DateTimeKind.Local).AddTicks(9325));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Pandits",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 52, 16, 508, DateTimeKind.Local).AddTicks(7679),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 108, DateTimeKind.Local).AddTicks(5498));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Orders",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 52, 16, 510, DateTimeKind.Local).AddTicks(8336),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 111, DateTimeKind.Local).AddTicks(7785));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "OrderItems",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 52, 16, 510, DateTimeKind.Local).AddTicks(9646),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 111, DateTimeKind.Local).AddTicks(9699));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "LiveTests",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 52, 16, 509, DateTimeKind.Local).AddTicks(7597),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 110, DateTimeKind.Local).AddTicks(1169));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Horoscopes",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 52, 16, 511, DateTimeKind.Local).AddTicks(1687),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 112, DateTimeKind.Local).AddTicks(3367));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Feedbacks",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 52, 16, 509, DateTimeKind.Local).AddTicks(3959),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 109, DateTimeKind.Local).AddTicks(5484));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Countries",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 52, 16, 505, DateTimeKind.Local).AddTicks(4751),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 104, DateTimeKind.Local).AddTicks(6261));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 52, 16, 508, DateTimeKind.Local).AddTicks(5578),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 108, DateTimeKind.Local).AddTicks(229));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Checkouts",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 52, 16, 510, DateTimeKind.Local).AddTicks(7328),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 111, DateTimeKind.Local).AddTicks(6155));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Categories",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 52, 16, 510, DateTimeKind.Local).AddTicks(5259),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 111, DateTimeKind.Local).AddTicks(2443));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bookings",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 52, 16, 509, DateTimeKind.Local).AddTicks(9001),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 110, DateTimeKind.Local).AddTicks(3241));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bhaktas",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 52, 16, 508, DateTimeKind.Local).AddTicks(8835),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 108, DateTimeKind.Local).AddTicks(7495));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Banners",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 52, 16, 511, DateTimeKind.Local).AddTicks(618),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 112, DateTimeKind.Local).AddTicks(1369));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Addresss",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 52, 16, 511, DateTimeKind.Local).AddTicks(2851),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 112, DateTimeKind.Local).AddTicks(5304));

            migrationBuilder.AddColumn<int>(
                name: "BhaktaId",
                table: "Addresss",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 12, 52, 16, 503, DateTimeKind.Local).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 12, 52, 16, 503, DateTimeKind.Local).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 12, 52, 16, 503, DateTimeKind.Local).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 12, 52, 16, 503, DateTimeKind.Local).AddTicks(7741));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 12, 52, 16, 503, DateTimeKind.Local).AddTicks(7743));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 12, 52, 16, 503, DateTimeKind.Local).AddTicks(7745));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 12, 52, 16, 503, DateTimeKind.Local).AddTicks(7747));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 12, 52, 16, 503, DateTimeKind.Local).AddTicks(7749));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 12, 52, 16, 503, DateTimeKind.Local).AddTicks(7751));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 12, 52, 16, 503, DateTimeKind.Local).AddTicks(7752));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 12, 52, 16, 497, DateTimeKind.Local).AddTicks(4411));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 12, 52, 16, 499, DateTimeKind.Local).AddTicks(3642));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 12, 52, 16, 505, DateTimeKind.Local).AddTicks(151));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 12, 52, 16, 505, DateTimeKind.Local).AddTicks(837));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 12, 52, 16, 505, DateTimeKind.Local).AddTicks(842));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 12, 52, 16, 505, DateTimeKind.Local).AddTicks(844));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 12, 52, 16, 505, DateTimeKind.Local).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 12, 52, 16, 505, DateTimeKind.Local).AddTicks(847));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 12, 52, 16, 505, DateTimeKind.Local).AddTicks(849));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 12, 52, 16, 505, DateTimeKind.Local).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 12, 52, 16, 505, DateTimeKind.Local).AddTicks(852));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 12, 52, 16, 505, DateTimeKind.Local).AddTicks(853));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 12, 52, 16, 501, DateTimeKind.Local).AddTicks(3650));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 12, 52, 16, 501, DateTimeKind.Local).AddTicks(4474));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 12, 52, 16, 502, DateTimeKind.Local).AddTicks(3838));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 4, 4, 12, 52, 16, 502, DateTimeKind.Local).AddTicks(4404));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BhaktaId",
                table: "Addresss");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Temples",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 108, DateTimeKind.Local).AddTicks(3334),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 52, 16, 508, DateTimeKind.Local).AddTicks(6752));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "States",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 107, DateTimeKind.Local).AddTicks(4127),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 52, 16, 508, DateTimeKind.Local).AddTicks(4432));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Questions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 109, DateTimeKind.Local).AddTicks(7361),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 52, 16, 509, DateTimeKind.Local).AddTicks(5145));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "QuestionMappings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 109, DateTimeKind.Local).AddTicks(9329),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 52, 16, 509, DateTimeKind.Local).AddTicks(6386));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PushNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 110, DateTimeKind.Local).AddTicks(9915),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 52, 16, 510, DateTimeKind.Local).AddTicks(3239));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Products",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 111, DateTimeKind.Local).AddTicks(4342),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 52, 16, 510, DateTimeKind.Local).AddTicks(6362));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 109, DateTimeKind.Local).AddTicks(1642),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 52, 16, 509, DateTimeKind.Local).AddTicks(1202));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryMappings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 109, DateTimeKind.Local).AddTicks(3731),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 52, 16, 509, DateTimeKind.Local).AddTicks(2431));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 110, DateTimeKind.Local).AddTicks(5052),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 52, 16, 510, DateTimeKind.Local).AddTicks(405));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 108, DateTimeKind.Local).AddTicks(9325),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 52, 16, 508, DateTimeKind.Local).AddTicks(9802));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Pandits",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 108, DateTimeKind.Local).AddTicks(5498),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 52, 16, 508, DateTimeKind.Local).AddTicks(7679));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Orders",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 111, DateTimeKind.Local).AddTicks(7785),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 52, 16, 510, DateTimeKind.Local).AddTicks(8336));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "OrderItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 111, DateTimeKind.Local).AddTicks(9699),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 52, 16, 510, DateTimeKind.Local).AddTicks(9646));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "LiveTests",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 110, DateTimeKind.Local).AddTicks(1169),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 52, 16, 509, DateTimeKind.Local).AddTicks(7597));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Horoscopes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 112, DateTimeKind.Local).AddTicks(3367),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 52, 16, 511, DateTimeKind.Local).AddTicks(1687));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Feedbacks",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 109, DateTimeKind.Local).AddTicks(5484),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 52, 16, 509, DateTimeKind.Local).AddTicks(3959));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Countries",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 104, DateTimeKind.Local).AddTicks(6261),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 52, 16, 505, DateTimeKind.Local).AddTicks(4751));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 108, DateTimeKind.Local).AddTicks(229),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 52, 16, 508, DateTimeKind.Local).AddTicks(5578));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Checkouts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 111, DateTimeKind.Local).AddTicks(6155),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 52, 16, 510, DateTimeKind.Local).AddTicks(7328));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 111, DateTimeKind.Local).AddTicks(2443),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 52, 16, 510, DateTimeKind.Local).AddTicks(5259));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bookings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 110, DateTimeKind.Local).AddTicks(3241),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 52, 16, 509, DateTimeKind.Local).AddTicks(9001));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bhaktas",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 108, DateTimeKind.Local).AddTicks(7495),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 52, 16, 508, DateTimeKind.Local).AddTicks(8835));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Banners",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 112, DateTimeKind.Local).AddTicks(1369),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 52, 16, 511, DateTimeKind.Local).AddTicks(618));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Addresss",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 4, 4, 12, 29, 14, 112, DateTimeKind.Local).AddTicks(5304),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 4, 4, 12, 52, 16, 511, DateTimeKind.Local).AddTicks(2851));

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
    }
}
