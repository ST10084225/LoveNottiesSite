using Microsoft.EntityFrameworkCore.Migrations;

namespace LoveNottiesV2.Data.Migrations
{
    public partial class SuccessStory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "successStories",
                columns: table => new
                {
                    SuccessStoryID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SuccessStoryTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuccessStoryImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuccessStoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_successStories", x => x.SuccessStoryID);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "c45a921a-0bf0-4a53-a17e-5fc1c78f2e00");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "da854685-aa38-4518-8cf0-b5087976ca52");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "54b2f243-1b42-432e-9e47-33b6e7eb66d2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "d6f40c82-6a91-4712-99e9-bf8c3a0e3528");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab6f4e32-b815-4af3-bacd-2224c21885e1", "AQAAAAEAACcQAAAAEI+EsfYpgEkra/GIB3AzGhZJaIfHkgXS2lHXMTivz4ncYxUxNgvwBlKW7yOgjaUtBg==", "f2d77ca2-bf2e-4120-b6ce-4029ab7c4044" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da6e99a5-413f-4b3a-9a68-6e14c3b0769f", "AQAAAAEAACcQAAAAEL090ry09UETCOwMCn9uNHpc9EaiJjeD5gQNMG2N1kWQ5WvtPJFCnIc8OgTrvuzdkg==", "bbd3a4b8-de29-46bd-b3ff-ea0e6ab69fc4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "615db859-255d-4d3e-9e70-1901a2397d97", "AQAAAAEAACcQAAAAELmGHearTqlqy9AiMVZFPmdoR0Hpez1ejld7HgyLFSExP1/Jn3Z0gPJKpc06NtX1BQ==", "2352c80c-e668-4af2-a5bd-00cd0bd10070" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b5d1ffc-f16f-42db-ae6c-601efb64601f", "AQAAAAEAACcQAAAAEKBOtHd/F/TEeDDwfvv/wvmbhdjY3jCNFBDJsN1qpaT0MpxrKK57j2h7T7QpUOJJcw==", "e6d51e10-153d-42a4-8dfb-a5e7cb84b54d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "successStories");

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
    }
}
