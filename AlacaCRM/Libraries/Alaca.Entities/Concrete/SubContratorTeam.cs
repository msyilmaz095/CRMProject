using Alaca.Core.Entities;
using System;

#nullable disable

namespace Alaca.Entities.Concrete
{
    public partial class SubContratorTeam : IEntity
    {
        public Guid SubContratorTeamId { get; set; }
        public string SubcontratorTeamName { get; set; }
        public Guid CustomerId { get; set; }
        public Guid? CityId { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
