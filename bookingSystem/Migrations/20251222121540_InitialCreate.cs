using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace bookingSystem.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ResourceId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Status = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Resources",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resources", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Role = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "CreatedAt", "EndDate", "ResourceId", "StartDate", "Status", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 12, 22, 12, 15, 40, 265, DateTimeKind.Utc).AddTicks(6209), new DateTime(2026, 1, 4, 12, 15, 40, 265, DateTimeKind.Utc).AddTicks(2903), 9, new DateTime(2025, 12, 31, 12, 15, 40, 265, DateTimeKind.Utc).AddTicks(2903), "Completed", 8 },
                    { 2, new DateTime(2025, 12, 22, 12, 15, 40, 265, DateTimeKind.Utc).AddTicks(6639), new DateTime(2025, 12, 13, 12, 15, 40, 265, DateTimeKind.Utc).AddTicks(6628), 2, new DateTime(2025, 12, 12, 12, 15, 40, 265, DateTimeKind.Utc).AddTicks(6628), "InProgress", 2 },
                    { 3, new DateTime(2025, 12, 22, 12, 15, 40, 265, DateTimeKind.Utc).AddTicks(6658), new DateTime(2026, 1, 1, 12, 15, 40, 265, DateTimeKind.Utc).AddTicks(6639), 5, new DateTime(2025, 12, 30, 12, 15, 40, 265, DateTimeKind.Utc).AddTicks(6639), "Requested", 2 },
                    { 4, new DateTime(2025, 12, 22, 12, 15, 40, 265, DateTimeKind.Utc).AddTicks(6665), new DateTime(2025, 12, 31, 12, 15, 40, 265, DateTimeKind.Utc).AddTicks(6659), 1, new DateTime(2025, 12, 28, 12, 15, 40, 265, DateTimeKind.Utc).AddTicks(6659), "Expired", 3 },
                    { 5, new DateTime(2025, 12, 22, 12, 15, 40, 265, DateTimeKind.Utc).AddTicks(6667), new DateTime(2025, 12, 16, 12, 15, 40, 265, DateTimeKind.Utc).AddTicks(6665), 1, new DateTime(2025, 12, 15, 12, 15, 40, 265, DateTimeKind.Utc).AddTicks(6665), "Completed", 8 },
                    { 6, new DateTime(2025, 12, 22, 12, 15, 40, 265, DateTimeKind.Utc).AddTicks(6673), new DateTime(2025, 12, 27, 12, 15, 40, 265, DateTimeKind.Utc).AddTicks(6672), 6, new DateTime(2025, 12, 24, 12, 15, 40, 265, DateTimeKind.Utc).AddTicks(6672), "Confirmed", 9 },
                    { 7, new DateTime(2025, 12, 22, 12, 15, 40, 265, DateTimeKind.Utc).AddTicks(6675), new DateTime(2025, 12, 27, 12, 15, 40, 265, DateTimeKind.Utc).AddTicks(6674), 1, new DateTime(2025, 12, 23, 12, 15, 40, 265, DateTimeKind.Utc).AddTicks(6674), "InProgress", 8 },
                    { 8, new DateTime(2025, 12, 22, 12, 15, 40, 265, DateTimeKind.Utc).AddTicks(6677), new DateTime(2025, 12, 17, 12, 15, 40, 265, DateTimeKind.Utc).AddTicks(6676), 5, new DateTime(2025, 12, 13, 12, 15, 40, 265, DateTimeKind.Utc).AddTicks(6676), "NoShow", 3 },
                    { 9, new DateTime(2025, 12, 22, 12, 15, 40, 265, DateTimeKind.Utc).AddTicks(6680), new DateTime(2026, 1, 3, 12, 15, 40, 265, DateTimeKind.Utc).AddTicks(6678), 2, new DateTime(2025, 12, 30, 12, 15, 40, 265, DateTimeKind.Utc).AddTicks(6678), "Completed", 5 },
                    { 10, new DateTime(2025, 12, 22, 12, 15, 40, 265, DateTimeKind.Utc).AddTicks(6683), new DateTime(2025, 12, 15, 12, 15, 40, 265, DateTimeKind.Utc).AddTicks(6681), 2, new DateTime(2025, 12, 14, 12, 15, 40, 265, DateTimeKind.Utc).AddTicks(6681), "Rescheduled", 4 }
                });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "CreatedAt", "Description", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 12, 22, 12, 15, 40, 264, DateTimeKind.Utc).AddTicks(8118), "Auto generated resource number 1", true, "Resource 1" },
                    { 2, new DateTime(2025, 12, 22, 12, 15, 40, 264, DateTimeKind.Utc).AddTicks(8550), "Auto generated resource number 2", true, "Resource 2" },
                    { 3, new DateTime(2025, 12, 22, 12, 15, 40, 264, DateTimeKind.Utc).AddTicks(8554), "Auto generated resource number 3", true, "Resource 3" },
                    { 4, new DateTime(2025, 12, 22, 12, 15, 40, 264, DateTimeKind.Utc).AddTicks(8572), "Auto generated resource number 4", true, "Resource 4" },
                    { 5, new DateTime(2025, 12, 22, 12, 15, 40, 264, DateTimeKind.Utc).AddTicks(8581), "Auto generated resource number 5", true, "Resource 5" },
                    { 6, new DateTime(2025, 12, 22, 12, 15, 40, 264, DateTimeKind.Utc).AddTicks(8599), "Auto generated resource number 6", false, "Resource 6" },
                    { 7, new DateTime(2025, 12, 22, 12, 15, 40, 264, DateTimeKind.Utc).AddTicks(8603), "Auto generated resource number 7", true, "Resource 7" },
                    { 8, new DateTime(2025, 12, 22, 12, 15, 40, 264, DateTimeKind.Utc).AddTicks(8614), "Auto generated resource number 8", false, "Resource 8" },
                    { 9, new DateTime(2025, 12, 22, 12, 15, 40, 264, DateTimeKind.Utc).AddTicks(8618), "Auto generated resource number 9", false, "Resource 9" },
                    { 10, new DateTime(2025, 12, 22, 12, 15, 40, 264, DateTimeKind.Utc).AddTicks(8650), "Auto generated resource number 10", true, "Resource 10" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "PasswordHash", "Role" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 12, 22, 12, 15, 39, 442, DateTimeKind.Utc).AddTicks(9531), "user1@booking.com", "AQAAAAIAAYagAAAAENkfb1HDWL4C8lYUyJZpHJ4mpEag+mlaa7jI6mJCsutH507MTRB/8B2FkYkkHJtkvQ==", "user" },
                    { 2, new DateTime(2025, 12, 22, 12, 15, 39, 530, DateTimeKind.Utc).AddTicks(628), "user2@booking.com", "AQAAAAIAAYagAAAAEPOb0j0yYH0SXSw86ecUH64oAXcXXfireqtFl3voHJLivqlXnWAyDVfRvRQlYyiyNw==", "admin" },
                    { 3, new DateTime(2025, 12, 22, 12, 15, 39, 617, DateTimeKind.Utc).AddTicks(1830), "user3@booking.com", "AQAAAAIAAYagAAAAEPeRwZ0EWYbPUSWvVg+QOU+CrauO6uymBmvfO7vtKOsIx/5Tz/FSQer8i9NMh10k6A==", "admin" },
                    { 4, new DateTime(2025, 12, 22, 12, 15, 39, 699, DateTimeKind.Utc).AddTicks(5867), "user4@booking.com", "AQAAAAIAAYagAAAAEEWljLj5CZg9q3YC2AqUKq0JpRJ23PfqXh+i+BQIn9ljXfiVXSQLCLX3WMLXxXQJew==", "user" },
                    { 5, new DateTime(2025, 12, 22, 12, 15, 39, 775, DateTimeKind.Utc).AddTicks(6910), "user5@booking.com", "AQAAAAIAAYagAAAAEAn2D0pBpNGX/akXwVoPHRHhhHhGloty1Gk/JAtVBr2WEnQARa+jx3yc+oHGpEKDJQ==", "admin" },
                    { 6, new DateTime(2025, 12, 22, 12, 15, 39, 857, DateTimeKind.Utc).AddTicks(2115), "user6@booking.com", "AQAAAAIAAYagAAAAEC2zm8/1ZIV+IVh/9MhnF0lYBzrL06HXRWb2GsSzEGvzQZKnfV889f0BtUwLDIRFew==", "user" },
                    { 7, new DateTime(2025, 12, 22, 12, 15, 39, 942, DateTimeKind.Utc).AddTicks(3376), "user7@booking.com", "AQAAAAIAAYagAAAAEAEwIa8aN8wTVdzq2myAf8k51T5/O69+P7hISlIiOeA+HPUW9wxZqFsenRNlvJE7Tw==", "user" },
                    { 8, new DateTime(2025, 12, 22, 12, 15, 40, 25, DateTimeKind.Utc).AddTicks(6666), "user8@booking.com", "AQAAAAIAAYagAAAAEIqzfuwkItD7EKeKleJDmRed8zkqL6fPihmqaw97Vc+lJl6DIefwPu3tT/H1DAJtIQ==", "user" },
                    { 9, new DateTime(2025, 12, 22, 12, 15, 40, 105, DateTimeKind.Utc).AddTicks(5869), "user9@booking.com", "AQAAAAIAAYagAAAAEJYp6k3+vZlLQKjSW61HSj/PL+PYV4RGQc3uxR8bTFj2gqYotlJczsQ8xHB7Ag2NRw==", "admin" },
                    { 10, new DateTime(2025, 12, 22, 12, 15, 40, 187, DateTimeKind.Utc).AddTicks(3017), "user10@booking.com", "AQAAAAIAAYagAAAAEDv/SCFgPxOWITt0lyqf8kYEWfYsZdN+xa2UWl30+Wc6XEh2aAalUeRUkf08l/jPxw==", "user" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Resources");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
