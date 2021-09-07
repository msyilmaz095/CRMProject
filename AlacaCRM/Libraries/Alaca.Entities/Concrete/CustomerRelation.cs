using Alaca.Core.Entities;
using System;

#nullable disable

namespace Alaca.Entities.Concrete
{
    public partial class CustomerRelation : IEntity
    {
        public Guid CustomerRelationId { get; set; }
        public string CustomerRelationName { get; set; }
        public bool IsActive { get; set; }
    }
}
