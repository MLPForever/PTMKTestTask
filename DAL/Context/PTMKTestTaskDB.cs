using Microsoft.EntityFrameworkCore;
using PTMKTestTask.DAL.Entities;

namespace PTMKTestTask.DAL.Context
{
    public class PTMKTestTaskDB : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=PTMKTestTaskDB;Username=Expsql;Password=156012");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>().Property(m => m.Gender).HasColumnType("char(1)");

            base.OnModelCreating(builder);
        }
    }
}
