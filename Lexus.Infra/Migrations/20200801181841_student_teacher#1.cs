using Microsoft.EntityFrameworkCore.Migrations;

namespace Lexus.Infra.Migrations
{
    public partial class student_teacher1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f731ba96-9966-4d23-a611-55e8f34d5781");

            migrationBuilder.AlterColumn<string>(
                name: "PhotoPath",
                table: "Teacher",
                type: "VARCHAR(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddres",
                table: "Teacher",
                type: "VARCHAR(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Teacher",
                type: "VARCHAR(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Teacher",
                type: "VARCHAR(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Student",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Student",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Username" },
                values: new object[] { "359508b0-4765-4285-8375-b18676b97129", "secretpass", "nicoolas" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "359508b0-4765-4285-8375-b18676b97129");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Teacher");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Teacher");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Student");

            migrationBuilder.AlterColumn<string>(
                name: "PhotoPath",
                table: "Teacher",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddres",
                table: "Teacher",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(100)",
                oldMaxLength: 100);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Username" },
                values: new object[] { "f731ba96-9966-4d23-a611-55e8f34d5781", "secretpass", "nicoolas" });
        }
    }
}
