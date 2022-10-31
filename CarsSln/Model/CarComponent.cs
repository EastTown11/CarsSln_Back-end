using System;
using System.Collections.Generic;

#nullable disable

namespace CarsSln.Model
{
    public partial class CarComponent
    {
        public int ComponentId { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public byte Type { get; set; }
    }
}
