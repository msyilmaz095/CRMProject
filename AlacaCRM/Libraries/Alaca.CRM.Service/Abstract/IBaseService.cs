using Alaca.Core.Utilities.Result;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Alaca.CRM.Service.Abstract
{
    public interface IBaseService<TEntity, TType> : IBLL
    {
        Task<IResult> Add(TEntity data);
        Task<IResult> Remove(TEntity data);
        Task<IResult> Update(TEntity data);
        Task<IResultData<List<TEntity>>> GetAllList();
        Task<IResultData<TEntity>> GetById(TType Id);
    }

    public interface IBLL
    {

    }
}
