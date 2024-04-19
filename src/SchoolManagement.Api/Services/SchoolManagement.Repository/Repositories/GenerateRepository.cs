using SchoolManagement.Core.Models;
using SchoolManagement.Repository.Contracts;

namespace SchoolManagement.Repository.Repositories
{
    public abstract class GenerateRepository<T> : IGenerateRepository<T> where T : class
    {
        protected readonly List<T> _allItems;
        protected readonly SchoolManagementContext _context;

        protected GenerateRepository(SchoolManagementContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void AddRange(IEnumerable<T> entities)
        {
            _context.Set<T>().AddRange(entities);
        }

        public T? Find(Func<T, bool> predicate)
        {
            return _context.Set<T>().Find(predicate);
        }

        public T? FirstOrDefault(Func<T, bool> predicate)
        {
            return _context.Set<T>().FirstOrDefault(predicate);
        }

        public List<T> GetAll()
        {
            if (_allItems == null)
            {
                return new List<T>();
            }
            _allItems.Clear();
            _allItems.AddRange(_context.Set<T>().ToList());
            return _allItems;
        }

        public IEnumerable<T> Where(Func<T, bool> predicate)
        {
            return _context.Set<T>().Where(predicate);
        }
    }
}