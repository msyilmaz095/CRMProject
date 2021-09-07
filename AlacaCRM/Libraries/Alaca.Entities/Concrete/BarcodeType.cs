using Alaca.Core.Entities;
using System;

#nullable disable

namespace Alaca.Entities.Concrete
{
    public partial class BarcodeType : IEntity
    {
        public int BarcodeTypeId { get; set; }
        public string BarcodeTypeCode { get; set; }
        public string BarcodeTypeName { get; set; }
        public bool IsActive { get; set; }
    }

}
