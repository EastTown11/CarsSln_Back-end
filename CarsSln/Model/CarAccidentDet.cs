using System;
using System.Collections.Generic;

#nullable disable

namespace CarsSln.Model
{
    public partial class CarAccidentDet
    {
        public int AccidentDetId { get; set; }
        public int AccidentId { get; set; }
        public int ComponentId { get; set; }
        public float Cost { get; set; }
        public string Notes { get; set; }
        public byte Type { get; set; }
    }
}
