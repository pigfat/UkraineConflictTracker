using DataAccess.DBAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data;
public class Report : IReport
{
    private readonly ISqlDataAccess _db;

    public Report(ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<IEnumerable<ReportModel>> GetReports()
    {
        string sql = "select report_id, latitude, longitude, reported_at, sighting_type from report";

        return _db.LoadData<ReportModel, dynamic>(sql, new { });
    }

    public Task InsertReport(ReportModel report)
    {
        string sql = @"INSERT INTO report (latitude, longitude, reported_at, sighting_type)
                        VALUES(@latitude, @longitude, @reported_at, @sighting_type);";
        return _db.SaveData<ReportModel>(sql, report);
    }
}

