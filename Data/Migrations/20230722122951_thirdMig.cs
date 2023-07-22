using Microsoft.EntityFrameworkCore.Migrations;

namespace LoveNottiesV2.Data.Migrations
{
    public partial class thirdMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9555ddfb-68ff-437e-8591-9c8e395e4119", "Volunteer1@gmail.com", "VOLUNTEER1@GMAIL.COM", "AQAAAAEAACcQAAAAENA4AaYTZIxWTQh/Q2GkQBvhl2DyUesPVXQbcnRZclITq5f796Z4VyjWpEvGELKtWQ==", "0c06ce47-0d6d-494d-9348-d08e6d9ef1dc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7167743-243a-4bb6-bd9d-14d9e0b96382", "User1@gmail.com", "USER1@GMAIL.COM", "AQAAAAEAACcQAAAAEEazWzlbalfHwo03tI+8Z3L9z+keSyfaFt/x4o6f635GzzkqGkKoGzUgAPD4qHGEpQ==", "92bd2273-cffb-4986-b7be-5b3f60240aa6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "90040f4a-949b-4f53-8100-920dc5a1b8d8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "7573814a-f7f4-4512-9e6e-962b74f28dc5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "98b80e5c-dc51-471c-8a23-c68f5d799d3f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "8723cfd0-27a3-44fb-9b5d-9451aad1ff99");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d97105ff-1095-4daa-ac58-2f73c344c13d", "AQAAAAEAACcQAAAAEO7kZOuxbpY7q8bGaDOBmEXx85yc9NYjHKsCKE0Je9VU4sqiR/AFICoiMjKdsyIxLw==", "b2a86394-a3db-4846-981f-79b95e50f88d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "386c73f7-73cb-4be7-b668-5414e30a914a", "AQAAAAEAACcQAAAAEPqPuoeVdpXqCX1Zh/i7Y5DrT9Myn+UgeXWvSRf/ipqj8pNFWv7F3cYbeGQFY6cG3g==", "c81bd7f5-e742-4896-b9f5-413520c72562" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0fc67556-5685-422a-ba6a-34a2d7e4fd43", null, null, "AQAAAAEAACcQAAAAEEksZ1W69JHgz+0wqKIKRTtoyEG19nu1BTwaTQdmwpGkODjx8fuuAjkveIrOoJ9MOg==", "63edcee3-9bed-4f57-8f76-18d141ef7354" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d8e825e-f443-429a-9a5f-02fc2dd6ae70", null, null, "AQAAAAEAACcQAAAAEPKFZMRh2iz0OzmqxdMkLLkNIad2XU6Qm7xXq8uknUwC1DGp0aTG5/XriND7o9DqNg==", "a428f3e6-3704-4aa5-be64-cabc3418d2e8" });
        }
    }
}
