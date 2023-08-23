using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ST10084225_FarmCentral_MVC.Data.Migrations
{
    public partial class FinalMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Farmers",
                keyColumns: new[] { "FarmerID", "FarmerName" },
                keyValues: new object[] { "4", "Carol Canoli" });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumns: new[] { "FarmerID", "ProductID" },
                keyValues: new object[] { "2", 2 });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumns: new[] { "FarmerID", "ProductID" },
                keyValues: new object[] { "3", 3 });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumns: new[] { "FarmerID", "ProductID" },
                keyValues: new object[] { "4", 4 });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "0b587743-befd-4032-be19-f03a2742eab3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "26a28124-9387-4263-90a3-0c03fde3fca8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "1e2b3ddf-f9a2-4d52-8dc8-c01f020eb923");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "fab5f1c1-b964-4d31-bf49-92419228deae");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe9e14dc-2e87-4fb9-96d8-fa68d1697da5", "AQAAAAEAACcQAAAAEJbizqxf0/o1KiaTGzusgSaKimxxMA5+bdqYVBiYpDfyPu8FhrvzwKSczcJd9OVFDw==", "ea05a55f-42dd-41f0-9c39-708c58010991" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ee3f80e-c035-4bd4-8b11-38970b8f8e90", "AQAAAAEAACcQAAAAEO7/b+VrJ8qfoX/qw4E5+z8lysCIlZepYdo1LQyoUxvLh3P19n4ItEjeeEAuGQ4+9Q==", "8da034c0-8832-47e5-83d2-8c13bf7bd89d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f83134ea-1495-49de-8ffe-94046acd86f6", "AQAAAAEAACcQAAAAECp3idXVBKCs21QoLwwAIVOkkrzChDB91mJwKtOP7sq1BkZ/uv5ZkLEbHVKPxFk80w==", "de632cab-9d88-42a3-87dd-878fb95d3953" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c12747bf-f4f0-48c8-b956-e91dbe713862", "AQAAAAEAACcQAAAAED4kB8KAsbVXVrxw+wIycrs0STmLIkAkQIV+Hu953mGo/rcBCWL4onQjeJZqr4TlOA==", "b6ad4a2a-bccf-4be7-be9b-a23526141c9b" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumns: new[] { "FarmerID", "ProductID" },
                keyValues: new object[] { "1", 1 },
                columns: new[] { "Category", "Date" },
                values: new object[] { "Fruit", new DateTime(2023, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "FarmerID", "ProductID", "Category", "Date", "Description", "ImageID", "Name", "Price" },
                values: new object[,]
                {
                    { "3", 12, "Vegetable", new DateTime(2023, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fresh Leeks", "Broccoli.jpg", "Broccoli", 29.99m },
                    { "3", 11, "Fruit", new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fresh Strawberries", "Grapes.jpg", "Grapes", 32.99m },
                    { "3", 9, "Fruit", new DateTime(2023, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fresh Oranges", "pepper.jpg", "Peppers", 24.99m },
                    { "2", 8, "Vegetable", new DateTime(2023, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fresh Leeks", "Chilli.jpg", "Chillis", 31.99m },
                    { "2", 7, "Fruit", new DateTime(2023, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Freshly stolen from farmer Shivani", "Avocado.jpg", "Avocado", 27.99m },
                    { "2", 6, "Vegetable", new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fresh Butter Lettuce", "Aparagus.jpg", "Asparagus", 32.99m },
                    { "2", 5, "Fruit", new DateTime(2023, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fresh Oranges", "Apple.jpg", "Apples", 18.99m },
                    { "1", 4, "Vegetable", new DateTime(2023, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fresh Leeks", "Leeks.jpg", "leeks", 29.99m },
                    { "1", 3, "Fruit", new DateTime(2023, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fresh Strawberries", "Strawberries.jpg", "Strawberries", 32.99m },
                    { "3", 10, "Vegetable", new DateTime(2023, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fresh Butter Lettuce", "Tomato.jpg", "Tomato", 34.99m },
                    { "1", 2, "Vegetable", new DateTime(2023, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fresh Butter Lettuce", "Lettuce.jpg", "lettuce", 34.99m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumns: new[] { "FarmerID", "ProductID" },
                keyValues: new object[] { "1", 2 });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumns: new[] { "FarmerID", "ProductID" },
                keyValues: new object[] { "1", 3 });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumns: new[] { "FarmerID", "ProductID" },
                keyValues: new object[] { "1", 4 });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumns: new[] { "FarmerID", "ProductID" },
                keyValues: new object[] { "2", 5 });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumns: new[] { "FarmerID", "ProductID" },
                keyValues: new object[] { "2", 6 });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumns: new[] { "FarmerID", "ProductID" },
                keyValues: new object[] { "2", 7 });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumns: new[] { "FarmerID", "ProductID" },
                keyValues: new object[] { "2", 8 });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumns: new[] { "FarmerID", "ProductID" },
                keyValues: new object[] { "3", 9 });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumns: new[] { "FarmerID", "ProductID" },
                keyValues: new object[] { "3", 10 });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumns: new[] { "FarmerID", "ProductID" },
                keyValues: new object[] { "3", 11 });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumns: new[] { "FarmerID", "ProductID" },
                keyValues: new object[] { "3", 12 });

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

            migrationBuilder.InsertData(
                table: "Farmers",
                columns: new[] { "FarmerID", "FarmerName" },
                values: new object[] { "4", "Carol Canoli" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumns: new[] { "FarmerID", "ProductID" },
                keyValues: new object[] { "1", 1 },
                columns: new[] { "Category", "Date" },
                values: new object[] { "Fruits", new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "FarmerID", "ProductID", "Category", "Date", "Description", "ImageID", "Name", "Price" },
                values: new object[,]
                {
                    { "2", 2, "Vegetables", new DateTime(2023, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fresh Butter Lettuce", "Lettuce.jpg", "lettuce", 34.99m },
                    { "3", 3, "Fruits", new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fresh Strawberries", "Strawberries.jpg", "Strawberries", 32.99m },
                    { "4", 4, "Vegetables", new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fresh Leeks", "Leeks.jpg", "leeks", 29.99m }
                });
        }
    }
}
