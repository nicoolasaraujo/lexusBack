using Microsoft.EntityFrameworkCore.Migrations;

namespace Lexus.Infra.Migrations
{
    public partial class fillStudentData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "359508b0-4765-4285-8375-b18676b97129");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Username" },
                values: new object[] { "29ebc350-c831-4ec3-8eca-077f995b47ff", "secretpass", "nicoolas" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "29ebc350-c831-4ec3-8eca-077f995b47ff");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Username" },
                values: new object[] { "359508b0-4765-4285-8375-b18676b97129", "secretpass", "nicoolas" });
        }
    }
}
