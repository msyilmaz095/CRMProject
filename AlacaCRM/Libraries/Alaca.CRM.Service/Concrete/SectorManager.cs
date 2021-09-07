using Alaca.Core.Utilities.Result;
using Alaca.Crm.Dal.Abstract;
using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alaca.CRM.Service.Concrete
{
    public class SectorManager : ISectorService
    {
        ISectorDal _sectorDal;
        public SectorManager(ISectorDal sectorDal)
        {
            _sectorDal = sectorDal;
        }
        public async Task<IResult> Add(Sector data)
        {
            await _sectorDal.Insert(data);
            return new SuccessResult("Sektör Eklendi.", data.SectorId);
        }

        public async Task<IResultData<List<Sector>>> GetAllList()
        {
            return new SuccessResultData<List<Sector>>(await _sectorDal.GetAllList());
        }

        public async Task<IResultData<Sector>> GetById(Guid Id)
        {
            return new SuccessResultData<Sector>(await _sectorDal.Get(p => p.SectorId == Id));
        }

        public async Task<IResult> Remove(Sector data)
        {
            await _sectorDal.Delete(data);
            return new SuccessResult("Sektör Silindi.", data.SectorId);
        }

        public async Task<IResult> Update(Sector data)
        {
            await _sectorDal.Update(data);
            return new SuccessResult("Sektör Güncellendi.", data.SectorId);
        }
    }
}
