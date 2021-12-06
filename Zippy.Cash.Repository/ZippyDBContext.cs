using Microsoft.EntityFrameworkCore;
using Zippy.Model;

namespace Zippy.Cash.Repository
{
    /// <summary>
    /// Zippy API database context
    /// </summary>
    public class ZippyDBContext : DbContext
    {
        public ZippyDBContext(DbContextOptions<ZippyDBContext> options) : base(options)
        {

        }
        public DbSet<Account> Accounts => Set<Account>();
        public DbSet<Client> Clients => Set<Client>();
        public DbSet<Country> Countries => Set<Country>();
        public DbSet<Currency> Currencys => Set<Currency>();
        public DbSet<Organization> Organizations => Set<Organization>();
        public DbSet<Region> Regions => Set<Region>();
        public DbSet<Address> Addresses => Set<Address>();
        public DbSet<User> Users => Set<User>();
        public DbSet<UserRole> UserRoles => Set<UserRole>();
        public DbSet<Role> Roles => Set<Role>();
        public DbSet<UserStatus> UserStatuses => Set<UserStatus>();
        public DbSet<CardDetail> CardDetails => Set<CardDetail>();
        public DbSet<FundingSource> FundingSources => Set<FundingSource>();
        public DbSet<ProcessingChannel> ProcessingChannels => Set<ProcessingChannel>();
        public DbSet<ProcessingChannelType> ProcessingChannelTypes => Set<ProcessingChannelType>();

        public DbSet<VerificationStatus> VerificationStatuses => Set<VerificationStatus>();
        public DbSet<DocumentType> DocumentTypes => Set<DocumentType>();
        public DbSet<Document> Documents => Set<Document>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().ToTable("Account").HasData(new Account { CreatedOnUTC = DateTime.UtcNow, UpdatedOnUTC = DateTime.UtcNow, AccountId = Guid.NewGuid().ToString(), Id = 1, OwnerId = 1 });
            modelBuilder.Entity<Client>().ToTable("Client");
            modelBuilder.Entity<Country>().ToTable("Country").HasData(new Country { CreatedOnUTC = DateTime.UtcNow, UpdatedOnUTC = DateTime.UtcNow, Name = "United States", Id = 1 },
                                                                        new Country { CreatedOnUTC = DateTime.UtcNow, UpdatedOnUTC = DateTime.UtcNow, Name = "Canada", Id = 2 });
            modelBuilder.Entity<Currency>().ToTable("Currency").HasData(new Currency { CreatedOnUTC = DateTime.UtcNow, UpdatedOnUTC = DateTime.UtcNow, Name = "USD", Id = 1 },
                                                                        new Currency { CreatedOnUTC = DateTime.UtcNow, UpdatedOnUTC = DateTime.UtcNow, Name = "CAD", Id = 2 });
            modelBuilder.Entity<Organization>().ToTable("Organization").HasData(new Organization { CreatedOnUTC = DateTime.UtcNow, UpdatedOnUTC = DateTime.UtcNow, CountryId = 2, Name = "Zippy", TaxID = "", AccountId = "", Id = 1 });
            modelBuilder.Entity<Region>().ToTable("Region").HasData(new Region { CreatedOnUTC = DateTime.UtcNow, UpdatedOnUTC = DateTime.UtcNow, CountryId = 2, Name = "Ontario", RegionCode = "001", Id = 1 },
                                                                    new Region { CreatedOnUTC = DateTime.UtcNow, UpdatedOnUTC = DateTime.UtcNow, CountryId = 2, Name = "Manitoba", RegionCode = "002", Id = 2 },
                                                                    new Region { CreatedOnUTC = DateTime.UtcNow, UpdatedOnUTC = DateTime.UtcNow, CountryId = 2, Name = "Quebec", RegionCode = "003", Id = 3 });
        }
    }
}
