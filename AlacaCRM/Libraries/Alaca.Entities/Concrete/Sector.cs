using Alaca.Core.Entities;
using System;

#nullable disable

namespace Alaca.Entities.Concrete
{
    public partial class Sector : IEntity
    {
        public Guid SectorId { get; set; }
        public string SectorName { get; set; }
        public bool IsActive { get; set; }

    }
}
