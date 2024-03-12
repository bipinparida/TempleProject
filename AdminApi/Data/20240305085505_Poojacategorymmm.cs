using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.data
{
    public partial class Poojacategorymmm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Temples",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 450, DateTimeKind.Local).AddTicks(1225),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 105, DateTimeKind.Local).AddTicks(1824));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "States",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 449, DateTimeKind.Local).AddTicks(8807),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 104, DateTimeKind.Local).AddTicks(9519));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Questions",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 450, DateTimeKind.Local).AddTicks(9491),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 105, DateTimeKind.Local).AddTicks(8843));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "QuestionMappings",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 451, DateTimeKind.Local).AddTicks(494),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 105, DateTimeKind.Local).AddTicks(9739));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PushNotifications",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 451, DateTimeKind.Local).AddTicks(6426),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 106, DateTimeKind.Local).AddTicks(5483));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryTypes",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 450, DateTimeKind.Local).AddTicks(5914),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 105, DateTimeKind.Local).AddTicks(5884));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryMappings",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 450, DateTimeKind.Local).AddTicks(7128),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 105, DateTimeKind.Local).AddTicks(6762));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryItems",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 451, DateTimeKind.Local).AddTicks(3726),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 106, DateTimeKind.Local).AddTicks(2631));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategories",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 450, DateTimeKind.Local).AddTicks(4959),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 105, DateTimeKind.Local).AddTicks(4897));

            migrationBuilder.AddColumn<double>(
                name: "PoojaPrice",
                table: "PoojaCategories",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Pandits",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 450, DateTimeKind.Local).AddTicks(2591),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 105, DateTimeKind.Local).AddTicks(2881));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "LiveTests",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 451, DateTimeKind.Local).AddTicks(1756),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 106, DateTimeKind.Local).AddTicks(738));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Feedbacks",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 450, DateTimeKind.Local).AddTicks(8218),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 105, DateTimeKind.Local).AddTicks(7761));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Countries",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 447, DateTimeKind.Local).AddTicks(2747),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 102, DateTimeKind.Local).AddTicks(5183));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 450, DateTimeKind.Local).AddTicks(222),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 105, DateTimeKind.Local).AddTicks(895));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bookings",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 451, DateTimeKind.Local).AddTicks(2755),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 106, DateTimeKind.Local).AddTicks(1673));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bhaktas",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 450, DateTimeKind.Local).AddTicks(3743),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 105, DateTimeKind.Local).AddTicks(3994));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PoojaPrice",
                table: "PoojaCategories");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Temples",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 105, DateTimeKind.Local).AddTicks(1824),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 450, DateTimeKind.Local).AddTicks(1225));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "States",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 104, DateTimeKind.Local).AddTicks(9519),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 449, DateTimeKind.Local).AddTicks(8807));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Questions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 105, DateTimeKind.Local).AddTicks(8843),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 450, DateTimeKind.Local).AddTicks(9491));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "QuestionMappings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 105, DateTimeKind.Local).AddTicks(9739),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 451, DateTimeKind.Local).AddTicks(494));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PushNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 106, DateTimeKind.Local).AddTicks(5483),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 451, DateTimeKind.Local).AddTicks(6426));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 105, DateTimeKind.Local).AddTicks(5884),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 450, DateTimeKind.Local).AddTicks(5914));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryMappings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 105, DateTimeKind.Local).AddTicks(6762),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 450, DateTimeKind.Local).AddTicks(7128));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 106, DateTimeKind.Local).AddTicks(2631),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 451, DateTimeKind.Local).AddTicks(3726));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 105, DateTimeKind.Local).AddTicks(4897),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 450, DateTimeKind.Local).AddTicks(4959));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Pandits",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 105, DateTimeKind.Local).AddTicks(2881),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 450, DateTimeKind.Local).AddTicks(2591));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "LiveTests",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 106, DateTimeKind.Local).AddTicks(738),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 451, DateTimeKind.Local).AddTicks(1756));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Feedbacks",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 105, DateTimeKind.Local).AddTicks(7761),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 450, DateTimeKind.Local).AddTicks(8218));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Countries",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 102, DateTimeKind.Local).AddTicks(5183),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 447, DateTimeKind.Local).AddTicks(2747));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 105, DateTimeKind.Local).AddTicks(895),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 450, DateTimeKind.Local).AddTicks(222));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bookings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 106, DateTimeKind.Local).AddTicks(1673),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 451, DateTimeKind.Local).AddTicks(2755));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bhaktas",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 4, 16, 8, 21, 105, DateTimeKind.Local).AddTicks(3994),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 5, 14, 25, 5, 450, DateTimeKind.Local).AddTicks(3743));

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
    }
}
