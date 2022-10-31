using System;
using System.Collections.Generic;

#nullable disable

namespace CarsSln.Model
{
    public partial class CarCompany
    {
        public CarCompany()
        {
            CarModels = new HashSet<CarModel>();
        }

        public int CompanyId { get; set; }
        public string Company { get; set; }
        public string Notes { get; set; }

        public virtual ICollection<CarModel> CarModels { get; set; }
    }
}
