using Alaca.Core.Entities;

#nullable disable

namespace Alaca.Entities.Concrete
{
    public partial class ProjectMilestoneType : IEntity
    {
        public byte ProjectMilestoneTypeId { get; set; }
        public string ProjectMilestoneTypeName { get; set; }
        public bool IsActive { get; set; }
    }
}
