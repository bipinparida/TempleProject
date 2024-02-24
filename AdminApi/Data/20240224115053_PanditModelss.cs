using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class PanditModelss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Temples",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 138, DateTimeKind.Local).AddTicks(8225),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 23, 15, 24, 56, 795, DateTimeKind.Local).AddTicks(4875));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "States",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 138, DateTimeKind.Local).AddTicks(3517),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 23, 15, 24, 56, 795, DateTimeKind.Local).AddTicks(485));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Questions",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 140, DateTimeKind.Local).AddTicks(460),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 23, 15, 24, 56, 796, DateTimeKind.Local).AddTicks(8065));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "QuestionMappings",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 140, DateTimeKind.Local).AddTicks(2402),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 23, 15, 24, 56, 797, DateTimeKind.Local).AddTicks(41));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryTypes",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 139, DateTimeKind.Local).AddTicks(5371),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 23, 15, 24, 56, 796, DateTimeKind.Local).AddTicks(2403));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryMappings",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 139, DateTimeKind.Local).AddTicks(7116),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 23, 15, 24, 56, 796, DateTimeKind.Local).AddTicks(4382));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryItems",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 140, DateTimeKind.Local).AddTicks(8891),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 23, 15, 24, 56, 797, DateTimeKind.Local).AddTicks(5783));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategories",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 139, DateTimeKind.Local).AddTicks(3690),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 23, 15, 24, 56, 796, DateTimeKind.Local).AddTicks(566));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Pandits",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Pandits",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 139, DateTimeKind.Local).AddTicks(204),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 23, 15, 24, 56, 795, DateTimeKind.Local).AddTicks(6709));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "LiveTests",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 140, DateTimeKind.Local).AddTicks(5296),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 23, 15, 24, 56, 797, DateTimeKind.Local).AddTicks(2077));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Feedbacks",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 139, DateTimeKind.Local).AddTicks(8761),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 23, 15, 24, 56, 796, DateTimeKind.Local).AddTicks(6119));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Countries",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 133, DateTimeKind.Local).AddTicks(1861),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 23, 15, 24, 56, 788, DateTimeKind.Local).AddTicks(341));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 138, DateTimeKind.Local).AddTicks(5868),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 23, 15, 24, 56, 795, DateTimeKind.Local).AddTicks(2563));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bookings",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 140, DateTimeKind.Local).AddTicks(7162),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 23, 15, 24, 56, 797, DateTimeKind.Local).AddTicks(4009));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bhaktas",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 139, DateTimeKind.Local).AddTicks(2010),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 23, 15, 24, 56, 795, DateTimeKind.Local).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 17, 20, 52, 130, DateTimeKind.Local).AddTicks(6367));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 17, 20, 52, 130, DateTimeKind.Local).AddTicks(7569));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 17, 20, 52, 130, DateTimeKind.Local).AddTicks(7579));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 17, 20, 52, 130, DateTimeKind.Local).AddTicks(7582));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 17, 20, 52, 130, DateTimeKind.Local).AddTicks(7585));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 17, 20, 52, 130, DateTimeKind.Local).AddTicks(7588));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 17, 20, 52, 130, DateTimeKind.Local).AddTicks(7591));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 17, 20, 52, 130, DateTimeKind.Local).AddTicks(7593));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 17, 20, 52, 130, DateTimeKind.Local).AddTicks(7596));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 17, 20, 52, 130, DateTimeKind.Local).AddTicks(7598));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 17, 20, 52, 121, DateTimeKind.Local).AddTicks(273));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 17, 20, 52, 123, DateTimeKind.Local).AddTicks(184));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 17, 20, 52, 132, DateTimeKind.Local).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 17, 20, 52, 132, DateTimeKind.Local).AddTicks(5388));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 17, 20, 52, 132, DateTimeKind.Local).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 17, 20, 52, 132, DateTimeKind.Local).AddTicks(5403));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 17, 20, 52, 132, DateTimeKind.Local).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 17, 20, 52, 132, DateTimeKind.Local).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 17, 20, 52, 132, DateTimeKind.Local).AddTicks(5411));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 17, 20, 52, 132, DateTimeKind.Local).AddTicks(5414));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 17, 20, 52, 132, DateTimeKind.Local).AddTicks(5416));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 17, 20, 52, 132, DateTimeKind.Local).AddTicks(5419));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 17, 20, 52, 126, DateTimeKind.Local).AddTicks(5386));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 17, 20, 52, 126, DateTimeKind.Local).AddTicks(6574));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 17, 20, 52, 128, DateTimeKind.Local).AddTicks(2683));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 24, 17, 20, 52, 128, DateTimeKind.Local).AddTicks(4242));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Temples",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 23, 15, 24, 56, 795, DateTimeKind.Local).AddTicks(4875),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 138, DateTimeKind.Local).AddTicks(8225));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "States",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 23, 15, 24, 56, 795, DateTimeKind.Local).AddTicks(485),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 138, DateTimeKind.Local).AddTicks(3517));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Questions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 23, 15, 24, 56, 796, DateTimeKind.Local).AddTicks(8065),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 140, DateTimeKind.Local).AddTicks(460));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "QuestionMappings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 23, 15, 24, 56, 797, DateTimeKind.Local).AddTicks(41),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 140, DateTimeKind.Local).AddTicks(2402));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 23, 15, 24, 56, 796, DateTimeKind.Local).AddTicks(2403),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 139, DateTimeKind.Local).AddTicks(5371));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryMappings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 23, 15, 24, 56, 796, DateTimeKind.Local).AddTicks(4382),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 139, DateTimeKind.Local).AddTicks(7116));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 23, 15, 24, 56, 797, DateTimeKind.Local).AddTicks(5783),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 140, DateTimeKind.Local).AddTicks(8891));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 23, 15, 24, 56, 796, DateTimeKind.Local).AddTicks(566),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 139, DateTimeKind.Local).AddTicks(3690));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Pandits",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Pandits",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 23, 15, 24, 56, 795, DateTimeKind.Local).AddTicks(6709),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 139, DateTimeKind.Local).AddTicks(204));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "LiveTests",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 23, 15, 24, 56, 797, DateTimeKind.Local).AddTicks(2077),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 140, DateTimeKind.Local).AddTicks(5296));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Feedbacks",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 23, 15, 24, 56, 796, DateTimeKind.Local).AddTicks(6119),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 139, DateTimeKind.Local).AddTicks(8761));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Countries",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 23, 15, 24, 56, 788, DateTimeKind.Local).AddTicks(341),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 133, DateTimeKind.Local).AddTicks(1861));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 23, 15, 24, 56, 795, DateTimeKind.Local).AddTicks(2563),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 138, DateTimeKind.Local).AddTicks(5868));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bookings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 23, 15, 24, 56, 797, DateTimeKind.Local).AddTicks(4009),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 140, DateTimeKind.Local).AddTicks(7162));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bhaktas",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 23, 15, 24, 56, 795, DateTimeKind.Local).AddTicks(8733),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 24, 17, 20, 52, 139, DateTimeKind.Local).AddTicks(2010));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 23, 15, 24, 56, 783, DateTimeKind.Local).AddTicks(9342));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 23, 15, 24, 56, 784, DateTimeKind.Local).AddTicks(1229));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 23, 15, 24, 56, 784, DateTimeKind.Local).AddTicks(1246));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 23, 15, 24, 56, 784, DateTimeKind.Local).AddTicks(1251));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 23, 15, 24, 56, 784, DateTimeKind.Local).AddTicks(1256));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 23, 15, 24, 56, 784, DateTimeKind.Local).AddTicks(1407));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 23, 15, 24, 56, 784, DateTimeKind.Local).AddTicks(1414));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 23, 15, 24, 56, 784, DateTimeKind.Local).AddTicks(1419));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 23, 15, 24, 56, 784, DateTimeKind.Local).AddTicks(1422));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 23, 15, 24, 56, 784, DateTimeKind.Local).AddTicks(1426));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 23, 15, 24, 56, 770, DateTimeKind.Local).AddTicks(4061));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 23, 15, 24, 56, 772, DateTimeKind.Local).AddTicks(8537));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 23, 15, 24, 56, 786, DateTimeKind.Local).AddTicks(8454));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 23, 15, 24, 56, 787, DateTimeKind.Local).AddTicks(457));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 23, 15, 24, 56, 787, DateTimeKind.Local).AddTicks(479));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 23, 15, 24, 56, 787, DateTimeKind.Local).AddTicks(483));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 23, 15, 24, 56, 787, DateTimeKind.Local).AddTicks(487));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 23, 15, 24, 56, 787, DateTimeKind.Local).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 23, 15, 24, 56, 787, DateTimeKind.Local).AddTicks(493));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 23, 15, 24, 56, 787, DateTimeKind.Local).AddTicks(496));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 23, 15, 24, 56, 787, DateTimeKind.Local).AddTicks(499));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 23, 15, 24, 56, 787, DateTimeKind.Local).AddTicks(502));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 23, 15, 24, 56, 777, DateTimeKind.Local).AddTicks(4523));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 23, 15, 24, 56, 777, DateTimeKind.Local).AddTicks(6479));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 23, 15, 24, 56, 780, DateTimeKind.Local).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 23, 15, 24, 56, 780, DateTimeKind.Local).AddTicks(2809));
        }
    }
}
