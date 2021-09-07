using Alaca.Core.Entities;
using System;
using System.Collections;
using System.Collections.Generic;

#nullable disable

namespace Alaca.Entities.Concrete
{
    public partial class LocationType : IEntity
    {
        public Guid LocationTypeId { get; set; }
        public string LocationTypeName { get; set; }
        public bool IsActive { get; set; }
        public virtual IList<CustomerLocation> CustomerLocations { get; set; }
    }
}
