using Alaca.Core.Entities;
using System;

#nullable disable

namespace Alaca.Entities.Concrete
{
    public partial class Store : IEntity
    {
        public Guid StoreId { get; set; }
        public string StoreName { get; set; }
        public string StoreCode { get; set; }
        public Guid StoreFactoryId { get; set; }
        public string Description { get; set; }
        public string SpecialCode1 { get; set; }
        public string SpecialCode2 { get; set; }
        public string SpecialCode3 { get; set; }
        public bool IsActive { get; set; }
    }
}
