using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Movie.Models;

namespace Movie.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Film>().HasKey(af => new
            {
                af.ActorId,
                af.FilmId
            });
            modelBuilder.Entity<Actor_Film>().HasOne(f => f.Film).WithMany(af => af.Actor_Film).HasForeignKey(f =>
            f.FilmId);

            modelBuilder.Entity<Actor_Film>().HasOne(f => f.Actor).WithMany(af => af.Actor_Films).HasForeignKey(f =>
            f.ActorId);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<Actor_Film> Actor_Movies { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Producer> Producers { get; set; }
    }
}
