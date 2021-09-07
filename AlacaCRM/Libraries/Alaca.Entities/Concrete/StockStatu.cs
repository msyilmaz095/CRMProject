using Alaca.Core.Entities;
using System;

#nullable disable

namespace Alaca.Entities.Concrete
{
    public partial class StockStatu : IEntity
    {
        public Guid StockStatuId { get; set; }
        public string StockStatuName { get; set; }
        public bool IsActive { get; set; }
    }

}
