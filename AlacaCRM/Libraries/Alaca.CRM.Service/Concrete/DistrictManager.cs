using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Alaca.Core.Utilities.Result;
using Alaca.Crm.Dal.Abstract;
using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;

namespace Alaca.CRM.Service.Concrete
{
    public class DistrictManager : IDistrictService
    {
        IDistrictDal _districtDal;
        public DistrictManager(IDistrictDal districtDal)
        {
            _districtDal = districtDal;
        }

        public async Task<IResult> Add(District data)
        {
            await _districtDal.Insert(data);
            return new SuccessResult("İlçe Eklendi.", data.Districtd);
        }

        public async Task<IResultData<List<District>>> GetAllList()
        {
            var data = await _districtDal.GetAllList();
            return new SuccessResultData<List<District>>(data);
        }

        public async Task<IResultData<District>> GetById(Guid Id)
        {
            return new SuccessResultData<District>(await _districtDal.Get(p => p.Districtd == Id));
        }

        public async Task<IResult> Remove(District data)
        {
            await _districtDal.Delete(data);
            return new SuccessResult("İlçe Silindi.", data.Districtd);
        }

        public async Task<IResult> Update(District data)
        {
            await _districtDal.Update(data);
            return new SuccessResult("İlçe Güncellendi.", data.Districtd);
        }
    }
}
