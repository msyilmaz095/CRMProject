using Alaca.Core.DataAccess;
using Alaca.Entities.Concrete;
using System.Collections.Generic;
using Alaca.Entities.Dto;
using System.Threading.Tasks;
using System;
using System.Linq.Expressions;

namespace Alaca.Crm.Dal.Abstract
{
    public interface ISalesOfferDal : IEntityRepository<SalesOffer>
    {
        public Task<List<viewSalesOffer>> GetOrderDescTop10viewSalesOffers();
        public Task<List<viewSalesOffer>> GetviewSalesOffers();
        public Task<List<viewSalesOffer>> GetwhereviewSalesOffer(Expression<Func<viewSalesOffer, bool>> Filter = null);
    }
}
