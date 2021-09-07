using Alaca.Core.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;


namespace Alaca.Entities.Concrete
{
    public partial class SalesOfferLine : IEntity
    {
        public Guid SaleOfferLineId { get; set; }
        public Guid? SaleOfferId { get; set; }
        public Guid? StockId { get; set; }
        public Guid? StockUnitId { get; set; }
        public Guid? CurrencyId { get; set; }
        public byte LineType { get; set; }
        public double CurrencyValue { get; set; }
        public double TaxRate { get; set; }
        public double Amount { get; set; }
        public double Price { get; set; }
        public double Total { get; set; }
        public double TaxTotal { get; set; }
        public double DiscountRate { get; set; }
        public double DiscountAmount { get; set; }
        public double DiscountTotal { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    public partial class SalesOfferLine
    {
        private byte? _CRUDOperation;

        [NotMapped]
        [System.ComponentModel.DefaultValue(2)]
        public byte? CRUDOperation
        {
            get
            {
                return _CRUDOperation == null ? 2 : _CRUDOperation;
            }
            set
            {
                _CRUDOperation = value;
            }
        }
    }
}
