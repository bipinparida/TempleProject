using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.data
{
    public partial class Subcategorys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Temples",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 21, 16, 36, 4, 237, DateTimeKind.Local).AddTicks(9334),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 21, 15, 39, 5, 645, DateTimeKind.Local).AddTicks(8586));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "States",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 21, 16, 36, 4, 237, DateTimeKind.Local).AddTicks(3573),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 21, 15, 39, 5, 645, DateTimeKind.Local).AddTicks(4602));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Questions",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 21, 16, 36, 4, 241, DateTimeKind.Local).AddTicks(4037),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 21, 15, 39, 5, 647, DateTimeKind.Local).AddTicks(1849));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "QuestionMappings",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 21, 16, 36, 4, 241, DateTimeKind.Local).AddTicks(7456),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 21, 15, 39, 5, 647, DateTimeKind.Local).AddTicks(3838));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PushNotifications",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 16, 36, 4, 244, DateTimeKind.Local).AddTicks(3424),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 21, 15, 39, 5, 648, DateTimeKind.Local).AddTicks(4285));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Products",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 21, 16, 36, 4, 245, DateTimeKind.Local).AddTicks(1069),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 21, 15, 39, 5, 648, DateTimeKind.Local).AddTicks(8709));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryTypes",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 21, 16, 36, 4, 238, DateTimeKind.Local).AddTicks(8514),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 21, 15, 39, 5, 646, DateTimeKind.Local).AddTicks(5887));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryMappings",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 21, 16, 36, 4, 239, DateTimeKind.Local).AddTicks(408),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 21, 15, 39, 5, 646, DateTimeKind.Local).AddTicks(7667));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryItems",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 21, 16, 36, 4, 243, DateTimeKind.Local).AddTicks(5170),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 21, 15, 39, 5, 647, DateTimeKind.Local).AddTicks(9582));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategories",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 21, 16, 36, 4, 238, DateTimeKind.Local).AddTicks(6245),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 21, 15, 39, 5, 646, DateTimeKind.Local).AddTicks(4067));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Pandits",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 21, 16, 36, 4, 238, DateTimeKind.Local).AddTicks(1904),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 21, 15, 39, 5, 646, DateTimeKind.Local).AddTicks(565));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Orders",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 21, 16, 36, 4, 245, DateTimeKind.Local).AddTicks(4850),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 21, 15, 39, 5, 649, DateTimeKind.Local).AddTicks(1788));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "OrderItems",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 21, 16, 36, 4, 245, DateTimeKind.Local).AddTicks(6488),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 21, 15, 39, 5, 649, DateTimeKind.Local).AddTicks(3482));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "LiveTests",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 21, 16, 36, 4, 242, DateTimeKind.Local).AddTicks(9826),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 21, 15, 39, 5, 647, DateTimeKind.Local).AddTicks(5714));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Feedbacks",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 21, 16, 36, 4, 241, DateTimeKind.Local).AddTicks(1819),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 21, 15, 39, 5, 646, DateTimeKind.Local).AddTicks(9463));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Countries",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 21, 16, 36, 4, 233, DateTimeKind.Local).AddTicks(1373),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 21, 15, 39, 5, 641, DateTimeKind.Local).AddTicks(7102));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 21, 16, 36, 4, 237, DateTimeKind.Local).AddTicks(6549),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 21, 15, 39, 5, 645, DateTimeKind.Local).AddTicks(6711));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Checkouts",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 21, 16, 36, 4, 245, DateTimeKind.Local).AddTicks(3030),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 21, 15, 39, 5, 649, DateTimeKind.Local).AddTicks(318));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Categories",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 21, 16, 36, 4, 244, DateTimeKind.Local).AddTicks(8557),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 21, 15, 39, 5, 648, DateTimeKind.Local).AddTicks(6858));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bookings",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 21, 16, 36, 4, 243, DateTimeKind.Local).AddTicks(2978),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 21, 15, 39, 5, 647, DateTimeKind.Local).AddTicks(7707));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bhaktas",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 21, 16, 36, 4, 238, DateTimeKind.Local).AddTicks(4062),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 21, 15, 39, 5, 646, DateTimeKind.Local).AddTicks(2401));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Banners",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 21, 16, 36, 4, 245, DateTimeKind.Local).AddTicks(8194),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 21, 15, 39, 5, 649, DateTimeKind.Local).AddTicks(5016));

            migrationBuilder.CreateTable(
                name: "SubCategorys",
                columns: table => new
                {
                    SubCategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(nullable: false),
                    SubCategoryName = table.Column<string>(nullable: true),
                    SubCategoryImage = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategorys", x => x.SubCategoryId);
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 21, 16, 36, 4, 230, DateTimeKind.Local).AddTicks(261));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 21, 16, 36, 4, 230, DateTimeKind.Local).AddTicks(1427));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 21, 16, 36, 4, 230, DateTimeKind.Local).AddTicks(1442));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 21, 16, 36, 4, 230, DateTimeKind.Local).AddTicks(1447));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 21, 16, 36, 4, 230, DateTimeKind.Local).AddTicks(1452));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 21, 16, 36, 4, 230, DateTimeKind.Local).AddTicks(1455));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 21, 16, 36, 4, 230, DateTimeKind.Local).AddTicks(1457));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 21, 16, 36, 4, 230, DateTimeKind.Local).AddTicks(1461));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 21, 16, 36, 4, 230, DateTimeKind.Local).AddTicks(1465));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 21, 16, 36, 4, 230, DateTimeKind.Local).AddTicks(1467));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 21, 16, 36, 4, 219, DateTimeKind.Local).AddTicks(532));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 21, 16, 36, 4, 222, DateTimeKind.Local).AddTicks(4688));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 21, 16, 36, 4, 232, DateTimeKind.Local).AddTicks(907));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 21, 16, 36, 4, 232, DateTimeKind.Local).AddTicks(1824));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 21, 16, 36, 4, 232, DateTimeKind.Local).AddTicks(1833));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 21, 16, 36, 4, 232, DateTimeKind.Local).AddTicks(1837));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 21, 16, 36, 4, 232, DateTimeKind.Local).AddTicks(1839));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 21, 16, 36, 4, 232, DateTimeKind.Local).AddTicks(1842));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 21, 16, 36, 4, 232, DateTimeKind.Local).AddTicks(1845));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 21, 16, 36, 4, 232, DateTimeKind.Local).AddTicks(1851));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 21, 16, 36, 4, 232, DateTimeKind.Local).AddTicks(1854));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 21, 16, 36, 4, 232, DateTimeKind.Local).AddTicks(1856));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 21, 16, 36, 4, 225, DateTimeKind.Local).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 21, 16, 36, 4, 225, DateTimeKind.Local).AddTicks(8304));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 21, 16, 36, 4, 227, DateTimeKind.Local).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 21, 16, 36, 4, 227, DateTimeKind.Local).AddTicks(6915));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubCategorys");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Temples",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 21, 15, 39, 5, 645, DateTimeKind.Local).AddTicks(8586),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 21, 16, 36, 4, 237, DateTimeKind.Local).AddTicks(9334));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "States",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 21, 15, 39, 5, 645, DateTimeKind.Local).AddTicks(4602),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 21, 16, 36, 4, 237, DateTimeKind.Local).AddTicks(3573));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Questions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 21, 15, 39, 5, 647, DateTimeKind.Local).AddTicks(1849),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 21, 16, 36, 4, 241, DateTimeKind.Local).AddTicks(4037));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "QuestionMappings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 21, 15, 39, 5, 647, DateTimeKind.Local).AddTicks(3838),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 21, 16, 36, 4, 241, DateTimeKind.Local).AddTicks(7456));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PushNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 21, 15, 39, 5, 648, DateTimeKind.Local).AddTicks(4285),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 21, 16, 36, 4, 244, DateTimeKind.Local).AddTicks(3424));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Products",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 21, 15, 39, 5, 648, DateTimeKind.Local).AddTicks(8709),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 21, 16, 36, 4, 245, DateTimeKind.Local).AddTicks(1069));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 21, 15, 39, 5, 646, DateTimeKind.Local).AddTicks(5887),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 21, 16, 36, 4, 238, DateTimeKind.Local).AddTicks(8514));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryMappings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 21, 15, 39, 5, 646, DateTimeKind.Local).AddTicks(7667),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 21, 16, 36, 4, 239, DateTimeKind.Local).AddTicks(408));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 21, 15, 39, 5, 647, DateTimeKind.Local).AddTicks(9582),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 21, 16, 36, 4, 243, DateTimeKind.Local).AddTicks(5170));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 21, 15, 39, 5, 646, DateTimeKind.Local).AddTicks(4067),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 21, 16, 36, 4, 238, DateTimeKind.Local).AddTicks(6245));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Pandits",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 21, 15, 39, 5, 646, DateTimeKind.Local).AddTicks(565),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 21, 16, 36, 4, 238, DateTimeKind.Local).AddTicks(1904));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Orders",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 21, 15, 39, 5, 649, DateTimeKind.Local).AddTicks(1788),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 21, 16, 36, 4, 245, DateTimeKind.Local).AddTicks(4850));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "OrderItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 21, 15, 39, 5, 649, DateTimeKind.Local).AddTicks(3482),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 21, 16, 36, 4, 245, DateTimeKind.Local).AddTicks(6488));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "LiveTests",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 21, 15, 39, 5, 647, DateTimeKind.Local).AddTicks(5714),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 21, 16, 36, 4, 242, DateTimeKind.Local).AddTicks(9826));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Feedbacks",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 21, 15, 39, 5, 646, DateTimeKind.Local).AddTicks(9463),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 21, 16, 36, 4, 241, DateTimeKind.Local).AddTicks(1819));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Countries",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 21, 15, 39, 5, 641, DateTimeKind.Local).AddTicks(7102),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 21, 16, 36, 4, 233, DateTimeKind.Local).AddTicks(1373));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 21, 15, 39, 5, 645, DateTimeKind.Local).AddTicks(6711),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 21, 16, 36, 4, 237, DateTimeKind.Local).AddTicks(6549));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Checkouts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 21, 15, 39, 5, 649, DateTimeKind.Local).AddTicks(318),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 21, 16, 36, 4, 245, DateTimeKind.Local).AddTicks(3030));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 21, 15, 39, 5, 648, DateTimeKind.Local).AddTicks(6858),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 21, 16, 36, 4, 244, DateTimeKind.Local).AddTicks(8557));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bookings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 21, 15, 39, 5, 647, DateTimeKind.Local).AddTicks(7707),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 21, 16, 36, 4, 243, DateTimeKind.Local).AddTicks(2978));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bhaktas",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 21, 15, 39, 5, 646, DateTimeKind.Local).AddTicks(2401),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 21, 16, 36, 4, 238, DateTimeKind.Local).AddTicks(4062));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Banners",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 21, 15, 39, 5, 649, DateTimeKind.Local).AddTicks(5016),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 21, 16, 36, 4, 245, DateTimeKind.Local).AddTicks(8194));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 21, 15, 39, 5, 639, DateTimeKind.Local).AddTicks(6347));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 21, 15, 39, 5, 639, DateTimeKind.Local).AddTicks(7148));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 21, 15, 39, 5, 639, DateTimeKind.Local).AddTicks(7155));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 21, 15, 39, 5, 639, DateTimeKind.Local).AddTicks(7158));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 21, 15, 39, 5, 639, DateTimeKind.Local).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 21, 15, 39, 5, 639, DateTimeKind.Local).AddTicks(7163));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 21, 15, 39, 5, 639, DateTimeKind.Local).AddTicks(7166));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 21, 15, 39, 5, 639, DateTimeKind.Local).AddTicks(7168));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 21, 15, 39, 5, 639, DateTimeKind.Local).AddTicks(7172));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 21, 15, 39, 5, 639, DateTimeKind.Local).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 21, 15, 39, 5, 629, DateTimeKind.Local).AddTicks(2820));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 21, 15, 39, 5, 632, DateTimeKind.Local).AddTicks(942));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 21, 15, 39, 5, 641, DateTimeKind.Local).AddTicks(1465));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 21, 15, 39, 5, 641, DateTimeKind.Local).AddTicks(2142));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 21, 15, 39, 5, 641, DateTimeKind.Local).AddTicks(2147));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 21, 15, 39, 5, 641, DateTimeKind.Local).AddTicks(2149));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 21, 15, 39, 5, 641, DateTimeKind.Local).AddTicks(2151));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 21, 15, 39, 5, 641, DateTimeKind.Local).AddTicks(2154));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 21, 15, 39, 5, 641, DateTimeKind.Local).AddTicks(2156));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 21, 15, 39, 5, 641, DateTimeKind.Local).AddTicks(2159));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 21, 15, 39, 5, 641, DateTimeKind.Local).AddTicks(2161));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 21, 15, 39, 5, 641, DateTimeKind.Local).AddTicks(2163));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 21, 15, 39, 5, 636, DateTimeKind.Local).AddTicks(514));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 21, 15, 39, 5, 636, DateTimeKind.Local).AddTicks(1300));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 21, 15, 39, 5, 637, DateTimeKind.Local).AddTicks(4633));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 21, 15, 39, 5, 637, DateTimeKind.Local).AddTicks(5625));
        }
    }
}
