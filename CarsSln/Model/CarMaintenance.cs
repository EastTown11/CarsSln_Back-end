using System;
using System.Collections.Generic;

#nullable disable

namespace CarsSln.Model
{
    public partial class CarMaintenance
    {
        public int MaintenanceId { get; set; }
        public DateTime Date { get; set; }
        public int CarId { get; set; }
        public int? EmployeeId { get; set; }
        public float? TotalCost { get; set; }
        public byte TypeFlg { get; set; }
        public string ReasonReqMaintenance { get; set; }
        public string ReportMaintenance { get; set; }
        public string Notes { get; set; }
        public int? AccidentId { get; set; }
    }
}
