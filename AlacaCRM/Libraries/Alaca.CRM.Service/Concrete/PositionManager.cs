using Alaca.Core.Utilities.Result;
using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alaca.Crm.Dal.Abstract;

namespace Alaca.CRM.Service.Concrete
{
    public class PositionManager : IPositionService
    {
        IPositionDal _positionDal;
        public PositionManager(IPositionDal positionDal)
        {
            _positionDal = positionDal;
        }
        public async Task<IResult> Add(Position data)
        {
            await _positionDal.Insert(data);
            return new SuccessResult("Posizyon Eklendi.");
        }

        public async Task<IResultData<List<Position>>> GetAllList()
        {
            var data = await _positionDal.GetAllList();
            return new SuccessResultData<List<Position>>(data);
        }

        public async Task<IResultData<Position>> GetById(Guid Id)
        {
            return new SuccessResultData<Position>(await _positionDal.Get(p => p.PositionId == Id));
        }

        public async Task<IResult> Remove(Position data)
        {
            await _positionDal.Delete(data);
            return new SuccessResult("Posizyon Silindi.");
        }

        public async Task<IResult> Update(Position data)
        {
            await _positionDal.Update(data);
            return new SuccessResult("Posizyon Güncellendi.");
        }
    }
}
