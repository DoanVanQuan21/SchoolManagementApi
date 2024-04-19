namespace SchoolManagement.Repository.Contracts.IRepositories
{
    public interface IClassRepository<T> : IGenerateRepository<T> where T : class
    {
        T GetClassByID(int classID);

        List<T> GetAllClassesByID(IList<int> ids);
    }
}