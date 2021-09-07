using Alaca.Core.Entities;
using System;
using System.Collections.Generic;

#nullable disable

namespace Alaca.Entities.Concrete
{
    public partial class Position : IEntity
    {
        public Guid PositionId { get; set; }
        public string PositionName { get; set; }
        public bool IsActive { get; set; }
        public virtual IList<Contact> Contacts { get; set; }
    }
}
