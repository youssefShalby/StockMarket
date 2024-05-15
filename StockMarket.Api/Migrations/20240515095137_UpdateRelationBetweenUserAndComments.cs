using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockMarket.Api.Migrations
{
    public partial class UpdateRelationBetweenUserAndComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_AppUserId",
                table: "Comments");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 10, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(6346));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 12, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 14, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7129));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 8, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 11, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 13, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7156));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 9, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7163));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 12, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 14, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7178));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 9, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7186));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 12, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7193));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 14, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 8, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7207));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 11, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7214));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 13, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7221));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 10, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 12, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7236));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 14, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7244));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 9, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7252));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 11, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7259));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 13, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7266));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 10, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7273));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 12, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 14, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7288));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 8, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7295));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 11, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7302));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 13, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7309));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 9, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7316));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 12, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7323));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 14, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7331));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 10, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 12, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 14, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7352));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 9, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 12, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7368));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 14, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7375));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 10, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7382));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 12, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7390));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 14, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7397));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 9, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7404));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 12, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7411));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 14, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7418));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 8, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7426));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 11, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7433));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 13, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 9, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7447));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 12, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7454));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 14, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7461));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 10, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7469));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 12, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 14, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7483));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 9, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7490));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 12, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7497));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 14, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7504));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 8, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7511));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 11, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7583));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 13, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7591));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 9, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7599));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 12, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7606));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 14, 12, 51, 36, 594, DateTimeKind.Local).AddTicks(7613));

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_AspNetUsers_AppUserId",
                table: "Comments",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_AppUserId",
                table: "Comments");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 10, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(8204));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 12, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(8988));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 14, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(8997));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 8, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9004));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 11, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9011));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 13, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9028));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 9, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9035));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 12, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 14, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9051));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 9, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 12, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9068));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 14, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9075));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 8, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9084));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 11, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 13, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9098));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 10, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9105));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 12, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9112));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 14, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9121));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 9, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9129));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 11, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9136));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 13, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9143));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 10, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9150));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 12, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9157));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 14, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9164));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 8, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9171));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 11, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 13, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9186));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 9, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9193));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 12, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9200));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 14, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9207));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 10, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 12, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9221));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 14, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9228));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 9, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9238));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 12, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9245));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 14, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9252));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 10, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9259));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 12, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9266));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 14, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9273));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 9, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9280));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 12, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9287));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 14, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9294));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 8, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9301));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 11, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9309));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 13, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9316));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 9, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9323));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 12, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 14, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9337));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 10, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9344));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 12, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9351));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 14, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9358));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 9, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 12, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9373));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 14, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 8, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9387));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 11, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9474));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 13, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9481));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 9, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9488));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 12, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9495));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedOn",
                value: new DateTime(2024, 5, 14, 1, 30, 31, 532, DateTimeKind.Local).AddTicks(9502));

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_AspNetUsers_AppUserId",
                table: "Comments",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
