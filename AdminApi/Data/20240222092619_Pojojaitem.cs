using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.data
{
    public partial class Pojojaitem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Temples",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 22, 14, 56, 19, 25, DateTimeKind.Local).AddTicks(322),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 22, 12, 52, 16, 729, DateTimeKind.Local).AddTicks(6310));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "States",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 22, 14, 56, 19, 24, DateTimeKind.Local).AddTicks(7227),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 22, 12, 52, 16, 729, DateTimeKind.Local).AddTicks(468));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Questions",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 22, 14, 56, 19, 25, DateTimeKind.Local).AddTicks(9949),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 22, 12, 52, 16, 731, DateTimeKind.Local).AddTicks(1815));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "QuestionMappings",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 22, 14, 56, 19, 26, DateTimeKind.Local).AddTicks(1801),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 22, 12, 52, 16, 731, DateTimeKind.Local).AddTicks(4006));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryTypes",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 22, 14, 56, 19, 25, DateTimeKind.Local).AddTicks(6026),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 22, 12, 52, 16, 730, DateTimeKind.Local).AddTicks(5166));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryMappings",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 22, 14, 56, 19, 25, DateTimeKind.Local).AddTicks(7256),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 22, 12, 52, 16, 730, DateTimeKind.Local).AddTicks(7325));

            migrationBuilder.AddColumn<int>(
                name: "PoojaCategoryTypeId",
                table: "PoojaCategoryMappings",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryItems",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 22, 14, 56, 19, 26, DateTimeKind.Local).AddTicks(5877),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 22, 12, 52, 16, 732, DateTimeKind.Local).AddTicks(358));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategories",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 22, 14, 56, 19, 25, DateTimeKind.Local).AddTicks(4504),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 22, 12, 52, 16, 730, DateTimeKind.Local).AddTicks(2895));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Pandits",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 22, 14, 56, 19, 25, DateTimeKind.Local).AddTicks(1801),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 22, 12, 52, 16, 729, DateTimeKind.Local).AddTicks(8613));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "LiveTests",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 22, 14, 56, 19, 26, DateTimeKind.Local).AddTicks(3152),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 22, 12, 52, 16, 731, DateTimeKind.Local).AddTicks(5977));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Feedbacks",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 22, 14, 56, 19, 25, DateTimeKind.Local).AddTicks(8662),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 22, 12, 52, 16, 730, DateTimeKind.Local).AddTicks(9614));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Countries",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 22, 14, 56, 19, 21, DateTimeKind.Local).AddTicks(6996),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 22, 12, 52, 16, 724, DateTimeKind.Local).AddTicks(4516));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 22, 14, 56, 19, 24, DateTimeKind.Local).AddTicks(8930),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 22, 12, 52, 16, 729, DateTimeKind.Local).AddTicks(3752));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bookings",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 22, 14, 56, 19, 26, DateTimeKind.Local).AddTicks(4382),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 22, 12, 52, 16, 731, DateTimeKind.Local).AddTicks(8073));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bhaktas",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 22, 14, 56, 19, 25, DateTimeKind.Local).AddTicks(3308),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 22, 12, 52, 16, 730, DateTimeKind.Local).AddTicks(847));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 14, 56, 19, 20, DateTimeKind.Local).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 14, 56, 19, 20, DateTimeKind.Local).AddTicks(4812));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 14, 56, 19, 20, DateTimeKind.Local).AddTicks(4815));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 14, 56, 19, 20, DateTimeKind.Local).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 14, 56, 19, 20, DateTimeKind.Local).AddTicks(4819));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 14, 56, 19, 20, DateTimeKind.Local).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 14, 56, 19, 20, DateTimeKind.Local).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 14, 56, 19, 20, DateTimeKind.Local).AddTicks(4825));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 14, 56, 19, 20, DateTimeKind.Local).AddTicks(4827));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 14, 56, 19, 20, DateTimeKind.Local).AddTicks(4828));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 14, 56, 19, 13, DateTimeKind.Local).AddTicks(9682));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 14, 56, 19, 15, DateTimeKind.Local).AddTicks(6437));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 14, 56, 19, 21, DateTimeKind.Local).AddTicks(3354));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 14, 56, 19, 21, DateTimeKind.Local).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 14, 56, 19, 21, DateTimeKind.Local).AddTicks(3813));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 14, 56, 19, 21, DateTimeKind.Local).AddTicks(3815));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 14, 56, 19, 21, DateTimeKind.Local).AddTicks(3817));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 14, 56, 19, 21, DateTimeKind.Local).AddTicks(3818));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 14, 56, 19, 21, DateTimeKind.Local).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 14, 56, 19, 21, DateTimeKind.Local).AddTicks(3822));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 14, 56, 19, 21, DateTimeKind.Local).AddTicks(3823));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 14, 56, 19, 21, DateTimeKind.Local).AddTicks(3825));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 14, 56, 19, 17, DateTimeKind.Local).AddTicks(9869));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 14, 56, 19, 18, DateTimeKind.Local).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 14, 56, 19, 19, DateTimeKind.Local).AddTicks(1869));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 14, 56, 19, 19, DateTimeKind.Local).AddTicks(2717));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PoojaCategoryTypeId",
                table: "PoojaCategoryMappings");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Temples",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 22, 12, 52, 16, 729, DateTimeKind.Local).AddTicks(6310),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 22, 14, 56, 19, 25, DateTimeKind.Local).AddTicks(322));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "States",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 22, 12, 52, 16, 729, DateTimeKind.Local).AddTicks(468),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 22, 14, 56, 19, 24, DateTimeKind.Local).AddTicks(7227));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Questions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 22, 12, 52, 16, 731, DateTimeKind.Local).AddTicks(1815),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 22, 14, 56, 19, 25, DateTimeKind.Local).AddTicks(9949));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "QuestionMappings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 22, 12, 52, 16, 731, DateTimeKind.Local).AddTicks(4006),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 22, 14, 56, 19, 26, DateTimeKind.Local).AddTicks(1801));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 22, 12, 52, 16, 730, DateTimeKind.Local).AddTicks(5166),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 22, 14, 56, 19, 25, DateTimeKind.Local).AddTicks(6026));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryMappings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 22, 12, 52, 16, 730, DateTimeKind.Local).AddTicks(7325),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 22, 14, 56, 19, 25, DateTimeKind.Local).AddTicks(7256));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 22, 12, 52, 16, 732, DateTimeKind.Local).AddTicks(358),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 22, 14, 56, 19, 26, DateTimeKind.Local).AddTicks(5877));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 22, 12, 52, 16, 730, DateTimeKind.Local).AddTicks(2895),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 22, 14, 56, 19, 25, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Pandits",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 22, 12, 52, 16, 729, DateTimeKind.Local).AddTicks(8613),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 22, 14, 56, 19, 25, DateTimeKind.Local).AddTicks(1801));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "LiveTests",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 22, 12, 52, 16, 731, DateTimeKind.Local).AddTicks(5977),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 22, 14, 56, 19, 26, DateTimeKind.Local).AddTicks(3152));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Feedbacks",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 22, 12, 52, 16, 730, DateTimeKind.Local).AddTicks(9614),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 22, 14, 56, 19, 25, DateTimeKind.Local).AddTicks(8662));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Countries",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 22, 12, 52, 16, 724, DateTimeKind.Local).AddTicks(4516),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 22, 14, 56, 19, 21, DateTimeKind.Local).AddTicks(6996));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 22, 12, 52, 16, 729, DateTimeKind.Local).AddTicks(3752),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 22, 14, 56, 19, 24, DateTimeKind.Local).AddTicks(8930));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bookings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 22, 12, 52, 16, 731, DateTimeKind.Local).AddTicks(8073),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 22, 14, 56, 19, 26, DateTimeKind.Local).AddTicks(4382));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bhaktas",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 22, 12, 52, 16, 730, DateTimeKind.Local).AddTicks(847),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 22, 14, 56, 19, 25, DateTimeKind.Local).AddTicks(3308));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 12, 52, 16, 721, DateTimeKind.Local).AddTicks(5441));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 12, 52, 16, 721, DateTimeKind.Local).AddTicks(6539));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 12, 52, 16, 721, DateTimeKind.Local).AddTicks(6549));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 12, 52, 16, 721, DateTimeKind.Local).AddTicks(6551));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 12, 52, 16, 721, DateTimeKind.Local).AddTicks(6555));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 12, 52, 16, 721, DateTimeKind.Local).AddTicks(6559));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 12, 52, 16, 721, DateTimeKind.Local).AddTicks(6561));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 12, 52, 16, 721, DateTimeKind.Local).AddTicks(6565));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 12, 52, 16, 721, DateTimeKind.Local).AddTicks(6568));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 12, 52, 16, 721, DateTimeKind.Local).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 12, 52, 16, 711, DateTimeKind.Local).AddTicks(6090));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 12, 52, 16, 713, DateTimeKind.Local).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 12, 52, 16, 723, DateTimeKind.Local).AddTicks(6023));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 12, 52, 16, 723, DateTimeKind.Local).AddTicks(7285));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 12, 52, 16, 723, DateTimeKind.Local).AddTicks(7296));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 12, 52, 16, 723, DateTimeKind.Local).AddTicks(7300));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 12, 52, 16, 723, DateTimeKind.Local).AddTicks(7303));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 12, 52, 16, 723, DateTimeKind.Local).AddTicks(7305));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 12, 52, 16, 723, DateTimeKind.Local).AddTicks(7309));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 12, 52, 16, 723, DateTimeKind.Local).AddTicks(7312));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 12, 52, 16, 723, DateTimeKind.Local).AddTicks(7315));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 12, 52, 16, 723, DateTimeKind.Local).AddTicks(7318));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 12, 52, 16, 717, DateTimeKind.Local).AddTicks(1683));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 12, 52, 16, 717, DateTimeKind.Local).AddTicks(2888));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 12, 52, 16, 718, DateTimeKind.Local).AddTicks(9429));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 22, 12, 52, 16, 719, DateTimeKind.Local).AddTicks(807));
        }
    }
}
