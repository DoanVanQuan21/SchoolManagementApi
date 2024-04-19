using SchoolManagement.Core.Models;
using SchoolManagement.Repository.Contracts.IRepositories;

namespace SchoolManagement.Repository.Repositories.SchoolManagement
{
    public class ClassRepository : GenerateRepository<Class>, IClassRepository<Class>
    {
        private List<Class> _classesOfTeacher;

        public ClassRepository(SchoolManagementContext context) : base(context)
        {
            _classesOfTeacher = new();
        }

        public List<Class> GetAllClassesByID(IList<int> ids)
        {
            if (ids == null || ids.Count == 0) { return _classesOfTeacher; }
            _classesOfTeacher.Clear();
            var classes = new List<Class>();
            foreach (var id in ids)
            {
                var c = GetClassByID(id);
                if (c == null)
                {
                    continue;
                }
                classes.Add(c);
            }
            _classesOfTeacher.AddRange(classes);
            return _classesOfTeacher;
        }

        public Class GetClassByID(int classID)
        {
            return FirstOrDefault(item => item.ClassId == classID);
        }
    }
}