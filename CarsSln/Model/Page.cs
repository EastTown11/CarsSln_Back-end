using System;
using System.Collections.Generic;

#nullable disable

namespace CarsSln.Model
{
    public partial class Page
    {
        public Page()
        {
            PagesInRoles = new HashSet<PagesInRole>();
        }

        public int PageId { get; set; }
        public string PageProjectName { get; set; }
        public string PageName { get; set; }
        public byte? PageType { get; set; }
        public byte? ProjectId { get; set; }
        public byte? Order { get; set; }

        public virtual ICollection<PagesInRole> PagesInRoles { get; set; }
    }
}
