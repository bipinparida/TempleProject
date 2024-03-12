using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.data
{
    public partial class Poojacategorym : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Temples",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 105, DateTimeKind.Local).AddTicks(1824),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 847, DateTimeKind.Local).AddTicks(6803));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "States",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 104, DateTimeKind.Local).AddTicks(9519),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 846, DateTimeKind.Local).AddTicks(9382));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Questions",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 105, DateTimeKind.Local).AddTicks(8843),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 850, DateTimeKind.Local).AddTicks(6074));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "QuestionMappings",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 105, DateTimeKind.Local).AddTicks(9739),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 850, DateTimeKind.Local).AddTicks(9475));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PushNotifications",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 106, DateTimeKind.Local).AddTicks(5483),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 852, DateTimeKind.Local).AddTicks(8025));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryTypes",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 105, DateTimeKind.Local).AddTicks(5884),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 849, DateTimeKind.Local).AddTicks(2474));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryMappings",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 105, DateTimeKind.Local).AddTicks(6762),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 849, DateTimeKind.Local).AddTicks(7102));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryItems",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 106, DateTimeKind.Local).AddTicks(2631),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 852, DateTimeKind.Local).AddTicks(133));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategories",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 105, DateTimeKind.Local).AddTicks(4897),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 848, DateTimeKind.Local).AddTicks(8111));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Pandits",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 105, DateTimeKind.Local).AddTicks(2881),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 848, DateTimeKind.Local).AddTicks(313));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "LiveTests",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 106, DateTimeKind.Local).AddTicks(738),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 851, DateTimeKind.Local).AddTicks(2603));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Feedbacks",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 105, DateTimeKind.Local).AddTicks(7761),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 850, DateTimeKind.Local).AddTicks(1351));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Countries",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 102, DateTimeKind.Local).AddTicks(5183),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 838, DateTimeKind.Local).AddTicks(9264));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 105, DateTimeKind.Local).AddTicks(895),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 847, DateTimeKind.Local).AddTicks(3446));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bookings",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 106, DateTimeKind.Local).AddTicks(1673),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 851, DateTimeKind.Local).AddTicks(5931));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bhaktas",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 105, DateTimeKind.Local).AddTicks(3994),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 848, DateTimeKind.Local).AddTicks(3951));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 16, 8, 21, 100, DateTimeKind.Local).AddTicks(4000));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 16, 8, 21, 100, DateTimeKind.Local).AddTicks(4473));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 16, 8, 21, 100, DateTimeKind.Local).AddTicks(4477));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 16, 8, 21, 100, DateTimeKind.Local).AddTicks(4479));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 16, 8, 21, 100, DateTimeKind.Local).AddTicks(4481));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 16, 8, 21, 100, DateTimeKind.Local).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 16, 8, 21, 100, DateTimeKind.Local).AddTicks(4484));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 16, 8, 21, 100, DateTimeKind.Local).AddTicks(4486));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 16, 8, 21, 100, DateTimeKind.Local).AddTicks(4488));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 16, 8, 21, 100, DateTimeKind.Local).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 16, 8, 21, 95, DateTimeKind.Local).AddTicks(1458));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 16, 8, 21, 96, DateTimeKind.Local).AddTicks(4908));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 16, 8, 21, 101, DateTimeKind.Local).AddTicks(8729));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 16, 8, 21, 101, DateTimeKind.Local).AddTicks(9497));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 16, 8, 21, 101, DateTimeKind.Local).AddTicks(9503));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 16, 8, 21, 101, DateTimeKind.Local).AddTicks(9505));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 16, 8, 21, 101, DateTimeKind.Local).AddTicks(9508));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 16, 8, 21, 101, DateTimeKind.Local).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 16, 8, 21, 101, DateTimeKind.Local).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 16, 8, 21, 101, DateTimeKind.Local).AddTicks(9515));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 16, 8, 21, 101, DateTimeKind.Local).AddTicks(9517));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 16, 8, 21, 101, DateTimeKind.Local).AddTicks(9519));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 16, 8, 21, 98, DateTimeKind.Local).AddTicks(2553));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 16, 8, 21, 98, DateTimeKind.Local).AddTicks(2957));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 16, 8, 21, 99, DateTimeKind.Local).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 4, 16, 8, 21, 99, DateTimeKind.Local).AddTicks(1628));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Temples",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 847, DateTimeKind.Local).AddTicks(6803),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 105, DateTimeKind.Local).AddTicks(1824));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "States",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 846, DateTimeKind.Local).AddTicks(9382),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 104, DateTimeKind.Local).AddTicks(9519));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Questions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 850, DateTimeKind.Local).AddTicks(6074),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 105, DateTimeKind.Local).AddTicks(8843));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "QuestionMappings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 850, DateTimeKind.Local).AddTicks(9475),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 105, DateTimeKind.Local).AddTicks(9739));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PushNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 852, DateTimeKind.Local).AddTicks(8025),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 106, DateTimeKind.Local).AddTicks(5483));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 849, DateTimeKind.Local).AddTicks(2474),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 105, DateTimeKind.Local).AddTicks(5884));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryMappings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 849, DateTimeKind.Local).AddTicks(7102),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 105, DateTimeKind.Local).AddTicks(6762));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 852, DateTimeKind.Local).AddTicks(133),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 106, DateTimeKind.Local).AddTicks(2631));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 848, DateTimeKind.Local).AddTicks(8111),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 105, DateTimeKind.Local).AddTicks(4897));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Pandits",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 848, DateTimeKind.Local).AddTicks(313),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 105, DateTimeKind.Local).AddTicks(2881));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "LiveTests",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 851, DateTimeKind.Local).AddTicks(2603),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 106, DateTimeKind.Local).AddTicks(738));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Feedbacks",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 850, DateTimeKind.Local).AddTicks(1351),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 105, DateTimeKind.Local).AddTicks(7761));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Countries",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 838, DateTimeKind.Local).AddTicks(9264),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 102, DateTimeKind.Local).AddTicks(5183));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 847, DateTimeKind.Local).AddTicks(3446),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 105, DateTimeKind.Local).AddTicks(895));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bookings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 851, DateTimeKind.Local).AddTicks(5931),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 106, DateTimeKind.Local).AddTicks(1673));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bhaktas",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 10, 39, 58, 848, DateTimeKind.Local).AddTicks(3951),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 105, DateTimeKind.Local).AddTicks(3994));

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
    }
}
