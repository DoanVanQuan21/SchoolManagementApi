using SchoolManagement.Core.Models;
using System.Collections.ObjectModel;

namespace SchoolManagement.Repository.Contracts.IServices
{
    public interface ICourseService
    {
        List<Course> GetCourseByTeacherID(int TeacherID);

        Task<List<Course>> GetCourseByTeacherIDAsync(int TeacherID);

        List<int> GetClassIDs(int teacherID);

        Task<List<int>> GetClassIDsAsync(int teacherID);
    }
}