using Alaca.Core.Entities;
using System;
using System.Collections.Generic;

#nullable disable

namespace Alaca.Entities.Concrete
{
    public partial class Zone : IEntity
    {
        public Guid ZoneId { get; set; }
        public string ZoneName { get; set; }
        public bool IsActive { get; set; }
        public virtual List<CustomerLocation> CustomerLocations { get; set; }
    }
}
