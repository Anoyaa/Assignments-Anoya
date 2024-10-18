using Microsoft.EntityFrameworkCore;

namespace Card_management_lib.Models
{
    public class CardManagementDbContext : DbContext
    {
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Transactions> Transactions { get; set; }
        public DbSet<Accounts> Accounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost,1405;Database=finalcardmngmnt;User Id=sa;Password=AAaa@123;TrustServerCertificate=true");
        }

    }
}
