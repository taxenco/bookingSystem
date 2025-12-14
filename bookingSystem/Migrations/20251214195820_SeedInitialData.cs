using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace bookingSystem.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "CreatedAt", "EndDate", "ResourceId", "StartDate", "Status", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 12, 14, 19, 58, 19, 642, DateTimeKind.Utc).AddTicks(180), new DateTime(2025, 12, 27, 19, 58, 19, 641, DateTimeKind.Utc).AddTicks(6544), 9, new DateTime(2025, 12, 23, 19, 58, 19, 641, DateTimeKind.Utc).AddTicks(6544), "Completed", 8 },
                    { 2, new DateTime(2025, 12, 14, 19, 58, 19, 642, DateTimeKind.Utc).AddTicks(600), new DateTime(2025, 12, 5, 19, 58, 19, 642, DateTimeKind.Utc).AddTicks(590), 2, new DateTime(2025, 12, 4, 19, 58, 19, 642, DateTimeKind.Utc).AddTicks(590), "InProgress", 2 },
                    { 3, new DateTime(2025, 12, 14, 19, 58, 19, 642, DateTimeKind.Utc).AddTicks(603), new DateTime(2025, 12, 24, 19, 58, 19, 642, DateTimeKind.Utc).AddTicks(601), 5, new DateTime(2025, 12, 22, 19, 58, 19, 642, DateTimeKind.Utc).AddTicks(601), "Requested", 2 },
                    { 4, new DateTime(2025, 12, 14, 19, 58, 19, 642, DateTimeKind.Utc).AddTicks(605), new DateTime(2025, 12, 23, 19, 58, 19, 642, DateTimeKind.Utc).AddTicks(603), 1, new DateTime(2025, 12, 20, 19, 58, 19, 642, DateTimeKind.Utc).AddTicks(603), "Expired", 3 },
                    { 5, new DateTime(2025, 12, 14, 19, 58, 19, 642, DateTimeKind.Utc).AddTicks(607), new DateTime(2025, 12, 8, 19, 58, 19, 642, DateTimeKind.Utc).AddTicks(605), 1, new DateTime(2025, 12, 7, 19, 58, 19, 642, DateTimeKind.Utc).AddTicks(605), "Completed", 8 },
                    { 6, new DateTime(2025, 12, 14, 19, 58, 19, 642, DateTimeKind.Utc).AddTicks(613), new DateTime(2025, 12, 19, 19, 58, 19, 642, DateTimeKind.Utc).AddTicks(612), 6, new DateTime(2025, 12, 16, 19, 58, 19, 642, DateTimeKind.Utc).AddTicks(612), "Confirmed", 9 },
                    { 7, new DateTime(2025, 12, 14, 19, 58, 19, 642, DateTimeKind.Utc).AddTicks(615), new DateTime(2025, 12, 19, 19, 58, 19, 642, DateTimeKind.Utc).AddTicks(614), 1, new DateTime(2025, 12, 15, 19, 58, 19, 642, DateTimeKind.Utc).AddTicks(614), "InProgress", 8 },
                    { 8, new DateTime(2025, 12, 14, 19, 58, 19, 642, DateTimeKind.Utc).AddTicks(618), new DateTime(2025, 12, 9, 19, 58, 19, 642, DateTimeKind.Utc).AddTicks(616), 5, new DateTime(2025, 12, 5, 19, 58, 19, 642, DateTimeKind.Utc).AddTicks(616), "NoShow", 3 },
                    { 9, new DateTime(2025, 12, 14, 19, 58, 19, 642, DateTimeKind.Utc).AddTicks(620), new DateTime(2025, 12, 26, 19, 58, 19, 642, DateTimeKind.Utc).AddTicks(618), 2, new DateTime(2025, 12, 22, 19, 58, 19, 642, DateTimeKind.Utc).AddTicks(618), "Completed", 5 },
                    { 10, new DateTime(2025, 12, 14, 19, 58, 19, 642, DateTimeKind.Utc).AddTicks(623), new DateTime(2025, 12, 7, 19, 58, 19, 642, DateTimeKind.Utc).AddTicks(621), 2, new DateTime(2025, 12, 6, 19, 58, 19, 642, DateTimeKind.Utc).AddTicks(621), "Rescheduled", 4 }
                });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "CreatedAt", "Description", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 12, 14, 19, 58, 19, 641, DateTimeKind.Utc).AddTicks(1362), "Auto generated resource number 1", true, "Resource 1" },
                    { 2, new DateTime(2025, 12, 14, 19, 58, 19, 641, DateTimeKind.Utc).AddTicks(1812), "Auto generated resource number 2", true, "Resource 2" },
                    { 3, new DateTime(2025, 12, 14, 19, 58, 19, 641, DateTimeKind.Utc).AddTicks(1815), "Auto generated resource number 3", true, "Resource 3" },
                    { 4, new DateTime(2025, 12, 14, 19, 58, 19, 641, DateTimeKind.Utc).AddTicks(1818), "Auto generated resource number 4", true, "Resource 4" },
                    { 5, new DateTime(2025, 12, 14, 19, 58, 19, 641, DateTimeKind.Utc).AddTicks(1821), "Auto generated resource number 5", true, "Resource 5" },
                    { 6, new DateTime(2025, 12, 14, 19, 58, 19, 641, DateTimeKind.Utc).AddTicks(1827), "Auto generated resource number 6", false, "Resource 6" },
                    { 7, new DateTime(2025, 12, 14, 19, 58, 19, 641, DateTimeKind.Utc).AddTicks(1829), "Auto generated resource number 7", true, "Resource 7" },
                    { 8, new DateTime(2025, 12, 14, 19, 58, 19, 641, DateTimeKind.Utc).AddTicks(1831), "Auto generated resource number 8", false, "Resource 8" },
                    { 9, new DateTime(2025, 12, 14, 19, 58, 19, 641, DateTimeKind.Utc).AddTicks(1833), "Auto generated resource number 9", false, "Resource 9" },
                    { 10, new DateTime(2025, 12, 14, 19, 58, 19, 641, DateTimeKind.Utc).AddTicks(1841), "Auto generated resource number 10", true, "Resource 10" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "PasswordHash", "Role" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 12, 14, 19, 58, 19, 638, DateTimeKind.Utc).AddTicks(1391), "user1@booking.com", "hashed_password_1", "user" },
                    { 2, new DateTime(2025, 12, 14, 19, 58, 19, 638, DateTimeKind.Utc).AddTicks(2060), "user2@booking.com", "hashed_password_2", "admin" },
                    { 3, new DateTime(2025, 12, 14, 19, 58, 19, 638, DateTimeKind.Utc).AddTicks(2064), "user3@booking.com", "hashed_password_3", "admin" },
                    { 4, new DateTime(2025, 12, 14, 19, 58, 19, 638, DateTimeKind.Utc).AddTicks(2068), "user4@booking.com", "hashed_password_4", "user" },
                    { 5, new DateTime(2025, 12, 14, 19, 58, 19, 638, DateTimeKind.Utc).AddTicks(2070), "user5@booking.com", "hashed_password_5", "admin" },
                    { 6, new DateTime(2025, 12, 14, 19, 58, 19, 638, DateTimeKind.Utc).AddTicks(2083), "user6@booking.com", "hashed_password_6", "user" },
                    { 7, new DateTime(2025, 12, 14, 19, 58, 19, 638, DateTimeKind.Utc).AddTicks(2086), "user7@booking.com", "hashed_password_7", "user" },
                    { 8, new DateTime(2025, 12, 14, 19, 58, 19, 638, DateTimeKind.Utc).AddTicks(2088), "user8@booking.com", "hashed_password_8", "user" },
                    { 9, new DateTime(2025, 12, 14, 19, 58, 19, 638, DateTimeKind.Utc).AddTicks(2091), "user9@booking.com", "hashed_password_9", "admin" },
                    { 10, new DateTime(2025, 12, 14, 19, 58, 19, 638, DateTimeKind.Utc).AddTicks(2099), "user10@booking.com", "hashed_password_10", "user" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
