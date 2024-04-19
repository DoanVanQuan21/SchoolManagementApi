using SchoolManagement.Core.Models;

namespace SchoolManagement.Repository.Contracts.IServices
{
    public interface ITeacherService
    {
        Teacher? GetTeacherInfo(int userID);

        Task<Teacher?> GetTeacherInfoAsync(int userID);
    }
}