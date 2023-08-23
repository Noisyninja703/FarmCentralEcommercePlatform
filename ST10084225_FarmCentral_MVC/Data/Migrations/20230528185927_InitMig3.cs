using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ST10084225_FarmCentral_MVC.Data.Migrations
{
    public partial class InitMig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumns: new[] { "FarmerID", "ProductID" },
                keyValues: new object[] { "2", 1 });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumns: new[] { "FarmerID", "ProductID" },
                keyValues: new object[] { "3", 2 });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumns: new[] { "FarmerID", "ProductID" },
                keyValues: new object[] { "1", 3 });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "1af19f3d-3090-425c-b83c-ba3a05861063");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "28935aa2-5fba-44ba-ada2-835bc3230864");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "0f7a972a-500c-4e41-92ca-9bf882d7d932");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "bef8d7db-e0cc-4679-b715-e8201f31a42b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5cfb616-6f5a-494b-b7f9-83b8d0673bbb", "AQAAAAEAACcQAAAAEMeP+vwdz1jQckofUoZ75bR75juaFxULlBNrNRQdYNkWou4pRIHrRBXyxsrNgGtJiw==", "596fbbcd-39f9-46b2-881c-80225bacb9d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f14c61e6-6c84-4852-82b9-7c5525860022", "AQAAAAEAACcQAAAAEMwjJsKIEuAlNwJeIeCbw+y+o6dc8r4TmBe3HhTFqslEGPrJxzDbJprCobiE7TlUwQ==", "f201511c-18cb-418c-a6bd-9b2714c6a215" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7076442-04ab-4a4b-8c9d-1150db97c4c0", "AQAAAAEAACcQAAAAEDwKWc3/+f2i8dFyWPc2MZAHAYtX7cht1Z41tsmpZoYxxIXNZqhnqeUg4MhX2vv+ZA==", "c1f75c6c-cd50-4fc5-91d4-78734173a10b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f4c01717-47e5-4437-9747-9a3f965326e4", "AQAAAAEAACcQAAAAEBPcO66V25Wa33yCE4LccCZu6K55mT8RDIVnEGpcu77cMAbUpRKf9laQxurbIDQmbw==", "f0968551-3762-4f6e-8037-5d87b2dcacec" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumns: new[] { "FarmerID", "ProductID" },
                keyValues: new object[] { "4", 4 },
                columns: new[] { "Description", "Price" },
                values: new object[] { "Fresh Leeks", 29.99m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "FarmerID", "ProductID", "Category", "Date", "Description", "ImageID", "Name", "Price" },
                values: new object[,]
                {
                    { "1", 1, "Fruits", new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fresh Oranges", "Oranges.jpg", "Oranges", 24.99m },
                    { "2", 2, "Vegetables", new DateTime(2023, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fresh Butter Lettuce", "Lettuce.jpg", "lettuce", 34.99m },
                    { "3", 3, "Fruits", new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fresh Strawberries", "Strawberries.jpg", "Strawberries", 32.99m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumns: new[] { "FarmerID", "ProductID" },
                keyValues: new object[] { "1", 1 });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumns: new[] { "FarmerID", "ProductID" },
                keyValues: new object[] { "2", 2 });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumns: new[] { "FarmerID", "ProductID" },
                keyValues: new object[] { "3", 3 });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "f8f96c94-e543-49c4-956c-cdc8fa45bb7a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "77284827-8c11-43f2-a32a-a0056569248d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "c97c3ae9-a2ab-4f0c-8f2b-cebe97aa9b21");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "dcdcf301-acd3-4ad6-ba66-55ccf03da96d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32161e6f-38b6-4bd0-8560-57d041e34a02", "AQAAAAEAACcQAAAAELAPsrCxPzsT91EQRrOzV1dehIT0P0kzrnT+T0z4kZDSbdFLUA0qbXFZmT4bTwlgtg==", "d5a96732-bbbd-4d08-aaec-42d03d2d40e6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e35f8e80-f4fd-4c08-9a08-abbcf4dc5eff", "AQAAAAEAACcQAAAAEIPYYh9qIFdamtFVHWVMH/TNr8tx65DH1wqRf93FVjik7kEdMF8iYm0BptY8TE/l8Q==", "f708423e-a395-4538-bcd5-192f599cd7b2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7aace170-d128-4251-a9ee-a468e5f55357", "AQAAAAEAACcQAAAAEDs7qJHfqxPm4/+OXeHDgbK/Y5TRnW4DGqQmCyK58RifokN+XBRne7tw8X6is4BLFQ==", "ec3c8c0f-0667-42d8-90d0-1558ddcc8f84" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a7d2d3b-1f66-4a81-9e5c-8f1a7f8308b9", "AQAAAAEAACcQAAAAEIAbOIWWKsUcspKI5OM45XlGGFovprNf9PSLG/tNzr+xbc3YrxTJCrt4syXC64au+A==", "15811b4a-004c-4578-beb2-d96e22888821" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumns: new[] { "FarmerID", "ProductID" },
                keyValues: new object[] { "4", 4 },
                columns: new[] { "Description", "Price" },
                values: new object[] { "Fresh Sweet Onions", 49.99m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "FarmerID", "ProductID", "Category", "Date", "Description", "ImageID", "Name", "Price" },
                values: new object[,]
                {
                    { "2", 1, "Fruits", new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fresh black current grapes", "Oranges.jpg", "Oranges", 24.99m },
                    { "3", 2, "Vegetables", new DateTime(2023, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fresh Doughlas potatoes", "Lettuce.jpg", "lettuce", 72.99m },
                    { "1", 3, "Fruits", new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fresh Strawberries", "Strawberries.jpg", "Strawberries", 32.99m }
                });
        }
    }
}
