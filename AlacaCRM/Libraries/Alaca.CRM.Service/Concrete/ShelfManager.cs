using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Alaca.Core.Utilities.Result;
using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;
using Alaca.Crm.Dal.Abstract;
using Alaca.Validations.FluentValidation;
using Alaca.Core.Aop.Autofac;

namespace Alaca.CRM.Service.Concrete
{
    public class ShelfManager : IShelfService
    {
        IShelfDal _shelfDal;
        public ShelfManager(IShelfDal shelfDal)
        {
            _shelfDal = shelfDal;
        }

        [Validation(typeof(ShelfValidator))]
        public async Task<IResult> Add(Shelf data)
        {
            await _shelfDal.Insert(data);
            return new SuccessResult("Raf Eklendi.", data.ShelfId);
        }

        public async Task<IResultData<List<Shelf>>> GetAllList()
        {
            var data = await _shelfDal.GetAllList();
            return new SuccessResultData<List<Shelf>>(data);
        }

        public async Task<IResultData<Shelf>> GetById(Guid Id)
        {
            return new SuccessResultData<Shelf>(await _shelfDal.Get(p => p.ShelfId == Id));
        }

        public async Task<IResult> Remove(Shelf data)
        {
            await _shelfDal.Delete(data);
            return new SuccessResult("Raf Silindi.", data.ShelfId);
        }

        [Validation(typeof(ShelfValidator))]
        public async Task<IResult> Update(Shelf data)
        {
            await _shelfDal.Update(data);
            return new SuccessResult("Raf Güncellendi.", data.ShelfId);
        }
    }
}
