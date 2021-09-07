using Alaca.Core.Entities;
using System;

#nullable disable

namespace Alaca.Entities.Concrete
{
    public class Rayon : IEntity
    {
        public Guid RayonId { get; set; }
        public string RayonCode { get; set; }
        public string RayonName { get; set; }
        public bool IsActive { get; set; }
    }
}
