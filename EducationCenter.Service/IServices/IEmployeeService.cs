using EducationCenter.Domain.Common;
using EducationCenter.Domain.Configurations;
using EducationCenter.Domain.Models.Entities;
using EducationCenter.Service.DTOs.Employee;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EducationCenter.Service.IServices
{
    public interface IEmployeeService
    {
        Task<BaseResponse<Employee>> CreateAsync(EmployeeCreationalDTO EmployeeDto);

        Task<BaseResponse<Employee>> GetAsync(Expression<Func<Employee, bool>> expression);

        Task<BaseResponse<IEnumerable<Employee>>> GetAllAsync(PaginationParams @params, 
            Expression<Func<Employee, bool>> expression = null);

        Task<BaseResponse<bool>> DeleteAsync(Expression<Func<Employee, bool>> expression);

        Task<BaseResponse<Employee>> UpdateAsync(Guid id, EmployeeCreationalDTO EmployeeDto);
    }
}
