using Alaca.Core.Entities;
using System;

#nullable disable

namespace Alaca.Entities.Concrete
{
    public partial class Activity : IEntity
    {
        public Guid ActivityId { get; set; }
        public Guid? ActivityTypeId { get; set; }
        public Guid? EmployeeId { get; set; }
        public Guid? CustomerId { get; set; }
        public Guid? ContactId { get; set; }
        public Guid? ProjectId { get; set; }
        public Guid? AssignedTo { get; set; }
        public DateTime? ActivityDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? FinishDate { get; set; }
        public string Location { get; set; }
        public DateTime? NextActivityDate { get; set; }
        public string Explanation { get; set; }
        public string Subject { get; set; }
    }
}
