using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssessmentProject.Migrations
{
    /// <inheritdoc />
    public partial class addAssessmentTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Assessment",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OverallResult = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    OverallGrade = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    PercentageScore = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CourseId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assessment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assessment_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assessment_CourseId",
                table: "Assessment",
                column: "CourseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assessment");
        }
    }
}
