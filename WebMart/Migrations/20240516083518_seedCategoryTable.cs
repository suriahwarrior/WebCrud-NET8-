using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebMart.Migrations
{
    /// <inheritdoc />
    public partial class seedCategoryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { new Guid("6c62e1b2-d9f7-4232-b43b-75b9d2c052d8"), 1, "Action" },
                    { new Guid("8dad3ae0-4865-492d-aa08-51bca0b2e61a"), 2, "SciFi" },
                    { new Guid("e78da947-c3de-4330-ada5-6ae52b2592bb"), 3, "Horror" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6c62e1b2-d9f7-4232-b43b-75b9d2c052d8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8dad3ae0-4865-492d-aa08-51bca0b2e61a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e78da947-c3de-4330-ada5-6ae52b2592bb"));
        }
    }
}
