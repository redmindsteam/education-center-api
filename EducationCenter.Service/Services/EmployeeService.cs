using EducationCenter.Data.IRepasitories;
using EducationCenter.Domain.Common;
using EducationCenter.Domain.Configurations;
using EducationCenter.Domain.Models.Entities;
using EducationCenter.Service.DTOs.Employee;
using EducationCenter.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EducationCenter.Service.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepasitory _employeeRepasitory;

        public EmployeeService(IEmployeeRepasitory employeeRepasitory)
        {
            this._employeeRepasitory = employeeRepasitory;
        }

        public async Task<BaseResponse<Employee>> CreateAsync(EmployeeCreationalDTO EmployeeDto)
        {
            var response = new BaseResponse<Employee>();



            return response;
        }

        public Task<BaseResponse<bool>> DeleteAsync(Expression<Func<Employee, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<IEnumerable<Employee>>> GetAllAsync(PaginationParams @params, 
            Expression<Func<Employee, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<Employee>> GetAsync(Expression<Func<Employee, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<Employee>> UpdateAsync(Guid id, EmployeeCreationalDTO EmployeeDto)
        {
            throw new NotImplementedException();
        }
    }
}
