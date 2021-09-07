using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using MudBlazor.Services;
using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;
using Blazor.AdminLte;
using Alaca.Crm.Client.Extensions;
using Alaca.Crm.Client.Service.Manager;
using System.Globalization;
using Alaca.Core.Utilities.Localization;
using Alaca.Crm.Client.Service.Settings;
using System.Linq;
using Smart.Blazor;

namespace Alaca.Crm.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder
                      .CreateDefault(args)
                      .AddRootComponents()
                      .AddClientServices();
            builder.Services.AddSmart();
            builder.Services.AddFluentValidatorBlazor();
            builder.Services.AddRadzenBlazor();
            builder.Services.AddAdminLte();
            builder.Services.AddBlazorise(options =>
            {
                options.ChangeTextOnKeyPress = true;
            })
    .AddBootstrapProviders()
    .AddFontAwesomeIcons();

            var host = builder.Build();
            var storageService = host.Services.GetRequiredService<ClientPreferenceManager>();
            if (storageService != null)
            {
                CultureInfo culture;
                var preference = await storageService.GetPreference() as ClientPreference;
                if (preference != null)
                    culture = new CultureInfo(preference.LanguageCode);
                else
                    culture = new CultureInfo(LocalizationConstants.SupportedLanguages.FirstOrDefault()?.Code ?? "tr-TR");
                //Console.WriteLine(CultureInfo.DefaultThreadCurrentCulture);
                CultureInfo.DefaultThreadCurrentCulture = culture;
                CultureInfo.DefaultThreadCurrentUICulture = culture;
            }

            await builder.Build().RunAsync();
        }
    }
}
