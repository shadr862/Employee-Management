using Employee_Management.Application.DTOs;
using Employee_Management.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management.Application.Interfaces
{
    public interface IEmployeeService
    {
        Task<List<EmployeeDto>> GetAllAsync();
        Task<EmployeeDto> GetByIdAsync(Guid id);
        Task DeleteAsync(Guid id);
        Task AddAsync(CreateEmployeeDto entity);
        Task UpdateAsync(UpdateEmployeeDto entity);
    }
}
