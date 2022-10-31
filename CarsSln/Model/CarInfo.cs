using System;
using System.Collections.Generic;

#nullable disable

namespace CarsSln.Model
{
    public partial class CarInfo
    {
        public int CarId { get; set; }
        public string Code { get; set; }
        public int ModelId { get; set; }
        public string Photo { get; set; }
        public string ChaseNo { get; set; }
        public int? InsuranceId { get; set; }
        public int ColorId { get; set; }
        public string MotorsNo { get; set; }
        public string CapMotors { get; set; }
        public DateTime DateBuy { get; set; }
        public string PeriodOfInsurance { get; set; }
        public DateTime? DateEndInsurance { get; set; }
        public string LicenseNo { get; set; }
        public DateTime DateEndLicens { get; set; }
        public string CodeGps { get; set; }
        public string LinkGps { get; set; }
        public string Notes { get; set; }
        public byte Status { get; set; }
        public int? Bestcar { get; set; }

        public virtual CarColor Color { get; set; }
        public virtual CarInsuranceComp Insurance { get; set; }
        public virtual CarModel Model { get; set; }
    }
}
