using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class Bookingsssss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Temples",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 847, DateTimeKind.Local).AddTicks(6803),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 29, 17, 20, 4, 875, DateTimeKind.Local).AddTicks(492));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "States",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 846, DateTimeKind.Local).AddTicks(9382),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 29, 17, 20, 4, 874, DateTimeKind.Local).AddTicks(3540));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Questions",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 850, DateTimeKind.Local).AddTicks(6074),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 29, 17, 20, 4, 877, DateTimeKind.Local).AddTicks(6210));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "QuestionMappings",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 850, DateTimeKind.Local).AddTicks(9475),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 29, 17, 20, 4, 877, DateTimeKind.Local).AddTicks(9317));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PushNotifications",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 852, DateTimeKind.Local).AddTicks(8025),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 2, 29, 17, 20, 4, 879, DateTimeKind.Local).AddTicks(8383));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryTypes",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 849, DateTimeKind.Local).AddTicks(2474),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 29, 17, 20, 4, 876, DateTimeKind.Local).AddTicks(5004));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryMappings",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 849, DateTimeKind.Local).AddTicks(7102),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 29, 17, 20, 4, 876, DateTimeKind.Local).AddTicks(8389));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryItems",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 852, DateTimeKind.Local).AddTicks(133),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 29, 17, 20, 4, 878, DateTimeKind.Local).AddTicks(9688));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategories",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 848, DateTimeKind.Local).AddTicks(8111),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 29, 17, 20, 4, 876, DateTimeKind.Local).AddTicks(643));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Pandits",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 848, DateTimeKind.Local).AddTicks(313),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 29, 17, 20, 4, 875, DateTimeKind.Local).AddTicks(3446));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "LiveTests",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 851, DateTimeKind.Local).AddTicks(2603),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 29, 17, 20, 4, 878, DateTimeKind.Local).AddTicks(2101));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Feedbacks",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 850, DateTimeKind.Local).AddTicks(1351),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 29, 17, 20, 4, 877, DateTimeKind.Local).AddTicks(1888));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Countries",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 838, DateTimeKind.Local).AddTicks(9264),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 29, 17, 20, 4, 866, DateTimeKind.Local).AddTicks(2130));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 847, DateTimeKind.Local).AddTicks(3446),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 29, 17, 20, 4, 874, DateTimeKind.Local).AddTicks(7245));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bookings",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 851, DateTimeKind.Local).AddTicks(5931),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 29, 17, 20, 4, 878, DateTimeKind.Local).AddTicks(5842));

            migrationBuilder.AddColumn<int>(
                name: "PoojaCategoryItemId",
                table: "Bookings",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PoojaCategoryTypeId",
                table: "Bookings",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "PoojaPrice",
                table: "Bookings",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bhaktas",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 848, DateTimeKind.Local).AddTicks(3951),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 29, 17, 20, 4, 875, DateTimeKind.Local).AddTicks(7602));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 39, 58, 833, DateTimeKind.Local).AddTicks(1885));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 39, 58, 833, DateTimeKind.Local).AddTicks(4378));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 39, 58, 833, DateTimeKind.Local).AddTicks(4398));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 39, 58, 833, DateTimeKind.Local).AddTicks(4402));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 39, 58, 833, DateTimeKind.Local).AddTicks(4406));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 39, 58, 833, DateTimeKind.Local).AddTicks(4446));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 39, 58, 833, DateTimeKind.Local).AddTicks(4454));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 39, 58, 833, DateTimeKind.Local).AddTicks(4458));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 39, 58, 833, DateTimeKind.Local).AddTicks(4462));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 39, 58, 833, DateTimeKind.Local).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 39, 58, 816, DateTimeKind.Local).AddTicks(8566));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 39, 58, 819, DateTimeKind.Local).AddTicks(4948));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 39, 58, 837, DateTimeKind.Local).AddTicks(3815));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 39, 58, 837, DateTimeKind.Local).AddTicks(6838));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 39, 58, 837, DateTimeKind.Local).AddTicks(6865));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 39, 58, 837, DateTimeKind.Local).AddTicks(6871));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 39, 58, 837, DateTimeKind.Local).AddTicks(6876));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 39, 58, 837, DateTimeKind.Local).AddTicks(6883));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 39, 58, 837, DateTimeKind.Local).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 39, 58, 837, DateTimeKind.Local).AddTicks(6892));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 39, 58, 837, DateTimeKind.Local).AddTicks(6898));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 39, 58, 837, DateTimeKind.Local).AddTicks(6902));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 39, 58, 824, DateTimeKind.Local).AddTicks(8866));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 39, 58, 825, DateTimeKind.Local).AddTicks(1323));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 39, 58, 828, DateTimeKind.Local).AddTicks(1278));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 10, 39, 58, 828, DateTimeKind.Local).AddTicks(4223));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PoojaCategoryItemId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "PoojaCategoryTypeId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "PoojaPrice",
                table: "Bookings");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Temples",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 29, 17, 20, 4, 875, DateTimeKind.Local).AddTicks(492),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 847, DateTimeKind.Local).AddTicks(6803));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "States",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 29, 17, 20, 4, 874, DateTimeKind.Local).AddTicks(3540),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 846, DateTimeKind.Local).AddTicks(9382));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Questions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 29, 17, 20, 4, 877, DateTimeKind.Local).AddTicks(6210),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 850, DateTimeKind.Local).AddTicks(6074));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "QuestionMappings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 29, 17, 20, 4, 877, DateTimeKind.Local).AddTicks(9317),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 850, DateTimeKind.Local).AddTicks(9475));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PushNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 2, 29, 17, 20, 4, 879, DateTimeKind.Local).AddTicks(8383),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 852, DateTimeKind.Local).AddTicks(8025));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 29, 17, 20, 4, 876, DateTimeKind.Local).AddTicks(5004),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 849, DateTimeKind.Local).AddTicks(2474));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryMappings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 29, 17, 20, 4, 876, DateTimeKind.Local).AddTicks(8389),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 849, DateTimeKind.Local).AddTicks(7102));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 29, 17, 20, 4, 878, DateTimeKind.Local).AddTicks(9688),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 852, DateTimeKind.Local).AddTicks(133));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 29, 17, 20, 4, 876, DateTimeKind.Local).AddTicks(643),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 848, DateTimeKind.Local).AddTicks(8111));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Pandits",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 29, 17, 20, 4, 875, DateTimeKind.Local).AddTicks(3446),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 848, DateTimeKind.Local).AddTicks(313));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "LiveTests",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 29, 17, 20, 4, 878, DateTimeKind.Local).AddTicks(2101),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 851, DateTimeKind.Local).AddTicks(2603));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Feedbacks",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 29, 17, 20, 4, 877, DateTimeKind.Local).AddTicks(1888),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 850, DateTimeKind.Local).AddTicks(1351));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Countries",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 29, 17, 20, 4, 866, DateTimeKind.Local).AddTicks(2130),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 838, DateTimeKind.Local).AddTicks(9264));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 29, 17, 20, 4, 874, DateTimeKind.Local).AddTicks(7245),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 847, DateTimeKind.Local).AddTicks(3446));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bookings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 29, 17, 20, 4, 878, DateTimeKind.Local).AddTicks(5842),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 851, DateTimeKind.Local).AddTicks(5931));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bhaktas",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 29, 17, 20, 4, 875, DateTimeKind.Local).AddTicks(7602),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 848, DateTimeKind.Local).AddTicks(3951));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 29, 17, 20, 4, 860, DateTimeKind.Local).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 29, 17, 20, 4, 860, DateTimeKind.Local).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 29, 17, 20, 4, 860, DateTimeKind.Local).AddTicks(9624));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 29, 17, 20, 4, 860, DateTimeKind.Local).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 29, 17, 20, 4, 860, DateTimeKind.Local).AddTicks(9637));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 29, 17, 20, 4, 860, DateTimeKind.Local).AddTicks(9644));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 29, 17, 20, 4, 860, DateTimeKind.Local).AddTicks(9651));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 29, 17, 20, 4, 860, DateTimeKind.Local).AddTicks(9656));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 29, 17, 20, 4, 860, DateTimeKind.Local).AddTicks(9662));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 29, 17, 20, 4, 860, DateTimeKind.Local).AddTicks(9669));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 29, 17, 20, 4, 842, DateTimeKind.Local).AddTicks(8255));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 29, 17, 20, 4, 846, DateTimeKind.Local).AddTicks(4146));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 29, 17, 20, 4, 864, DateTimeKind.Local).AddTicks(6534));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 29, 17, 20, 4, 864, DateTimeKind.Local).AddTicks(8962));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 29, 17, 20, 4, 864, DateTimeKind.Local).AddTicks(8979));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 29, 17, 20, 4, 864, DateTimeKind.Local).AddTicks(8982));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 29, 17, 20, 4, 864, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 29, 17, 20, 4, 864, DateTimeKind.Local).AddTicks(8988));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 29, 17, 20, 4, 864, DateTimeKind.Local).AddTicks(8991));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 29, 17, 20, 4, 864, DateTimeKind.Local).AddTicks(8994));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 29, 17, 20, 4, 864, DateTimeKind.Local).AddTicks(8997));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 29, 17, 20, 4, 864, DateTimeKind.Local).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 29, 17, 20, 4, 852, DateTimeKind.Local).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 29, 17, 20, 4, 852, DateTimeKind.Local).AddTicks(3731));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 29, 17, 20, 4, 855, DateTimeKind.Local).AddTicks(5262));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 29, 17, 20, 4, 855, DateTimeKind.Local).AddTicks(8232));
        }
    }
}
