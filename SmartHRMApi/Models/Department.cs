using System;
using System.Collections.Generic;

#nullable disable

namespace SmartHRMApi.Models
{
    public partial class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }

        public int DepartmentId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
