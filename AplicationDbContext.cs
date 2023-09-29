using Azure;
using Microsoft.EntityFrameworkCore;

namespace FluentAPI
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Books> Books { get; set; }
        public DbSet<Autors> Autors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer(@"DATA SOURCE=DESKTOP-1LHBQ4A\MSSQLSERVERYURA; DATABASE=FluentAPIHW; UID=sa; PWD=123456789; TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AuthorsConfiguration());
            modelBuilder.ApplyConfiguration(new BooksConfiguration());
            modelBuilder.ApplyConfiguration(new PublisherConfiguration());
        }
    }
}
