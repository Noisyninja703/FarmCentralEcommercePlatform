using Microsoft.EntityFrameworkCore.Migrations;

namespace ST10084225_FarmCentral_MVC.Data.Migrations
{
    public partial class InitialMig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "f1123cc1-b6d7-4b44-9c9f-d56674627b28");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "afbc1158-c96b-4c59-bb99-86385258894d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "2d43d263-5492-4a77-b566-2dbbf79d2427");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "1f7f2e3b-69e6-4bbc-ae69-7ffdf8bbd51d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2156593-7d25-4f99-8860-9757c12ab1bc", "AQAAAAEAACcQAAAAEAzXE1cZRJq9odZ5pS+LAeLlxvFfqs2WUQER8grbRrwv6Ak03ePUEKfXTcmJEz1tUw==", "b6168514-7b4c-4c3e-ba1f-3f91927de877" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "793f3ae1-e11f-40ea-ba15-1a220825336b", "AQAAAAEAACcQAAAAEHtfMmiP61v1MAMd7KGdKSqghEyynwdy+0bMxKTrJSKITpN984Pm6CmM4hHDxjNtoQ==", "eb09c0ca-2d5b-4b3d-8b54-1ac4012d03dd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "112259f8-acb5-40fb-a9e0-1463435c5766", "AQAAAAEAACcQAAAAEMh6TYN/hYBzFG+l/56Iv2qXaaWaD4JM8UHoHtCiCkDNodmH+0UIfLI3SOheHWjCSA==", "6ba05bb2-a954-4cba-b006-c46f6509bcf6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d962b19c-6c90-48ad-a4b2-924eed473163", "AQAAAAEAACcQAAAAEIdzIOYsLqeDzqKaRElGPW6yA3o8O4IpZz2lHnDKfUU+7ewLVghs6zez97SueDYVzg==", "00ddf314-6334-4814-96f5-b3460a2e7363" });
        }
    }
}
