using Alaca.Core.Entities;
using System;
using System.Collections;
using System.Collections.Generic;

#nullable disable

namespace Alaca.Entities.Concrete
{
    public partial class CustomerLocation : IEntity
    {
        public Guid CustomerLocationId { get; set; }
        public string CustomerLocationName { get; set; }
        public Guid? CustomerId { get; set; }
        public Guid? LocationTypeId { get; set; }
        public Guid? ZoneId { get; set; }
        public Guid? CityId { get; set; }
        public Guid? DistrictId { get; set; }
        public string Address { get; set; }
        public bool IsMainAddress { get; set; }
        public bool IsActive { get; set; }
        public virtual City City { get; set; }
        public virtual District District { get; set; }
        public virtual Zone Zone { get; set; }
        public virtual LocationType LocationType { get; set; }
        public virtual  IList<CustomerLocation> CustomerLocations { get; set; }
    }
}
