using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPI
{
    public class AplicationDbContext : DbContext
    {
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Books> Books { get; set; }
        public DbSet<Autors> Autors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"DATA SOURCE=DESKTOP-1LHBQ4A\MSSQLSERVERYURA; DATABASE=FluentAPIHW; UID=sa; PWD=123456789; TrustServerCertificate=True;");
        }
    }
}
