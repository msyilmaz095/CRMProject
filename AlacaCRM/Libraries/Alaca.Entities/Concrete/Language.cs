using System;
using System.Collections.Generic;

#nullable disable

namespace Alaca.Entities.Concrete
{
    public partial class Language
    {
        public Guid LanguageId { get; set; }
        public string LanguageName { get; set; }
        public string LanguageCulture { get; set; }
        public string UniqueSeoCode { get; set; }
        public string FlagImageFileName { get; set; }
        public int? DefaultCurrencyId { get; set; }
        public bool? Published { get; set; }
        public short? DisplayOrder { get; set; }
        public string LanguageStringLocaleCode { get; set; }
    }
}
