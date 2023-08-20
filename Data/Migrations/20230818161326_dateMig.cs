using Microsoft.EntityFrameworkCore.Migrations;

namespace LoveNottiesV2.Data.Migrations
{
    public partial class dateMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BlogDate",
                table: "BlogItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "2585416a-0852-4b7a-bb4a-4caf35596250");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "642b5f0d-2bef-4741-a234-18c86cad9b53");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "78c5d153-4284-4386-ac8d-bd747bb09808");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "53059833-2413-4fe4-8d7c-ab8aa251175c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a23cf487-1c59-423a-a279-090a0f15fbb0", "AQAAAAEAACcQAAAAEOh44EBrAREOYbbFX9fqwq7F0/UPmyZIL+9X1Q5RriSIaEGEPhdvjNuTUEV2CMvTbw==", "193012bb-c053-4d30-82c8-114d90964ecf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57ae8b82-8f53-4046-b6c7-2a1a01c1e514", "AQAAAAEAACcQAAAAEKsiPMhVCKoQFrVk3pEI9cXwXh4k0bq7Vf6bSCqzxkspkSVKaSg+C4eXv3gmgkZJbw==", "0e8b76bf-81ad-4673-84b2-79b49cfb1b47" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "944e0a06-67e5-4ed2-90d0-69c4dfc4ea05", "AQAAAAEAACcQAAAAEFbHNtZo+zTi5XVXZ7QSaVrIpngOGXRDdkhBDBy8SBQTbAfxu315WvazsOWTnal7cA==", "1bba441a-d3ac-4587-b679-e13ea8627a50" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13ddd83c-7102-40b9-9ef7-c7dac5b98ae4", "AQAAAAEAACcQAAAAEFK1jo4b1ey4AW4i4arVRtYhfraCRKr6tMmoaGJouJQTxdKcxAU0ziva9Li5cCSOPg==", "5f7b2a10-255e-4b53-a892-98584afa55f5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BlogDate",
                table: "BlogItems");

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
    }
}
