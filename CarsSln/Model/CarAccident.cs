using System;
using System.Collections.Generic;

#nullable disable

namespace CarsSln.Model
{
    public partial class CarAccident
    {
        public int AccidentId { get; set; }
        public DateTime Date { get; set; }
        public int CarId { get; set; }
        public string PlacesAccidnt { get; set; }
        public string Time { get; set; }
        public string Descrption { get; set; }
        public string MaintenanceReq { get; set; }
        public float? TotalCost { get; set; }
        public string TimeReq { get; set; }
        public int? EmployeeId { get; set; }
        public byte TypeFlg { get; set; }
        public bool IsClosed { get; set; }
    }
}
