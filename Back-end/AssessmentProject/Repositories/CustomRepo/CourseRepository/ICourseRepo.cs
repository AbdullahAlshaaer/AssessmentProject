using AssessmentProject.Models;
using AssessmentProject.Repositories.GenericRepo;

namespace AssessmentProject.Repositories.CustomRepo.CourseRepository
{
    public interface ICourseRepo:IGenericRepo<Course>
    {
        public Task<IEnumerable<Course>> FilterByGradeLevel(long GradeId);
        //other filters need to be finished
    }
}
