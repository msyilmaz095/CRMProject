using Alaca.Core.Entities;
using System;

#nullable disable

namespace Alaca.Entities.Concrete
{
    public partial class Customer : IEntity
    {
        public Guid CustomerId { get; set; }
        public Guid? CustomerTypeId { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string CustomerTitle { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Fax { get; set; }
        public string WebSite { get; set; }
        public string Email { get; set; }
        public Guid? CustomerRelationId { get; set; }
        public string TaxAdministration { get; set; }
        public string TaxNumber { get; set; }
        public string IbanNo1 { get; set; }
        public string IbanNo2 { get; set; }
        public string Explanation { get; set; }
        public string CustomField1 { get; set; }
        public string CustomField2 { get; set; }
        public string CustomField3 { get; set; }
        public Guid? CustomerStatuId { get; set; }
        public Guid? SectorId { get; set; }
        public Guid? CustomerGroupId { get; set; }
        public bool IsActive { get; set; }
        public Guid? AssignedTo { get; set; }
        public bool IsCandidate { get; set; }
    }
}
