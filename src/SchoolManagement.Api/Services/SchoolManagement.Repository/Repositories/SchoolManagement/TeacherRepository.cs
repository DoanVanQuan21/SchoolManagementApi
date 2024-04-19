using SchoolManagement.Core.Models;
using SchoolManagement.Repository.Contracts.IRepositories;

namespace SchoolManagement.Repository.Repositories.SchoolManagement
{
    public class TeacherRepository : GenerateRepository<Teacher>, ITeacherRepository<Teacher>
    {
        public TeacherRepository(SchoolManagementContext context) : base(context)
        {
        }

        public Teacher? GetTeacherInfo(int userID)
        {
            return FirstOrDefault(item => item.UserId == userID);
        }
    }
}