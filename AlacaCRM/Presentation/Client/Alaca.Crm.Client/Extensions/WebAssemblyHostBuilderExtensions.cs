using Alaca.Crm.Client.Service.Abstract;
using Alaca.Crm.Client.Service.Authentication;
using Alaca.Crm.Client.Service.Helpers;
using Alaca.Crm.Client.Service.Manager;
using Alaca.Entities.Concrete;
using Alaca.Validations.FluentValidation;
using FluentValidation;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor;
using MudBlazor.Services;
using System;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Toolbelt.Blazor.Extensions.DependencyInjection;

namespace Alaca.Crm.Client.Extensions
{
    public static class WebAssemblyHostBuilderExtensions
    {
        private const string ClientName = "BlazorHero.API";
        public static WebAssemblyHostBuilder AddRootComponents(this WebAssemblyHostBuilder builder)
        {
            builder.RootComponents.Add<App>("#app");
            return builder;
        }

        public static IServiceCollection AddRadzenBlazor(this IServiceCollection services)
        {
            services.AddScoped<Radzen.DialogService>();
            services.AddScoped<Radzen.NotificationService>();
            services.AddScoped<Radzen.TooltipService>();
            services.AddScoped<Radzen.ContextMenuService>();
            return services;
        }
        public static IServiceCollection AddFluentValidatorBlazor(this IServiceCollection services)
        {
            services.AddTransient<IValidator<SalesOfferLine>, SalesOfferLineValitador>();
            return services;
        }

        public static WebAssemblyHostBuilder AddClientServices(this WebAssemblyHostBuilder builder)
        {
            builder.Services
                    .AddLocalization(options =>
                    {
                        options.ResourcesPath = "Resources";
                    })
                    .AddAuthorizationCore()
                    .AddMudServices(configuration =>
                    {
                        configuration.SnackbarConfiguration.PositionClass = MudBlazor.Defaults.Classes.Position.BottomRight;
                        configuration.SnackbarConfiguration.HideTransitionDuration = 100;
                        configuration.SnackbarConfiguration.ShowTransitionDuration = 100;
                        configuration.SnackbarConfiguration.VisibleStateDuration = 3000;
                        configuration.SnackbarConfiguration.ShowCloseIcon = false;
                    })
                    //.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies())
                    .AddScoped<ClientPreferenceManager>()
                    .AddScoped<CustomAuthStateProvider>()
                    .AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>()
                    .AddManagers()
                    .AddTransient<AuthenticationHeaderHandler>()
                    .AddScoped(sp => sp
                        .GetRequiredService<IHttpClientFactory>()
                        .CreateClient(ClientName).EnableIntercept(sp))
                    .AddHttpClient(ClientName, client =>
                    {
                        client.DefaultRequestHeaders.AcceptLanguage.Clear();
                        client.DefaultRequestHeaders.AcceptLanguage.ParseAdd(CultureInfo.DefaultThreadCurrentCulture?.TwoLetterISOLanguageName);
                        client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
                    })
                    .AddHttpMessageHandler<AuthenticationHeaderHandler>();
            builder.Services.AddHttpClientInterceptor();
            builder.Services.AddScoped<ILocalStorageService, LocalStorageService>();
            return builder;
        }

        public static IServiceCollection AddManagers(this IServiceCollection services)
        {
            var managers = typeof(IManager);

            var types = managers
                .Assembly
                .GetExportedTypes()
                .Where(t => t.IsClass && !t.IsAbstract)
                .Select(t => new
                {
                    Service = t.GetInterface($"I{t.Name}"),
                    Implementation = t
                })
                .Where(t => t.Service != null);

            foreach (var type in types)
            {
                //Console.WriteLine(type.Service.Name);
                if (managers.IsAssignableFrom(type.Service))
                {
                    services.AddTransient(type.Service, type.Implementation);
                }
            }

            return services;
        }

