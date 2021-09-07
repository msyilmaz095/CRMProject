using Alaca.Core.Entities;
using System;
using System.Collections.Generic;

#nullable disable

namespace Alaca.Entities.Concrete
{
    public partial class Currency : IEntity
    {
        public Guid CurrencyId { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencyCode { get; set; }
        public int? DisplayOrder { get; set; }
        public byte? AmountDecimalPlaces { get; set; }
    }

}
