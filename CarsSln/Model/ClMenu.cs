using System;
using System.Collections.Generic;

#nullable disable

namespace CarsSln.Model
{
    public partial class ClMenu
    {
        public int MenuId { get; set; }
        public string MenuName { get; set; }
        public float DiscountRatio { get; set; }
        public string Notes { get; set; }
        public byte? Type { get; set; }
    }
}
