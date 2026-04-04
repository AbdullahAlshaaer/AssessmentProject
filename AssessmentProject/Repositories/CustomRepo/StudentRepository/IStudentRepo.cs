using AssessmentProject.Models;
using AssessmentProject.Repositories.GenericRepo;
using System.Runtime.CompilerServices;

namespace AssessmentProject.Repositories.CustomRepo.StudentRepository
{
    public interface IStudentRepo:IGenericRepo<StudentProfileSelected>
    {
        //Student filter have to be made! filtering by (grade level - Class - Competency - Trial)
    }
}
