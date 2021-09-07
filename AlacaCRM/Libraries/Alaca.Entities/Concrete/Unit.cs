using Alaca.Core.Entities;
using System;

#nullable disable

namespace Alaca.Entities.Concrete
{
    public partial class Unit : IEntity
    {
        public Guid UnitId { get; set; }
        public string UnitName { get; set; }
        public string SpecialCode1 { get; set; }
        public string SpecialCode2 { get; set; }
        public string SpecialCode3 { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }

}
