using Alaca.Core.Entities;
using System;

#nullable disable

namespace Alaca.Entities.Concrete
{
    public partial class ActivityType : IEntity
    {
        public Guid ActivityTypeId { get; set; }
        public string ActivityTypeName { get; set; }
        public byte? IsCustomerExist { get; set; }
        public byte? IsContactExist { get; set; }
        public byte? IsProjectExist { get; set; }
        public byte? IsEmployeeExist { get; set; }
        public byte? IsLocationExist { get; set; }
        public bool IsActive { get; set; }
    }

}
