using Alaca.Crm.Dal.Abstract;
using Alaca.Entities.Concrete;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alaca.Crm.Dal.Concrete
{
    public class DatabaseSeeder : IDatabaseSeeder
    {
        private readonly ILogger<DatabaseSeeder> _logger;
        private readonly IStringLocalizer<DatabaseSeeder> _localizer;
        private readonly Alaca_CRMContext _db;

        public DatabaseSeeder(
            Alaca_CRMContext db,
            ILogger<DatabaseSeeder> logger,
            IStringLocalizer<DatabaseSeeder> localizer)
        {
            _db = db;
            _logger = logger;
            _localizer = localizer;
        }

        public void Initialize()
        {
            AddActivityType();
            _db.SaveChanges();
            AddSalesOfferStatus();
            _db.SaveChanges();
            AddCurrency();
            _db.SaveChanges();
            AddEmployee();
            _db.SaveChanges();
            AddPaymentMethod();
            _db.SaveChanges();
            AddStockUnitType();
            _db.SaveChanges();
            AddConfigurations();
            _db.SaveChanges();
            AddMenu();
            _db.SaveChanges();
            AddAdministrator();
            _db.SaveChanges();
            AddUserRole();
            _db.SaveChanges();
        }

        private void AddConfigurations()
        {
            Task.Run(() =>
            {
                if (_db.Configurations.FirstOrDefault(p => p.ConfigurationCode == "ProjectCompanyName") == null)
                    _db.Configurations.Add(new Configuration() { ConfigurationCode = "ProjectCompanyName", ConfigurationDescription = "ProjectCompanyName", ConfigurationValue = "ALACA" });
            }).GetAwaiter().GetResult();
        }
        private void AddEmployee()
        {
            Task.Run(() =>
            {
                if (_db.Employees.FirstOrDefault(p => p.Name == "ALACA") == null)
                    _db.Employees.Add(new Employee() { Name = "ALACA", Surname = "YAZILIM", IsActive = true, Email = "ALACA" });
            }).GetAwaiter().GetResult();
        }

        private void AddStockUnitType()
        {
            Task.Run(() =>
            {
                if (_db.StockUnitDefinitions.FirstOrDefault(p => p.StockUnitDefinitionName == "ADET") == null)
                    _db.StockUnitDefinitions.Add(new StockUnitDefinition() { StockUnitDefinitionName = "ADET", IsActive = true, StockUnitDefinitionCode = "ADT" });

                if (_db.StockUnitDefinitions.FirstOrDefault(p => p.StockUnitDefinitionName == "KG") == null)
                    _db.StockUnitDefinitions.Add(new StockUnitDefinition() { StockUnitDefinitionName = "KG", IsActive = true, StockUnitDefinitionCode = "KG" });

                if (_db.StockUnitDefinitions.FirstOrDefault(p => p.StockUnitDefinitionName == "CM") == null)
                    _db.StockUnitDefinitions.Add(new StockUnitDefinition() { StockUnitDefinitionName = "CM", IsActive = true, StockUnitDefinitionCode = "CM" });

                if (_db.StockUnitDefinitions.FirstOrDefault(p => p.StockUnitDefinitionName == "METRE") == null)
                    _db.StockUnitDefinitions.Add(new StockUnitDefinition() { StockUnitDefinitionName = "METRE", IsActive = true, StockUnitDefinitionCode = "MT" });

                if (_db.StockUnitDefinitions.FirstOrDefault(p => p.StockUnitDefinitionName == "PAKET") == null)
                    _db.StockUnitDefinitions.Add(new StockUnitDefinition() { StockUnitDefinitionName = "PAKET", IsActive = true, StockUnitDefinitionCode = "PKT" });

                if (_db.StockUnitDefinitions.FirstOrDefault(p => p.StockUnitDefinitionName == "KUTU") == null)
                    _db.StockUnitDefinitions.Add(new StockUnitDefinition() { StockUnitDefinitionName = "KUTU", IsActive = true, StockUnitDefinitionCode = "KT" });

                if (_db.StockUnitDefinitions.FirstOrDefault(p => p.StockUnitDefinitionName == "LİTRE") == null)
                    _db.StockUnitDefinitions.Add(new StockUnitDefinition() { StockUnitDefinitionName = "LİTRE", IsActive = true, StockUnitDefinitionCode = "LT" });
            }).GetAwaiter().GetResult();
        }

        private void AddCurrency()
        {
            Task.Run(() =>
            {
                if (_db.Currencies.FirstOrDefault(p => p.CurrencyName == "USD") == null)
                    _db.Currencies.Add(new Currency() { CurrencyName = "USD", CurrencyCode = "USD" });

                if (_db.Currencies.FirstOrDefault(p => p.CurrencyName == "EUR") == null)
                    _db.Currencies.Add(new Currency() { CurrencyName = "EUR", CurrencyCode = "EUR" });

                if (_db.Currencies.FirstOrDefault(p => p.CurrencyName == "TL") == null)
                    _db.Currencies.Add(new Currency() { CurrencyName = "TL", CurrencyCode = "TL" });
            }).GetAwaiter().GetResult();
        }

        private void AddSalesOfferStatus()
        {
            Task.Run(() =>
            {
                if (_db.SalesOfferStatus.FirstOrDefault(p => p.SalesOfferStatuName == "ONAY BEKLİYOR") == null)
                    _db.SalesOfferStatus.Add(new SalesOfferStatu() { SalesOfferStatuName = "ONAY BEKLİYOR" });

                if (_db.SalesOfferStatus.FirstOrDefault(p => p.SalesOfferStatuName == "ONAYLANDI") == null)
                    _db.SalesOfferStatus.Add(new SalesOfferStatu() { SalesOfferStatuName = "ONAYLANDI"});
            }).GetAwaiter().GetResult();
        }

        private void AddActivityType()
        {
            Task.Run(() =>
            {
                if (_db.ActivityTypes.FirstOrDefault(p => p.ActivityTypeName == "TELEFON") == null)
                    _db.ActivityTypes.Add(new ActivityType() { ActivityTypeName = "TELEFON", IsActive = true });

                if (_db.ActivityTypes.FirstOrDefault(p => p.ActivityTypeName == "TOPLANTI") == null)
                    _db.ActivityTypes.Add(new ActivityType() { ActivityTypeName = "TOPLANTI", IsActive = true });

                if (_db.ActivityTypes.FirstOrDefault(p => p.ActivityTypeName == "EĞİTİM") == null)
                    _db.ActivityTypes.Add(new ActivityType() { ActivityTypeName = "EĞİTİM", IsActive = true });
            }).GetAwaiter().GetResult();
        }

        private void AddPaymentMethod()
        {
            Task.Run(() =>
            {
                if (_db.PaymentMethods.FirstOrDefault(p => p.PaymentMethodName == "K.K.") == null)
                    _db.PaymentMethods.Add(new PaymentMethod() { PaymentMethodCode = "001", PaymentMethodName = "K.K.", IsActive = true });

                if (_db.PaymentMethods.FirstOrDefault(p => p.PaymentMethodName == "NAKİT") == null)
                    _db.PaymentMethods.Add(new PaymentMethod() { PaymentMethodCode = "003", PaymentMethodName = "NAKİT", IsActive = true });

                if (_db.PaymentMethods.FirstOrDefault(p => p.PaymentMethodName == "ÇEK") == null)
                    _db.PaymentMethods.Add(new PaymentMethod() { PaymentMethodCode = "004", PaymentMethodName = "ÇEK", IsActive = true });

                if (_db.PaymentMethods.FirstOrDefault(p => p.PaymentMethodName == "SENET") == null)
                    _db.PaymentMethods.Add(new PaymentMethod() { PaymentMethodCode = "005", PaymentMethodName = "SENET", IsActive = true });

                if (_db.PaymentMethods.FirstOrDefault(p => p.PaymentMethodName == "VADELİ") == null)
                    _db.PaymentMethods.Add(new PaymentMethod() { PaymentMethodCode = "005", PaymentMethodName = "VADELİ", IsActive = true });
            }).GetAwaiter().GetResult();
        }

        private void AddAdministrator()
        {
            Task.Run(() =>
            {
                UserRole userRole = _db.UserRoles.FirstOrDefault(p => p.UserRoleName == "Admin");
                if (userRole == null)
                {
                    userRole = new UserRole() { UserRoleName = "Admin", IsActive = true };
                    _db.UserRoles.Add(userRole);
                    _db.SaveChanges();
                }
                if (_db.Users.FirstOrDefault(p => p.Email == "alaca") == null)
                    _db.Users.Add(new User() { Email = "alaca", UserCode = "alaca", Password = "1", UserName = "1", UserStatusId = 1, UserRoleId = userRole.UserRoleId });
            }).GetAwaiter().GetResult();
        }

        private void AddUserRole()
        {
            var userRole = _db.UserRoles.FirstOrDefault(p => p.UserRoleName == "Admin");
            if (userRole != null)
            {
                foreach (var item in _db.Menus.Where(p => p.Url != "#"))
                {
                    if (_db.UserRoleMenus.FirstOrDefault(p => p.UserRoleId == userRole.UserRoleId && p.MenuId == item.MenuId) == null)
                        _db.UserRoleMenus.Add(new UserRoleMenu() { MenuId = item.MenuId, UserRoleId = userRole.UserRoleId });
                }
            }
        }

        private void AddMenu()
        {
            Task.Run(() =>
            {
                List<Menu> lstMenu = new List<Menu>() {
                new Menu(){ Icon="fas fa-th",MenuName="GENEL",Url="#",Description="GENEL",IsActive=true,Menus=new HashSet<Menu>{
                new Menu(){ Icon="fas fa-ellipsis-v",MenuName="MENULER",Url="menus",Description="MENULER",IsActive=true },
                new Menu(){ Icon="fas fa-th",MenuName="POZİSYONLAR",Url="positions",Description="POZİSYONLAR",IsActive=true },
                new Menu(){ Icon="fas fa-money-bill-wave",MenuName="PARA BİRİMLERİ",Url="Currencies",Description="PARA BİRİMLERİ",IsActive=true },
                new Menu(){ Icon="fas fa-city",MenuName="İLLER",Url="citys",Description="İLLER",IsActive=true },
                new Menu(){ Icon="fas fa-th",MenuName="KULLANICI GİRİŞLERİ",Url="UserLoginInfos",Description="KULLANICI GİRİŞLERİ",IsActive=true },
                new Menu(){ Icon="far fa-compass",MenuName="ROLLER",Url="UserRoles",Description="ROLLER",IsActive=true },
                new Menu(){ Icon="fas fa-th",MenuName="DEPARTMANLAR",Url="Departments",Description="DEPARTMANLAR",IsActive=true },
                new Menu(){ Icon="fas fa-th",MenuName="İLÇELER",Url="Districts",Description="İLÇELER",IsActive=true },
                new Menu(){ Icon="fas fa-money-bill-alt",MenuName="KURLAR",Url="currenciesvalue",Description="KURLAR",IsActive=true },
                new Menu(){ Icon="fas fa-user-friends",MenuName="PERSONELLER",Url="Employees",Description="PERSONELLER",IsActive=true },
                new Menu(){ Icon="fas fa-th",MenuName="KULLANICILAR",Url="USERS",Description="KULLANICILAR",IsActive=true },
                new Menu(){ Icon="fas fa-th",MenuName="ŞİRKETLER",Url="Companies",Description="ŞİRKETLER",IsActive=true },
                new Menu(){ Icon="fas fa-th",MenuName="BÖLGELER",Url="zones",Description="BÖLGELER",IsActive=true },
                new Menu(){ Icon="fas fa-th",MenuName="PARAMETRELER",Url="Configurations",Description="PARAMETRELER",IsActive=true },
                new Menu(){ Icon="fas fa-th",MenuName="MASRAF KARTLARI",Url="ExpenseCards",Description="MASRAF KARTLARI",IsActive=true },
                new Menu(){ Icon="fas fa-th",MenuName="HİZMET KARTLARI",Url="ServiceCards",Description="HİZMET KARTLARI",IsActive=true }
                } },
                new Menu(){ Icon="fas fa-th",MenuName="TANIMLAR",Url="#",Description="TANIMLAR",IsActive=true,Menus=new HashSet<Menu>{
                new Menu(){ Icon="fas fa-location-arrow",MenuName="LOKASYON TÜRLERİ",Url="LocationTypes",Description="LOKASYON TÜRLERİ",IsActive=true },
                new Menu(){ Icon="fas fa-th",MenuName="YETKİLİ TÜRÜ",Url="contacttype",Description="YETKİLİ TÜRÜ",IsActive=true },
                new Menu(){ Icon="fas fa-th",MenuName="BARKOD TİPLERİ",Url="BarcodeTypes",Description="BARKOD TİPLERİ",IsActive=true },
                new Menu(){ Icon="fas fa-th",MenuName="YETKİLİ DURUM",Url="contactstatu",Description="YETKİLİ DURUM",IsActive=true },
                } },
                new Menu(){ Icon="fas fa-th",MenuName="MÜŞTERİ",Url="#",Description="MÜŞTERİ",IsActive=true,Menus=new HashSet<Menu>{
                new Menu(){ Icon="fas fa-th",MenuName="AKTİVİTE TÜRLERİ",Url="activitytype",Description="AKTİVİTE TÜRLERİ",IsActive=true },
                new Menu(){ Icon="fas fa-th",MenuName="MÜŞTERİ GRUPLARI",Url="customergroups",Description="MÜŞTERİ GRUPLARI",IsActive=true },
                new Menu(){ Icon="fas fa-th",MenuName="MÜŞTERİLER",Url="customers",Description="MÜŞTERİLER",IsActive=true },
                new Menu(){ Icon="fas fa-th",MenuName="İLİŞKİ TÜRLERİ",Url="CustomerRelations",Description="İLİŞKİ TÜRLERİ",IsActive=true },
                new Menu(){ Icon="fas fa-th",MenuName="TAKVİM",Url="Scheduler",Description="TAKVİM",IsActive=true },
                new Menu(){ Icon="fas fa-th",MenuName="SEKTÖRLER",Url="sectors",Description="SEKTÖRLER",IsActive=true },
                new Menu(){ Icon="fas fa-th",MenuName="AKTİVİTELER",Url="Activities",Description="AKTİVİTELER",IsActive=true },

                } },
                new Menu(){ Icon="fas fa-th",MenuName="STOKLAR",Url="#",Description="STOKLAR",IsActive=true,Menus=new HashSet<Menu>{
                new Menu(){ Icon="fas fa-th",MenuName="STOKLAR",Url="Stocks",Description="STOKLAR",IsActive=true },
                new Menu(){ Icon="fas fa-th",MenuName="STOK DURUMLARI",Url="StockStatus",Description="STOK DURUMLARI",IsActive=true },
                new Menu(){ Icon="fas fa-th",MenuName="STOK BİRİMLERİ",Url="StockUnitDefinitions",Description="STOK BİRİMLERİ",IsActive=true },
                new Menu(){ Icon="fas fa-th",MenuName="STOK GRUPLARI",Url="StockGroups",Description="STOK GRUPLARI",IsActive=true },
                new Menu(){ Icon="fas fa-th",MenuName="MARKA TANIMLARI",Url="StockBrands",Description="MARKA TANIMLARI",IsActive=true },
                } },
                new Menu(){ Icon="fas fa-th",MenuName="TEKLİF",Url="#",Description="TEKLİF",IsActive=true,Menus=new HashSet<Menu>{
                new Menu(){ Icon="fas fa-th",MenuName="TEKLİFLER",Url="salesoffers",Description="TEKLİFLER",IsActive=true },
                new Menu(){ Icon="fas fa-th",MenuName="TEKLİF DURUM",Url="salesofferStatus",Description="TEKLİF DURUM",IsActive=true },
                } },
                new Menu(){ Icon="fas fa-th",MenuName="PROJE",Url="#",Description="PROJE",IsActive=true,Menus=new HashSet<Menu>{
                new Menu(){ Icon="fas fa-th",MenuName="PROJELER",Url="Projects",Description="PROJELER",IsActive=true },
                new Menu(){ Icon="fas fa-th",MenuName="PROJE DURUM",Url="ProjectStatus",Description="PROJE DURUM",IsActive=true },
                new Menu(){ Icon="fas fa-th",MenuName="PROJE SÜREÇ DURUMLARI",Url="MilestoneStatus",Description="PROJE SÜREÇ DURUM",IsActive=true },
                new Menu(){ Icon="fas fa-th",MenuName="PROJE SÜREÇ TÜRLERİ",Url="MilestoneTypes",Description="PROJE SÜREÇ TÜR",IsActive=true },
                new Menu(){ Icon="fas fa-th",MenuName="PROJE SÜREÇ TAKİP",Url="gantt",Description="PROJE SÜREÇ TAKİP",IsActive=true },
                } }
                };
                SaveIsCheckMenu(lstMenu);
            }).GetAwaiter().GetResult();
        }

        private void SaveIsCheckMenu(List<Menu> lstMenu)
        {
            foreach (var item in lstMenu)
            {
                if (item.Url == "#")
                {
                    if (_db.Menus.FirstOrDefault(p => p.MenuName == item.MenuName) == null)
                    {
                        _db.Menus.Add(item);
                    }
                }
                else
                {
                    if (_db.Menus.FirstOrDefault(p => p.Url == item.Url) == null)
                    {
                        _db.Menus.Add(item);
                    }
                }
                if (item.Menus.Count > 0)
                {
                    SaveIsCheckMenu(item.Menus.ToList());
                }
            }
        }
    }
}