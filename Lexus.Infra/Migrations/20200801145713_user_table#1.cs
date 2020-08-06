using Microsoft.EntityFrameworkCore.Migrations;

namespace Lexus.Infra.Migrations
{
    public partial class user_table1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "VARCHAR(36)", maxLength: 36, nullable: false),
                    Username = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Username" },
                values: new object[] { "1c1afc1e-0f93-4027-b884-cc36828b6223", "secretpass", "nicoolas" });

            migrationBuilder.CreateIndex(
                name: "User_Unique",
                table: "Users",
                column: "Username",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
