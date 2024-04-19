using SchoolManagement.Core.Models;
using System.Collections.ObjectModel;

namespace SchoolManagement.Repository.Contracts.IServices
{
    public interface IClassService
    {
        Class GetClassByID(int classID);

        Task<Class> GetClassByIDAsync(int classID);

        List<Class> GetAllClassesByID(IList<int> ids);

        Task<List<Class>> GetAllClassesByIDAsync(IList<int> ids);
    }
}