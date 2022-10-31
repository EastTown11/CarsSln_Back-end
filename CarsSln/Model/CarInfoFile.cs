using System;
using System.Collections.Generic;

#nullable disable

namespace CarsSln.Model
{
    public partial class CarInfoFile
    {
        public int FileId { get; set; }
        public int CarId { get; set; }
        public string FileTitle { get; set; }
        public string FileName { get; set; }
    }
}
