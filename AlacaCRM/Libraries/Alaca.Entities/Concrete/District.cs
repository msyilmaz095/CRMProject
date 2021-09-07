using Alaca.Core.Entities;
using System;
using System.Collections.Generic;

#nullable disable

namespace Alaca.Entities.Concrete
{
    public partial class District : IEntity
    {
        public Guid Districtd { get; set; }
        public string DistrictName { get; set; }
        public Guid? CityId { get; set; }
        public bool IsActive { get; set; }
        public virtual City City { get; set; }
        public virtual List<CustomerLocation> CustomerLocations { get; set; }

    }
}
