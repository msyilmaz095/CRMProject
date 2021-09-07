using Alaca.Core.Entities;
using System;

#nullable disable

namespace Alaca.Entities.Concrete
{
    public partial class Factory : IEntity
    {
        public Guid FactoryId { get; set; }
        public string FactoryName { get; set; }
        public string FactoryCity { get; set; }
        public string FactoryZone { get; set; }
        public string Description { get; set; }
        public string SpecialCode1 { get; set; }
        public string SpecialCode2 { get; set; }
        public string SpecialCode3 { get; set; }
        public bool IsActive { get; set; }
    }

}
