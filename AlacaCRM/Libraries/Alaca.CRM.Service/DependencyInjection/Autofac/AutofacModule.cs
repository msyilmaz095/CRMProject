using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Alaca.Crm.Dal.Concrete;
using Alaca.Crm.Dal.Abstract;
using Alaca.CRM.Service.Concrete;
using Alaca.CRM.Service.Abstract;
using Alaca.Core.Utilities.Security.Jwt;
using Alaca.Core.Utilities.Interceptors;

namespace Alaca.CRM.Service.DependencyInjection.Autofac
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EFUserDal>().As<IUserDal>();
            builder.RegisterType<UserManager>().As<IUserService>();

            builder.RegisterType<EFCompanyDal>().As<ICompanyDal>();
            builder.RegisterType<CompanyManager>().As<ICompanyService>();

            builder.RegisterType<EFDepartmentDal>().As<IDepartmentDal>();
            builder.RegisterType<DepartmentManager>().As<IDepartmentService>();

            builder.RegisterType<EFEmployeeDal>().As<IEmployeeDal>();
            builder.RegisterType<EmployeeManager>().As<IEmployeeService>();

            builder.RegisterType<EFUserRoleDal>().As<IUserRoleDal>();
            builder.RegisterType<UserRoleManager>().As<IUserRoleService>();

            builder.RegisterType<EFMenuDal>().As<IMenuDal>();
            builder.RegisterType<MenuManager>().As<IMenuService>();

            builder.RegisterType<EFUserRoleMenuDal>().As<IUserRoleMenuDal>();
            builder.RegisterType<UserRoleMenuManager>().As<IUserRoleMenuService>();

            builder.RegisterType<EFCurrencyDal>().As<ICurrencyDal>();
            builder.RegisterType<CurrencyManager>().As<ICurrencyService>();

            builder.RegisterType<EFPositionDal>().As<IPositionDal>();
            builder.RegisterType<PositionManager>().As<IPositionService>();

            builder.RegisterType<EFUserLoginInfoDal>().As<IUserLoginInfoDal>();
            builder.RegisterType<UserLoginInfoManager>().As<IUserLoginInfoService>();

            builder.RegisterType<EFCurrencyValueDal>().As<ICurrencyValueDal>();
            builder.RegisterType<CurrencyValueManager>().As<ICurrencyValueService>();

            builder.RegisterType<EFConfigurationDal>().As<IConfigurationDal>();
            builder.RegisterType<ConfigurationManager>().As<IConfigurationService>();

            builder.RegisterType<EFLocationTypeDal>().As<ILocationTypeDal>();
            builder.RegisterType<LocationTypeManager>().As<ILocationTypeService>();

            builder.RegisterType<EFCityDal>().As<ICityDal>();
            builder.RegisterType<CityManager>().As<ICityService>();

            builder.RegisterType<EFDistrictDal>().As<IDistrictDal>();
            builder.RegisterType<DistrictManager>().As<IDistrictService>();

            builder.RegisterType<EFZoneDal>().As<IZoneDal>();
            builder.RegisterType<ZoneManager>().As<IZoneService>();

            builder.RegisterType<EFCustomerDal>().As<ICustomerDal>();
            builder.RegisterType<CustomerManager>().As<ICustomerService>();

            builder.RegisterType<EFCustomerRelationDal>().As<ICustomerRelationDal>();
            builder.RegisterType<CustomerRelationManager>().As<ICustomerRelationService>();

            builder.RegisterType<EFSectorDal>().As<ISectorDal>();
            builder.RegisterType<SectorManager>().As<ISectorService>();

            builder.RegisterType<EFCustomerGroupDal>().As<ICustomerGroupDal>();
            builder.RegisterType<CustomerGroupManager>().As<ICustomerGroupService>();

            builder.RegisterType<EFCustomerLocationDal>().As<ICustomerLocationDal>();
            builder.RegisterType<CustomerLocationManager>().As<ICustomerLocationService>();

            builder.RegisterType<EFContactDal>().As<IContactDal>();
            builder.RegisterType<ContactManager>().As<IContactService>();

            builder.RegisterType<EFContactStatuDal>().As<IContactStatuDal>();
            builder.RegisterType<ContactStatuManager>().As<IContactStatuService>();

            builder.RegisterType<EFContactTypeDal>().As<IContactTypeDal>();
            builder.RegisterType<ContactTypeManager>().As<IContactTypeService>();

            builder.RegisterType<EFActivityDal>().As<IActivityDal>();
            builder.RegisterType<ActivityManager>().As<IActivityService>();

            builder.RegisterType<EFActivityTypeDal>().As<IActivityTypeDal>();
            builder.RegisterType<ActivityTypeManager>().As<IActivityTypeService>();

            builder.RegisterType<EFSubContratorTeamDal>().As<ISubContratorTeamDal>();
            builder.RegisterType<SubContratorTeamManager>().As<ISubContratorTeamService>();

            builder.RegisterType<EFProjectDocumentDal>().As<IProjectDocumentDal>();
            builder.RegisterType<ProjectDocumentManager>().As<IProjectDocumentService>();

            builder.RegisterType<EFMilestoneStatuDal>().As<IMilestoneStatuDal>();
            builder.RegisterType<MilestoneStatuManager>().As<IMilestoneStatuService>();

            builder.RegisterType<EFProjectStatuDal>().As<IProjectStatuDal>();
            builder.RegisterType<ProjectStatuManager>().As<IProjectStatuService>();

            builder.RegisterType<EFProjectMilestoneDal>().As<IProjectMilestoneDal>();
            builder.RegisterType<ProjectMilestoneManager>().As<IProjectMilestoneService>();

            builder.RegisterType<EFProjectDal>().As<IProjectDal>();
            builder.RegisterType<ProjectManager>().As<IProjectService>();

            builder.RegisterType<EFUserDepartmentPermissionDal>().As<IUserDepartmentPermissionDal>();
            builder.RegisterType<UserDepartmentPermissionManager>().As<IUserDepartmentPermissionService>();

            builder.RegisterType<EFStockBrandDal>().As<IStockBrandDal>();
            builder.RegisterType<StockBrandManager>().As<IStockBrandService>();

            builder.RegisterType<EFStockStatuDal>().As<IStockStatuDal>();
            builder.RegisterType<StockStatuManager>().As<IStockStatuService>();

            builder.RegisterType<EFStockGroupDal>().As<IStockGroupDal>();
            builder.RegisterType<StockGroupManager>().As<IStockGroupService>();

            builder.RegisterType<EFStockUnitDefinitionDal>().As<IStockUnitDefinitionDal>();
            builder.RegisterType<StockUnitDefinitionManager>().As<IStockUnitDefinitionService>();

            builder.RegisterType<EFBarcodeTypeDal>().As<IBarcodeTypeDal>();
            builder.RegisterType<BarcodeTypeManager>().As<IBarcodeTypeService>();

            builder.RegisterType<EFRayonDal>().As<IRayonDal>();
            builder.RegisterType<RayonManager>().As<IRayonService>();

            builder.RegisterType<EFPaymentMethodDal>().As<IPaymentMethodDal>();
            builder.RegisterType<PaymentMethodManager>().As<IPaymentMethodService>();

            builder.RegisterType<EFStockDal>().As<IStockDal>();
            builder.RegisterType<StockManager>().As<IStockService>();

            builder.RegisterType<EFStockBarcodeDal>().As<IStockBarcodeDal>();
            builder.RegisterType<StockBarcodeManager>().As<IStockBarcodeService>();

            builder.RegisterType<EFStockUnitDal>().As<IStockUnitDal>();
            builder.RegisterType<StockUnitManager>().As<IStockUnitService>();

            builder.RegisterType<EFSalesOfferDal>().As<ISalesOfferDal>();
            builder.RegisterType<SalesOfferManager>().As<ISalesOfferService>();

            builder.RegisterType<EFSalesOfferLineDal>().As<ISalesOfferLineDal>();
            builder.RegisterType<SalesOfferLineManager>().As<ISalesOfferLineService>();

            builder.RegisterType<EFSalesOfferStatuDal>().As<ISalesOfferStatuDal>();
            builder.RegisterType<SalesOfferStatuManager>().As<ISalesOfferStatuService>();

            builder.RegisterType<EFExpenseCardDal>().As<IExpenseCardDal>();
            builder.RegisterType<ExpenseCardManager>().As<IExpenseCardService>();

            builder.RegisterType<EFServiceCardDal>().As<IServiceCardDal>();
            builder.RegisterType<ServiceCardManager>().As<IServiceCardService>();

            builder.RegisterType<EFFactoryDal>().As<IFactoryDal>();
            builder.RegisterType<FactoryManager>().As<IFactoryService>();

            builder.RegisterType<EFWorkTaskDal>().As<IWorkTaskDal>();
            builder.RegisterType<WorkTaskManager>().As<IWorkTaskService>();

            builder.RegisterType<EFWorkTaskTypeDal>().As<IWorkTaskTypeDal>();
            builder.RegisterType<WorkTaskTypeManager>().As<IWorkTaskTypeService>();

            builder.RegisterType<EFUnitDal>().As<IUnitDal>();
            builder.RegisterType<UnitManager>().As<IUnitService>();

            builder.RegisterType<EFStoreDal>().As<IStoreDal>();
            builder.RegisterType<StoreManager>().As<IStoreService>();

            builder.RegisterType<EFShelfDal>().As<IShelfDal>();
            builder.RegisterType<ShelfManager>().As<IShelfService>();

            builder.RegisterType<EFProjectMilestoneStatuDal>().As<IProjectMilestoneStatuDal>();
            builder.RegisterType<ProjectMilestoneStatuManager>().As<IProjectMilestoneStatuService>();

            builder.RegisterType<EFProjectMilestoneTypeDal>().As<IProjectMilestoneTypeDal>();
            builder.RegisterType<ProjectMilestoneTypeManager>().As<IProjectMilestoneTypeService>();

            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }
    }
}
