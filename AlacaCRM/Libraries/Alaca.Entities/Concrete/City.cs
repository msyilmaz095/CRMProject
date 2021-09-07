using Alaca.Core.Entities;
using System;
using System.Collections.Generic;

#nullable disable

namespace Alaca.Entities.Concrete
{
    public partial class City : IEntity
    {
        public Guid CityId { get; set; }
        public string CityCode { get; set; }
        public string CityName { get; set; }
        public bool IsActive { get; set; }
        public virtual List<District> Districts { get; set; }
        public virtual List<CustomerLocation> CustomerLocations { get; set; }
    }
}
