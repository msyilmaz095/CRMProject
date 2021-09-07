using Alaca.Core.Entities;
using System;

#nullable disable

namespace Alaca.Entities.Concrete
{
    public partial class StockGroup : IEntity
    {
        public Guid StockGroupId { get; set; }
        public Guid StockGroupMainId { get; set; }
        public string StockGroupCode { get; set; }
        public string StockGroupName { get; set; }
        public bool IsActive { get; set; }
    }

}
