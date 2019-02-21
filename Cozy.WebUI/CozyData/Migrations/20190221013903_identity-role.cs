using Microsoft.EntityFrameworkCore.Migrations;

namespace CozyData.Migrations
{
    public partial class identityrole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "13a480bc-8f01-4773-a087-b1f44bf2bcca", "a3b1732e-8822-4b0c-a3b4-77557cee5f1e", "Landlord", "LANDLORD" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a8b7f8ec-3475-41f0-876c-0bf4ce97b642", "7c7db8e5-2cac-43d2-86b3-659d71409e14", "Tenant", "TENANT" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "13a480bc-8f01-4773-a087-b1f44bf2bcca", "a3b1732e-8822-4b0c-a3b4-77557cee5f1e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "a8b7f8ec-3475-41f0-876c-0bf4ce97b642", "7c7db8e5-2cac-43d2-86b3-659d71409e14" });
        }
    }
}
