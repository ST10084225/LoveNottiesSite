using Microsoft.EntityFrameworkCore.Migrations;

namespace LoveNottiesV2.Data.Migrations
{
    public partial class fourthMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Volunteers",
                columns: table => new
                {
                    VolunteerID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    VolunteerName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    VolunteerCell = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VolunteerEmail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Volunteers", x => new { x.VolunteerID, x.VolunteerName });
                });

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

            migrationBuilder.InsertData(
                table: "Volunteers",
                columns: new[] { "VolunteerID", "VolunteerName", "VolunteerCell", "VolunteerEmail" },
                values: new object[] { "1", "Sivan Moodley", "0815750712", "sivan.moodley02@gmail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Volunteers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "22295775-89ed-4021-87cc-51c7b50f48e2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "f0a33f28-2120-4d88-9c76-ec859606702b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "82c2a4f3-bb99-4312-8396-5175411acad9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "1109d9d9-253b-4cec-aaa4-8afe861aac7c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f4b72ef2-1697-4905-b87c-588a18f59d8b", "AQAAAAEAACcQAAAAEPALHFzmr6KtvaIvpHtgzp8YsQiY3dASgVpJ6ZkJHshzpWZp7QwL5W+Zo9GjnhPoCg==", "fadcbb53-c364-483d-8345-1d6aa1ea6ef3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bffdbd95-0d8b-4f13-b1db-24a4043897ed", "AQAAAAEAACcQAAAAEMv+ppuqFJ31Pi7mmGnhffE4rZWFUnaWXsbHhc5E3md0xFI9jv88fkXk8J2QRRJAEw==", "50a05172-be98-4211-95c2-46a8cad11b55" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9555ddfb-68ff-437e-8591-9c8e395e4119", "AQAAAAEAACcQAAAAENA4AaYTZIxWTQh/Q2GkQBvhl2DyUesPVXQbcnRZclITq5f796Z4VyjWpEvGELKtWQ==", "0c06ce47-0d6d-494d-9348-d08e6d9ef1dc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7167743-243a-4bb6-bd9d-14d9e0b96382", "AQAAAAEAACcQAAAAEEazWzlbalfHwo03tI+8Z3L9z+keSyfaFt/x4o6f635GzzkqGkKoGzUgAPD4qHGEpQ==", "92bd2273-cffb-4986-b7be-5b3f60240aa6" });
        }
    }
}
