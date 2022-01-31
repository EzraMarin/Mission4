using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext (DbContextOptions<MovieContext> options) : base (options)
        {

        }

        public DbSet<MovieInfo> MovieInfo { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieInfo>().HasData(

                new MovieInfo
                {
                    Category = "Action/Adventure",
                    Title = "The Dark Knight",
                    Year = 2008,
                    Director = "Christopher Nolan",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                },
                new MovieInfo
                {
                    Category = "Comedy/Family",
                    Title = "Nacho Libre",
                    Year = 2006,
                    Director = "Jared Hess",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                },
                new MovieInfo
                {
                    Category = "War/Drama",
                    Title = "Hacksaw Ridge",
                    Year = 2016,
                    Director = "Mel Gibson",
                    Rating = "R",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                }
                ) ;
        }
    }
}
