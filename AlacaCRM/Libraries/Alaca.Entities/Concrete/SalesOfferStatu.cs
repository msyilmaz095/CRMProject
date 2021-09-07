using Alaca.Core.Entities;

namespace Alaca.Entities.Concrete
{
    public class SalesOfferStatu : IEntity
    {
        public byte SalesOfferStatuId { get; set; }
        public string SalesOfferStatuName { get; set; }
        public bool IsActive { get; set; }
    }
}
