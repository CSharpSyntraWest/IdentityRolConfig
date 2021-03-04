using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityRolConfig.Migrations
{
    public partial class InsertRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5fa6f702-bd6f-4f2e-b22f-7bf75a339188", "d9a937f4-3a98-457c-9118-d7f3195b970c", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "31c65f55-48e5-440e-b3f0-04cc81c0ca31", "2a0f37e8-bdcd-4529-9cda-480adab7c9e3", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "31c65f55-48e5-440e-b3f0-04cc81c0ca31");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5fa6f702-bd6f-4f2e-b22f-7bf75a339188");
        }
    }
}
