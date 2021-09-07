using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Alaca.Core.Utilities.Result;
using Alaca.Crm.Dal.Abstract;
using Alaca.CRM.Service.Abstract;
using Alaca.Entities.Concrete;

namespace Alaca.CRM.Service.Concrete
{
    public class CompanyManager : ICompanyService
    {
        ICompanyDal _companyDal;
        public CompanyManager(ICompanyDal companyDal)
        {
            _companyDal = companyDal;
        }
        public async Task<IResult> Add(Company data)
        {
            await _companyDal.Insert(data);
            return new SuccessResult();
        }

        public async Task<IResultData<List<Company>>> GetAllList()
        {
            var data = await _companyDal.GetAllList();
            return new SuccessResultData<List<Company>>(data);
        }

        public async Task<IResultData<Company>> GetById(Guid Id)
        {
            return new SuccessResultData<Company>(await _companyDal.Get(p => p.CompanyId == Id));
        }

        public async Task<IResult> Remove(Company data)
        {
            await _companyDal.Delete(data);
            return new SuccessResult();
        }

        public async Task<IResult> Update(Company data)
        {
            await _companyDal.Update(data);
            return new SuccessResult();
        }
    }
}
