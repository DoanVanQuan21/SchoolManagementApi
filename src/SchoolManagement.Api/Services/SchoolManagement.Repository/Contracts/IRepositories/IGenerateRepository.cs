using System.Collections.ObjectModel;

namespace SchoolManagement.Repository.Contracts
{
    public interface IGenerateRepository<T> where T : class
    {
        void Add(T entity);

        void AddRange(IEnumerable<T> entities);

        T? Find(Func<T, bool> predicate);

        T? FirstOrDefault(Func<T, bool> predicate);

        List<T> GetAll();

        IEnumerable<T> Where(Func<T, bool> predicate);
    }
}