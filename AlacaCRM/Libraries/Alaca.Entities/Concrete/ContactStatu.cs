using Alaca.Core.Entities;
using System;
using System.Collections.Generic;

#nullable disable

namespace Alaca.Entities.Concrete
{
    public partial class ContactStatu : IEntity
    {
        public Guid ContactStatuId { get; set; }
        public string ContactStatuName { get; set; }
        public bool IsActive { get; set; }
        public virtual IList<Contact> Contacts { get; set; }
    }
}
