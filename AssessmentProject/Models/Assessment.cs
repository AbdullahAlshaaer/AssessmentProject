using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AssessmentProject.Models
{
    public class Assessment
    {
        [Key]
        public long Id { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string? OverallResult { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string? OverallGrade { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string? Notes { get; set; }
        public decimal PercentageScore { get; set; }
        public DateTime AssessedDate { get; set; }
        public Course Course { get; set; }
        public Account Account { get; set; }
        [ForeignKey(nameof(Account))]
        public long AssessorAccountId { get; set; }
        [ForeignKey(nameof(Course))]
        public long CourseId { get; set; }
    }
}