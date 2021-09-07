using System;
using System.Collections.Generic;

#nullable disable

namespace Alaca.Entities.Concrete
{
    public partial class LocaleStringResource
    {
        public Guid Id { get; set; }
        public Guid LanguageId { get; set; }
        public string ResourceName { get; set; }
        public string ResourceValue { get; set; }
    }
}
