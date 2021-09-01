using System;
using System.Collections.Generic;

#nullable disable

namespace SmartHRMApi.Models
{
    public partial class Employees
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Status { get; set; }
        public DateTime? Dob { get; set; }
        public DateTime? Doj { get; set; }
        public string Gender { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string Designation { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Email { get; set; }

        public virtual Department Department { get; set; }
    }
}
