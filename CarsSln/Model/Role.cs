using System;
using System.Collections.Generic;

#nullable disable

namespace CarsSln.Model
{
    public partial class Role
    {
        public Role()
        {
            PagesInRoles = new HashSet<PagesInRole>();
            Users = new HashSet<User>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string Notes { get; set; }

        public virtual ICollection<PagesInRole> PagesInRoles { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
