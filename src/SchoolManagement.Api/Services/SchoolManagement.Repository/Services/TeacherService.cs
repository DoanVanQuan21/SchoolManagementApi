using SchoolManagement.Core.Models;
using SchoolManagement.Repository.Contracts.IServices;

namespace SchoolManagement.Repository.Services
{
    public class TeacherService : BaseService, ITeacherService
    {
        public TeacherService() : base()
        {
        }

        public Teacher? GetTeacherInfo(int userID)
        {
            return _schoolManagementSevice.TeacherRepository.GetTeacherInfo(userID);
        }

        public Task<Teacher?> GetTeacherInfoAsync(int userID)
        {
            return Task.Factory.StartNew(() =>
            {
                return GetTeacherInfo(userID);
            });
        }
    }
}