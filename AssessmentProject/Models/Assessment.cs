using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace AssessmentProject.Models
{
    public class Assessment
    {
        [Key]
        public int Id { get; set; }
        public Course course { get; set; }
        [ForeignKey(nameof(course))]
        public int CourseId { get; set; }
        public string? Overall_Result { get; set; }
        public string? Overall_Grade { get; set; }
        public string? Notes { get; set; }
        public decimal Percentage_Score { get; set; }
    }
}