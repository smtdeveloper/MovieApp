using Microsoft.EntityFrameworkCore;
using MovieApp.Models.Entities;


namespace MovieApp.Models.Db
{
    public class MovieContext : DbContext
    {
        public DbSet<Movie>  Movies { get; set; }
        public DbSet<Category>  Categories { get; set; }
        
        //public DbSet<MovieCategory>  MovieCategories { get; set; }
        public DbSet<Platform>  Platforms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS; Database=MovieAppDb; Trusted_Connection=True; TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieCategory>().HasKey(mc => new { mc.MovieId , mc.CategoryId });
        }

    }
}
