using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ST10084225_FarmCentral_MVC.Data.Migrations
{
    public partial class InitialMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.CreateTable(
                name: "Farmers",
                columns: table => new
                {
                    FarmerID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FarmerName = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Farmers", x => new { x.FarmerID, x.FarmerName });
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    FarmerID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageID = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => new { x.ProductID, x.FarmerID });
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", "f1123cc1-b6d7-4b44-9c9f-d56674627b28", "Manager", "MANAGER" },
                    { "2", "afbc1158-c96b-4c59-bb99-86385258894d", "Employee", "EMPLOYEE" },
                    { "3", "2d43d263-5492-4a77-b566-2dbbf79d2427", "Farmer", "FARMER" },
                    { "4", "1f7f2e3b-69e6-4bbc-ae69-7ffdf8bbd51d", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "e2156593-7d25-4f99-8860-9757c12ab1bc", null, false, false, null, null, "MANAGER1", "AQAAAAEAACcQAAAAEAzXE1cZRJq9odZ5pS+LAeLlxvFfqs2WUQER8grbRrwv6Ak03ePUEKfXTcmJEz1tUw==", null, false, "b6168514-7b4c-4c3e-ba1f-3f91927de877", false, "Manager1" },
                    { "2", 0, "793f3ae1-e11f-40ea-ba15-1a220825336b", null, false, false, null, null, "EMPLOYEE1", "AQAAAAEAACcQAAAAEHtfMmiP61v1MAMd7KGdKSqghEyynwdy+0bMxKTrJSKITpN984Pm6CmM4hHDxjNtoQ==", null, false, "eb09c0ca-2d5b-4b3d-8b54-1ac4012d03dd", false, "Employee1" },
                    { "3", 0, "112259f8-acb5-40fb-a9e0-1463435c5766", null, false, false, null, null, "FARMER1", "AQAAAAEAACcQAAAAEMh6TYN/hYBzFG+l/56Iv2qXaaWaD4JM8UHoHtCiCkDNodmH+0UIfLI3SOheHWjCSA==", null, false, "6ba05bb2-a954-4cba-b006-c46f6509bcf6", false, "Farmer1" },
                    { "4", 0, "d962b19c-6c90-48ad-a4b2-924eed473163", null, false, false, null, null, "CUSTOMER1", "AQAAAAEAACcQAAAAEIdzIOYsLqeDzqKaRElGPW6yA3o8O4IpZz2lHnDKfUU+7ewLVghs6zez97SueDYVzg==", null, false, "00ddf314-6334-4814-96f5-b3460a2e7363", false, "Customer1" }
                });

            migrationBuilder.InsertData(
                table: "Farmers",
                columns: new[] { "FarmerID", "FarmerName" },
                values: new object[,]
                {
                    { "1", "Mike Wozoski" },
                    { "2", "Dave Davidson" },
                    { "3", "Jakko Marakko" },
                    { "4", "Carol Canoli" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "FarmerID", "ProductID", "Category", "Date", "Description", "ImageID", "Name", "Price" },
                values: new object[,]
                {
                    { "2", 1, "Fruits", new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fresh black current grapes", "Oranges.jpg", "Oranges", 24.99m },
                    { "3", 2, "Vegetables", new DateTime(2023, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fresh Doughlas potatoes", "Lettuce.jpg", "lettuce", 72.99m },
                    { "1", 3, "Fruits", new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fresh Strawberries", "Strawberries.jpg", "Strawberries", 32.99m },
                    { "4", 4, "Vegetables", new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fresh Sweet Onions", "Leeks.jpg", "leeks", 49.99m }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "1" },
                    { "2", "2" },
                    { "3", "3" },
                    { "4", "4" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Farmers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4", "4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
