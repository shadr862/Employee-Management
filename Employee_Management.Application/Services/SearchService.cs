using AutoMapper;
using Employee_Management.Application.DTOs;
using Employee_Management.Application.Interfaces;
using Employee_Management.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management.Application.Services
{
    public class SearchService : ISearchService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;

        public SearchService(IEmployeeRepository employeeRepository,IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        public async Task<List<EmployeeDto>> SearchEmployee(string item)
        {
            if(string.IsNullOrWhiteSpace(item))
            {
                return _mapper.Map<List<EmployeeDto>>(await _employeeRepository.GetAllAsync());
            }

            var employee= await _employeeRepository.GetAllAsync();

            return _mapper.Map<List<EmployeeDto>> (employee.Where(e =>
                                        e.Name.Contains(item) ||
                                        e.Department.Contains(item) ||
                                        e.Role.Contains(item) ||
                                        e.Status.Contains(item)));
            
        }
    }
}
