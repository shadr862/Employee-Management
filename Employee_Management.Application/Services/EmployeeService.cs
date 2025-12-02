using AutoMapper;
using Employee_Management.Application.DTOs;
using Employee_Management.Application.Interfaces;
using Employee_Management.Domain.Entities;
using Employee_Management.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management.Application.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;

        public EmployeeService(IEmployeeRepository employeeRepository,IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        public async Task AddAsync(CreateEmployeeDto entity)
        {
            await _employeeRepository.AddAsync(_mapper.Map<Employee>(entity));
        }

        public async Task DeleteAsync(Guid id)
        {
            await _employeeRepository.DeleteAsync(id);
        }

        public async Task<List<EmployeeDto>> GetAllAsync()
        {
            return _mapper.Map<List<EmployeeDto>>(await _employeeRepository.GetAllAsync());
        }

        public async Task<EmployeeDto> GetByIdAsync(Guid id)
        {
            return _mapper.Map<EmployeeDto>(await  _employeeRepository.GetByIdAsync(id));
        }

        public async Task UpdateAsync(UpdateEmployeeDto entity)
        {
            await _employeeRepository.UpdateAsync(_mapper.Map<Employee>(entity));
        }
    }
}
