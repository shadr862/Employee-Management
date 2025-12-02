using Employee_Management.Application.DTOs;
using Employee_Management.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Employee_Management_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        private readonly ISearchService _searchService;
        public EmployeeController(IEmployeeService employeeService, ISearchService searchService)
        {
            _employeeService = employeeService;
            _searchService = searchService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync(int pagenumber,int perpageView)
        {
            var employees = await _employeeService.GetAllAsync();
            
            return Ok(employees.Where(emp=>emp.Status!="Archived").Skip((pagenumber - 1) * perpageView).Take(perpageView));
        }
        [HttpGet("Archived")]
        public async Task<IActionResult> GetAllArchivedAsync()
        {
            var employees = await _employeeService.GetAllAsync();

            return Ok(employees.Where(emp => emp.Status == "Archived"));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(Guid id)
        {
            return Ok(await _employeeService.GetByIdAsync(id));
        }

        [HttpGet("Search/{item}")]
        public async Task<IActionResult> Search(string item)
        {
            return Ok(await _searchService.SearchEmployee(item));
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateEmployeeDto entity)
        {
            await _employeeService.AddAsync(entity);
            return Ok(entity);
        }
        [HttpPut]
        public async Task<IActionResult> Update(UpdateEmployeeDto entity)
        {
            await _employeeService.UpdateAsync(entity);
            return Ok(entity);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _employeeService.DeleteAsync(id);
            return Ok();
        }

    }
}
