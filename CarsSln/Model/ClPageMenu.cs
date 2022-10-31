using System;
using System.Collections.Generic;

#nullable disable

namespace CarsSln.Model
{
    public partial class ClPageMenu
    {
        public int MenuItemId { get; set; }
        public string ItemPage { get; set; }
        public string ItemNameAr { get; set; }
        public string ItemNameEg { get; set; }
        public int MasterMenu { get; set; }
        public int PageId { get; set; }
        public int? Orders { get; set; }
    }
}
