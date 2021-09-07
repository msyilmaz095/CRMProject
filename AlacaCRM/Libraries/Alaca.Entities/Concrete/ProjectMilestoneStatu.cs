using Alaca.Core.Entities;

#nullable disable

namespace Alaca.Entities.Concrete
{
    public partial class ProjectMilestoneStatu : IEntity
    {
        public byte ProjectMilestoneStatuId { get; set; }
        public string ProjectMilestoneStatuName { get; set; }
        public bool IsActive { get; set; }
    }
}
