using Alaca.Core.Entities;
using System;
using System.Collections.Generic;

#nullable disable

namespace Alaca.Entities.Concrete
{
    public partial class CurrencyValue : IEntity
    {
        public Guid CurrencyValuesId { get; set; }
        public Guid? CurrencyId { get; set; }
        public decimal? Parity { get; set; }
        public DateTime? Date { get; set; }
    }
}
