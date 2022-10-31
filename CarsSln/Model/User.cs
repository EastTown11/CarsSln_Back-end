using System;
using System.Collections.Generic;

#nullable disable

namespace CarsSln.Model
{
    public partial class User
    {
        public int UserId { get; set; }
        public string UserFullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public bool UserAllow { get; set; }
        public bool Deleted { get; set; }
        public string Notes { get; set; }
        public int? EmployeeId { get; set; }

        public virtual HrEmployee Employee { get; set; }
        public virtual Role Role { get; set; }
    }
}
