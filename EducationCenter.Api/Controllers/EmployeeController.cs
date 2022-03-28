using EducationCenter.Domain.Common;
using EducationCenter.Domain.Configurations;
using EducationCenter.Domain.Models.Entities;
using EducationCenter.Service.DTOs.Employee;
using EducationCenter.Service.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EducationCenter.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            this._employeeService = employeeService;
        }

        [HttpGet]
        public async Task<BaseResponse<IEnumerable<Employee>>> Get(
            [FromQuery] PaginationParams @params)
        {
            return await _employeeService.GetAllAsync(@params);
        }

        [HttpGet("{id}")]
        public async Task<BaseResponse<Employee>> Get(int id)
        {
            return await _employeeService.GetAsync(x=>x.Id.Equals(id));
        }

        [HttpPost]
        public async Task<BaseResponse<Employee>> Post([FromBody] EmployeeCreationalDTO EmployeeDto)
        {
            return await _employeeService.CreateAsync(EmployeeDto);
        }

        [HttpPut("{id}")]
        public async Task<BaseResponse<Employee>> Put(int id, 
            [FromBody] EmployeeCreationalDTO employeeDto)
        {
            return await _employeeService.UpdateAsync(id, employeeDto);
        }

        [HttpDelete("{id}")]
        public async Task<BaseResponse<bool>> Delete(int id)
        {
            return await _employeeService.DeleteAsync(x => x.Id.Equals(id));
        }
    }
}
