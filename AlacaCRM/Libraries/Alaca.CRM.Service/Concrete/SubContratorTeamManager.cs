using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Alaca.Core.Utilities.Result;
using Alaca.Crm.Dal.Abstract;
using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;

namespace Alaca.CRM.Service.Concrete
{
    public class SubContratorTeamManager : ISubContratorTeamService
    {
        ISubContratorTeamDal _subContratorTeamDal;
        public SubContratorTeamManager(ISubContratorTeamDal SubContratorTeamDal)
        {
            _subContratorTeamDal = SubContratorTeamDal;
        }
        public async Task<IResult> Add(SubContratorTeam data)
        {
            await _subContratorTeamDal.Insert(data);
            return new SuccessResult(data.SubContratorTeamId);
        }

        public async Task<IResultData<List<SubContratorTeam>>> GetAllList()
        {
            var data = await _subContratorTeamDal.GetAllList();
            return new SuccessResultData<List<SubContratorTeam>>(data);
        }

        public async Task<IResultData<List<SubContratorTeam>>> GetByCustomerIdSubContratorTeam(Guid CustomerId)
        {
            var data = await _subContratorTeamDal.GetWhere(p => p.CustomerId == CustomerId);
            return new SuccessResultData<List<SubContratorTeam>>(data);
        }

        public async Task<IResultData<SubContratorTeam>> GetById(Guid Id)
        {
            return new SuccessResultData<SubContratorTeam>(await _subContratorTeamDal.Get(p => p.SubContratorTeamId == Id));
        }

        public async Task<IResult> Remove(SubContratorTeam data)
        {
            await _subContratorTeamDal.Delete(data);
            return new SuccessResult(data.SubContratorTeamId);
        }

        public async Task<IResult> Update(SubContratorTeam data)
        {
            await _subContratorTeamDal.Update(data);
            return new SuccessResult(data.SubContratorTeamId);
        }
    }
}
