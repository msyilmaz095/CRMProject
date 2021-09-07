using Alaca.Core.Entities;
using System;
using System.Collections.Generic;

#nullable disable

namespace Alaca.Entities.Concrete
{
    public partial class EmployeePosition : IEntity
    {
        public Guid EmployeePositionId { get; set; }
        public string EmployeePositionName { get; set; }
        public bool? IsActive { get; set; }
    }
}
