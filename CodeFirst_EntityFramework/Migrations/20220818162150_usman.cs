using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirst_EntityFramework.Migrations
{
    public partial class usman : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FatherName",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FatherName",
                table: "Students");
        }
    }
}
