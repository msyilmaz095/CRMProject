using Alaca.Core.Entities;
using System;

#nullable disable

namespace Alaca.Entities.Concrete
{
    public partial class CustomerStatu : IEntity
    {
        public Guid CustomerStatusId { get; set; }
        public string CustomerStatusName { get; set; }
        public bool IsActive { get; set; }
    }
}
