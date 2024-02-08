using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class PoojaCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Temples",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 8, 16, 49, 19, 242, DateTimeKind.Local).AddTicks(3372),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 7, 16, 33, 2, 723, DateTimeKind.Local).AddTicks(5705));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "States",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 8, 16, 49, 19, 241, DateTimeKind.Local).AddTicks(9027),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 7, 16, 33, 2, 717, DateTimeKind.Local).AddTicks(7919));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Pandits",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 8, 16, 49, 19, 242, DateTimeKind.Local).AddTicks(5320),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 7, 16, 33, 2, 723, DateTimeKind.Local).AddTicks(7931));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Countries",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 8, 16, 49, 19, 237, DateTimeKind.Local).AddTicks(8104),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 7, 16, 33, 2, 714, DateTimeKind.Local).AddTicks(692));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 8, 16, 49, 19, 242, DateTimeKind.Local).AddTicks(1213),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 7, 16, 33, 2, 723, DateTimeKind.Local).AddTicks(1767));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bhaktas",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 8, 16, 49, 19, 242, DateTimeKind.Local).AddTicks(7212),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 7, 16, 33, 2, 723, DateTimeKind.Local).AddTicks(9932));

            migrationBuilder.CreateTable(
                name: "PoojaCategories",
                columns: table => new
                {
                    PoojaCategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PoojaCategoryName = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true, defaultValue: new DateTime(2024, 2, 8, 16, 49, 19, 242, DateTimeKind.Local).AddTicks(8974)),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PoojaCategories", x => x.PoojaCategoryId);
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 8, 16, 49, 19, 235, DateTimeKind.Local).AddTicks(3743));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 8, 16, 49, 19, 235, DateTimeKind.Local).AddTicks(4966));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 8, 16, 49, 19, 235, DateTimeKind.Local).AddTicks(4975));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 8, 16, 49, 19, 235, DateTimeKind.Local).AddTicks(4978));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 8, 16, 49, 19, 235, DateTimeKind.Local).AddTicks(4981));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 8, 16, 49, 19, 235, DateTimeKind.Local).AddTicks(4983));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 8, 16, 49, 19, 235, DateTimeKind.Local).AddTicks(4986));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 8, 16, 49, 19, 235, DateTimeKind.Local).AddTicks(4988));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 8, 16, 49, 19, 235, DateTimeKind.Local).AddTicks(4991));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 8, 16, 49, 19, 235, DateTimeKind.Local).AddTicks(4994));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 8, 16, 49, 19, 224, DateTimeKind.Local).AddTicks(8094));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 8, 16, 49, 19, 227, DateTimeKind.Local).AddTicks(4992));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 8, 16, 49, 19, 237, DateTimeKind.Local).AddTicks(1556));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 8, 16, 49, 19, 237, DateTimeKind.Local).AddTicks(2932));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 8, 16, 49, 19, 237, DateTimeKind.Local).AddTicks(2941));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 8, 16, 49, 19, 237, DateTimeKind.Local).AddTicks(2944));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 8, 16, 49, 19, 237, DateTimeKind.Local).AddTicks(2946));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 8, 16, 49, 19, 237, DateTimeKind.Local).AddTicks(2948));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 8, 16, 49, 19, 237, DateTimeKind.Local).AddTicks(2950));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 8, 16, 49, 19, 237, DateTimeKind.Local).AddTicks(2953));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 8, 16, 49, 19, 237, DateTimeKind.Local).AddTicks(2955));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 8, 16, 49, 19, 237, DateTimeKind.Local).AddTicks(2957));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 8, 16, 49, 19, 231, DateTimeKind.Local).AddTicks(5237));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 8, 16, 49, 19, 231, DateTimeKind.Local).AddTicks(6672));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 8, 16, 49, 19, 233, DateTimeKind.Local).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 8, 16, 49, 19, 233, DateTimeKind.Local).AddTicks(2426));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PoojaCategories");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Temples",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 7, 16, 33, 2, 723, DateTimeKind.Local).AddTicks(5705),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 8, 16, 49, 19, 242, DateTimeKind.Local).AddTicks(3372));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "States",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 7, 16, 33, 2, 717, DateTimeKind.Local).AddTicks(7919),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 8, 16, 49, 19, 241, DateTimeKind.Local).AddTicks(9027));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Pandits",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 7, 16, 33, 2, 723, DateTimeKind.Local).AddTicks(7931),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 8, 16, 49, 19, 242, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Countries",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 7, 16, 33, 2, 714, DateTimeKind.Local).AddTicks(692),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 8, 16, 49, 19, 237, DateTimeKind.Local).AddTicks(8104));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 7, 16, 33, 2, 723, DateTimeKind.Local).AddTicks(1767),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 8, 16, 49, 19, 242, DateTimeKind.Local).AddTicks(1213));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bhaktas",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 2, 7, 16, 33, 2, 723, DateTimeKind.Local).AddTicks(9932),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 2, 8, 16, 49, 19, 242, DateTimeKind.Local).AddTicks(7212));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 7, 16, 33, 2, 711, DateTimeKind.Local).AddTicks(7219));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 7, 16, 33, 2, 711, DateTimeKind.Local).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 7, 16, 33, 2, 711, DateTimeKind.Local).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 7, 16, 33, 2, 711, DateTimeKind.Local).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 7, 16, 33, 2, 711, DateTimeKind.Local).AddTicks(8558));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 7, 16, 33, 2, 711, DateTimeKind.Local).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 7, 16, 33, 2, 711, DateTimeKind.Local).AddTicks(8650));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 7, 16, 33, 2, 711, DateTimeKind.Local).AddTicks(8653));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 7, 16, 33, 2, 711, DateTimeKind.Local).AddTicks(8656));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 7, 16, 33, 2, 711, DateTimeKind.Local).AddTicks(8659));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 7, 16, 33, 2, 701, DateTimeKind.Local).AddTicks(2470));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 7, 16, 33, 2, 703, DateTimeKind.Local).AddTicks(9321));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 7, 16, 33, 2, 713, DateTimeKind.Local).AddTicks(4126));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 7, 16, 33, 2, 713, DateTimeKind.Local).AddTicks(5251));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 7, 16, 33, 2, 713, DateTimeKind.Local).AddTicks(5259));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 7, 16, 33, 2, 713, DateTimeKind.Local).AddTicks(5262));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 7, 16, 33, 2, 713, DateTimeKind.Local).AddTicks(5265));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 7, 16, 33, 2, 713, DateTimeKind.Local).AddTicks(5267));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 7, 16, 33, 2, 713, DateTimeKind.Local).AddTicks(5269));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 7, 16, 33, 2, 713, DateTimeKind.Local).AddTicks(5272));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 7, 16, 33, 2, 713, DateTimeKind.Local).AddTicks(5274));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 7, 16, 33, 2, 713, DateTimeKind.Local).AddTicks(5277));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 7, 16, 33, 2, 707, DateTimeKind.Local).AddTicks(5006));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 7, 16, 33, 2, 707, DateTimeKind.Local).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 7, 16, 33, 2, 709, DateTimeKind.Local).AddTicks(1131));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 7, 16, 33, 2, 709, DateTimeKind.Local).AddTicks(2960));
        }
    }
}
