using Employee_Management.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management.Domain.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetAllAsync();
        Task<Employee> GetByIdAsync(Guid id);
        Task DeleteAsync(Guid id);
        Task AddAsync(Employee entity);
        Task UpdateAsync(Employee entity);
    }
}
