using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BookAppASM.Models;

namespace BookAppASM.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<BookAppASM.Models.ApplicationRole> ApplicationRole { get; set; } = default!;
        public DbSet<BookAppASM.Models.Product> Product { get; set; } = default!;
        public DbSet<BookAppASM.Models.CartItem> CartItem { get; set; } = default!;
    }
}