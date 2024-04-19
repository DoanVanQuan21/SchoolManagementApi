using SchoolManagement.Core.Models;
using SchoolManagement.Repository.Contracts;
using SchoolManagement.Repository.Repositories.SchoolManagement;

namespace SchoolManagement.Repository.Services
{
    public class SchoolManagementService : ISchoolManagementSevice
    {
        private SchoolManagementContext schoolManagementContext;
        private readonly string _connectionString = "Data Source=ADMIN;Initial Catalog=SchoolManagement;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        private static SchoolManagementService _instance = new SchoolManagementService();

        private SchoolManagementService()
        {
            InitConnectionDatabase();
        }

        public static SchoolManagementService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SchoolManagementService();
                }
                return _instance;
            }
        }

        public UserRepository UserRepository { get; private set; }

        public GradeSheetRepository GradeSheetRepository { get; private set; }

        public CourseRepository CourseRepository { get; private set; }

        public ClassRepository ClassRepository { get; private set; }
        public TeacherRepository TeacherRepository { get; private set; }

        public StudentRepository StudentRepository { get; private set; }

        private void InitConnectionDatabase()
        {
            schoolManagementContext = new SchoolManagementContext(_connectionString);
            UserRepository = new UserRepository(schoolManagementContext);
            GradeSheetRepository = new GradeSheetRepository(schoolManagementContext);
            CourseRepository = new CourseRepository(schoolManagementContext);
            ClassRepository = new ClassRepository(schoolManagementContext);
            TeacherRepository = new TeacherRepository(schoolManagementContext);
            StudentRepository = new StudentRepository(schoolManagementContext);
        }
    }
}