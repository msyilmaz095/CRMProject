
using Alaca.Core.Utilities.Configuration;
using Alaca.Crm.Dal.Abstract;
using Alaca.Crm.Dal.Concrete;
using Alaca.CRM.Service.Abstract;
using Alaca.CRM.Service.Concrete;
using Alaca.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alaca.Core.Utilities.Localization;
using Microsoft.AspNetCore.Builder;

namespace Alaca.Crm.Server.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IUserDal, EFUserDal>();
            services.AddScoped<IUserService, UserManager>();

            services.AddScoped<ICompanyDal, EFCompanyDal>();
            services.AddScoped<ICompanyService, CompanyManager>();

            services.AddScoped<IDepartmentDal, EFDepartmentDal>();
            services.AddScoped<IDepartmentService, DepartmentManager>();

            services.AddScoped<IEmployeeDal, EFEmployeeDal>();
            services.AddScoped<IEmployeeService, EmployeeManager>();

            services.AddScoped<IUserRoleDal, EFUserRoleDal>();
            services.AddScoped<IUserRoleService, UserRoleManager>();

            services.AddScoped<IMenuDal, EFMenuDal>();
            services.AddScoped<IMenuService, MenuManager>();

            services.AddScoped<IUserRoleMenuDal, EFUserRoleMenuDal>();
            services.AddScoped<IUserRoleMenuService, UserRoleMenuManager>();

            services.AddScoped<ICurrencyDal, EFCurrencyDal>();
            services.AddScoped<ICurrencyService, CurrencyManager>();

            services.AddScoped<IPositionDal, EFPositionDal>();
            services.AddScoped<IPositionService, PositionManager>();

            services.AddScoped<IUserLoginInfoDal, EFUserLoginInfoDal>();
            services.AddScoped<IUserLoginInfoService, UserLoginInfoManager>();

            services.AddScoped<ICurrencyValueDal, EFCurrencyValueDal>();
            services.AddScoped<ICurrencyValueService, CurrencyValueManager>();

            services.AddScoped<IConfigurationDal, EFConfigurationDal>();
            services.AddScoped<IConfigurationService, ConfigurationManager>();

            services.AddScoped<ILocationTypeDal, EFLocationTypeDal>();
            services.AddScoped<ILocationTypeService, LocationTypeManager>();

            services.AddScoped<ICityDal, EFCityDal>();
            services.AddScoped<ICityService, CityManager>();

            services.AddScoped<IDistrictDal, EFDistrictDal>();
            services.AddScoped<IDistrictService, DistrictManager>();

            services.AddScoped<IZoneDal, EFZoneDal>();
            services.AddScoped<IZoneService, ZoneManager>();

            services.AddScoped<ICustomerDal, EFCustomerDal>();
            services.AddScoped<ICustomerService, CustomerManager>();

            services.AddScoped<ICustomerRelationDal, EFCustomerRelationDal>();
            services.AddScoped<ICustomerRelationService, CustomerRelationManager>();

            services.AddScoped<ISectorDal, EFSectorDal>();
            services.AddScoped<ISectorService, SectorManager>();

            services.AddScoped<ICustomerGroupDal, EFCustomerGroupDal>();
            services.AddScoped<ICustomerGroupService, CustomerGroupManager>();

            services.AddScoped<ICustomerLocationDal, EFCustomerLocationDal>();
            services.AddScoped<ICustomerLocationService, CustomerLocationManager>();

            services.AddScoped<IContactDal, EFContactDal>();
            services.AddScoped<IContactService, ContactManager>();

            services.AddScoped<IContactStatuDal, EFContactStatuDal>();
            services.AddScoped<IContactStatuService, ContactStatuManager>();

            services.AddScoped<IContactTypeDal, EFContactTypeDal>();
            services.AddScoped<IContactTypeService, ContactTypeManager>();

            services.AddScoped<IActivityDal, EFActivityDal>();
            services.AddScoped<IActivityService, ActivityManager>();

            services.AddScoped<IActivityTypeDal, EFActivityTypeDal>();
            services.AddScoped<IActivityTypeService, ActivityTypeManager>();

            services.AddScoped<ISubContratorTeamDal, EFSubContratorTeamDal>();
            services.AddScoped<ISubContratorTeamService, SubContratorTeamManager>();

            services.AddScoped<IProjectDocumentDal, EFProjectDocumentDal>();
            services.AddScoped<IProjectDocumentService, ProjectDocumentManager>();

            services.AddScoped<IMilestoneStatuDal, EFMilestoneStatuDal>();
            services.AddScoped<IMilestoneStatuService, MilestoneStatuManager>();

            services.AddScoped<IProjectStatuDal, EFProjectStatuDal>();
            services.AddScoped<IProjectStatuService, ProjectStatuManager>();

            services.AddScoped<IProjectMilestoneDal, EFProjectMilestoneDal>();
            services.AddScoped<IProjectMilestoneService, ProjectMilestoneManager>();

            services.AddScoped<IUserDepartmentPermissionDal, EFUserDepartmentPermissionDal>();
            services.AddScoped<IUserDepartmentPermissionService, UserDepartmentPermissionManager>();

            services.AddScoped<IProjectDal, EFProjectDal>();
            services.AddScoped<IProjectService, ProjectManager>();
            return services;
        }

        internal static IServiceCollection AddDatabase(
        this IServiceCollection services,
        IConfiguration configuration)
        {
           return services
              .AddDbContext<Alaca_CRMContext>(options => options
                  .UseSqlServer(configuration.GetConnectionString("Alaca_CRMContext")))
          .AddTransient<IDatabaseSeeder, DatabaseSeeder>();
        }
        internal static IServiceCollection AddServerLocalization(this IServiceCollection services)
        {
            services.TryAddTransient(typeof(IStringLocalizer<>), typeof(ServerLocalizer<>));
            return services;
        }

        internal static IApplicationBuilder Initialize(this IApplicationBuilder app, Microsoft.Extensions.Configuration.IConfiguration _configuration)
        {
            using var serviceScope = app.ApplicationServices.CreateScope();

            var initializers = serviceScope.ServiceProvider.GetServices<IDatabaseSeeder>();

            foreach (var initializer in initializers)
            {
                initializer.Initialize();
            }

            return app;
        }
        //    internal static AppConfiguration GetApplicationSettings(
        //this IServiceCollection services,
        //IConfiguration configuration)
        //    {
        //        var applicationSettingsConfiguration = configuration.GetSection(nameof(AppConfiguration));
        //        services.Configure<AppConfiguration>(applicationSettingsConfiguration);
        //        return applicationSettingsConfiguration.Get<AppConfiguration>();
        //    }
    }
}
