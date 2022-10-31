using System;
using System.Collections.Generic;

#nullable disable

namespace CarsSln.Model
{
    public partial class CarDailyCheckUp
    {
        public int DailyChkupdId { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }
        public int EmployeeId { get; set; }
    }
}
