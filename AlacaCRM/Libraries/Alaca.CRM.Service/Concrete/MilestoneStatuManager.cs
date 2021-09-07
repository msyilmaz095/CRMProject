using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Alaca.Core.Utilities.Result;
using Alaca.Crm.Dal.Abstract;
using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;

namespace Alaca.CRM.Service.Concrete
{
    public class MilestoneStatuManager : IMilestoneStatuService
    {
        IMilestoneStatuDal _milestoneStatuDal;
        public MilestoneStatuManager(IMilestoneStatuDal MilestoneStatuDal)
        {
            _milestoneStatuDal = MilestoneStatuDal;
        }
        public async Task<IResult> Add(MilestoneStatu data)
        {
            await _milestoneStatuDal.Insert(data);
            return new SuccessResult(data.MilestoneStatuId);
        }

        public async Task<IResultData<List<MilestoneStatu>>> GetAllList()
        {
            var data = await _milestoneStatuDal.GetAllList();
            return new SuccessResultData<List<MilestoneStatu>>(data);
        }

        public async Task<IResultData<MilestoneStatu>> GetById(Guid Id)
        {
            return new SuccessResultData<MilestoneStatu>(await _milestoneStatuDal.Get(p => p.MilestoneStatuId == Id));
        }

        public async Task<IResult> Remove(MilestoneStatu data)
        {
            await _milestoneStatuDal.Delete(data);
            return new SuccessResult(data.MilestoneStatuId);
        }

        public async Task<IResult> Update(MilestoneStatu data)
        {
            await _milestoneStatuDal.Update(data);
            return new SuccessResult(data.MilestoneStatuId);
        }
    }
}
