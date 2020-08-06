using Microsoft.EntityFrameworkCore.Migrations;

namespace Lexus.Infra.Migrations
{
    public partial class teacher_table1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1c1afc1e-0f93-4027-b884-cc36828b6223");

            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    TeacherId = table.Column<string>(nullable: false),
                    PhotoPath = table.Column<string>(nullable: true),
                    EmailAddres = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.TeacherId);
                    table.ForeignKey(
                        name: "FK_Teacher_Users_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Username" },
                values: new object[] { "9a7533b7-4479-4d43-90db-f12993b6a8d3", "secretpass", "nicoolas" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teacher");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9a7533b7-4479-4d43-90db-f12993b6a8d3");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Username" },
                values: new object[] { "1c1afc1e-0f93-4027-b884-cc36828b6223", "secretpass", "nicoolas" });
        }
    }
}
