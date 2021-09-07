using Alaca.Entities.Concrete;

namespace Alaca.Entities.Dto
{
    public class viewProjectMilestone : ProjectMilestone
    {
        public string ProjectMilestoneStatuName { get; set; }
        public string ProjectMilestoneTypeName { get; set; }
        public string AssignedToName { get; set; }
        public string SubContratorName { get; set; }
        public string SubContratorTeamName { get; set; }
    }
}
