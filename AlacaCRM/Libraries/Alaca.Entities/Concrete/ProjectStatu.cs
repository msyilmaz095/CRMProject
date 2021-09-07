using Alaca.Core.Entities;
using System;

#nullable disable

namespace Alaca.Entities.Concrete
{
    public partial class ProjectStatu : IEntity
    {
        public byte ProjectStatuId { get; set; }
        public string ProjectStatuName { get; set; }
        public bool IsActive { get; set; }
    }
}
