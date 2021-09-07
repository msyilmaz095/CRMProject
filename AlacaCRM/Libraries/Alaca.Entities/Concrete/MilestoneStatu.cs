using Alaca.Core.Entities;
using System;

#nullable disable

namespace Alaca.Entities.Concrete
{
    public partial class MilestoneStatu : IEntity
    {
        public Guid MilestoneStatuId { get; set; }
        public string MilestoneStatuName { get; set; }
        public bool IsActive { get; set; }
    }
}
