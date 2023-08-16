using Microsoft.EntityFrameworkCore.Migrations;

namespace LoveNottiesV2.Data.Migrations
{
    public partial class BlogUpdate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BlogTag",
                table: "BlogItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BlogTitle",
                table: "BlogItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "23b1bd81-f047-41f0-b14b-005362df6966");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "cd86dc3f-445e-45c2-b85a-d3a70e3231f5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "c810c929-3420-43e1-8dc3-100c120705c2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "dfc8cf2f-cfde-424b-98c4-a103c444d36d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "afe9c0b3-3e15-459e-af20-a241997e98f9", "AQAAAAEAACcQAAAAEGJ++dqMmdvdbUsN7+ITl70aeDM+4uZ1VZCi/CN+xJ2BoqYPFI1tDHWZAcdTIKdDkQ==", "a67d9c3b-6067-4ec8-9945-18a66eb064f9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02dcf563-a5d0-40e2-bd8d-b49df326dabf", "AQAAAAEAACcQAAAAENNi3Gpli5kmI/LOSYy3KzhfBGaDRRrddjDzmZDE4rH2kDAF1N/bafOR3uG6MYwr8w==", "23ebf92d-c321-4956-b41e-e763b41afc71" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f39f630-7fc8-43ba-8140-ad6149872ded", "AQAAAAEAACcQAAAAEHqxWtmXEeBh/XQzhvLAjJSKh4PovFPAC/2ZkZlBmk0fqh00y2gKWQZxKQKKYrTarw==", "cd0453b8-ec5b-4719-ba2d-f3d8d6425ca2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d9126f0-4c81-442f-bb10-6557bc4a29b9", "AQAAAAEAACcQAAAAEIW9uYdP2ICRahvU5HSh842G6/KStDZDEtF1Lihgc9Q1SSTpThuAovsZiZk19vrhyg==", "cd0277f6-473e-4c39-96e0-f9aa1c6ac3e0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BlogTag",
                table: "BlogItems");

            migrationBuilder.DropColumn(
                name: "BlogTitle",
                table: "BlogItems");

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
    }
}
