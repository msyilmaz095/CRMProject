using Alaca.Core.Entities;
using System;

#nullable disable

namespace Alaca.Entities.Concrete
{
    public partial class CustomerGroup : IEntity
    {
        public Guid CustomerGroupId { get; set; }
        public string CustomerGroupName { get; set; }
        public bool IsActive { get; set; }
    }
}
