using SchoolManagement.Core.Models;

namespace SchoolManagement.Repository.Contracts.IServices
{
    public interface IUserService
    {
        List<User> GetAllAccounts();

        List<User> GetAllStudentsByCourse(int classID, int subjectID);

        List<User> GetTeacherByDepartment(int departmentID);

        (bool, User) Login(User user);

        bool RegisterAccount(User user);

        bool UpdateUserInfor(User user);

        string GetFullname(int userID);
    }
}