using Alaca.Core.Entities;
using System;

#nullable disable

namespace Alaca.Entities.Concrete
{
    public partial class StockBrand : IEntity
    {
        public Guid StockBrandId { get; set; }
        public string StockBrandCode { get; set; }
        public string StockBrandName { get; set; }
        public bool IsActive { get; set; }
    }

}
