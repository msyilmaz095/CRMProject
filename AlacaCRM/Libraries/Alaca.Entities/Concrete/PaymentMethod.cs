using Alaca.Core.Entities;
using System;

#nullable disable

namespace Alaca.Entities.Concrete
{
    public class PaymentMethod : IEntity
    {
        public Guid PaymentMethodId { get; set; }
        public string PaymentMethodCode { get; set; }
        public string PaymentMethodName { get; set; }
        public bool IsActive { get; set; }
    }
}
