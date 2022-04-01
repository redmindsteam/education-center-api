using AutoMapper;
using EducationCenter.Data.IRepositories;
using EducationCenter.Domain.Common;
using EducationCenter.Domain.Configurations;
using EducationCenter.Domain.Models.Entities;
using EducationCenter.Service.DTOs.Employee;
using EducationCenter.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using EducationCenter.Service.Extensions;

namespace EducationCenter.Service.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepasitory;
        private readonly IMapper _mapper;

        public EmployeeService(IEmployeeRepository employeeRepasitory, 
            IMapper mapper)
        {
            this._employeeRepasitory = employeeRepasitory;
            this._mapper = mapper;
        }

        public async Task<BaseResponse<Employee>> CreateAsync(EmployeeCreationalDTO employeeDto)
        {
            var response = new BaseResponse<Employee>();

            var employee = _mapper.Map<Employee>(employeeDto);

            employee = await _employeeRepasitory.CreateAsync(employee);

            response.Data = employee;

            return response;
        }

        public async Task<BaseResponse<bool>> DeleteAsync(Expression<Func<Employee, bool>> expression)
        {
            var response = new BaseResponse<bool>();

            bool isDeleted = await _employeeRepasitory.DeleteAsync(expression);

            response.Data = isDeleted;

            return response;
        }

        public async Task<BaseResponse<IEnumerable<Employee>>> GetAllAsync(PaginationParams @params, 
            Expression<Func<Employee, bool>> expression = null)
        {
            var response = new BaseResponse<IEnumerable<Employee>>();

            var employeesQuery = await _employeeRepasitory.GetAllAsync(expression);

            var employees = await employeesQuery.ToPagedListAsync(@params.PageNumber, @params.PageSize);

            response.Data = employees;

            return response;
        }

        public async Task<BaseResponse<Employee>> GetAsync(Expression<Func<Employee, bool>> expression)
        {
            var response = new BaseResponse<Employee>();

            var employee = await _employeeRepasitory.GetAsync(expression);

            response.Data=employee;

            return response;
        }

        public async Task<BaseResponse<Employee>> UpdateAsync(int id, 
            EmployeeCreationalDTO employeeDto)
        {
            var response = new BaseResponse<Employee>();
            
            var employee = await _employeeRepasitory.GetAsync(employee => employee.Id.Equals(id));

            if(employee is null)
            {
                var error = new ErrorResponse(404, "Employee was not faund");
                response.Error = error;
            }
            else
            {
                _mapper.Map(employeeDto, employee);
                await _employeeRepasitory.UpdateAsync(employee);
            }

            return response;
        }
    }
}
