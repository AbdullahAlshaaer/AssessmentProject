using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssessmentProject.Models;

public partial class Course
{
    public long Id { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public long? LevelStatusId { get; set; }

    public long? DurationHours { get; set; }

    public string? BusinessEntity { get; set; }
    [ForeignKey(nameof(Grade))]
    public long? GradeId { get; set; }
    public Grade Grade { get; set; }
    public ICollection<Course> Courses { get; set; }

}
