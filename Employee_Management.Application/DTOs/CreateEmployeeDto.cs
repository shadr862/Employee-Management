using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management.Application.DTOs
{
    public class CreateEmployeeDto
    {
        public string Name { get; set; } = null!;
        public string Department { get; set; } = null!;
        public string Role { get; set; } = null!;
        public DateTime JoiningDate { get; set; }
        public string Status { get; set; }//Active and Inactive
        public int Performance { get; set; }//1-100
    }
}
