using SchoolManagement.Repository.Contracts;

namespace SchoolManagement.Repository.Services
{
    public abstract class BaseService
    {
        protected readonly ISchoolManagementSevice _schoolManagementSevice;

        protected BaseService()
        {
            _schoolManagementSevice = SchoolManagementService.Instance;
        }
    }
}