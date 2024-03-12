using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.data
{
    public partial class PoojacategoryItemmm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Temples",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 7, 15, 26, 52, 467, DateTimeKind.Local).AddTicks(5878),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 450, DateTimeKind.Local).AddTicks(1225));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "States",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 7, 15, 26, 52, 467, DateTimeKind.Local).AddTicks(2290),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 449, DateTimeKind.Local).AddTicks(8807));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Questions",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 7, 15, 26, 52, 468, DateTimeKind.Local).AddTicks(7204),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 450, DateTimeKind.Local).AddTicks(9491));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "QuestionMappings",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 7, 15, 26, 52, 468, DateTimeKind.Local).AddTicks(8691),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 451, DateTimeKind.Local).AddTicks(494));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PushNotifications",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 7, 15, 26, 52, 469, DateTimeKind.Local).AddTicks(7366),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 451, DateTimeKind.Local).AddTicks(6426));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryTypes",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 7, 15, 26, 52, 468, DateTimeKind.Local).AddTicks(2292),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 450, DateTimeKind.Local).AddTicks(5914));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryMappings",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 7, 15, 26, 52, 468, DateTimeKind.Local).AddTicks(3857),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 450, DateTimeKind.Local).AddTicks(7128));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryItems",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 7, 15, 26, 52, 469, DateTimeKind.Local).AddTicks(3631),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 451, DateTimeKind.Local).AddTicks(3726));

            migrationBuilder.AddColumn<int>(
                name: "TempleId",
                table: "PoojaCategoryItems",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategories",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 7, 15, 26, 52, 468, DateTimeKind.Local).AddTicks(663),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 450, DateTimeKind.Local).AddTicks(4959));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Pandits",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 7, 15, 26, 52, 467, DateTimeKind.Local).AddTicks(7421),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 450, DateTimeKind.Local).AddTicks(2591));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "LiveTests",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 7, 15, 26, 52, 469, DateTimeKind.Local).AddTicks(399),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 451, DateTimeKind.Local).AddTicks(1756));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Feedbacks",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 7, 15, 26, 52, 468, DateTimeKind.Local).AddTicks(5479),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 450, DateTimeKind.Local).AddTicks(8218));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Countries",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 7, 15, 26, 52, 464, DateTimeKind.Local).AddTicks(2266),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 447, DateTimeKind.Local).AddTicks(2747));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 7, 15, 26, 52, 467, DateTimeKind.Local).AddTicks(4311),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 450, DateTimeKind.Local).AddTicks(222));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bookings",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 7, 15, 26, 52, 469, DateTimeKind.Local).AddTicks(2076),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 451, DateTimeKind.Local).AddTicks(2755));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bhaktas",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 7, 15, 26, 52, 467, DateTimeKind.Local).AddTicks(9188),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 450, DateTimeKind.Local).AddTicks(3743));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 7, 15, 26, 52, 462, DateTimeKind.Local).AddTicks(4698));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 7, 15, 26, 52, 462, DateTimeKind.Local).AddTicks(5335));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 7, 15, 26, 52, 462, DateTimeKind.Local).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 7, 15, 26, 52, 462, DateTimeKind.Local).AddTicks(5342));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 7, 15, 26, 52, 462, DateTimeKind.Local).AddTicks(5346));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 7, 15, 26, 52, 462, DateTimeKind.Local).AddTicks(5347));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 7, 15, 26, 52, 462, DateTimeKind.Local).AddTicks(5349));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 7, 15, 26, 52, 462, DateTimeKind.Local).AddTicks(5351));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 7, 15, 26, 52, 462, DateTimeKind.Local).AddTicks(5353));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 7, 15, 26, 52, 462, DateTimeKind.Local).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 7, 15, 26, 52, 456, DateTimeKind.Local).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 7, 15, 26, 52, 457, DateTimeKind.Local).AddTicks(9864));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 7, 15, 26, 52, 463, DateTimeKind.Local).AddTicks(7119));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 7, 15, 26, 52, 463, DateTimeKind.Local).AddTicks(7763));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 7, 15, 26, 52, 463, DateTimeKind.Local).AddTicks(7768));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 7, 15, 26, 52, 463, DateTimeKind.Local).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 7, 15, 26, 52, 463, DateTimeKind.Local).AddTicks(7771));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 7, 15, 26, 52, 463, DateTimeKind.Local).AddTicks(7773));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 7, 15, 26, 52, 463, DateTimeKind.Local).AddTicks(7774));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 7, 15, 26, 52, 463, DateTimeKind.Local).AddTicks(7776));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 7, 15, 26, 52, 463, DateTimeKind.Local).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 7, 15, 26, 52, 463, DateTimeKind.Local).AddTicks(7779));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 7, 15, 26, 52, 459, DateTimeKind.Local).AddTicks(9770));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 7, 15, 26, 52, 460, DateTimeKind.Local).AddTicks(398));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 7, 15, 26, 52, 461, DateTimeKind.Local).AddTicks(731));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 7, 15, 26, 52, 461, DateTimeKind.Local).AddTicks(1544));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TempleId",
                table: "PoojaCategoryItems");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Temples",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 450, DateTimeKind.Local).AddTicks(1225),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 7, 15, 26, 52, 467, DateTimeKind.Local).AddTicks(5878));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "States",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 449, DateTimeKind.Local).AddTicks(8807),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 7, 15, 26, 52, 467, DateTimeKind.Local).AddTicks(2290));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Questions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 450, DateTimeKind.Local).AddTicks(9491),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 7, 15, 26, 52, 468, DateTimeKind.Local).AddTicks(7204));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "QuestionMappings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 451, DateTimeKind.Local).AddTicks(494),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 7, 15, 26, 52, 468, DateTimeKind.Local).AddTicks(8691));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PushNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 451, DateTimeKind.Local).AddTicks(6426),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 7, 15, 26, 52, 469, DateTimeKind.Local).AddTicks(7366));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 450, DateTimeKind.Local).AddTicks(5914),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 7, 15, 26, 52, 468, DateTimeKind.Local).AddTicks(2292));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryMappings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 450, DateTimeKind.Local).AddTicks(7128),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 7, 15, 26, 52, 468, DateTimeKind.Local).AddTicks(3857));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 451, DateTimeKind.Local).AddTicks(3726),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 7, 15, 26, 52, 469, DateTimeKind.Local).AddTicks(3631));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 450, DateTimeKind.Local).AddTicks(4959),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 7, 15, 26, 52, 468, DateTimeKind.Local).AddTicks(663));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Pandits",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 450, DateTimeKind.Local).AddTicks(2591),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 7, 15, 26, 52, 467, DateTimeKind.Local).AddTicks(7421));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "LiveTests",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 451, DateTimeKind.Local).AddTicks(1756),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 7, 15, 26, 52, 469, DateTimeKind.Local).AddTicks(399));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Feedbacks",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 450, DateTimeKind.Local).AddTicks(8218),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 7, 15, 26, 52, 468, DateTimeKind.Local).AddTicks(5479));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Countries",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 447, DateTimeKind.Local).AddTicks(2747),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 7, 15, 26, 52, 464, DateTimeKind.Local).AddTicks(2266));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 450, DateTimeKind.Local).AddTicks(222),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 7, 15, 26, 52, 467, DateTimeKind.Local).AddTicks(4311));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bookings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 451, DateTimeKind.Local).AddTicks(2755),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 7, 15, 26, 52, 469, DateTimeKind.Local).AddTicks(2076));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bhaktas",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 450, DateTimeKind.Local).AddTicks(3743),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 7, 15, 26, 52, 467, DateTimeKind.Local).AddTicks(9188));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 5, 14, 25, 5, 445, DateTimeKind.Local).AddTicks(1219));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 5, 14, 25, 5, 445, DateTimeKind.Local).AddTicks(1930));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 5, 14, 25, 5, 445, DateTimeKind.Local).AddTicks(1935));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 5, 14, 25, 5, 445, DateTimeKind.Local).AddTicks(1938));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 5, 14, 25, 5, 445, DateTimeKind.Local).AddTicks(1944));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 5, 14, 25, 5, 445, DateTimeKind.Local).AddTicks(1946));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 5, 14, 25, 5, 445, DateTimeKind.Local).AddTicks(1948));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 5, 14, 25, 5, 445, DateTimeKind.Local).AddTicks(1950));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 5, 14, 25, 5, 445, DateTimeKind.Local).AddTicks(1952));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 5, 14, 25, 5, 445, DateTimeKind.Local).AddTicks(1954));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 5, 14, 25, 5, 436, DateTimeKind.Local).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 5, 14, 25, 5, 438, DateTimeKind.Local).AddTicks(3976));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 5, 14, 25, 5, 446, DateTimeKind.Local).AddTicks(6654));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 5, 14, 25, 5, 446, DateTimeKind.Local).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 5, 14, 25, 5, 446, DateTimeKind.Local).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 5, 14, 25, 5, 446, DateTimeKind.Local).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 5, 14, 25, 5, 446, DateTimeKind.Local).AddTicks(7343));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 5, 14, 25, 5, 446, DateTimeKind.Local).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 5, 14, 25, 5, 446, DateTimeKind.Local).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 5, 14, 25, 5, 446, DateTimeKind.Local).AddTicks(7349));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 5, 14, 25, 5, 446, DateTimeKind.Local).AddTicks(7351));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 5, 14, 25, 5, 446, DateTimeKind.Local).AddTicks(7354));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 5, 14, 25, 5, 441, DateTimeKind.Local).AddTicks(5128));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 5, 14, 25, 5, 441, DateTimeKind.Local).AddTicks(6038));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 5, 14, 25, 5, 442, DateTimeKind.Local).AddTicks(9619));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 5, 14, 25, 5, 443, DateTimeKind.Local).AddTicks(612));
        }
    }
}
