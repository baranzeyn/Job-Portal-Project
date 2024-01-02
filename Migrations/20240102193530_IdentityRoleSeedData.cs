using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobPortalProject.Migrations
{
    /// <inheritdoc />
    public partial class IdentityRoleSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "34302ee4-791c-4f05-ba11-42318bfb8ee2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a09f25e-0d6f-4006-9d04-657d7e4f83ca");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "724032bb-4650-4ee7-8f68-c26803e8ebda");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1e5a54d2-05ae-449f-91b1-d1378af3a6b4", null, "User", "USER" },
                    { "ad0e574d-d634-4526-a5b1-f2b6590e3092", null, "Employer", "EMPLOYER" },
                    { "ec2412e2-7288-4f31-b035-612c60caa365", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1e5a54d2-05ae-449f-91b1-d1378af3a6b4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad0e574d-d634-4526-a5b1-f2b6590e3092");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec2412e2-7288-4f31-b035-612c60caa365");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "34302ee4-791c-4f05-ba11-42318bfb8ee2", null, "Admin", "ADMIN" },
                    { "3a09f25e-0d6f-4006-9d04-657d7e4f83ca", null, "Employer", "EMPLOYER" },
                    { "724032bb-4650-4ee7-8f68-c26803e8ebda", null, "User", "USER" }
                });
        }
    }
}
