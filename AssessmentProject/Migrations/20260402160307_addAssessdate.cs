using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssessmentProject.Migrations
{
    /// <inheritdoc />
    public partial class addAssessdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "AssessedDate",
                table: "Assessment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "AssessorAccountId",
                table: "Assessment",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Assessment_AssessorAccountId",
                table: "Assessment",
                column: "AssessorAccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Assessment_Account_AssessorAccountId",
                table: "Assessment",
                column: "AssessorAccountId",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assessment_Account_AssessorAccountId",
                table: "Assessment");

            migrationBuilder.DropIndex(
                name: "IX_Assessment_AssessorAccountId",
                table: "Assessment");

            migrationBuilder.DropColumn(
                name: "AssessedDate",
                table: "Assessment");

            migrationBuilder.DropColumn(
                name: "AssessorAccountId",
                table: "Assessment");
        }
    }
}
