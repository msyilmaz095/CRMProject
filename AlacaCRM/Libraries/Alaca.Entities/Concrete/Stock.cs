using Alaca.Core.Entities;
using FluentValidation;
using System;

#nullable disable

namespace Alaca.Entities.Concrete
{
    public partial class Stock : IEntity
    {
        public Guid StockId { get; set; }
        public string StockCode { get; set; }
        public string StockName { get; set; }
        public string Description { get; set; }
        public string SpecialCode1 { get; set; }
        public string SpecialCode2 { get; set; }
        public string SpecialCode3 { get; set; }
        public double? MinStockLevel { get; set; }
        public double? MaxStockLevel { get; set; }
        public Guid? StockGroupId { get; set; }
        public Guid? StockRayonId { get; set; }
        public Guid? StockBrandId { get; set; }
        public Guid? StockStatuId { get; set; }
        public short? ShelfLife { get; set; }
        public byte? ShelfLifeType { get; set; }
        public string Origin { get; set; }
        public Guid? PaymentMethodId { get; set; }
        public bool IsActive { get; set; }
    }


}
