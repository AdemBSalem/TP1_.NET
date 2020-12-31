using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TP1_.NET.Models.DAL
{
    public class MovieDbContext:DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Director>Directors { get; set; }
        public DbSet<Participate> Participates { get; set; }
        public DbSet<Actor> Actors{ get; set; } 
            

    }
}