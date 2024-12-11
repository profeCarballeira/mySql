using System;
using System.Collections.Generic;

namespace _12_EF_linq_category.Modelss
{
    public partial class Employee
    {
        public Employee()
        {
            Orders = new HashSet<Order>();
        }

        public int EmployeeId { get; set; }
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public DateOnly? BirthDate { get; set; }
        public string? Photo { get; set; }
        public string? Notes { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
