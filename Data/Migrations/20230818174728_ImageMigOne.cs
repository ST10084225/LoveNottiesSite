using Microsoft.EntityFrameworkCore.Migrations;

namespace LoveNottiesV2.Data.Migrations
{
    public partial class ImageMigOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BlogImage",
                table: "BlogItems",
                newName: "BlogImageID");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BlogImageID",
                table: "BlogItems",
                newName: "BlogImage");

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
    }
}
