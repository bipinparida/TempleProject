using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.data
{
    public partial class OrderParents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Temples",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 706, DateTimeKind.Local).AddTicks(6158),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 15, 15, 27, 24, 38, DateTimeKind.Local).AddTicks(3649));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "States",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 706, DateTimeKind.Local).AddTicks(2404),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 15, 15, 27, 24, 37, DateTimeKind.Local).AddTicks(9916));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Questions",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 707, DateTimeKind.Local).AddTicks(8201),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 15, 15, 27, 24, 39, DateTimeKind.Local).AddTicks(4597));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "QuestionMappings",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 707, DateTimeKind.Local).AddTicks(9676),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 15, 15, 27, 24, 39, DateTimeKind.Local).AddTicks(6059));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PushNotifications",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 708, DateTimeKind.Local).AddTicks(9378),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 15, 15, 27, 24, 40, DateTimeKind.Local).AddTicks(5253));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Products",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 709, DateTimeKind.Local).AddTicks(3778),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 15, 15, 27, 24, 40, DateTimeKind.Local).AddTicks(9330));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryTypes",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 707, DateTimeKind.Local).AddTicks(3081),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 15, 15, 27, 24, 38, DateTimeKind.Local).AddTicks(9975));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryMappings",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 707, DateTimeKind.Local).AddTicks(4799),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 15, 15, 27, 24, 39, DateTimeKind.Local).AddTicks(1325));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryItems",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 708, DateTimeKind.Local).AddTicks(4632),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 15, 15, 27, 24, 40, DateTimeKind.Local).AddTicks(799));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategories",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 707, DateTimeKind.Local).AddTicks(1463),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 15, 15, 27, 24, 38, DateTimeKind.Local).AddTicks(8481));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Pandits",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 706, DateTimeKind.Local).AddTicks(7988),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 15, 15, 27, 24, 38, DateTimeKind.Local).AddTicks(5259));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "LiveTests",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 708, DateTimeKind.Local).AddTicks(1352),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 15, 15, 27, 24, 39, DateTimeKind.Local).AddTicks(7599));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Feedbacks",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 707, DateTimeKind.Local).AddTicks(6348),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 15, 15, 27, 24, 39, DateTimeKind.Local).AddTicks(3091));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Countries",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 701, DateTimeKind.Local).AddTicks(3383),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 15, 15, 27, 24, 34, DateTimeKind.Local).AddTicks(5494));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 706, DateTimeKind.Local).AddTicks(4286),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 15, 15, 27, 24, 38, DateTimeKind.Local).AddTicks(1773));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Checkouts",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 709, DateTimeKind.Local).AddTicks(5386),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 15, 15, 27, 24, 41, DateTimeKind.Local).AddTicks(963));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Categories",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 709, DateTimeKind.Local).AddTicks(1714),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 15, 15, 27, 24, 40, DateTimeKind.Local).AddTicks(7713));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bookings",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 708, DateTimeKind.Local).AddTicks(2969),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 15, 15, 27, 24, 39, DateTimeKind.Local).AddTicks(9261));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bhaktas",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 706, DateTimeKind.Local).AddTicks(9792),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 15, 15, 27, 24, 38, DateTimeKind.Local).AddTicks(6985));

            migrationBuilder.CreateTable(
                name: "OrderParents",
                columns: table => new
                {
                    OrderParentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BhaktaId = table.Column<int>(nullable: false),
                    TotalQuantity = table.Column<int>(nullable: false),
                    TotalAmount = table.Column<double>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true, defaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 709, DateTimeKind.Local).AddTicks(7132)),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderParents", x => x.OrderParentId);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderParents");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Temples",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 15, 15, 27, 24, 38, DateTimeKind.Local).AddTicks(3649),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 706, DateTimeKind.Local).AddTicks(6158));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "States",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 15, 15, 27, 24, 37, DateTimeKind.Local).AddTicks(9916),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 706, DateTimeKind.Local).AddTicks(2404));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Questions",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 15, 15, 27, 24, 39, DateTimeKind.Local).AddTicks(4597),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 707, DateTimeKind.Local).AddTicks(8201));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "QuestionMappings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 15, 15, 27, 24, 39, DateTimeKind.Local).AddTicks(6059),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 707, DateTimeKind.Local).AddTicks(9676));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PushNotifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 15, 15, 27, 24, 40, DateTimeKind.Local).AddTicks(5253),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 708, DateTimeKind.Local).AddTicks(9378));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Products",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 15, 15, 27, 24, 40, DateTimeKind.Local).AddTicks(9330),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 709, DateTimeKind.Local).AddTicks(3778));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryTypes",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 15, 15, 27, 24, 38, DateTimeKind.Local).AddTicks(9975),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 707, DateTimeKind.Local).AddTicks(3081));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryMappings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 15, 15, 27, 24, 39, DateTimeKind.Local).AddTicks(1325),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 707, DateTimeKind.Local).AddTicks(4799));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategoryItems",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 15, 15, 27, 24, 40, DateTimeKind.Local).AddTicks(799),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 708, DateTimeKind.Local).AddTicks(4632));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "PoojaCategories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 15, 15, 27, 24, 38, DateTimeKind.Local).AddTicks(8481),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 707, DateTimeKind.Local).AddTicks(1463));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Pandits",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 15, 15, 27, 24, 38, DateTimeKind.Local).AddTicks(5259),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 706, DateTimeKind.Local).AddTicks(7988));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "LiveTests",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 15, 15, 27, 24, 39, DateTimeKind.Local).AddTicks(7599),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 708, DateTimeKind.Local).AddTicks(1352));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Feedbacks",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 15, 15, 27, 24, 39, DateTimeKind.Local).AddTicks(3091),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 707, DateTimeKind.Local).AddTicks(6348));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Countries",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 15, 15, 27, 24, 34, DateTimeKind.Local).AddTicks(5494),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 701, DateTimeKind.Local).AddTicks(3383));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Cities",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 15, 15, 27, 24, 38, DateTimeKind.Local).AddTicks(1773),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 706, DateTimeKind.Local).AddTicks(4286));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Checkouts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 15, 15, 27, 24, 41, DateTimeKind.Local).AddTicks(963),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 709, DateTimeKind.Local).AddTicks(5386));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 15, 15, 27, 24, 40, DateTimeKind.Local).AddTicks(7713),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 709, DateTimeKind.Local).AddTicks(1714));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bookings",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 15, 15, 27, 24, 39, DateTimeKind.Local).AddTicks(9261),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 708, DateTimeKind.Local).AddTicks(2969));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Bhaktas",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2024, 3, 15, 15, 27, 24, 38, DateTimeKind.Local).AddTicks(6985),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 3, 18, 11, 55, 17, 706, DateTimeKind.Local).AddTicks(9792));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 15, 15, 27, 24, 32, DateTimeKind.Local).AddTicks(3196));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 15, 15, 27, 24, 32, DateTimeKind.Local).AddTicks(4058));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 15, 15, 27, 24, 32, DateTimeKind.Local).AddTicks(4065));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 15, 15, 27, 24, 32, DateTimeKind.Local).AddTicks(4068));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 15, 15, 27, 24, 32, DateTimeKind.Local).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 15, 15, 27, 24, 32, DateTimeKind.Local).AddTicks(4078));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 15, 15, 27, 24, 32, DateTimeKind.Local).AddTicks(4081));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 15, 15, 27, 24, 32, DateTimeKind.Local).AddTicks(4084));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 15, 15, 27, 24, 32, DateTimeKind.Local).AddTicks(4087));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 15, 15, 27, 24, 32, DateTimeKind.Local).AddTicks(4089));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 15, 15, 27, 24, 20, DateTimeKind.Local).AddTicks(2625));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 15, 15, 27, 24, 26, DateTimeKind.Local).AddTicks(3633));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 15, 15, 27, 24, 33, DateTimeKind.Local).AddTicks(9305));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 15, 15, 27, 24, 34, DateTimeKind.Local).AddTicks(61));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 3, 15, 15, 27, 24, 34, DateTimeKind.Local).AddTicks(67));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 3, 15, 15, 27, 24, 34, DateTimeKind.Local).AddTicks(69));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 3, 15, 15, 27, 24, 34, DateTimeKind.Local).AddTicks(71));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 3, 15, 15, 27, 24, 34, DateTimeKind.Local).AddTicks(73));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 3, 15, 15, 27, 24, 34, DateTimeKind.Local).AddTicks(76));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 3, 15, 15, 27, 24, 34, DateTimeKind.Local).AddTicks(78));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 3, 15, 15, 27, 24, 34, DateTimeKind.Local).AddTicks(81));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 3, 15, 15, 27, 24, 34, DateTimeKind.Local).AddTicks(83));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 15, 15, 27, 24, 29, DateTimeKind.Local).AddTicks(7));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 15, 15, 27, 24, 29, DateTimeKind.Local).AddTicks(776));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 3, 15, 15, 27, 24, 30, DateTimeKind.Local).AddTicks(3822));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 3, 15, 15, 27, 24, 30, DateTimeKind.Local).AddTicks(4597));
        }
    }
}
