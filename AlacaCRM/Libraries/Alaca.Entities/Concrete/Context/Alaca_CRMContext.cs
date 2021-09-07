using System;
using Alaca.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.AspNetCore.Http;
using Alaca.Entities.Concrete;
using Alaca.Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;
#nullable disable

namespace Alaca.Entities.Concrete
{
    public partial class Alaca_CRMContext : DbContext
    {
        public Alaca_CRMContext()
        {
        }
        public Alaca_CRMContext(DbContextOptions<Alaca_CRMContext> options)
            : base(options)
        {
            // options.UseLazyLoadingProxies();
        }
        #region DbSet
        public virtual DbSet<ProjectMilestoneStatu> ProjectMilestoneStatus { get; set; }
        public virtual DbSet<ProjectMilestoneType> ProjectMilestoneTypes { get; set; }
        public virtual DbSet<ExpenseCard> ExpenseCards { get; set; }
        public virtual DbSet<ServiceCard> ServiceCards { get; set; }
        public virtual DbSet<WorkTask> WorkTask { get; set; }
        public virtual DbSet<WorkTaskType> WorkTaskType { get; set; }
        public virtual DbSet<Unit> Unit { get; set; }
        public virtual DbSet<Factory> Factory { get; set; }
        public virtual DbSet<Store> Store { get; set; }
        public virtual DbSet<Shelf> Shelf { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<SalesOfferStatu> SalesOfferStatus { get; set; }
        public virtual DbSet<SalesOffer> SalesOffers { get; set; }
        public virtual DbSet<SalesOfferLine> SalesOfferLines { get; set; }
        public virtual DbSet<StockUnit> StockUnits { get; set; }
        public virtual DbSet<StockBarcode> StockBarcodes { get; set; }
        public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }
        public virtual DbSet<Rayon> Rayons { get; set; }
        public virtual DbSet<StockStatu> StockStatus { get; set; }
        public virtual DbSet<StockGroup> StockGroups { get; set; }
        public virtual DbSet<StockUnitDefinition> StockUnitDefinitions { get; set; }
        public virtual DbSet<BarcodeType> BarcodeTypes { get; set; }
        public virtual DbSet<StockBrand> StockBrands { get; set; }
        public virtual DbSet<UserDepartmentPermission> UserDepartmentPermissions { get; set; }
        public virtual DbSet<ProjectStatu> ProjectStatus { get; set; }
        public virtual DbSet<MilestoneStatu> MilestoneStatus { get; set; }
        public virtual DbSet<ProjectDocument> ProjectDocuments { get; set; }
        public virtual DbSet<ProjectMilestone> ProjectMilestones { get; set; }
        public virtual DbSet<SubContratorTeam> SubContratorTeams { get; set; }
        public virtual DbSet<ContactType> ContactTypes { get; set; }
        public virtual DbSet<ContactStatu> ContactStatus { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<ActivityType> ActivityTypes { get; set; }
        public virtual DbSet<Activity> Activities { get; set; }
        public virtual DbSet<CustomerGroup> CustomerGroups { get; set; }
        public virtual DbSet<Sector> Sectors { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<City> Citys { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<CustomerLocation> CustomerLocations { get; set; }
        public virtual DbSet<CustomerStatu> CustomerStatus { get; set; }
        public virtual DbSet<CustomerRelation> CustomerRelations { get; set; }
        public virtual DbSet<Zone> Zones { get; set; }
        public virtual DbSet<LocationType> LocationTypes { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Configuration> Configurations { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<CurrencyValue> CurrencyValues { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeePosition> EmployeePositions { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<LocaleStringResource> LocaleStringResources { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserLoginInfo> UserLoginInfos { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<UserRoleMenu> UserRoleMenus { get; set; }
        #endregion DbSet
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=185.15.198.104,11433;Database=Alaca_CRM_TERMOKON_V5;User ID=zafer;Password=Z@fer159357;");//.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

            modelBuilder.Entity<Company>(entity =>
            {
                entity.HasKey(e => e.CompanyId);

                entity.ToTable("Company");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CompanyName");

                entity.Property(e => e.Adress)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ConnectionString)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CompanyId)
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("date");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.Property(e => e.CustomerId)
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CustomerCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerTitle)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phone1)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Phone2)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.WebSite)
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.TaxAdministration)
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.TaxNumber)
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.IbanNo1)
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.IbanNo2)
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.Explanation)
                    .HasMaxLength(1000)
                    .IsUnicode(false);


