using SchoolManagement.Core.Models;

namespace SchoolManagement.Repository.Contracts.IServices
{
    public interface IStudentService
    {
        Student? GetStudent(int studentID);
    }
}