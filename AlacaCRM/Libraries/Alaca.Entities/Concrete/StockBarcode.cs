using Alaca.Core.Entities;
using System;

#nullable disable

namespace Alaca.Entities.Concrete
{
    public partial class StockBarcode : IEntity
    {
        public Guid StockBarcodeId { get; set; }
        public Guid StockId { get; set; }
        public string StockBarcodeName { get; set; }
        public string Barcode { get; set; }
        public string PartyCode { get; set; }
        public string LotNumber { get; set; }
        public Guid? StockUnitId { get; set; }
    }
}
