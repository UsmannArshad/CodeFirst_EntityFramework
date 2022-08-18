using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirst_EntityFramework.Migrations
{
    public partial class markcolumnadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "marks",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "marks",
                table: "Students");
        }
    }
}
