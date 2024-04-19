using SchoolManagement.Core.Models;
using SchoolManagement.Repository.Contracts.IRepositories;

namespace SchoolManagement.Repository.Repositories.SchoolManagement
{
    public class CourseRepository : GenerateRepository<Course>, ICourseRepository<Course>
    {
        private List<Course> _coursesOfTeacher;

        public CourseRepository(SchoolManagementContext context) : base(context)
        {
            _coursesOfTeacher = new();
        }

        public List<int> GetClassIDs(int teacherID)
        {
            return GetCouseByTeacherID(teacherID).Select(item => item.ClassId).ToList();
        }

        public List<Course> GetCouseByClassID(int classID)
        {
            return new();
        }

        public List<Course> GetCouseByTeacherID(int teacherID)
        {
            var courses = Where(item => item.TeacherId == teacherID);
            if (courses == null)
            {
                return _coursesOfTeacher;
            }
            _coursesOfTeacher.Clear();
            _coursesOfTeacher.AddRange(courses);
            return _coursesOfTeacher;
        }
    }
}