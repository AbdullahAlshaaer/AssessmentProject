using AssessmentProject.Models;
using AssessmentProject.Repositories.GenericRepo;
using Microsoft.EntityFrameworkCore;

namespace AssessmentProject.Repositories.CustomRepo.CourseRepository
{
    public class CourseRepo:GenericRepo<Course>,ICourseRepo
    {
        public CourseRepo(ElsewedySchoolSysDbDevContext context) : base(context) { }

        public async Task<IEnumerable<Course>> FilterByGradeLevel(long GradeId)
        {
            return await _dbSet.Courses.Where(x => x.CourseGrade.Any(gd => gd.GradeId == GradeId)).ToListAsync();
        }
    }
}
