using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management.Application.DTOs
{
    public class EmployeeDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } 
        public string Department { get; set; } 
        public string Role { get; set; }
        public DateTime JoiningDate { get; set; }
        public string Status { get; set; }
        public int Performance { get; set; }
    }
}
