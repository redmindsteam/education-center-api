using AutoMapper;
using EducationCenter.Data.IRepositories;
using EducationCenter.Domain.Common;
using EducationCenter.Domain.Configurations;
using EducationCenter.Domain.Models.Entities;
using EducationCenter.Service.DTOs.Group;
using EducationCenter.Service.Extensions;
using EducationCenter.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EducationCenter.Service.Services
{
    public class GroupService : IGroupService
    {
        private readonly IMapper _mapper;
        private readonly IGroupRepository _repository;

        public GroupService(IMapper mapper, IGroupRepository repasitory)
        {
            this._mapper = mapper;
            this._repository = repasitory;
        }

        public async Task<BaseResponse<Group>> CreateAsync(GroupCreationalDTO dto)
        {
            var response = new BaseResponse<Group>();
            var group = _mapper.Map<Group>(dto);
            group = await _repository.CreateAsync(group);
            response.Data = group;
            return response;
        }

        public async Task<BaseResponse<bool>> DeleteAsync(Expression<Func<Group, bool>> expression)
        {
            var response = new BaseResponse<bool>();
            bool isdeleted = await _repository.DeleteAsync(expression);
            response.Data = isdeleted;
            return response;
        }

        public async Task<BaseResponse<IEnumerable<Group>>> GetAllAsync(PaginationParams @params, 
            Expression<Func<Group, bool>> expression = null)
        {
            var response = new BaseResponse<IEnumerable<Group>>();

            var query = await _repository.GetAllAsync(expression);
            
            var groups = await query.ToPagedListAsync(@params.PageNumber, @params.PageSize);

            response.Data = groups;

            return response;
        }

        public async Task<BaseResponse<Group>> GetAsync(Expression<Func<Group, bool>> expression)
        {
            var response = new BaseResponse<Group>();
            var employee = await _repository.GetAsync(expression);
            if (employee is null)
            {
                response.Error = new ErrorResponse()
                {
                    Code = 404,
                    Message = "Group not found"
                };
            }
            else response.Data = employee;
            return response;
        }

        public async Task<BaseResponse<Group>> UpdateAsync(int id, GroupCreationalDTO dto)
        {
            var response = new BaseResponse<Group>();
            var group = await _repository.FindAsync(id);
            if (group is null)
            {
                response.Error = new ErrorResponse()
                {
                    Code = 404,
                    Message = "Group not found"
                };
            }
            else
            {
                group.Name = dto.Name; 
                group.Description = dto.Description;
                group.Price = dto.Price;
                response.Data = await _repository.UpdateAsync(group);
            }
            return response;
        }
    }
}
