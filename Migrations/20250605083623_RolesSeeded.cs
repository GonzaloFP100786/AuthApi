using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApiIndentity.Migrations
{
    /// <inheritdoc />
    public partial class RolesSeeded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "081a5f1e-32b8-4d61-aeeb-c6af75ce6dd1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8df5ae9-e82b-4533-b780-447899af8a21");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6e03f71c-53c4-4e93-84bf-62715fc48d60", "1", "Admin", "Admin" },
                    { "e62a1c8e-3ade-482b-991c-066a04f18756", "1", "User", "User" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e03f71c-53c4-4e93-84bf-62715fc48d60");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e62a1c8e-3ade-482b-991c-066a04f18756");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "081a5f1e-32b8-4d61-aeeb-c6af75ce6dd1", "1", "Admin", "Admin" },
                    { "c8df5ae9-e82b-4533-b780-447899af8a21", "1", "User", "User" }
                });
        }
    }
}
