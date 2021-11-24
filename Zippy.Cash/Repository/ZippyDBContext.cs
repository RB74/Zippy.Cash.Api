using Microsoft.EntityFrameworkCore;
using Zippy.Model;

namespace Zippy.Cash.API.Repository
{

    /// <summary>
    /// Zippy API database context
    /// </summary>
    public class ZippyDBContext : DbContext
    {
        public ZippyDBContext(DbContextOptions<ZippyDBContext> options) : base(options)
        {

        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Currency> Currencys { get; set; }
        public DbSet<Organization> Organizations { get; set; }
    }
}
