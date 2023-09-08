using Microsoft.EntityFrameworkCore.Migrations;

namespace LoveNottiesV2.Data.Migrations
{
    public partial class secondMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

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
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d97105ff-1095-4daa-ac58-2f73c344c13d", "Manager1@gmail.com", "MANAGER1@GMAIL.COM", "AQAAAAEAACcQAAAAEO7kZOuxbpY7q8bGaDOBmEXx85yc9NYjHKsCKE0Je9VU4sqiR/AFICoiMjKdsyIxLw==", "b2a86394-a3db-4846-981f-79b95e50f88d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "386c73f7-73cb-4be7-b668-5414e30a914a", "Employee1@gmail.com", "EMPLOYEE1@GMAIL.COM", "AQAAAAEAACcQAAAAEPqPuoeVdpXqCX1Zh/i7Y5DrT9Myn+UgeXWvSRf/ipqj8pNFWv7F3cYbeGQFY6cG3g==", "c81bd7f5-e742-4896-b9f5-413520c72562" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0fc67556-5685-422a-ba6a-34a2d7e4fd43", "AQAAAAEAACcQAAAAEEksZ1W69JHgz+0wqKIKRTtoyEG19nu1BTwaTQdmwpGkODjx8fuuAjkveIrOoJ9MOg==", "63edcee3-9bed-4f57-8f76-18d141ef7354" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d8e825e-f443-429a-9a5f-02fc2dd6ae70", "AQAAAAEAACcQAAAAEPKFZMRh2iz0OzmqxdMkLLkNIad2XU6Qm7xXq8uknUwC1DGp0aTG5/XriND7o9DqNg==", "a428f3e6-3704-4aa5-be64-cabc3418d2e8" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "2d086356-2fdc-49be-9bb6-e6a41d2a9ed8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "571bf48f-40b9-4ac0-8b05-a5531a7d9863");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "b8bfae51-b96b-4681-aa18-acc67445cc5f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "ab9458c6-15fb-42b0-b323-9cb0caf9ccbc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bacacf3c-edf2-4d68-a615-6026b7d7df33", null, null, "AQAAAAEAACcQAAAAEKeP4H4/YiLW15JakuYEWrfiuQhSFta1VD5rgVcffH0/Nb/qvG1owkZNkseT+nyE0A==", "8f4b6b94-1c73-4c08-b644-87e4b594ed5d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b7c2ec0-7111-4eca-89a1-306ef47f3cc0", null, null, "AQAAAAEAACcQAAAAEP1Nt+C80xSFwM81YBKYpaesjaGFAnIPg2nTRZgQxN1xd+9VJ74JN93PUd8zMOMhdg==", "37049662-15ca-4e41-b358-d526d825e9d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38bd1715-8ad2-474c-b132-770f00a04c84", "AQAAAAEAACcQAAAAENuGZG85r6IZk0hFXKaOtC5u/T/CyVEoiXx0dFxc6PaK3BBJ20gFyCYn3VMqlws9Wg==", "41077d6d-d28c-49ef-9123-c2c16512e636" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9060148d-8d6b-421f-9764-ad11c438b81c", "AQAAAAEAACcQAAAAELIsXFCBihFKtaa4sSaqLIAHPO0EUHSy/oU5RtSuOPByKStkpB9G+eeW7d10XnfUMw==", "566f6573-f3d7-4b0c-9a2f-4f748d71ac5c" });
        }
    }
}
