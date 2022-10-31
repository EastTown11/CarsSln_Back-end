using System;
using System.Collections.Generic;

#nullable disable

namespace CarsSln.Model
{
    public partial class CarInsuranceComp
    {
        public CarInsuranceComp()
        {
            CarInfos = new HashSet<CarInfo>();
        }

        public int InsuranceId { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }

        public virtual ICollection<CarInfo> CarInfos { get; set; }
    }
}
