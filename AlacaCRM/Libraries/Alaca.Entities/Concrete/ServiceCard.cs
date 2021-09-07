using Alaca.Core.Entities;
using System;

#nullable disable

namespace Alaca.Entities.Concrete
{
    public partial class ServiceCard : IEntity
    {
        public Guid ServiceCardId { get; set; }
        public string ServiceCardCode { get; set; }
        public string ServiceCardName { get; set; }
        public string Description { get; set; }
        public string SpecialCode1 { get; set; }
        public string SpecialCode2 { get; set; }
        public string SpecialCode3 { get; set; }
        public bool IsActive { get; set; }
    }
}
