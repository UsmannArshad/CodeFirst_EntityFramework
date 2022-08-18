using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirst_EntityFramework.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /*migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    CourseName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CreditHours = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.UniqueConstraint("AK_Courses_CourseId", x => x.CourseId);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    StudentRollno = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.UniqueConstraint("AK_Students_StudentRollno", x => x.StudentRollno);
                });

            migrationBuilder.CreateTable(
                name: "AssignedCourses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssignedCourseId = table.Column<int>(type: "int", nullable: false),
                    StudentRollnumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssignedCourses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssignedCourses_Courses",
                        column: x => x.AssignedCourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId");
                    table.ForeignKey(
                        name: "FK_AssignedCourses_Students",
                        column: x => x.StudentRollnumber,
                        principalTable: "Students",
                        principalColumn: "StudentRollno");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AssignedCourses_AssignedCourseId",
                table: "AssignedCourses",
                column: "AssignedCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_AssignedCourses_StudentRollnumber",
                table: "AssignedCourses",
                column: "StudentRollnumber");

            migrationBuilder.CreateIndex(
                name: "UQ__Courses__C92D71A688AB2994",
                table: "Courses",
                column: "CourseId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__Students__7A342DE1A073BE4E",
                table: "Students",
                column: "StudentRollno",
                unique: true);*/
        }

/*        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssignedCourses");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Students");
        }*/
    }
}
