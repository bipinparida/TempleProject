using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class Country : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryCode = table.Column<string>(nullable: true),
                    CountryName = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryId);
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 6, 15, 4, 42, 159, DateTimeKind.Local).AddTicks(2567));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 6, 15, 4, 42, 159, DateTimeKind.Local).AddTicks(3792));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 6, 15, 4, 42, 159, DateTimeKind.Local).AddTicks(3806));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 6, 15, 4, 42, 159, DateTimeKind.Local).AddTicks(3812));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 6, 15, 4, 42, 159, DateTimeKind.Local).AddTicks(3818));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 6, 15, 4, 42, 159, DateTimeKind.Local).AddTicks(3822));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 6, 15, 4, 42, 159, DateTimeKind.Local).AddTicks(3825));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 6, 15, 4, 42, 159, DateTimeKind.Local).AddTicks(3829));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 6, 15, 4, 42, 159, DateTimeKind.Local).AddTicks(3831));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 6, 15, 4, 42, 159, DateTimeKind.Local).AddTicks(3835));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 6, 15, 4, 42, 143, DateTimeKind.Local).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 6, 15, 4, 42, 146, DateTimeKind.Local).AddTicks(6593));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 6, 15, 4, 42, 161, DateTimeKind.Local).AddTicks(5077));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 6, 15, 4, 42, 161, DateTimeKind.Local).AddTicks(6901));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 6, 15, 4, 42, 161, DateTimeKind.Local).AddTicks(6912));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 6, 15, 4, 42, 161, DateTimeKind.Local).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 6, 15, 4, 42, 161, DateTimeKind.Local).AddTicks(6917));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 6, 15, 4, 42, 161, DateTimeKind.Local).AddTicks(6919));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 6, 15, 4, 42, 161, DateTimeKind.Local).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 6, 15, 4, 42, 161, DateTimeKind.Local).AddTicks(6924));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 6, 15, 4, 42, 161, DateTimeKind.Local).AddTicks(6927));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 6, 15, 4, 42, 161, DateTimeKind.Local).AddTicks(6929));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 6, 15, 4, 42, 152, DateTimeKind.Local).AddTicks(4186));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 6, 15, 4, 42, 152, DateTimeKind.Local).AddTicks(6028));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 6, 15, 4, 42, 155, DateTimeKind.Local).AddTicks(388));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 6, 15, 4, 42, 155, DateTimeKind.Local).AddTicks(3725));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 6, 12, 13, 26, 506, DateTimeKind.Local).AddTicks(6513));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 6, 12, 13, 26, 506, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 6, 12, 13, 26, 506, DateTimeKind.Local).AddTicks(7685));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 6, 12, 13, 26, 506, DateTimeKind.Local).AddTicks(7688));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 6, 12, 13, 26, 506, DateTimeKind.Local).AddTicks(7691));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 6, 12, 13, 26, 506, DateTimeKind.Local).AddTicks(7694));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 6, 12, 13, 26, 506, DateTimeKind.Local).AddTicks(7697));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 6, 12, 13, 26, 506, DateTimeKind.Local).AddTicks(7699));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 6, 12, 13, 26, 506, DateTimeKind.Local).AddTicks(7702));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 6, 12, 13, 26, 506, DateTimeKind.Local).AddTicks(7705));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 6, 12, 13, 26, 498, DateTimeKind.Local).AddTicks(2063));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 6, 12, 13, 26, 499, DateTimeKind.Local).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 6, 12, 13, 26, 508, DateTimeKind.Local).AddTicks(7237));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 6, 12, 13, 26, 508, DateTimeKind.Local).AddTicks(8544));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 2, 6, 12, 13, 26, 508, DateTimeKind.Local).AddTicks(8553));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 2, 6, 12, 13, 26, 508, DateTimeKind.Local).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 2, 6, 12, 13, 26, 508, DateTimeKind.Local).AddTicks(8559));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 2, 6, 12, 13, 26, 508, DateTimeKind.Local).AddTicks(8561));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 2, 6, 12, 13, 26, 508, DateTimeKind.Local).AddTicks(8563));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 2, 6, 12, 13, 26, 508, DateTimeKind.Local).AddTicks(8566));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 2, 6, 12, 13, 26, 508, DateTimeKind.Local).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 2, 6, 12, 13, 26, 508, DateTimeKind.Local).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 6, 12, 13, 26, 502, DateTimeKind.Local).AddTicks(6018));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 6, 12, 13, 26, 502, DateTimeKind.Local).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 2, 6, 12, 13, 26, 504, DateTimeKind.Local).AddTicks(3215));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 2, 6, 12, 13, 26, 504, DateTimeKind.Local).AddTicks(4982));
        }
    }
}
