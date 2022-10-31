using System;
using System.Collections.Generic;

#nullable disable

namespace CarsSln.Model
{
    public partial class CarInfoComponent
    {
        public int ComponentCarId { get; set; }
        public int CarId { get; set; }
        public int ComponentId { get; set; }
        public bool IsHave { get; set; }
        public string Notes { get; set; }
    }
}
