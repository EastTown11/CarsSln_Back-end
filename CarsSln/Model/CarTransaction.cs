using System;
using System.Collections.Generic;

#nullable disable

namespace CarsSln.Model
{
    public partial class CarTransaction
    {
        public int TransactionId { get; set; }
        public DateTime? OutDate { get; set; }
        public int? CarId { get; set; }
        public int? EmployeeIdDriver { get; set; }
        public string CurrentMeter { get; set; }
        public bool? ProtectionType { get; set; }
        public int? ProtectionShortTime { get; set; }
        public DateTime? ProtectionLongDate { get; set; }
        public DateTime? BackDate { get; set; }
        public int? EmployeeIdRecived { get; set; }
        public string CurrentMoterBack { get; set; }
        public string PathCar { get; set; }
        public string OtherDirection { get; set; }
        public string Notes { get; set; }
    }
}
