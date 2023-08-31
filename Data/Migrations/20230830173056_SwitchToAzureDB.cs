using Microsoft.EntityFrameworkCore.Migrations;

namespace LoveNottiesV2.Data.Migrations
{
    public partial class SwitchToAzureDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "7de48ade-01f1-4f10-ba77-6d5781b6f081");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "bcd32ec3-e8c7-4589-a6d7-1ee21d31ab08");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "f4c96b86-d8af-4449-9c17-b93e666e7b08");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "d3497a53-2137-478e-b671-3436f6e8846e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e8cdb0d-af70-4405-ab0e-6dd340a0e03f", "AQAAAAEAACcQAAAAEPJgs99bqXxV5kb3NCY076hCqw9giuFxSOtM+hvaCYwm8Ya4Lz1rCjGsVjqbzAIVHA==", "8d241f6a-bdcd-4759-b6eb-f9268bc1365b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ccc12591-12f0-4478-a14e-3f366262afc4", "AQAAAAEAACcQAAAAEHl6QWlMF9Maabmyov7Q+/ig2PAVtQMWYU/s7KTjADC5eAM/O+23ER+9Cmy7jMU1lg==", "d9f193a2-90e3-4879-885d-cf548da405b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c9d18e4-4be3-4ea1-bc44-e3b5050a2321", "AQAAAAEAACcQAAAAEHwtuD4ft5GzmMCJ7xhHitU6MU6I6o4L2jgn95OMdjluwRkAxyzCZHkGstCbAYnMrg==", "b32ad4b0-48f3-4e1a-bd58-458be384daa0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c6871be-e68d-41ce-bc01-9ed6247bac08", "AQAAAAEAACcQAAAAEH/cyPvCd0MzzYxk1i8mry8TKUZu5eiRuQaKuAncuYeZRd+gBsr54GZjmIrfeVr6sA==", "eb9c1d97-9042-4ce1-b0fe-042b4ca40492" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
