using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alaca.Core.Utilities.Result;
using Alaca.Crm.Dal.Abstract;
using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;

namespace Alaca.CRM.Service.Concrete
{
    public class CityManager : ICityService
    {
        ICityDal _cityDal;
        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }
        public async Task<IResult> Add(City data)
        {
            await _cityDal.Insert(data);
            return new SuccessResult("Şehir Eklendi.",data.CityId);
        }

        public async Task<IResultData<List<City>>> GetAllList()
        {
            var data = await _cityDal.GetAllList();
            return new SuccessResultData<List<City>>(data);
        }

        public async Task<IResultData<City>> GetById(Guid Id)
        {
            return new SuccessResultData<City>(await _cityDal.Get(p => p.CityId == Id));
        }

        public async Task<IResult> Remove(City data)
        {
            await _cityDal.Delete(data);
            return new SuccessResult("Şehir Silindi.", data.CityId);
        }

        public async Task<IResult> Update(City data)
        {
            await _cityDal.Update(data);
            return new SuccessResult("Şehir Güncellendi.", data.CityId);
        }
    }
}
