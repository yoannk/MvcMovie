using System;
using System.Data.Entity;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public int MyProperty { get; set; }
    }

    class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}