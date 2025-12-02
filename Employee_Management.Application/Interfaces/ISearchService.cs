using Employee_Management.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management.Application.Interfaces
{
    public interface ISearchService
    {
        Task<List<EmployeeDto>> SearchEmployee(string item);
    }
}
