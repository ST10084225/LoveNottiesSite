using Microsoft.EntityFrameworkCore.Migrations;

namespace LoveNottiesV2.Data.Migrations
{
    public partial class OurPeople : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OurPeoples",
                columns: table => new
                {
                    OurPersonID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OurPersonFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OurPersonLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OurPersonTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OurPersonImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OurPersonDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OurPeoples", x => x.OurPersonID);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "687a23a7-2782-4204-a7cd-a322aa5f7f87");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "61f88ccc-dbb8-49f8-92e2-53c88db35a91");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "bd3cf557-cea6-48bc-b5e5-380e78e81636");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "7d94aadc-b205-4c19-90d2-88ef7bfc8900");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2626f1d8-7a30-491f-a191-501d214026db", "AQAAAAEAACcQAAAAEOsSFNi7ZMu6sLDgLVkcmTA1f/50R7Mct5p8288K6e+vNOOvz5lNuRfscfbOYHAudA==", "8c2aeee5-a41a-40fd-bc80-82218b4d586c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "26f6ae1d-b95a-4693-adbe-c5510b490328", "AQAAAAEAACcQAAAAEBVQ9rcwrbD2VO3ylZlL1oviD5zu3Prb635Z2FjQBn+fst16+1HDhpdYHHLLZBG4nQ==", "83e1789a-530a-4630-b1fc-71cf6c41e1ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ca22d72-024e-40ab-91a4-8bd97056958b", "AQAAAAEAACcQAAAAEKc8CuIwYRb4t31lEj0jYglSq0BY6moNy5cc1IckUMMdcNIkgvTW2TQ/gS8lpUaExQ==", "91d003ff-499d-40a1-9510-1d06aa7bf37a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "443f46cf-0480-42be-8020-3387a06706df", "AQAAAAEAACcQAAAAEG0A7EIzSYZ+gAGkxyos3XLa2ajKk/iEtobxYtdkCoGQEnXmLL1ax4z5Jq8bfZkMXg==", "e24f2899-3b7f-44fa-9315-3c9f99bd151d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OurPeoples");

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
    }
}
