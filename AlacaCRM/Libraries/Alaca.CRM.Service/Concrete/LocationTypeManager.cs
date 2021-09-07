using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Alaca.Core.Utilities.Result;
using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;
using Alaca.Crm.Dal.Abstract;

namespace Alaca.CRM.Service.Concrete
{
    public class LocationTypeManager : ILocationTypeService
    {
        ILocationTypeDal _locationTypeDal;
        public LocationTypeManager(ILocationTypeDal locationTypeDal)
        {
            _locationTypeDal = locationTypeDal;
        }
        public async Task<IResult> Add(LocationType data)
        {
            await _locationTypeDal.Insert(data);
            return new SuccessResult("Lokasyon Türü Eklendi.", data.LocationTypeId);
        }

        public async Task<IResultData<List<LocationType>>> GetAllList()
        {
            var data = await _locationTypeDal.GetAllList();
            return new SuccessResultData<List<LocationType>>(data);
        }

        public async Task<IResultData<LocationType>> GetById(Guid Id)
        {
            return new SuccessResultData<LocationType>(await _locationTypeDal.Get(p => p.LocationTypeId == Id));
        }

        public async Task<IResult> Remove(LocationType data)
        {
            await _locationTypeDal.Delete(data);
            return new SuccessResult("Lokasyon Türü Silindi.", data.LocationTypeId);
        }

        public async Task<IResult> Update(LocationType data)
        {
            await _locationTypeDal.Update(data);
            return new SuccessResult("Lokasyon Türü Güncellendi.", data.LocationTypeId);
        }
    }
}
