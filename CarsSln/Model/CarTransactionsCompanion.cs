using System;
using System.Collections.Generic;

#nullable disable

namespace CarsSln.Model
{
    public partial class CarTransactionsCompanion
    {
        public int TransEmployeeId { get; set; }
        public int? TransactionId { get; set; }
        public int? EmployeeId { get; set; }
        public string Notes { get; set; }
    }
}
