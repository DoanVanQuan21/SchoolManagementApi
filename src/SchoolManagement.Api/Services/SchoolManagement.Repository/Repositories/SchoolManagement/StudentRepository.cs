using SchoolManagement.Core.Models;
using SchoolManagement.Repository.Contracts.IRepositories;

namespace SchoolManagement.Repository.Repositories.SchoolManagement
{
    public class StudentRepository : GenerateRepository<Student>, IStudentRepository<Student>
    {
        public StudentRepository(SchoolManagementContext context) : base(context)
        {
        }

        public Student? GetStudent(int studentID)
        {
            return FirstOrDefault(item => item.StudentId == studentID);
        }
    }
}