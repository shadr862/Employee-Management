using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management.Domain.Entities
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Department { get; set; } = null!;
        public string Role { get; set; } = null!;
        public DateTime JoiningDate { get; set; }
        public string Status { get; set; } = "Active"; // Active | Archived
        public int Performance { get; set; } // 1..100
    }
}
