using System;
using System.Collections.Generic;

#nullable disable

namespace CarsSln.Model
{
    public partial class PagesInRole
    {
        public int UserPageId { get; set; }
        public int RoleId { get; set; }
        public int PageId { get; set; }
        public byte PagePer { get; set; }
        public bool UserStampPer { get; set; }

        public virtual Page Page { get; set; }
        public virtual Role Role { get; set; }
    }
}
