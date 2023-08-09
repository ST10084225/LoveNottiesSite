using Microsoft.EntityFrameworkCore.Migrations;

namespace LoveNottiesV2.Data.Migrations
{
    public partial class _212 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlogItems",
                columns: table => new
                {
                    BlogID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BlogImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogViews = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogItems", x => x.BlogID);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "2d1d6888-2f82-462a-a36b-7b49c6b7c3f0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "49f6532c-5932-4d40-a909-95ea0fcb3511");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "8361d860-c71e-427a-85b3-b3bd0e91c351");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "dd9982e7-688e-4cce-a313-f59c6643b52f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2dd63c3-8fec-4faa-8e4a-9fee76ca090a", "AQAAAAEAACcQAAAAEFRs0YoBxIaj9z5FK7MRiqSPweuMUEZTXDlmQB0v64eDlBsHyVRg3WpAUixB8N7h4A==", "89630b6f-3afa-4079-b759-97d44fd43ca5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0cd907e-1dca-47c1-9b83-351d29c9ae65", "AQAAAAEAACcQAAAAEO2uYgt9mRWPUKdEUlauVUP1TWmHnbs2NjsqyaI0BU0Lwcd0EwCpmHlP/Xzsa9qkBw==", "3c92934e-8672-456c-a06c-6b855d79490f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b59b172-5a72-4d80-bc77-55e14f5d07ce", "AQAAAAEAACcQAAAAEGpJMiRxMZji+inTukFDZI12TV2/zjzb7bFr5DTQkx3iFHgOfQxABLudre3vT07FKQ==", "770651b7-9397-4148-9c12-5f439abf7689" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c33a928a-ccc5-4c6e-aba0-6b42cbb3a40b", "AQAAAAEAACcQAAAAEDhO4nhvjYtYY8z6yM24u/AC/SnTs20CZqnBS4xBUPzRiyh6oEHX8IXdrN8t1OqwHg==", "613e2605-958a-4885-999d-87bbe04ecbdf" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogItems");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "236b0628-ee15-4448-b5d3-6aa063fe3917");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "a5198866-1652-4c81-8b8a-b98265558a8f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "8ad6a48c-b4a6-495b-9dc5-0ea4ba503310");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "89bf3883-1273-45d9-af96-b375957de585");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24f6b8b3-aa6a-4875-9df6-28a87e4999e6", "AQAAAAEAACcQAAAAEDEuvcbEJJiXsTrMwAa+gfQQb7xeYeGda3xxGO2xsz6TVxzYM8Q7HHOGDZAMpJLikQ==", "d96d347a-0d3e-40b9-a373-d2062f4e90c8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70f9a04a-529b-4daf-b654-f146d269382a", "AQAAAAEAACcQAAAAEHzJumbvTZq/7Dq9ANjjwdA6MKVdAFQt9NyYokpPUgiYKUVvVHY1HN9vHIcIc3rcTQ==", "74fe4427-1b6b-430d-81f2-d96f6127efbe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "074f79e8-ceec-4a67-8b8e-84533cadcc94", "AQAAAAEAACcQAAAAEFyvMQcyDvhIOaTbIMbP1m59+3+SFIm5dL8pD+cqv7kz44JlbSjDDjHPhq2yu8dSTg==", "a6897257-a94d-4838-a205-d56a84497a29" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "570eb545-e554-4943-9c3f-b2a35de9a8d5", "AQAAAAEAACcQAAAAEFUi1V6FmzraMQD2Dp0Qz7W7pkWiMbShN/QoqEcaXUifVBL8K7HNkq9sFz/3wGLqcg==", "7d3e4076-129c-406e-9445-9838f457aaca" });
        }
    }
}
