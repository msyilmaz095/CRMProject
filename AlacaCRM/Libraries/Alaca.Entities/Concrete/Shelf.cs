using Alaca.Core.Entities;
using System;

#nullable disable

namespace Alaca.Entities.Concrete
{
    public partial class Shelf : IEntity
    {
        public Guid ShelfId { get; set; }
        public string ShelfName { get; set; }
        public Guid ShelfStoreId { get; set; }
        public string Description { get; set; }
        public string SpecialCode1 { get; set; }
        public string SpecialCode2 { get; set; }
        public string SpecialCode3 { get; set; }
        public bool IsActive { get; set; }
    }
    public partial class Transfer : IEntity
    {
        public Guid TransferId { get; set; }
        public string SpecialCode1 { get; set; }
        public string SpecialCode2 { get; set; }
        public string SpecialCode3 { get; set; }
        public string IncomingType { get; set; }
        public string IncomingCode { get; set; }
        public string OutgoingType { get; set; }
        public string OutgoingCode { get; set; }
        public Guid TransferWorkTaskId { get; set; }
        public string Description { get; set; }
    }
    public partial class TransferLine : IEntity
    {
        public Guid TransferLineId { get; set; }
        public string SpecialCode1 { get; set; }
        public string SpecialCode2 { get; set; }
        public string SpecialCode3 { get; set; }
        public string StockCode { get; set; }
        public float Amount { get; set; }
        public Guid TransferId { get; set; }
        public string Description { get; set; }
    }
}