                entity.Property(e => e.CustomField1)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CustomField2)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CustomField3)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Configuration>(entity =>
            {
                entity.HasKey(e => e.ConfigurationCode);

                entity.Property(e => e.ConfigurationCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ConfigurationDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ConfigurationValue)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StockBarcode>(entity =>
            {
                entity.HasKey(e => e.StockBarcodeId);

                entity.Property(e => e.StockBarcodeId)
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.StockBarcodeName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
                entity.Property(e => e.Barcode)
                    .HasMaxLength(30)
                    .IsUnicode(false);
                entity.Property(e => e.PartyCode)
                    .HasMaxLength(30)
                    .IsUnicode(false);
                entity.Property(e => e.LotNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });
            modelBuilder.Entity<StockUnit>(entity =>
            {
                entity.HasKey(e => e.StockUnitId);

                entity.Property(e => e.StockUnitId)
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.StockUnitName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
                entity.Property(e => e.SpecialCode1)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.SpecialCode2)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.SpecialCode3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Stock>(entity =>
            {
                entity.HasKey(e => e.StockId);

                entity.Property(e => e.StockId)
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.StockCode)
                    .HasMaxLength(30)
                    .IsUnicode(false);
                entity.Property(e => e.StockName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
                entity.Property(e => e.SpecialCode1)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.SpecialCode2)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.SpecialCode3)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);
                entity.Property(e => e.Origin)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ServiceCard>(entity =>
            {
                entity.HasKey(e => e.ServiceCardId);

                entity.Property(e => e.ServiceCardId)
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ServiceCardCode)
                    .HasMaxLength(30)
                    .IsUnicode(false);
                entity.Property(e => e.ServiceCardName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
                entity.Property(e => e.SpecialCode1)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.SpecialCode2)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.SpecialCode3)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ExpenseCard>(entity =>
            {
                entity.HasKey(e => e.ExpenseCardId);

                entity.Property(e => e.ExpenseCardId)
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ExpenseCardCode)
                    .HasMaxLength(30)
                    .IsUnicode(false);
                entity.Property(e => e.ExpenseCardName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
                entity.Property(e => e.SpecialCode1)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.SpecialCode2)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.SpecialCode3)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<WorkTask>(entity =>
            {
                entity.HasKey(e => e.WorkTaskId);

                entity.Property(e => e.WorkTaskId)
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DocumentSerial)
                    .HasMaxLength(30)
                    .IsUnicode(false);
                entity.Property(e => e.WorkTaskHeader)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.SpecialCode1)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.SpecialCode2)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.SpecialCode3)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.Description)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<WorkTaskType>(entity =>
            {
                entity.HasKey(e => e.WorkTaskTypeId);

                entity.Property(e => e.WorkTaskTypeId)
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.WorkTaskTypeName)
                    .HasMaxLength(30)
                    .IsUnicode(false);
                entity.Property(e => e.SpecialCode1)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.SpecialCode2)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.SpecialCode3)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Unit>(entity =>
            {
                entity.HasKey(e => e.UnitId);

                entity.Property(e => e.UnitId)
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.UnitName)
                    .HasMaxLength(30)
                    .IsUnicode(false);
                entity.Property(e => e.SpecialCode1)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.SpecialCode2)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.SpecialCode3)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Factory>(entity =>
            {
                entity.HasKey(e => e.FactoryId);

                entity.Property(e => e.FactoryId)
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.FactoryName)
                    .HasMaxLength(30)
                    .IsUnicode(false);
                entity.Property(e => e.FactoryZone)
                    .HasMaxLength(30)
                    .IsUnicode(false);
                entity.Property(e => e.FactoryCity)
                    .HasMaxLength(30)
                    .IsUnicode(false);
                entity.Property(e => e.SpecialCode1)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.SpecialCode2)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.SpecialCode3)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.HasKey(e => e.StoreId);

                entity.Property(e => e.StoreId)
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.StoreCode)
                    .HasMaxLength(30)
                    .IsUnicode(false);
                entity.Property(e => e.StoreName)
                    .HasMaxLength(30)
                    .IsUnicode(false);
                entity.Property(e => e.SpecialCode1)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.SpecialCode2)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.SpecialCode3)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Shelf>(entity =>
            {
                entity.HasKey(e => e.ShelfId);

                entity.Property(e => e.ShelfId)
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ShelfName)
                    .HasMaxLength(30)
                    .IsUnicode(false);
                entity.Property(e => e.SpecialCode1)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.SpecialCode2)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.SpecialCode3)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Rayon>(entity =>
            {
                entity.HasKey(e => e.RayonId);

                entity.Property(e => e.RayonId)
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.RayonCode)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RayonName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ProjectMilestoneStatu>(entity =>
            {
                entity.HasKey(e => e.ProjectMilestoneStatuId);
                entity.Property(e => e.ProjectMilestoneStatuId).UseIdentityColumn();

                entity.Property(e => e.ProjectMilestoneStatuName)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ProjectMilestoneType>(entity =>
            {
                entity.HasKey(e => e.ProjectMilestoneTypeId);
                entity.Property(e => e.ProjectMilestoneTypeId).UseIdentityColumn();
                entity.Property(e => e.ProjectMilestoneTypeName)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SalesOfferStatu>(entity =>
            {
                entity.HasKey(e => e.SalesOfferStatuId);
                entity.Property(e => e.SalesOfferStatuId).UseIdentityColumn();

                entity.Property(e => e.SalesOfferStatuName)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SalesOffer>(entity =>
            {
                entity.HasKey(e => e.SalesOfferId);
                entity.Property(e => e.SalesOfferId)
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.HasKey(e => e.ProjectId);
                entity.Property(e => e.ProjectId)
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ProjectTitle)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SalesOfferLine>(entity =>
            {
                entity.HasKey(e => e.SaleOfferLineId);
                entity.Property(e => e.SaleOfferLineId)
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<PaymentMethod>(entity =>
            {
                entity.HasKey(e => e.PaymentMethodId);

                entity.Property(e => e.PaymentMethodId)
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.PaymentMethodCode)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentMethodName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Position>(entity =>
            {
                entity.HasKey(e => e.PositionId);

                entity.Property(e => e.PositionId)
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.PositionName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });


            modelBuilder.Entity<StockStatu>(entity =>
            {
                entity.HasKey(e => e.StockStatuId);

                entity.Property(e => e.StockStatuId)
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.StockStatuName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });


            modelBuilder.Entity<StockGroup>(entity =>
            {
                entity.HasKey(e => e.StockGroupId);

                entity.Property(e => e.StockGroupId)
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.StockGroupCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.StockGroupName)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });


            modelBuilder.Entity<StockUnitDefinition>(entity =>
            {
                entity.HasKey(e => e.StockUnitDefinitionId);

                entity.Property(e => e.StockUnitDefinitionId)
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.StockUnitDefinitionCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.StockUnitDefinitionName)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });


            modelBuilder.Entity<BarcodeType>(entity =>
            {
                entity.HasKey(e => e.BarcodeTypeId);
                entity.Property(e => e.BarcodeTypeId).UseIdentityColumn();

                entity.Property(e => e.BarcodeTypeCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.BarcodeTypeName)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<StockBrand>(entity =>
            {
                entity.HasKey(e => e.StockBrandId);

                entity.Property(e => e.StockBrandId)
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.StockBrandCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.StockBrandName)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MilestoneStatu>(entity =>
            {
                entity.HasKey(e => e.MilestoneStatuId);

                entity.Property(e => e.MilestoneStatuId)
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.MilestoneStatuName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ProjectStatu>(entity =>
            {
                entity.HasKey(e => e.ProjectStatuId);
                entity.Property(e => e.ProjectStatuId).UseIdentityColumn();

                entity.Property(e => e.ProjectStatuName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ProjectMilestone>(entity =>
            {
                entity.HasKey(e => e.ProjectMilestoneId);

                entity.Property(e => e.ProjectMilestoneId)
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ProjectMilestoneName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ProjectDocument>(entity =>
            {
                entity.HasKey(e => e.ProjectDocumentId);

                entity.Property(e => e.ProjectDocumentId)
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ProjectDocumentName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SubContratorTeam>(entity =>
            {
                entity.HasKey(e => e.SubContratorTeamId);

                entity.Property(e => e.SubContratorTeamId)
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.SubcontratorTeamName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ContactType>(entity =>
            {
                entity.HasKey(e => e.ContactTypeId);

                entity.Property(e => e.ContactTypeId)
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ContactTypeName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ContactStatu>(entity =>
            {
                entity.HasKey(e => e.ContactStatuId);

                entity.Property(e => e.ContactStatuId)
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ContactStatuName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ActivityType>(entity =>
            {
                entity.HasKey(e => e.ActivityTypeId);

                entity.Property(e => e.ActivityTypeId)
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ActivityTypeName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.HasKey(e => e.ContactId);

                entity.Property(e => e.ContactId)
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SureName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MobilePhoneNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OfficePhoneNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OfficePhoneNumberInternalCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Explanation)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });
            modelBuilder.Entity<Activity>(entity =>
            {
                entity.HasKey(e => e.ActivityId);

                entity.Property(e => e.ActivityId)
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Location)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Explanation)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });
            modelBuilder.Entity<Zone>(entity =>
            {
                entity.HasKey(e => e.ZoneId);

                entity.Property(e => e.ZoneId)
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ZoneName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });


            modelBuilder.Entity<Sector>(entity =>
            {
                entity.HasKey(e => e.SectorId);

                entity.Property(e => e.SectorId)
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.SectorName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CustomerGroup>(entity =>
            {
                entity.HasKey(e => e.CustomerGroupId);

                entity.Property(e => e.CustomerGroupId)
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CustomerGroupName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });
            modelBuilder.Entity<CustomerStatu>(entity =>
            {
                entity.HasKey(e => e.CustomerStatusId);

                entity.Property(e => e.CustomerStatusId)
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CustomerStatusName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.HasKey(e => e.CityId);

                entity.Property(e => e.CityId)
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CityCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CityName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<District>(entity =>
            {
                entity.HasKey(e => e.Districtd);

                entity.Property(e => e.Districtd)
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DistrictName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<LocationType>(entity =>
            {
                entity.HasKey(e => e.LocationTypeId);

                entity.Property(e => e.LocationTypeId)
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.LocationTypeName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CustomerRelation>(entity =>
            {
                entity.HasKey(e => e.CustomerRelationId);

                entity.Property(e => e.CustomerRelationId)
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CustomerRelationName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CustomerLocation>(entity =>
            {
                entity.HasKey(e => e.CustomerLocationId);

                entity.Property(e => e.CustomerLocationId)
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Address)
                    .HasMaxLength(300)
                    .IsUnicode(false);
                entity.Property(e => e.CustomerLocationName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.ToTable("Currency");

                entity.Property(e => e.CurrencyId)
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CurrencyCode).HasMaxLength(5);

                entity.Property(e => e.CurrencyName).HasMaxLength(100);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CurrencyValue>(entity =>
            {
                entity.HasKey(e => e.CurrencyValuesId);

                entity.Property(e => e.CurrencyValuesId)
                   .HasColumnType("uniqueidentifier")
                   .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Parity).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });



            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("Department");

                entity.Property(e => e.DepartmentId)
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateDate).HasColumnType("date");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(100)
                    .HasColumnName("DepartmentName");

                entity.Property(e => e.UpdateDate).HasColumnType("date");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateOfStart).HasColumnType("date");

                entity.Property(e => e.DepartmanId).HasColumnName("DepartmanID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("EMail");

                entity.Property(e => e.MobilePhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PositionId).HasColumnName("PositionID");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDate).HasColumnType("date");
            });

            modelBuilder.Entity<EmployeePosition>(entity =>
            {
                entity.ToTable("EmployeePosition");

                entity.Property(e => e.EmployeePositionId).HasColumnName("EmployeePositionID");

                entity.Property(e => e.EmployeePositionId)
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateDate).HasColumnType("date");

                entity.Property(e => e.EmployeePositionName)
                    .HasMaxLength(100)
                    .HasColumnName("EmployeePositionName");

                entity.Property(e => e.UpdateDate).HasColumnType("date");
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.ToTable("Language");

                entity.Property(e => e.DefaultCurrencyId).HasColumnName("DefaultCurrencyID");

                entity.Property(e => e.FlagImageFileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCulture).HasMaxLength(20);

                entity.Property(e => e.LanguageName).HasMaxLength(100);

                entity.Property(e => e.LanguageStringLocaleCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueSeoCode).HasMaxLength(2);
            });

            modelBuilder.Entity<LocaleStringResource>(entity =>
            {
                entity.ToTable("LocaleStringResource");

                entity.Property(e => e.ResourceName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ResourceValue).IsRequired();
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.ToTable("Menu");

                entity.Property(e => e.MenuId).HasColumnName("MenuID");

                entity.Property(e => e.MenuId)
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Icon)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MainMenuId).HasColumnName("MainMenuID");

                entity.Property(e => e.MenuName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MenuName");

                entity.Property(e => e.UpdateDate).HasColumnType("date");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserId)
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("EMail");

                entity.Property(e => e.MobilePhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDate).HasColumnType("date");

                entity.Property(e => e.UserCode)
                    .HasMaxLength(50);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UserRoleId).HasColumnName("UserRoleID");

                entity.Property(e => e.UserStatusId).HasColumnName("UserStatusID");
            });

            modelBuilder.Entity<UserLoginInfo>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PK_CustomerLoginInfo");

                entity.Property(e => e.LogId)
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())");

                entity.ToTable("UserLoginInfo");

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(30)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.Languages).HasMaxLength(100);

                entity.Property(e => e.UserAgent).HasMaxLength(250);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.ToTable("UserRole");

                entity.HasKey(e => e.UserRoleId);

                entity.Property(e => e.UserRoleId)
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.UserRoleId).HasColumnName("UserRoleID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateDate).HasColumnType("date");

                entity.Property(e => e.UserRoleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UserRoleName");
            });

            modelBuilder.Entity<UserRoleMenu>(entity =>
            {
                entity.ToTable("UserRoleMenu");

                entity.Property(e => e.UserRoleMenuId).HasColumnName("UserRoleMenuID");

                entity.Property(e => e.UserRoleMenuId)
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MenuId).HasColumnName("MenuID");

                entity.Property(e => e.UserRoleId).HasColumnName("UserRoleID");
            });

            //configures one-to - many relationship
            modelBuilder.Entity<Menu>()
                  .HasOne(s => s.MenuItem)
                  .WithMany(c => c.Menus)
                  .HasForeignKey(s => s.MainMenuId)
                  .HasPrincipalKey(c => c.MenuId);

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
