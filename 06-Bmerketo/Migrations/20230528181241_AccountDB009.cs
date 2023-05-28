using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _06_Bmerketo.Migrations
{
    /// <inheritdoc />
    public partial class AccountDB009 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b45865c-8a5f-4d16-b6fb-3f0407774e62",
                column: "ConcurrencyStamp",
                value: "9efd0ad2-e61c-400d-992c-ae323ecffc82");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9cd63817-dbb2-453b-8537-25c5e22c4d42",
                column: "ConcurrencyStamp",
                value: "babd205b-42d1-499e-ae4b-2caf0d9d1c5d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9fbca2c6-5ba9-4f9d-8f42-30245653861e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc15e1dc-d298-49b4-a7ff-e39ad5d10c98", "AQAAAAIAAYagAAAAEN2R05wI1wWJ1lC7WGoFI1R8N0p5f/hBKj6ER6xB86ZEUAlWDW8eIyp6coaXgyJ+PA==", "7b6a42ce-7616-4f5f-bd68-3ec7ca0c1ca4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b45865c-8a5f-4d16-b6fb-3f0407774e62",
                column: "ConcurrencyStamp",
                value: "80a5d97f-835a-478a-befb-10ba7c12ff60");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9cd63817-dbb2-453b-8537-25c5e22c4d42",
                column: "ConcurrencyStamp",
                value: "92971752-0628-4948-8168-72cd1f456c28");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9fbca2c6-5ba9-4f9d-8f42-30245653861e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e402c646-4437-4cdc-8240-e558e5d1fbbb", "AQAAAAIAAYagAAAAEGKJIfZ3JKD1n4fUGvX3usuMglSXQO2/y/N5wNtbbyDHWbEyqAt8yrYiSY3onDrqVA==", "bfdb549d-5bae-4e29-9a1c-0adbf4c64cf9" });
        }
    }
}
