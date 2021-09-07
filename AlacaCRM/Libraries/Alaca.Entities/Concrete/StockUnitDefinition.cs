using Alaca.Core.Entities;
using System;

#nullable disable

namespace Alaca.Entities.Concrete
{
    public partial class StockUnitDefinition : IEntity
    {
        public Guid StockUnitDefinitionId { get; set; }
        public string StockUnitDefinitionCode { get; set; }
        public string StockUnitDefinitionName { get; set; }
        public bool IsActive { get; set; }
    }

}
