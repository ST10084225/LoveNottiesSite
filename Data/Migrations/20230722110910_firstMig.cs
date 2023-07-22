using Microsoft.EntityFrameworkCore.Migrations;

namespace LoveNottiesV2.Data.Migrations
{
    public partial class firstMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", "2d086356-2fdc-49be-9bb6-e6a41d2a9ed8", "Manager", "MANAGER" },
                    { "2", "571bf48f-40b9-4ac0-8b05-a5531a7d9863", "Employee", "EMPLOYEE" },
                    { "3", "b8bfae51-b96b-4681-aa18-acc67445cc5f", "Volunteer", "VOLUNTEER" },
                    { "4", "ab9458c6-15fb-42b0-b323-9cb0caf9ccbc", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "bacacf3c-edf2-4d68-a615-6026b7d7df33", null, false, false, null, null, "MANAGER1", "AQAAAAEAACcQAAAAEKeP4H4/YiLW15JakuYEWrfiuQhSFta1VD5rgVcffH0/Nb/qvG1owkZNkseT+nyE0A==", null, false, "8f4b6b94-1c73-4c08-b644-87e4b594ed5d", false, "Manager1" },
                    { "2", 0, "9b7c2ec0-7111-4eca-89a1-306ef47f3cc0", null, false, false, null, null, "EMPLOYEE1", "AQAAAAEAACcQAAAAEP1Nt+C80xSFwM81YBKYpaesjaGFAnIPg2nTRZgQxN1xd+9VJ74JN93PUd8zMOMhdg==", null, false, "37049662-15ca-4e41-b358-d526d825e9d2", false, "Employee1" },
                    { "3", 0, "38bd1715-8ad2-474c-b132-770f00a04c84", null, false, false, null, null, "VOLUNTEER1", "AQAAAAEAACcQAAAAENuGZG85r6IZk0hFXKaOtC5u/T/CyVEoiXx0dFxc6PaK3BBJ20gFyCYn3VMqlws9Wg==", null, false, "41077d6d-d28c-49ef-9123-c2c16512e636", false, "Volunteer1" },
                    { "4", 0, "9060148d-8d6b-421f-9764-ad11c438b81c", null, false, false, null, null, "USER1", "AQAAAAEAACcQAAAAELIsXFCBihFKtaa4sSaqLIAHPO0EUHSy/oU5RtSuOPByKStkpB9G+eeW7d10XnfUMw==", null, false, "566f6573-f3d7-4b0c-9a2f-4f748d71ac5c", false, "User1" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "1" },
                    { "2", "2" },
                    { "3", "3" },
                    { "4", "4" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4", "4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4");
        }
    }
}
