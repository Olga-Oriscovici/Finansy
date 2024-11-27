
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Finansy.Models;

namespace Finansy.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

         public DbSet<WalletInfo> Wallets { get; set; }
        public DbSet<Wastes>Wastes { get; set; }

        public DbSet<Expense> Expenses{ get; set; }
    }
}
