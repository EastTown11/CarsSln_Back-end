using System;
using System.Collections.Generic;

#nullable disable

namespace CarsSln.Model
{
    public partial class CarPenaletyDet
    {
        public int PenaletyDetId { get; set; }
        public int PenaletyId { get; set; }
        public int NoPenalety { get; set; }
        public float Cost { get; set; }
        public DateTime Date { get; set; }
        public string Time { get; set; }
        public int EmployeeId { get; set; }
        public string FileTitle { get; set; }
        public string FilePath { get; set; }
        public int? CarId { get; set; }
    }
}
