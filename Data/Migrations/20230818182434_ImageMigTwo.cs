using Microsoft.EntityFrameworkCore.Migrations;

namespace LoveNottiesV2.Data.Migrations
{
    public partial class ImageMigTwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "41429312-36a9-489b-8d6f-c0fcea131da7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "a8a0b33f-1650-4afc-9d90-8a54ade26dae");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "f993e1c3-2d66-4f9f-9d6e-00c28d12d3be");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "5321ceff-5375-4027-8128-e9b449b04b32");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48149c0b-b2f9-4150-8de0-c8723380b76d", "AQAAAAEAACcQAAAAEDA+CP6M03sKlx7PXqRU+JorAodXze5fM3pMYs8jfLXzkBoxakJgUqzQAPVjQMKf/Q==", "45dce777-46e6-4af3-8ad6-d956cc3af9f9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "263856bd-78fd-4da5-bc5d-56f50ccce1bc", "AQAAAAEAACcQAAAAEGT7fXvp/aFT76QZ4ytwrT2AInpflYpBIT/eLFBD3l95bauU8N45rw5fhFfzfg8Tkg==", "456bdd18-241c-4079-aa13-f1b68f372c34" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d9739a6-6f21-41e6-b391-d29d97c1c8d5", "AQAAAAEAACcQAAAAEAuPQwTDQLNmVzjJCa3wvoTGyB0o5Gx0wV7uvB4IJNcprnoNG0T1Dixbh9VTAfyzvQ==", "bf1e3f8e-0ab6-4e6d-a622-acfc6ea47cf2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6dbb325-6e64-46c1-9d43-95bfb966116c", "AQAAAAEAACcQAAAAEAelcyU3+ims9fP7Sx4Dlz5UC4fBzgGYwMz3lg18cIkTVBfnGCAoShjfdRexpBU5Jg==", "04213bf6-c707-496c-a6be-bd0403f13481" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "08828f9c-0bef-4e5d-90f8-720c91fdb51a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "4877c638-1d63-43d7-a191-e65d35b9ddad");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "a96716b3-2e5b-410e-a27a-192a33f56593");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "884a5c43-49bf-4591-939d-bc5b33421e44");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "93599dfd-2de3-4f93-97c2-7a468dbbac02", "AQAAAAEAACcQAAAAEJaQRbz83HtV3t+2arURSEraQM8NKed2DASRJ3/MtcgzUKsOgJGFXw4nfkouOacO6w==", "7fc66ea9-6912-4616-b04f-1c9b77622339" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "397b961a-f807-4bc2-b7ca-d40cc5375930", "AQAAAAEAACcQAAAAEFR9dOOzFyMRbZnzn33gAN7lZxb8AVcpAA1jUknkmBmyVAPvET8R0W8wbnAhi0jR2g==", "6687bd0a-7b9d-4178-a747-df63947e5b66" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56781daa-4969-47d8-90ad-10b5cc889f40", "AQAAAAEAACcQAAAAENSYQiXR++Qo3s9pPLSENJutgPUsA2nbPaVg7vGS3RkXg4rQ9mlNfsOJkniXR4dWqg==", "612478cf-fdd0-4beb-8d93-a9c5fb6eeb22" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cdedd7a8-639a-45ca-b7f9-7ff4a31e4838", "AQAAAAEAACcQAAAAEOTe9vjlh0VpKIThssYdmEkGx0SHzr0dR8WWlJBauGBbCaKtbTIha2pFOvnxC2qFkw==", "12f83db3-32d2-4048-a98a-521093402911" });
        }
    }
}
