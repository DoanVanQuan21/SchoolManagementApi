using SchoolManagement.Core.Models;
using SchoolManagement.Repository.Contracts.IServices;

namespace SchoolManagement.Repository.Services
{
    public class ClassService : BaseService, IClassService
    {
        public ClassService() : base()
        {
        }

        public List<Class> GetAllClassesByID(IList<int> ids)
        {
            return _schoolManagementSevice.ClassRepository.GetAllClassesByID(ids);
        }

        public Task<List<Class>> GetAllClassesByIDAsync(IList<int> ids)
        {
            return Task.Factory.StartNew(() =>
            {
                return GetAllClassesByID(ids);
            });
        }

        public Class GetClassByID(int classID)
        {
            return _schoolManagementSevice.ClassRepository.GetClassByID(classID);
        }

        public Task<Class> GetClassByIDAsync(int classID)
        {
            return Task.Factory.StartNew(() =>
            {
                return GetClassByID(classID);
            });
        }
    }
}