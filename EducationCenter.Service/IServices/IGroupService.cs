using EducationCenter.Domain.Models.Entities;
using EducationCenter.Service.DTOs.Group;

namespace EducationCenter.Service.IServices
{
    public interface IGroupService 
        : IGenericService<Group, GroupCreationalDTO>
    {
    }
}