        //public static IServiceCollection AddManagers(this IServiceCollection services)
        //{
        //    services.AddScoped<IDepartmentService, DepartmentService>();
        //    services.AddScoped<IEmployeeService, EmployeeService>();
        //    services.AddScoped<IUserService, UserService>();
        //    services.AddScoped<ICompanyService, CompanyService>();
        //    services.AddScoped<IAccountService, AccountService>();
        //    services.AddScoped<IUserRoleService, UserRoleService>();
        //    services.AddScoped<ICurrencyService, CurrencyService>();
        //    services.AddScoped<ICurrencyValueService, CurrencyValueService>();
        //    services.AddScoped<IMenuService, MenuService>();
        //    services.AddScoped<IPositionService, PositionService>();
        //    services.AddScoped<IConfigurationService, ConfigurationService>();
        //    services.AddScoped<ILocationTypeService, LocationTypeService>();
        //    services.AddScoped<ICityService, CityService>();
        //    services.AddScoped<IDistrictService, DistrictService>();
        //    services.AddScoped<IZoneService, ZoneService>();
        //    services.AddScoped<ICustomerService, CustomerService>();
        //    services.AddScoped<ICustomerRelationService, CustomerRelationService>();
        //    services.AddScoped<ICustomerService, CustomerService>();
        //    services.AddScoped<ISectorService, SectorService>();
        //    services.AddScoped<ICustomerGroupService, CustomerGroupService>();
        //    services.AddScoped<ICustomerLocationService, CustomerLocationService>();
        //    services.AddScoped<IContactService, ContactService>();
        //    services.AddScoped<IContactTypeService, ContactTypeService>();
        //    services.AddScoped<IContactStatuService, ContactStatuService>();
        //    services.AddScoped<IActivityService, ActivityService>();
        //    services.AddScoped<IActivityTypeService, ActivityTypeService>();
        //    services.AddScoped<IProjectDocumentService, ProjectDocumentService>();
        //    services.AddScoped<IProjectMilestoneService, ProjectMilestoneService>();
        //    services.AddScoped<IProjectStatuService, ProjectStatuService>();
        //    services.AddScoped<IProjectService, ProjectService>();
        //    services.AddScoped<IMilestoneStatuService, MilestoneStatuService>();
        //    services.AddScoped<ISubContratorTeamService, SubContratorTeamService>();
        //    services.AddScoped<IStockStatuService, StockStatuService>();
        //    services.AddScoped<IStockUnitDefinitionService, StockUnitDefinitionService>();
        //    services.AddScoped<IStockGroupService, StockGroupService>();
        //    services.AddScoped<IStockBrandService, StockBrandService>();
        //    services.AddScoped<IBarcodeTypeService, BarcodeTypeService>();
        //    services.AddScoped<IPaymentMethodService, PaymentMethodService>();
        //    services.AddScoped<IRayonService, RayonService>();
        //    services.AddScoped<IStockService, StockService>();
        //    services.AddScoped<IStockBarcodeService, StockBarcodeService>();
        //    services.AddScoped<IStockUnitService, StockUnitService>();
        //    services.AddScoped<ISalesOfferLineService, SalesOfferLineService>();
        //    services.AddScoped<ISalesOfferService, SalesOfferService>();
        //    services.AddScoped<ISalesOfferStatuService, SalesOfferStatuService>();
        //    services.AddScoped<IHttpInterceptorManager, HttpInterceptorManager>();
        //    return services;
        //}
    }
    public class AuthenticationHeaderHandler : DelegatingHandler
    {
        private readonly ILocalStorageService localStorage;

        public AuthenticationHeaderHandler(ILocalStorageService localStorage)
            => this.localStorage = localStorage;

        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            if (request.Headers.Authorization?.Scheme != "Bearer")
            {
                var savedToken = await this.localStorage.GetItem<string>("token");

                if (!string.IsNullOrWhiteSpace(savedToken))
                {
                    request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", savedToken);
                }
            }

            return await base.SendAsync(request, cancellationToken);
        }
    }
}
