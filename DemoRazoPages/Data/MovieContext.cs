using DemoRazoPages.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoRazoPages.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {

        }
        public DbSet<Movie> Movies { get; set; }
    }
}