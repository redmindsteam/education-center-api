using AutoMapper;
using EducationCenter.Data.IRepositories;
using EducationCenter.Domain.Common;
using EducationCenter.Domain.Configurations;
using EducationCenter.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EducationCenter.Service.Services
{
    public class GenericService<TModel, TDTO>
        : IGenericService<TModel, TDTO>
    {
        private readonly IGenericRepository<TModel> _repository;
        private readonly IMapper _mapper;

        public GenericService(IGenericRepository<TModel> repository,
            IMapper mapper)
        {
            this._repository = repository;
            this._mapper = mapper;
        }

        public async Task<BaseResponse<TModel>> CreateAsync(TDTO dto)
        {
            var response = new BaseResponse<TModel>();
            var model = _mapper.Map<TModel>(dto);
            model = await _repository.CreateAsync(model);
            response.Data = model;
            return response;
        }

        public Task<BaseResponse<bool>> DeleteAsync(Expression<Func<TModel, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<IEnumerable<TModel>>> GetAllAsync(PaginationParams @params, Expression<Func<TModel, bool>> expression = null)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<TModel>> GetAsync(Expression<Func<TModel, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<TModel>> UpdateAsync(int id, TDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
