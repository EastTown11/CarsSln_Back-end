using System;
using System.Collections.Generic;

#nullable disable

namespace CarsSln.Model
{
    public partial class CarColor
    {
        public CarColor()
        {
            CarInfos = new HashSet<CarInfo>();
        }

        public int ColorId { get; set; }
        public string Color { get; set; }
        public string Notes { get; set; }

        public virtual ICollection<CarInfo> CarInfos { get; set; }
    }
}
