using Alaca.Core.Entities;
using System;
using System.Collections.Generic;

#nullable disable

namespace Alaca.Entities.Concrete
{
    public partial class ContactType : IEntity
    {
        public Guid ContactTypeId { get; set; }
        public string ContactTypeName { get; set; }
        public bool IsActive { get; set; }
        public virtual IList<Contact> Contacts { get; set; }
    }
}
