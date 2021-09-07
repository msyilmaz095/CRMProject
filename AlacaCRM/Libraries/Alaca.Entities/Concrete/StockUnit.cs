using Alaca.Core.Entities;
using System;

#nullable disable

namespace Alaca.Entities.Concrete
{
    public partial class StockUnit : IEntity
    {
        public Guid StockUnitId { get; set; }
        public Guid StockId { get; set; }
        public Guid? StockUnitDefinitionId { get; set; }
        public string StockUnitName { get; set; }
        public string SpecialCode1 { get; set; }
        public string SpecialCode2 { get; set; }
        public string SpecialCode3 { get; set; }
        public double? Length { get; set; }
        public double? Mass { get; set; }
        public double? Height { get; set; }
        public double? Weight { get; set; }
        public double? Width { get; set; }
        public double? Multiplier { get; set; }
    }
}
