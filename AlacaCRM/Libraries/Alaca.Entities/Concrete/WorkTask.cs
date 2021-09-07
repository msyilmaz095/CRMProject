using Alaca.Core.Entities;
using System;

#nullable disable

namespace Alaca.Entities.Concrete
{
    public partial class WorkTask : IEntity
    {
        public Guid WorkTaskId { get; set; }
        public string WorkTaskHeader { get; set; }
        public Guid WorkTaskType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public Guid PersonToDo { get; set; }
        public string SpecialCode1 { get; set; }
        public string SpecialCode2 { get; set; }
        public string SpecialCode3 { get; set; }
        public string DocumentType { get; set; }
        public string DocumentSerial { get; set; }
        public int DocumentNumber { get; set; }
        public string CustomerId { get; set; }
        public bool IsActive { get; set; }
        public bool Completed { get; set; }
        public string Description { get; set; }
    }

}
