using System;
using System.Collections.Generic;

#nullable disable

namespace CarsSln.Model
{
    public partial class CarMaintenanceDet
    {
        public int MaintenanceDetId { get; set; }
        public int MaintenanceId { get; set; }
        public int ComponentId { get; set; }
        public float? Cost { get; set; }
        public int? MaintDirectionId { get; set; }
        public string OrderNo { get; set; }
        public int? SuppId { get; set; }
        public string Notes { get; set; }
        public byte Type { get; set; }
    }
}
