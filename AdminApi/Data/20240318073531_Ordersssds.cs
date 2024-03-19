using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.data
{
    public partial class Ordersssds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Temples",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 18, 13, 5, 30, 341, DateTimeKind.Local).AddTicks(1282),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 706, DateTimeKind.Local).AddTicks(6158));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "States",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 18, 13, 5, 30, 340, DateTimeKind.Local).AddTicks(7891),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 706, DateTimeKind.Local).AddTicks(2404));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Questions",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 18, 13, 5, 30, 342, DateTimeKind.Local).AddTicks(1183),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 707, DateTimeKind.Local).AddTicks(8201));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "QuestionMappings",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 18, 13, 5, 30, 342, DateTimeKind.Local).AddTicks(2734),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 707, DateTimeKind.Local).AddTicks(9676));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PushNotifications",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 18, 13, 5, 30, 343, DateTimeKind.Local).AddTicks(848),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 708, DateTimeKind.Local).AddTicks(9378));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Products",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 18, 13, 5, 30, 343, DateTimeKind.Local).AddTicks(4809),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 709, DateTimeKind.Local).AddTicks(3778));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryTypes",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 18, 13, 5, 30, 341, DateTimeKind.Local).AddTicks(6805),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 707, DateTimeKind.Local).AddTicks(3081));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryMappings",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 18, 13, 5, 30, 341, DateTimeKind.Local).AddTicks(8325),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 707, DateTimeKind.Local).AddTicks(4799));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryItems",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 18, 13, 5, 30, 342, DateTimeKind.Local).AddTicks(6699),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 708, DateTimeKind.Local).AddTicks(4632));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategories",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 18, 13, 5, 30, 341, DateTimeKind.Local).AddTicks(5474),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 707, DateTimeKind.Local).AddTicks(1463));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Pandits",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 18, 13, 5, 30, 341, DateTimeKind.Local).AddTicks(2371),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 706, DateTimeKind.Local).AddTicks(7988));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "OrderParents",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 18, 13, 5, 30, 343, DateTimeKind.Local).AddTicks(7141),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 709, DateTimeKind.Local).AddTicks(7132));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "LiveTests",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 18, 13, 5, 30, 342, DateTimeKind.Local).AddTicks(4714),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 708, DateTimeKind.Local).AddTicks(1352));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Feedbacks",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 18, 13, 5, 30, 342, DateTimeKind.Local).AddTicks(50),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 707, DateTimeKind.Local).AddTicks(6348));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Countries",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 18, 13, 5, 30, 323, DateTimeKind.Local).AddTicks(1221),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 701, DateTimeKind.Local).AddTicks(3383));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 18, 13, 5, 30, 340, DateTimeKind.Local).AddTicks(9837),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 706, DateTimeKind.Local).AddTicks(4286));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Checkouts",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 18, 13, 5, 30, 343, DateTimeKind.Local).AddTicks(6208),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 709, DateTimeKind.Local).AddTicks(5386));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Categories",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 18, 13, 5, 30, 343, DateTimeKind.Local).AddTicks(3311),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 709, DateTimeKind.Local).AddTicks(1714));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bookings",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 18, 13, 5, 30, 342, DateTimeKind.Local).AddTicks(5785),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 708, DateTimeKind.Local).AddTicks(2969));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bhaktas",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 18, 13, 5, 30, 341, DateTimeKind.Local).AddTicks(4122),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 706, DateTimeKind.Local).AddTicks(9792));

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderParentId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Amount = table.Column<double>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true, defaultValue: new DateTime(2024, 3, 18, 13, 5, 30, 343, DateTimeKind.Local).AddTicks(8191)),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 18, 13, 5, 30, 321, DateTimeKind.Local).AddTicks(4558));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 18, 13, 5, 30, 321, DateTimeKind.Local).AddTicks(5356));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 18, 13, 5, 30, 321, DateTimeKind.Local).AddTicks(5361));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 18, 13, 5, 30, 321, DateTimeKind.Local).AddTicks(5363));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 18, 13, 5, 30, 321, DateTimeKind.Local).AddTicks(5365));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 18, 13, 5, 30, 321, DateTimeKind.Local).AddTicks(5367));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 18, 13, 5, 30, 321, DateTimeKind.Local).AddTicks(5369));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 18, 13, 5, 30, 321, DateTimeKind.Local).AddTicks(5371));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 18, 13, 5, 30, 321, DateTimeKind.Local).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 18, 13, 5, 30, 321, DateTimeKind.Local).AddTicks(5375));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 18, 13, 5, 30, 313, DateTimeKind.Local).AddTicks(4755));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 18, 13, 5, 30, 316, DateTimeKind.Local).AddTicks(1023));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 18, 13, 5, 30, 322, DateTimeKind.Local).AddTicks(6848));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 18, 13, 5, 30, 322, DateTimeKind.Local).AddTicks(7335));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 18, 13, 5, 30, 322, DateTimeKind.Local).AddTicks(7339));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 18, 13, 5, 30, 322, DateTimeKind.Local).AddTicks(7341));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 18, 13, 5, 30, 322, DateTimeKind.Local).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 18, 13, 5, 30, 322, DateTimeKind.Local).AddTicks(7344));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 18, 13, 5, 30, 322, DateTimeKind.Local).AddTicks(7346));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 18, 13, 5, 30, 322, DateTimeKind.Local).AddTicks(7348));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 18, 13, 5, 30, 322, DateTimeKind.Local).AddTicks(7349));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 18, 13, 5, 30, 322, DateTimeKind.Local).AddTicks(7351));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 18, 13, 5, 30, 318, DateTimeKind.Local).AddTicks(6294));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 18, 13, 5, 30, 318, DateTimeKind.Local).AddTicks(7300));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 18, 13, 5, 30, 319, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 18, 13, 5, 30, 319, DateTimeKind.Local).AddTicks(8936));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Temples",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 706, DateTimeKind.Local).AddTicks(6158),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 18, 13, 5, 30, 341, DateTimeKind.Local).AddTicks(1282));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "States",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 706, DateTimeKind.Local).AddTicks(2404),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 18, 13, 5, 30, 340, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Questions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 707, DateTimeKind.Local).AddTicks(8201),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 18, 13, 5, 30, 342, DateTimeKind.Local).AddTicks(1183));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "QuestionMappings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 707, DateTimeKind.Local).AddTicks(9676),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 18, 13, 5, 30, 342, DateTimeKind.Local).AddTicks(2734));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PushNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 708, DateTimeKind.Local).AddTicks(9378),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 18, 13, 5, 30, 343, DateTimeKind.Local).AddTicks(848));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Products",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 709, DateTimeKind.Local).AddTicks(3778),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 18, 13, 5, 30, 343, DateTimeKind.Local).AddTicks(4809));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 707, DateTimeKind.Local).AddTicks(3081),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 18, 13, 5, 30, 341, DateTimeKind.Local).AddTicks(6805));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryMappings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 707, DateTimeKind.Local).AddTicks(4799),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 18, 13, 5, 30, 341, DateTimeKind.Local).AddTicks(8325));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 708, DateTimeKind.Local).AddTicks(4632),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 18, 13, 5, 30, 342, DateTimeKind.Local).AddTicks(6699));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 707, DateTimeKind.Local).AddTicks(1463),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 18, 13, 5, 30, 341, DateTimeKind.Local).AddTicks(5474));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Pandits",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 706, DateTimeKind.Local).AddTicks(7988),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 18, 13, 5, 30, 341, DateTimeKind.Local).AddTicks(2371));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "OrderParents",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 709, DateTimeKind.Local).AddTicks(7132),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 18, 13, 5, 30, 343, DateTimeKind.Local).AddTicks(7141));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "LiveTests",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 708, DateTimeKind.Local).AddTicks(1352),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 18, 13, 5, 30, 342, DateTimeKind.Local).AddTicks(4714));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Feedbacks",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 707, DateTimeKind.Local).AddTicks(6348),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 18, 13, 5, 30, 342, DateTimeKind.Local).AddTicks(50));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Countries",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 701, DateTimeKind.Local).AddTicks(3383),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 18, 13, 5, 30, 323, DateTimeKind.Local).AddTicks(1221));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 706, DateTimeKind.Local).AddTicks(4286),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 18, 13, 5, 30, 340, DateTimeKind.Local).AddTicks(9837));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Checkouts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 709, DateTimeKind.Local).AddTicks(5386),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 18, 13, 5, 30, 343, DateTimeKind.Local).AddTicks(6208));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 709, DateTimeKind.Local).AddTicks(1714),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 18, 13, 5, 30, 343, DateTimeKind.Local).AddTicks(3311));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bookings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 708, DateTimeKind.Local).AddTicks(2969),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 18, 13, 5, 30, 342, DateTimeKind.Local).AddTicks(5785));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bhaktas",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 706, DateTimeKind.Local).AddTicks(9792),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 18, 13, 5, 30, 341, DateTimeKind.Local).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 18, 11, 55, 17, 698, DateTimeKind.Local).AddTicks(6873));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 18, 11, 55, 17, 698, DateTimeKind.Local).AddTicks(7612));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 18, 11, 55, 17, 698, DateTimeKind.Local).AddTicks(7619));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 18, 11, 55, 17, 698, DateTimeKind.Local).AddTicks(7622));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 18, 11, 55, 17, 698, DateTimeKind.Local).AddTicks(7629));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 18, 11, 55, 17, 698, DateTimeKind.Local).AddTicks(7632));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 18, 11, 55, 17, 698, DateTimeKind.Local).AddTicks(7634));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 18, 11, 55, 17, 698, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 18, 11, 55, 17, 698, DateTimeKind.Local).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 18, 11, 55, 17, 698, DateTimeKind.Local).AddTicks(7643));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 18, 11, 55, 17, 687, DateTimeKind.Local).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 18, 11, 55, 17, 690, DateTimeKind.Local).AddTicks(1307));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 18, 11, 55, 17, 700, DateTimeKind.Local).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 18, 11, 55, 17, 700, DateTimeKind.Local).AddTicks(6302));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 18, 11, 55, 17, 700, DateTimeKind.Local).AddTicks(6308));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 18, 11, 55, 17, 700, DateTimeKind.Local).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 18, 11, 55, 17, 700, DateTimeKind.Local).AddTicks(6313));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 18, 11, 55, 17, 700, DateTimeKind.Local).AddTicks(6316));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 18, 11, 55, 17, 700, DateTimeKind.Local).AddTicks(6318));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 18, 11, 55, 17, 700, DateTimeKind.Local).AddTicks(6321));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 18, 11, 55, 17, 700, DateTimeKind.Local).AddTicks(6326));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 18, 11, 55, 17, 700, DateTimeKind.Local).AddTicks(6329));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 18, 11, 55, 17, 693, DateTimeKind.Local).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 18, 11, 55, 17, 693, DateTimeKind.Local).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 18, 11, 55, 17, 696, DateTimeKind.Local).AddTicks(3437));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 18, 11, 55, 17, 696, DateTimeKind.Local).AddTicks(4946));
        }
    }
}
