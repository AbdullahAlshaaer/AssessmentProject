namespace AssessmentProject.Models
{
    public class CourseGrade
    {
        public long Id { get; set; }
        public long CourseId { get; set; }
        public long GradeId { get; set; }
        public Course Course { get; set; }
        public Grade Grade { get; set; }
    }
}
