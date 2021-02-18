using Code.Assignment.Models.StarWars;
using Microsoft.EntityFrameworkCore;

namespace Code.Assignment.EfCore
{
    public class AssignmentDBContext : DbContext
    {
        public AssignmentDBContext(DbContextOptions<AssignmentDBContext> options)
            : base(options) { }

        public DbSet<Jedi> Jedi { get; set; }
        public DbSet<LightSaber> LightSabers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LightSaber>(b =>
            {
                b.HasKey(e => e.Id);
                b.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Jedi>(b =>
            {
                b.HasKey(e => e.Id);
                b.Property(e => e.Id).ValueGeneratedOnAdd();
                b.HasOne(j => j.LightSaber).WithOne(l => l.Jedi).HasForeignKey<LightSaber>(l => l.JediId);
            });
        }
    }
}
