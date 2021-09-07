using Alaca.Core.Entities;
using System;

#nullable disable

namespace Alaca.Entities.Concrete
{
    public partial class Contact : IEntity
    {
        public Guid ContactId { get; set; }
        public Guid? ContactTypeId { get; set; }
        public Guid? CustomerId { get; set; }
        public Guid? CustomerLocationId { get; set; }
        public string Name { get; set; }
        public string SureName { get; set; }
        public Guid? DepartmentId { get; set; }
        public Guid? PositionId { get; set; }
        public string Email { get; set; }
        public string MobilePhoneNumber { get; set; }
        public string OfficePhoneNumber { get; set; }
        public string OfficePhoneNumberInternalCode { get; set; }
        public DateTime? BirthDay { get; set; }
        public string Explanation { get; set; }
        public Guid? ContactStatuId { get; set; }
        public virtual ContactType ContactType { get; set; }
        public virtual ContactStatu ContactStatu { get; set; }
        public virtual Department Department { get; set; }
        public virtual Position Position { get; set; }
        public virtual CustomerLocation CustomerLocation { get; set; }
    }
}
