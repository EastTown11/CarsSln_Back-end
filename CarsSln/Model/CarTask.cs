using System;
using System.Collections.Generic;

#nullable disable

namespace CarsSln.Model
{
    public partial class CarTask
    {
        public int TaskId { get; set; }
        public string Task { get; set; }
        public string Notes { get; set; }
    }
}
