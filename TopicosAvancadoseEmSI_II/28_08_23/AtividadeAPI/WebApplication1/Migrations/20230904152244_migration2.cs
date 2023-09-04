using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "c",
                table: "Equacao",
                newName: "C");

            migrationBuilder.RenameColumn(
                name: "b",
                table: "Equacao",
                newName: "B");

            migrationBuilder.RenameColumn(
                name: "a",
                table: "Equacao",
                newName: "A");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "C",
                table: "Equacao",
                newName: "c");

            migrationBuilder.RenameColumn(
                name: "B",
                table: "Equacao",
                newName: "b");

            migrationBuilder.RenameColumn(
                name: "A",
                table: "Equacao",
                newName: "a");
        }
    }
}
