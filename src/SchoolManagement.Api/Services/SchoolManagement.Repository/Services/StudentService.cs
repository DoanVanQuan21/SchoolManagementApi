using SchoolManagement.Core.Models;
using SchoolManagement.Repository.Contracts.IServices;

namespace SchoolManagement.Repository.Services
{
    public class StudentService : BaseService, IStudentService
    {
        public StudentService() : base()
        {
        }

        public Student? GetStudent(int studentID)
        {
            return _schoolManagementSevice.StudentRepository.GetStudent(studentID);
        }
    }
}