using AutoMapper;
using EducationCenter.Data.IRepasitories;
using EducationCenter.Domain.Common;
using EducationCenter.Service.DTOs.Group;
using EducationCenter.Service.IServices;
using System;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EducationCenter.Service.Services
{
    public class GroupService : IGroupService
    {
        private readonly IMapper _mapper;
        private readonly IGroupRepasitory _repasitory;

        public GroupService(IMapper mapper, IGroupRepasitory repasitory)
        {
            this._mapper = mapper;
            this._repasitory = repasitory;
        }

        public async Task<BaseResponse<Group>> CreateAsync(GroupCreationalDTO dto)
        {
            throw new NotImplementedException();
        }

        public async Task<BaseResponse<bool>> DeleteAsync(Expression<Func<Group, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public async Task<BaseResponse<GroupCreationalDTO>> GetAsync(Expression<Func<GroupCreationalDTO, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<Group>> UpdateAsync(int id, GroupCreationalDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
