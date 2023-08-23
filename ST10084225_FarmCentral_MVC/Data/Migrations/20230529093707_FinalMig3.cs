using Microsoft.EntityFrameworkCore.Migrations;

namespace ST10084225_FarmCentral_MVC.Data.Migrations
{
    public partial class FinalMig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "41ddfb7b-f8e2-4300-9318-865fc6baa101");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "5aedbb7d-b1a6-43f1-bf81-7b037c445f55");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "32699f3b-774e-4aa6-ba22-e64504a191f1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "ee0b6300-4d78-4714-9e2b-31baad0e2fbe");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56015bea-b598-4f0c-b262-7f57441fc202", "AQAAAAEAACcQAAAAEKZUdxXeUKs0poK64zw1+zPLxFxJK7VGfyJPanBrF5o3WtlhB2ybhAOGTqD1aC97qg==", "a1ded6b0-572e-4075-a14b-264a11ed844b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "19c8293f-9750-472e-903a-34da5050d6ba", "AQAAAAEAACcQAAAAEBV91JS1aKWiw6MSXT2JdnItZnfhEBSjaiEVnYOxG5ZPjDa3rw/JzqLB4XW8VxK0LA==", "4fef40a3-42a2-485b-96a3-619d43d034e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad9fd414-936b-48c2-acdd-ead003730554", "AQAAAAEAACcQAAAAEKxCFM/FnBcnw6h7BsEfCbbFCuYAwlOsbKCOb7VyE8VYS+ba+gsqR2kOKKl2KWg19A==", "793f76c5-4bf4-4167-88b5-cd3d311a8ffe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "daf81d0c-9e4e-4e39-a288-dcfbd65ce633", "AQAAAAEAACcQAAAAEIsM3+RLxz7sSAlUO3C48zmhqNQ1CIMt7Wcp6XZhajlZwrqJT32XbkgzN09VpvvY5A==", "5cc982b4-9613-4f21-8785-e550d5364c14" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumns: new[] { "FarmerID", "ProductID" },
                keyValues: new object[] { "2", 5 },
                column: "Description",
                value: "Fresh Apples");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumns: new[] { "FarmerID", "ProductID" },
                keyValues: new object[] { "2", 6 },
                column: "Description",
                value: "Fresh Asparagus");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumns: new[] { "FarmerID", "ProductID" },
                keyValues: new object[] { "2", 8 },
                column: "Description",
                value: "Fresh Chillis");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumns: new[] { "FarmerID", "ProductID" },
                keyValues: new object[] { "3", 9 },
                column: "Description",
                value: "Fresh Peppers");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumns: new[] { "FarmerID", "ProductID" },
                keyValues: new object[] { "3", 10 },
                column: "Description",
                value: "Fresh Tomato");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumns: new[] { "FarmerID", "ProductID" },
                keyValues: new object[] { "3", 11 },
                column: "Description",
                value: "Fresh Grapes");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumns: new[] { "FarmerID", "ProductID" },
                keyValues: new object[] { "3", 12 },
                column: "Description",
                value: "Fresh Broccoli");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValues: new object[] { "2", 5 },
                column: "Description",
                value: "Fresh Oranges");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumns: new[] { "FarmerID", "ProductID" },
                keyValues: new object[] { "2", 6 },
                column: "Description",
                value: "Fresh Butter Lettuce");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumns: new[] { "FarmerID", "ProductID" },
                keyValues: new object[] { "2", 8 },
                column: "Description",
                value: "Fresh Leeks");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumns: new[] { "FarmerID", "ProductID" },
                keyValues: new object[] { "3", 9 },
                column: "Description",
                value: "Fresh Oranges");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumns: new[] { "FarmerID", "ProductID" },
                keyValues: new object[] { "3", 10 },
                column: "Description",
                value: "Fresh Butter Lettuce");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumns: new[] { "FarmerID", "ProductID" },
                keyValues: new object[] { "3", 11 },
                column: "Description",
                value: "Fresh Strawberries");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumns: new[] { "FarmerID", "ProductID" },
                keyValues: new object[] { "3", 12 },
                column: "Description",
                value: "Fresh Leeks");
        }
    }
}
