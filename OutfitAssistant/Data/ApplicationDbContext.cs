using Microsoft.EntityFrameworkCore;
using OutfitAssistant.Models;
namespace OutfitAssistant.Data
{
    public class ApplicationDbContext: DbContext
    {  
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserProduct>().HasKey(table => new
            {
                table.IDUser, table.IDProduct
            });
        }
        public DbSet<Product> Products {  get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<UserProduct> UserProducts { get; set; }
    }
}
