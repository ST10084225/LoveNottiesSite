using Microsoft.EntityFrameworkCore.Migrations;

namespace LoveNottiesV2.Data.Migrations
{
    public partial class ModelUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SuccessStoryImage",
                table: "successStories",
                newName: "SuccessStoryImageID");

            migrationBuilder.RenameColumn(
                name: "OurPersonImage",
                table: "OurPeoples",
                newName: "OurPersonImageID");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "6657240c-bd5c-4f59-b39d-1ae78b21c677");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "ed890465-1e6c-4287-98d4-9d376c250bee");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "6d63a861-d9ef-48cc-9225-07aa64bc34f5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "9af34114-b501-4cb1-82d3-0b93cf40c230");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f30cbdd4-f388-4e2f-bd50-de340a64532f", "AQAAAAEAACcQAAAAEGL6O8UBgYeTyXmrtAvVAbRVEar1SXZeJpYcQdKoJhrn1O1ZX4K59NqLSqzkZy11Rg==", "cc8e3d36-d9d7-4bc7-a9af-bcaba159cb13" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f589b741-776e-4918-9b85-77407d470dd8", "AQAAAAEAACcQAAAAEHr95RK9W+FlypCBsC96+qTKohXSvByzkNH5JGvBee11nGZL9zMQPgQdhSIc5Piy0Q==", "fff0e89b-2c86-43ae-9fa1-8fa0d0018611" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28de2208-e60f-4ac9-84a9-f707f4f2bf8b", "AQAAAAEAACcQAAAAENY9Fd1z9bzJMLpq95B3xIzcwpURlRBL/PhoAJD18dQKW2x+Ll06I68wDOSrS07glA==", "eb03522d-61ee-4f22-92dc-b8cbc6222fc2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc019cb9-3925-4e03-b367-21c9569f0e9f", "AQAAAAEAACcQAAAAEG8DnRKE95Z9b1EGIdsQ1NZhUMQKvQpOrfcWLAldEBLRHxRJ5cuSCMWq54D6R3C+Tg==", "b056f5bb-70c6-4169-b888-b2f235e75149" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SuccessStoryImageID",
                table: "successStories",
                newName: "SuccessStoryImage");

            migrationBuilder.RenameColumn(
                name: "OurPersonImageID",
                table: "OurPeoples",
                newName: "OurPersonImage");

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
    }
}
