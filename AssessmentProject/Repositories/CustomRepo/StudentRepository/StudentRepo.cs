using AssessmentProject.Models;
using AssessmentProject.Repositories.GenericRepo;
using Microsoft.EntityFrameworkCore;

namespace AssessmentProject.Repositories.CustomRepo.StudentRepository
{
    public class StudentRepo : GenericRepo<StudentProfileSelected>, IStudentRepo
    {
        public StudentRepo(ElsewedySchoolSysDbDevContext context) : base(context) { }
    }
}
