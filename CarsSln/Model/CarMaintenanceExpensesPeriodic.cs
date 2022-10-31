using System;
using System.Collections.Generic;

#nullable disable

namespace CarsSln.Model
{
    public partial class CarMaintenanceExpensesPeriodic
    {
        public int ExpensesPeriodId { get; set; }
        public int? CarId { get; set; }
        public int? MaintenanceId { get; set; }
        public int ExpensesId { get; set; }
        public float Cost { get; set; }
        public string Notes { get; set; }
    }
}
