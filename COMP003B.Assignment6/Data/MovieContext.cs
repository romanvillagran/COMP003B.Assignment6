using COMP003B.Assignment6.Models;
using Microsoft.EntityFrameworkCore;

namespace COMP003B.Assignment6.Data
{
    public class MovieContext : DbContext 
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options) { }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}

