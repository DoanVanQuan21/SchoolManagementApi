using System.Collections.ObjectModel;

namespace SchoolManagement.Repository.Contracts.IRepositories
{
    public interface ICourseRepository<T> : IGenerateRepository<T> where T : class
    {
        List<T> GetCouseByTeacherID(int teacherID);

        List<T> GetCouseByClassID(int classID);

        List<int> GetClassIDs(int teacherID);
    }
}