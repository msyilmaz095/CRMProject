using Alaca.Core.Utilities.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alaca.Crm.Client.Service.Abstract
{
    public interface IBaseService<TEntities, TType>: IManager
    {
        Task<IResult> Insert(TEntities data);
        Task<IResult> Update(TEntities data);
        Task<IResult> Delete(TType id);
        Task<IResultData<TEntities[]>> GetAll();
        Task<IResultData<TEntities>> GetById(TType id);
    }
    public interface IManager
    {
    }
}
