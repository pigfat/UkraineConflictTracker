using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models;
public class ReportModel
{
    [Key]
    public int report_id { get; set; }
    public double latitude { get; set; }
    public double longitude { get; set; }
    public DateTime reported_on { get; set; }
    public int sighting_type { get; set; }
}
