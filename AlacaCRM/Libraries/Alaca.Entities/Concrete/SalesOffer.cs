using Alaca.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alaca.Entities.Concrete
{
    public class SalesOffer : IEntity
    {
        public Guid SalesOfferId { get; set; }
        public DateTime? SalesOfferDate { get; set; }
        public string SalesOfferNumber { get; set; }
        public Guid? ProjectId { get; set; }
        public Guid CustomerId { get; set; }
        public Guid? CustomerContactId { get; set; }
        public Guid? AssignedTo { get; set; }
        public DateTime? SalesOfferFinishDate { get; set; }
        public string Description { get; set; }
        public Guid? CurrencyId { get; set; }
        public double? CurrencyValue { get; set; }
        public Guid? PaymentMethodId { get; set; }
        public byte? SalesOfferStatuId { get; set; }
        public double SalesOfferTotal { get; set; }
        public double SalesOfferTaxTotal { get; set; }
        [System.ComponentModel.DefaultValue(true)]
        public bool IsActive { get; set; }
        [System.ComponentModel.DefaultValue(true)]
        public bool IsSelectedOffer { get; set; }

        [System.ComponentModel.DefaultValue(1)]
        public short ReviseNumber { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
