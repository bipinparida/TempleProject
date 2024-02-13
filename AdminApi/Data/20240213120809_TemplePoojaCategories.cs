using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class TemplePoojaCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Temples",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 13, 17, 38, 8, 659, DateTimeKind.Local).AddTicks(6660),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 12, 11, 49, 54, 437, DateTimeKind.Local).AddTicks(4060));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "States",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 13, 17, 38, 8, 659, DateTimeKind.Local).AddTicks(345),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 12, 11, 49, 54, 436, DateTimeKind.Local).AddTicks(9907));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Questions",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 13, 17, 38, 8, 661, DateTimeKind.Local).AddTicks(3179),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 12, 11, 49, 54, 438, DateTimeKind.Local).AddTicks(3411));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategories",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 13, 17, 38, 8, 660, DateTimeKind.Local).AddTicks(6279),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 12, 11, 49, 54, 437, DateTimeKind.Local).AddTicks(9733));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Pandits",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 13, 17, 38, 8, 659, DateTimeKind.Local).AddTicks(9991),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 12, 11, 49, 54, 437, DateTimeKind.Local).AddTicks(5823));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "LiveTests",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 13, 17, 38, 8, 661, DateTimeKind.Local).AddTicks(6060),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 12, 11, 49, 54, 438, DateTimeKind.Local).AddTicks(5067));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Feedbacks",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 13, 17, 38, 8, 660, DateTimeKind.Local).AddTicks(9743),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 12, 11, 49, 54, 438, DateTimeKind.Local).AddTicks(1661));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Countries",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 13, 17, 38, 8, 653, DateTimeKind.Local).AddTicks(1262),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 12, 11, 49, 54, 432, DateTimeKind.Local).AddTicks(4213));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 13, 17, 38, 8, 659, DateTimeKind.Local).AddTicks(3655),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 12, 11, 49, 54, 437, DateTimeKind.Local).AddTicks(2130));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bhaktas",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 13, 17, 38, 8, 660, DateTimeKind.Local).AddTicks(3126),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 12, 11, 49, 54, 437, DateTimeKind.Local).AddTicks(7889));

            migrationBuilder.CreateTable(
                name: "TemplePoojaCategories",
                columns: table => new
                {
                    TemplePoojaCategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TempleId = table.Column<int>(nullable: false),
                    PoojaCategoryId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true, defaultValue: new DateTime(2024, 2, 13, 17, 38, 8, 661, DateTimeKind.Local).AddTicks(9073)),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemplePoojaCategories", x => x.TemplePoojaCategoryId);
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 13, 17, 38, 8, 650, DateTimeKind.Local).AddTicks(3028));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 13, 17, 38, 8, 650, DateTimeKind.Local).AddTicks(4256));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 13, 17, 38, 8, 650, DateTimeKind.Local).AddTicks(4266));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 13, 17, 38, 8, 650, DateTimeKind.Local).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 13, 17, 38, 8, 650, DateTimeKind.Local).AddTicks(4273));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 13, 17, 38, 8, 650, DateTimeKind.Local).AddTicks(4276));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 13, 17, 38, 8, 650, DateTimeKind.Local).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 13, 17, 38, 8, 650, DateTimeKind.Local).AddTicks(4281));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 13, 17, 38, 8, 650, DateTimeKind.Local).AddTicks(4283));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 13, 17, 38, 8, 650, DateTimeKind.Local).AddTicks(4286));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 13, 17, 38, 8, 641, DateTimeKind.Local).AddTicks(5534));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 13, 17, 38, 8, 642, DateTimeKind.Local).AddTicks(9766));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 13, 17, 38, 8, 652, DateTimeKind.Local).AddTicks(1063));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 13, 17, 38, 8, 652, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 13, 17, 38, 8, 652, DateTimeKind.Local).AddTicks(2249));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 13, 17, 38, 8, 652, DateTimeKind.Local).AddTicks(2252));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 13, 17, 38, 8, 652, DateTimeKind.Local).AddTicks(2254));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 13, 17, 38, 8, 652, DateTimeKind.Local).AddTicks(2257));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 13, 17, 38, 8, 652, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 13, 17, 38, 8, 652, DateTimeKind.Local).AddTicks(2262));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 13, 17, 38, 8, 652, DateTimeKind.Local).AddTicks(2264));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 13, 17, 38, 8, 652, DateTimeKind.Local).AddTicks(2266));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 13, 17, 38, 8, 645, DateTimeKind.Local).AddTicks(9973));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 13, 17, 38, 8, 646, DateTimeKind.Local).AddTicks(1113));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 13, 17, 38, 8, 647, DateTimeKind.Local).AddTicks(5911));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 13, 17, 38, 8, 647, DateTimeKind.Local).AddTicks(7719));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TemplePoojaCategories");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Temples",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 12, 11, 49, 54, 437, DateTimeKind.Local).AddTicks(4060),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 13, 17, 38, 8, 659, DateTimeKind.Local).AddTicks(6660));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "States",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 12, 11, 49, 54, 436, DateTimeKind.Local).AddTicks(9907),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 13, 17, 38, 8, 659, DateTimeKind.Local).AddTicks(345));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Questions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 12, 11, 49, 54, 438, DateTimeKind.Local).AddTicks(3411),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 13, 17, 38, 8, 661, DateTimeKind.Local).AddTicks(3179));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 12, 11, 49, 54, 437, DateTimeKind.Local).AddTicks(9733),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 13, 17, 38, 8, 660, DateTimeKind.Local).AddTicks(6279));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Pandits",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 12, 11, 49, 54, 437, DateTimeKind.Local).AddTicks(5823),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 13, 17, 38, 8, 659, DateTimeKind.Local).AddTicks(9991));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "LiveTests",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 12, 11, 49, 54, 438, DateTimeKind.Local).AddTicks(5067),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 13, 17, 38, 8, 661, DateTimeKind.Local).AddTicks(6060));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Feedbacks",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 12, 11, 49, 54, 438, DateTimeKind.Local).AddTicks(1661),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 13, 17, 38, 8, 660, DateTimeKind.Local).AddTicks(9743));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Countries",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 12, 11, 49, 54, 432, DateTimeKind.Local).AddTicks(4213),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 13, 17, 38, 8, 653, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 12, 11, 49, 54, 437, DateTimeKind.Local).AddTicks(2130),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 13, 17, 38, 8, 659, DateTimeKind.Local).AddTicks(3655));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bhaktas",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 12, 11, 49, 54, 437, DateTimeKind.Local).AddTicks(7889),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 13, 17, 38, 8, 660, DateTimeKind.Local).AddTicks(3126));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 12, 11, 49, 54, 429, DateTimeKind.Local).AddTicks(9165));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 12, 11, 49, 54, 430, DateTimeKind.Local).AddTicks(376));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 12, 11, 49, 54, 430, DateTimeKind.Local).AddTicks(386));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 12, 11, 49, 54, 430, DateTimeKind.Local).AddTicks(389));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 12, 11, 49, 54, 430, DateTimeKind.Local).AddTicks(391));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 12, 11, 49, 54, 430, DateTimeKind.Local).AddTicks(394));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 12, 11, 49, 54, 430, DateTimeKind.Local).AddTicks(397));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 12, 11, 49, 54, 430, DateTimeKind.Local).AddTicks(400));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 12, 11, 49, 54, 430, DateTimeKind.Local).AddTicks(402));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 12, 11, 49, 54, 430, DateTimeKind.Local).AddTicks(405));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 12, 11, 49, 54, 421, DateTimeKind.Local).AddTicks(6135));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 12, 11, 49, 54, 423, DateTimeKind.Local).AddTicks(519));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 12, 11, 49, 54, 431, DateTimeKind.Local).AddTicks(7058));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 12, 11, 49, 54, 431, DateTimeKind.Local).AddTicks(8241));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 12, 11, 49, 54, 431, DateTimeKind.Local).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 12, 11, 49, 54, 431, DateTimeKind.Local).AddTicks(8253));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 12, 11, 49, 54, 431, DateTimeKind.Local).AddTicks(8255));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 12, 11, 49, 54, 431, DateTimeKind.Local).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 12, 11, 49, 54, 431, DateTimeKind.Local).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 12, 11, 49, 54, 431, DateTimeKind.Local).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 12, 11, 49, 54, 431, DateTimeKind.Local).AddTicks(8265));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 12, 11, 49, 54, 431, DateTimeKind.Local).AddTicks(8267));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 12, 11, 49, 54, 425, DateTimeKind.Local).AddTicks(9905));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 12, 11, 49, 54, 426, DateTimeKind.Local).AddTicks(1114));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 12, 11, 49, 54, 427, DateTimeKind.Local).AddTicks(5804));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 12, 11, 49, 54, 427, DateTimeKind.Local).AddTicks(7462));
        }
    }
}
