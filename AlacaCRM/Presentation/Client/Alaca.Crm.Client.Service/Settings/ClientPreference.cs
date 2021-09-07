using Alaca.Core.Utilities.Localization;
using Alaca.Core.Utilities.Manager;
using Alaca.Crm.Client.Service.Manager;
using System.Linq;

namespace Alaca.Crm.Client.Service.Settings
{
    public record ClientPreference : IPreference
    {
        public bool IsDarkMode { get; set; }
        public bool IsRTL { get; set; }
        public bool IsDrawerOpen { get; set; }
        public string PrimaryColor { get; set; }
        public string LanguageCode { get; set; } = LocalizationConstants.SupportedLanguages.FirstOrDefault()?.Code ?? "tr-TR";
    }
}