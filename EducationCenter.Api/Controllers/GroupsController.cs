using EducationCenter.Domain.Common;
using EducationCenter.Domain.Configurations;
using EducationCenter.Domain.Models.Entities;
using EducationCenter.Service.DTOs.Group;
using EducationCenter.Service.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EducationCenter.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupsController : ControllerBase
    {
        private readonly IGroupService _service;

        public GroupsController(IGroupService groupService)
        {
            this._service = groupService;
        }

        [HttpGet]
        public async Task<BaseResponse<IEnumerable<Group>>> Get(
            [FromQuery] PaginationParams @params)
        {
            return await _service.GetAllAsync(@params);
        }

        [HttpGet("{id}")]
        public async Task<BaseResponse<Group>> Get(int id)
        {
            return await _service.GetAsync(x => x.Id.Equals(id));
        }

        [HttpPost]
        public async Task<BaseResponse<Group>> Post([FromBody] GroupCreationalDTO EmployeeDto)
        {
            return await _service.CreateAsync(EmployeeDto);
        }

        [HttpPut("{id}")]
        public async Task<BaseResponse<Group>> Put(int id,
            [FromBody] GroupCreationalDTO employeeDto)
        {
            return await _service.UpdateAsync(id, employeeDto);
        }

        [HttpDelete("{id}")]
        public async Task<BaseResponse<bool>> Delete(int id)
        {
            return await _service.DeleteAsync(x => x.Id.Equals(id));
        }
    }
}
