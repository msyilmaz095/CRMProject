using Alaca.Core.Entities;
using System;

#nullable disable

namespace Alaca.Entities.Concrete
{
    public partial class ExpenseCard : IEntity
    {
        public Guid ExpenseCardId { get; set; }
        public string ExpenseCardCode { get; set; }
        public string ExpenseCardName { get; set; }
        public string Description { get; set; }
        public string SpecialCode1 { get; set; }
        public string SpecialCode2 { get; set; }
        public string SpecialCode3 { get; set; }
        public bool IsActive { get; set; }
    }
}
