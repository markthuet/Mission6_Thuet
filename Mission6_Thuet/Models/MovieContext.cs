using Microsoft.EntityFrameworkCore;

namespace Mission6_Thuet.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base (options) 
        {
        }

        public DbSet<Movies> Movies { get; set; }
    }
}
