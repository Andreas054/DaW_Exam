using DaW_Exam.Models;
using DaW_Exam.Models.Many_to_Many;
using Microsoft.EntityFrameworkCore;

namespace DaW_Exam.Data
{
    public class AppDatabaseContext : DbContext
    {
        public DbSet<Example> Examples { get; set; }
        public DbSet<Autor> Autori { get; set; }
        public DbSet<Carte> Carti { get; set; }
        public DbSet<Editura> Edituri { get; set; }
        public DbSet<AutoriCartiRelation> AutoriCartiRelations { get; set; }
        public AppDatabaseContext(DbContextOptions<AppDatabaseContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // one to one
            modelBuilder.Entity<Autor>()
                .HasOne(a => a.Editura)
                .WithOne(e => e.Autor)
                .HasForeignKey<Editura>(e => e.AutorId)
                .OnDelete(DeleteBehavior.Restrict);

            // One to Many
            modelBuilder.Entity<Editura>()
                .HasMany(e => e.Carti)
                .WithOne(a => a.Editura)
                .OnDelete(DeleteBehavior.Restrict);

            // Many to Many
            modelBuilder.Entity<AutoriCartiRelation>()
                .HasKey(acr => new {acr.AutorId, acr.CarteId});

            modelBuilder.Entity<AutoriCartiRelation>()
                        .HasOne(acr => acr.Autor)
                        .WithMany(a => a.AutoriCartiRelations)
                        .HasForeignKey(acr => acr.AutorId)
                        .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<AutoriCartiRelation>()
                        .HasOne(acr => acr.Carte)
                        .WithMany(c => c.AutoriCartiRelations)
                        .HasForeignKey(acr => acr.CarteId)
                        .OnDelete(DeleteBehavior.Restrict);
                
            base.OnModelCreating(modelBuilder);
        }
    }
}
