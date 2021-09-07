using Alaca.Core.Utilities.Manager;
using MudBlazor;
using System.Threading.Tasks;

namespace Alaca.Crm.Client.Service.Manager
{
    public interface IClientPreferenceManager : IPreferenceManager
    {
        Task<MudTheme> GetCurrentThemeAsync();

        Task<bool> ToggleDarkModeAsync();
    }
}
