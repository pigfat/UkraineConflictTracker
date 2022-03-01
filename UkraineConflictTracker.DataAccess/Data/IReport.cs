using DataAccess.Models;

namespace DataAccess.Data
{
    public interface IReport
    {
        Task<IEnumerable<ReportModel>> GetReports();
        Task InsertReport(ReportModel report);
    }
}