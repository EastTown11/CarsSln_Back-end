using System;
using System.Collections.Generic;

#nullable disable

namespace CarsSln.Model
{
    public partial class Project
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectLink { get; set; }
        public byte? Order { get; set; }
    }
}
