using SchoolManagement.Core.Models;
using SchoolManagement.Repository.Contracts.IServices;

namespace SchoolManagement.Repository.Services
{
    public class GradeSheetService : BaseService, IGradeSheetService
    {
        public GradeSheetService() : base()
        {
        }

        public List<GradeSheet> GetGradeSheets(int subjectID, int classID)
        {
            return _schoolManagementSevice.GradeSheetRepository.GetAllGradeSheet(subjectID, classID);
        }

        public Task<List<GradeSheet>> GetGradeSheetsAsync(int subjectID, int classID)
        {
            return Task.Factory.StartNew(() =>
            {
                return GetGradeSheets(subjectID, classID);
            });
        }
    }
}