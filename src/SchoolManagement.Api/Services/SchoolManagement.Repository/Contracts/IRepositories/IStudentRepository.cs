namespace SchoolManagement.Repository.Contracts.IRepositories
{
    public interface IStudentRepository<T> : IGenerateRepository<T> where T : class
    {
        T? GetStudent(int studentID);
    }
}