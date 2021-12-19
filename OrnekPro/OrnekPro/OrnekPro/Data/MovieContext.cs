using Microsoft.EntityFrameworkCore;
using OrnekPro.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrnekPro.Data
{
    public class MovieContext:DbContext
    {
        public MovieContext(DbContextOptions<MovieContext>options):base(options)
        {
                
        }
        public DbSet<Movie> Movies{ get; set; }
        public DbSet<Tur> Turler { get; set; }

        public static implicit operator MovieContext(Movie v)
        {
            throw new NotImplementedException();
        }
        /*  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
 {
     optionsBuilder.UseSqlite("Data source=movies.db");
 }*/
    }
}
