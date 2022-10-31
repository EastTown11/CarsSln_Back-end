using System;
using System.Collections.Generic;

#nullable disable

namespace CarsSln.Model
{
    public partial class CarInfoPhoto
    {
        public int CarImageId { get; set; }
        public int CarId { get; set; }
        public byte[] Image { get; set; }
    }
}
