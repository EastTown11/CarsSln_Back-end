using System;
using System.Collections.Generic;

#nullable disable

namespace CarsSln.Model
{
    public partial class CarPenalety
    {
        public int PenaletyId { get; set; }
        public DateTime Date { get; set; }
        public int CarId { get; set; }
        public string Notes { get; set; }
    }
}
