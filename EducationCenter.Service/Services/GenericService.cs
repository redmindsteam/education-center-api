using AutoMapper;
using EducationCenter.Data.IRepositories;
using EducationCenter.Domain.Common;
using EducationCenter.Domain.Configurations;
using EducationCenter.Service.Extensions;
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
        protected readonly IGenericRepository<TModel> _repository;
        protected readonly IMapper _mapper;

        public GenericService(IGenericRepository<TModel> repository,
            IMapper mapper)
        {
            this._repository = repository;
            this._mapper = mapper;
        }

        public virtual async Task<BaseResponse<TModel>> CreateAsync(TDTO dto)
        {
            var response = new BaseResponse<TModel>();
            var model = _mapper.Map<TModel>(dto);
            model = await _repository.CreateAsync(model);
            response.Data = model;
            return response;
        }

        public virtual async Task<BaseResponse<bool>> DeleteAsync(Expression<Func<TModel, bool>> expression)
        {
            var response = new BaseResponse<bool>();
            bool isdeleted = await _repository.DeleteAsync(expression);
            if(isdeleted) response.Data = isdeleted;
            else
            {
                response.Error = new ErrorResponse()
                {
                    Code = 404,
                    Message = "Image didn't find or cannot deleted"
                };
            }

            return response;
        }

        public virtual async Task<BaseResponse<IEnumerable<TModel>>> GetAllAsync(PaginationParams @params, 
            Expression<Func<TModel, bool>> expression = null)
        {
            var response = new BaseResponse<IEnumerable<TModel>>();

            var query = await _repository.GetAllAsync(expression);

            var items = await query.ToPagedListAsync(@params.PageNumber, @params.PageSize);

            response.Data = items;

            return response;
        }

        public virtual async Task<BaseResponse<TModel>> GetAsync(Expression<Func<TModel, bool>> expression)
        {
            var response = new BaseResponse<TModel>();
            var entity = await _repository.GetAsync(expression);
            if (entity is null)
            {
                response.Error = new ErrorResponse()
                {
                    Code = 404,
                    Message = $"{typeof(TModel)} is not found"
                };
            }
            else response.Data = entity;
            return response;
        }

        public virtual Task<BaseResponse<TModel>> UpdateAsync(int id, TDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
