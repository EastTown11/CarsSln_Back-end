using System;
using System.Collections.Generic;

#nullable disable

namespace CarsSln.Model
{
    public partial class CarDailyCheckUpDet
    {
        public int DailyChkupdDetId { get; set; }
        public int DailyChkupdId { get; set; }
        public int CarId { get; set; }
        public int CheckupItemId { get; set; }
        public byte Status { get; set; }
        public string Notes { get; set; }
    }
}
