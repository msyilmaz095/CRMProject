using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Alaca.Core.Utilities.Result;
using Alaca.Crm.Dal.Abstract;
using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;

namespace Alaca.CRM.Service.Concrete
{
    public class ZoneManager : IZoneService
    {
        IZoneDal _zoneDal;
        public ZoneManager(IZoneDal zoneDal)
        {
            _zoneDal = zoneDal;
        }
        public async Task<IResult> Add(Zone data)
        {
            await _zoneDal.Insert(data);
            return new SuccessResult("Bölge Eklendi.", data.ZoneId);
        }

        public async Task<IResultData<List<Zone>>> GetAllList()
        {
            var data = await _zoneDal.GetAllList();
            return new SuccessResultData<List<Zone>>(data);
        }

        public async Task<IResultData<Zone>> GetById(Guid Id)
        {
            return new SuccessResultData<Zone>(await _zoneDal.Get(p => p.ZoneId == Id));
        }

        public async Task<IResult> Remove(Zone data)
        {
            await _zoneDal.Delete(data);
            return new SuccessResult("Bölge Silindi.", data.ZoneId);
        }

        public async Task<IResult> Update(Zone data)
        {
            await _zoneDal.Update(data);
            return new SuccessResult("Bölge Güncellendi.", data.ZoneId);
        }
    }
}
