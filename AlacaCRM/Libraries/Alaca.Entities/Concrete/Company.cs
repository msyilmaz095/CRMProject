using Alaca.Core.Entities;
using System;
using System.Collections.Generic;

#nullable disable

namespace Alaca.Entities.Concrete
{
    public partial class Company : IEntity
    {
        public Guid CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string ConnectionString { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
