using System;
using System.Collections.Generic;

#nullable disable

namespace CarsSln.Model
{
    public partial class CarType
    {
        public CarType()
        {
            CarModels = new HashSet<CarModel>();
        }

        public int TypeId { get; set; }
        public string Type { get; set; }
        public string Notes { get; set; }

        public virtual ICollection<CarModel> CarModels { get; set; }
    }
}
