using EducationCenter.Domain.Models.Entities;
using EducationCenter.Service.DTOs.Employee;

namespace EducationCenter.Service.IServices
{
    public interface IEmployeeService
        :IGenericService<Employee, EmployeeCreationalDTO>
    {
    }
}
