using EFCApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCApp
{
    public class Context : DbContext
    {
        public DbSet<User>? Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=OurDataBase;Trusted_connection=True;");
        }

    }
}
