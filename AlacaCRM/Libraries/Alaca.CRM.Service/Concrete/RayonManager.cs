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
    public class RayonManager : IRayonService
    {
        IRayonDal _rayonDal;
        public RayonManager(IRayonDal rayonDal)
        {
            _rayonDal = rayonDal;
        }
        public async Task<IResult> Add(Rayon data)
        {
            await _rayonDal.Insert(data);
            return new SuccessResult("Reyon Eklendi.", data.RayonId);
        }

        public async Task<IResultData<List<Rayon>>> GetAllList()
        {
            var data = await _rayonDal.GetAllList();
            return new SuccessResultData<List<Rayon>>(data);
        }

        public async Task<IResultData<Rayon>> GetById(Guid Id)
        {
            return new SuccessResultData<Rayon>(await _rayonDal.Get(p => p.RayonId == Id));
        }

        public async Task<IResult> Remove(Rayon data)
        {
            await _rayonDal.Delete(data);
            return new SuccessResult("Reyon Silindi.", data.RayonId);
        }

        public async Task<IResult> Update(Rayon data)
        {
            await _rayonDal.Update(data);
            return new SuccessResult("Reyon Güncellendi.", data.RayonId);
        }
    }
}