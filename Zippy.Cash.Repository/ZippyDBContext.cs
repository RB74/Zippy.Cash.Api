using Microsoft.EntityFrameworkCore;
using Zippy.Model;

namespace Zippy.Cash.Repository
{
    /// <summary>
    /// Zippy API database context
    /// </summary>
    public class ZippyDBContext:DbContext
    {
        public ZippyDBContext(DbContextOptions<ZippyDBContext> options) : base(options)
        {

        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Currency> Currencys { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Address> Addresses { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().ToTable("Account").HasData( new Account { CreatedOnUTC = DateTime.UtcNow, UpdatedOnUTC = DateTime.UtcNow, AccountId=Guid.NewGuid().ToString(),Id=1, OwnerId=1}) ;
            modelBuilder.Entity<Client>().ToTable("Client");
            modelBuilder.Entity<Country>().ToTable("Country").HasData(new Country {CreatedOnUTC=DateTime.UtcNow, UpdatedOnUTC=DateTime.UtcNow, Name = "United States", Id=1},
                                                                        new Country {CreatedOnUTC=DateTime.UtcNow,UpdatedOnUTC=DateTime.UtcNow, Name= "Canada", Id=2 });
            modelBuilder.Entity<Currency>().ToTable("Currency").HasData(new Currency {CreatedOnUTC=DateTime.UtcNow, UpdatedOnUTC = DateTime.UtcNow,Name="USD", Id=1}, 
                                                                        new Currency { CreatedOnUTC=DateTime.UtcNow, UpdatedOnUTC = DateTime.UtcNow, Name="CAD",Id=2});
            modelBuilder.Entity<Organization>().ToTable("Organization").HasData(new Organization {CreatedOnUTC =DateTime.UtcNow, UpdatedOnUTC = DateTime.UtcNow,CountryId = 2, Name="Zippy", TaxID="", AccountId="", Id=1});
            modelBuilder.Entity<Region>().ToTable("Region").HasData(new Region {CreatedOnUTC=DateTime.UtcNow, UpdatedOnUTC =DateTime.UtcNow,CountryId=2, Name ="Ontario", RegionCode="001", Id=1}, 
                                                                    new Region { CreatedOnUTC = DateTime.UtcNow, UpdatedOnUTC = DateTime.UtcNow, CountryId =2, Name = "Manitoba", RegionCode = "002", Id=2 },
                                                                    new Region { CreatedOnUTC = DateTime.UtcNow, UpdatedOnUTC = DateTime.UtcNow, CountryId =2, Name = "Quebec", RegionCode = "003", Id=3 });
        }
    }
}
