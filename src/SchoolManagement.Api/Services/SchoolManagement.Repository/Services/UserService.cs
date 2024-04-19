using SchoolManagement.Core.Models;
using SchoolManagement.Repository.Contracts.IServices;

namespace SchoolManagement.Repository.Services
{
    public class UserService : BaseService, IUserService
    {
        public UserService() : base()
        {
        }

        public List<User> GetAllAccounts()
        {
            //TODO
            return _schoolManagementSevice.UserRepository.GetAll();
        }

        public List<User> GetAllStudentsByCourse(int classID, int subjectID)
        {
            //TODO
            var users = new List<User>();
            return users;
        }

        public string GetFullname(int userID)
        {
            return _schoolManagementSevice.UserRepository.GetFullname(userID);
        }

        public List<User> GetTeacherByDepartment(int departmentID)
        {
            //TODO
            return new();
        }

        public (bool, User) Login(User user)
        {
            var currentUser = _schoolManagementSevice.UserRepository.FirstOrDefault(r => r.Username == user.Username && r.Password == user.Password);
            if (currentUser == null)
            {
                return (false, currentUser);
            }
            return (true, currentUser);
        }

        public bool RegisterAccount(User user)
        {
            var account = _schoolManagementSevice.UserRepository.FirstOrDefault(u => u.PhoneNumber == user.PhoneNumber);
            if (account != null)
            {
                return false;
            }
            _schoolManagementSevice.UserRepository.Add(user);
            return true;
        }

        public bool UpdateUserInfor(User user)
        {
            var userDb = _schoolManagementSevice.UserRepository.FirstOrDefault(u => u.UserId == user.UserId);
            if (userDb == null)
            {
                return false;
            }
            _schoolManagementSevice.UserRepository.Update(user);
            return true;
        }
    }
}