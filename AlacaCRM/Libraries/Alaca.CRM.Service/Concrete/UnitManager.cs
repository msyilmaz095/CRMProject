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
    public class UnitManager : IUnitService
    {
        IUnitDal _unitDal;
        public UnitManager(IUnitDal unitDal)
        {
            _unitDal = unitDal;
        }

        [Validation(typeof(UnitValidator))]
        public async Task<IResult> Add(Unit data)
        {
            await _unitDal.Insert(data);
            return new SuccessResult("Birim Eklendi.", data.UnitId);
        }

        public async Task<IResultData<List<Unit>>> GetAllList()
        {
            var data = await _unitDal.GetAllList();
            return new SuccessResultData<List<Unit>>(data);
        }

        public async Task<IResultData<Unit>> GetById(Guid Id)
        {
            return new SuccessResultData<Unit>(await _unitDal.Get(p => p.UnitId == Id));
        }

        public async Task<IResult> Remove(Unit data)
        {
            await _unitDal.Delete(data);
            return new SuccessResult("Birim Silindi.", data.UnitId);
        }

        [Validation(typeof(UnitValidator))]
        public async Task<IResult> Update(Unit data)
        {
            await _unitDal.Update(data);
            return new SuccessResult("Birim Güncellendi.", data.UnitId);
        }
    }
}
