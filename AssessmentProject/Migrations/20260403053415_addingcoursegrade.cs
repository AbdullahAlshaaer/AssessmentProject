using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssessmentProject.Migrations
{
    /// <inheritdoc />
    public partial class addingcoursegrade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "courseGrades",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<long>(type: "bigint", nullable: false),
                    GradeId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courseGrades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_courseGrades_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_courseGrades_Grade_GradeId",
                        column: x => x.GradeId,
                        principalTable: "Grade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_courseGrades_CourseId_GradeId",
                table: "courseGrades",
                columns: new[] { "CourseId", "GradeId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_courseGrades_GradeId",
                table: "courseGrades",
                column: "GradeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "courseGrades");
        }
    }
}
