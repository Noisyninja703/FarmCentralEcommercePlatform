using Microsoft.EntityFrameworkCore.Migrations;

namespace ST10084225_FarmCentral_MVC.Data.Migrations
{
    public partial class FinalMig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "b619741d-88d1-44c9-9994-3b95037e2422");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "72201b32-c13f-47dc-bbdc-3ce2af92a28f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "efc51c77-6cfd-45b9-bf23-b226d7a0a847");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "e58d8337-e6e5-44fa-9022-1f793ef556ce");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89d5b962-4a3c-4763-9ef3-b1adcdc27dfe", "AQAAAAEAACcQAAAAEDJfOpMseV+o74LKpZ+u5GV2uW2e0xKrh7dcF/sYheWUp0/mGwaXuQsbsg25ZH6+JA==", "33773478-6a9f-4292-bcae-83cb1a07b823" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc4f1cae-c74b-4bb5-8325-1a397d0796c8", "AQAAAAEAACcQAAAAEHAlruhQZb1Q8iWrHj89fAqK+WIPAbvA1oYmi6Y6dSWHU6Tk7vQw4Owa16G1r/cdmg==", "89d8934d-d91a-496f-b1d6-f6e5e5011e10" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8dc5acc5-25f7-43ea-8e57-a36586c0d09b", "AQAAAAEAACcQAAAAEE+ZfA3aiggMsZr+FcGLTyEefmqNvWI6ASYtV9m3PZSUPJnX/KObIFD/ZZDb8g8I7Q==", "9e6e14ec-6f71-4be5-9271-beebe97ed999" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d0373a8-f1a9-45a1-b96f-32cbcd5a189e", "AQAAAAEAACcQAAAAEKTQ8M0W3W8OU7l0D8FPoJvetnt/+ks31OQa29J4D94qINH+1Utoa7wynu9rnePBdQ==", "138a687e-ba5f-461b-872b-e69d96939f81" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumns: new[] { "FarmerID", "ProductID" },
                keyValues: new object[] { "3", 9 },
                column: "Category",
                value: "Vegetable");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                keyValues: new object[] { "3", 9 },
                column: "Category",
                value: "Fruit");
        }
    }
}
