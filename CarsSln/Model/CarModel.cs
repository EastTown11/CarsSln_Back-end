using System;
using System.Collections.Generic;

#nullable disable

namespace CarsSln.Model
{
    public partial class CarModel
    {
        public CarModel()
        {
            CarInfos = new HashSet<CarInfo>();
        }

        public int ModelId { get; set; }
        public string Model { get; set; }
        public int? TypeId { get; set; }
        public int? CompanyId { get; set; }
        public string Notes { get; set; }

        public virtual CarCompany Company { get; set; }
        public virtual CarType Type { get; set; }
        public virtual ICollection<CarInfo> CarInfos { get; set; }
    }
}
