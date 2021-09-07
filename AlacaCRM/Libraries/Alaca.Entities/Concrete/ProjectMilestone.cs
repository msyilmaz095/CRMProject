using Alaca.Core.Entities;
using System;

#nullable disable

namespace Alaca.Entities.Concrete
{
    public partial class ProjectMilestone : IEntity
    {
        public Guid ProjectMilestoneId { get; set; }
        public string ProjectMilestoneName { get; set; }
        public byte? ProjectMilestoneStatuId { get; set; }
        public byte? ProjectMilestoneTypeId { get; set; }
        public Guid? ProjectId { get; set; }
        public Guid? AssignedTo { get; set; }
        public Guid? SubContratorId { get; set; }
        public Guid? SubcontratorTeamId { get; set; }
        public DateTime? MilestoneTargetStartDate { get; set; }
        public DateTime? MilestoneTargetFinishDate { get; set; }
        public DateTime? MilestoneActualStartDate { get; set; }
        public DateTime? MilestoneActualFinishDate { get; set; }
        public string Description { get; set; }
    }
}
