using SchoolManagement.Core.Models;
using System.Collections.ObjectModel;

namespace SchoolManagement.Repository.Contracts.IServices
{
    public interface IGradeSheetService
    {
        List<GradeSheet> GetGradeSheets(int subjectID, int classID);

        Task<List<GradeSheet>> GetGradeSheetsAsync(int subjectID, int classID);
    }
}