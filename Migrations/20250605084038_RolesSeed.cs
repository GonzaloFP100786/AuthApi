using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApiIndentity.Migrations
{
    /// <inheritdoc />
    public partial class RolesSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "18e1709a-6a0a-4f4d-aec0-8bd2cf1227bb", null, "Admin", "ADMIN" },
                    { "5dbca489-6b21-42f0-aa92-17b3e22bba24", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18e1709a-6a0a-4f4d-aec0-8bd2cf1227bb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5dbca489-6b21-42f0-aa92-17b3e22bba24");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6e03f71c-53c4-4e93-84bf-62715fc48d60", "1", "Admin", "Admin" },
                    { "e62a1c8e-3ade-482b-991c-066a04f18756", "1", "User", "User" }
                });
        }
    }
}
