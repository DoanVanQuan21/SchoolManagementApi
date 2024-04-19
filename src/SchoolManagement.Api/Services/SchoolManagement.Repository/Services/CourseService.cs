using SchoolManagement.Core.Models;
using SchoolManagement.Repository.Contracts.IServices;

namespace SchoolManagement.Repository.Services
{
    public class CourseService : BaseService, ICourseService
    {
        public CourseService() : base()
        {
        }

        public List<int> GetClassIDs(int teacherID)
        {
            return _schoolManagementSevice.CourseRepository.GetClassIDs(teacherID);
        }

        public Task<List<int>> GetClassIDsAsync(int teacherID)
        {
            return Task.Factory.StartNew(() =>
            {
                return GetClassIDs(teacherID);
            });
        }

        public List<Course> GetCourseByTeacherID(int TeacherID)
        {
            return _schoolManagementSevice.CourseRepository.GetCouseByTeacherID(TeacherID);
        }

        public Task<List<Course>> GetCourseByTeacherIDAsync(int TeacherID)
        {
            return Task.Factory.StartNew(() =>
            {
                return GetCourseByTeacherID(TeacherID);
            });
        }
    }
}