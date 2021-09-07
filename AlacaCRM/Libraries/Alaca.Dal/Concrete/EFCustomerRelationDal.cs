﻿using Alaca.Core.DataAccess.EntityFramework;
using Alaca.Crm.Dal.Abstract;
using Alaca.Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Alaca.Crm.Dal.Concrete
{
    public class EFCustomerRelationDal : EFEntityRepository<CustomerRelation, Alaca_CRMContext>, ICustomerRelationDal
    {
        public EFCustomerRelationDal(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
        }
    }
}
