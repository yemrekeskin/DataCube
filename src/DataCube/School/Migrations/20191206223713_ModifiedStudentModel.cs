using Microsoft.EntityFrameworkCore.Migrations;

namespace School.Migrations
{
    public partial class ModifiedStudentModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Students");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Students",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Students");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
