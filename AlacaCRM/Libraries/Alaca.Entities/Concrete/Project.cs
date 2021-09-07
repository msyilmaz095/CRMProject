using Alaca.Core.Entities;
using System;

namespace Alaca.Entities.Concrete
{
    public class Project : IEntity
    {
        public Guid ProjectId { get; set; }
        public DateTime? ProjectDate { get; set; }
        public string ProjectNumber { get; set; }
        public Guid CustomerId { get; set; }
        public Guid? CustomerContactId { get; set; }
        public Guid? AssignedTo { get; set; }
        public DateTime? ProjectStartDate { get; set; }
        public DateTime? ProjectFinishDate { get; set; }
        public string ProjectTitle { get; set; }
        public string ProjectDescription { get; set; }
        public Guid? CurrencyId { get; set; }
        public double? CurrencyValue { get; set; }
        public Guid? PaymentMethodId { get; set; }
        public byte? ProjectStatuId { get; set; }
        [System.ComponentModel.DefaultValue(true)]
        public bool IsActive { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
