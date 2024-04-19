using SchoolManagement.Repository.Repositories.SchoolManagement;

namespace SchoolManagement.Repository.Contracts
{
    public interface ISchoolManagementSevice
    {
        UserRepository UserRepository { get; }
        GradeSheetRepository GradeSheetRepository { get; }
        CourseRepository CourseRepository { get; }
        ClassRepository ClassRepository { get; }
        TeacherRepository TeacherRepository { get; }
        StudentRepository StudentRepository { get; }
    }
}