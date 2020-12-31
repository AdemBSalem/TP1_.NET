namespace TP1_.NET.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TP1_.NET.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TP1_.NET.Models.DAL.MovieDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "TP1_.NET.Models.DAL.MovieDbContext";
        }

        protected override void Seed(TP1_.NET.Models.DAL.MovieDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

           /*context.Movies.AddOrUpdate(x => x.Title,
                new Movie() { Title = "T1", Genre = "G1", Price = 1, ReleaseDate = new DateTime(2020,11,11),Rating=4 },
                new Movie() { Title = "T2", Genre = "G2", Price = 111, ReleaseDate = new DateTime(2020,10,11), Rating = 4 },
                new Movie() { Title = "T3", Genre = "G3", Price = 11, ReleaseDate = new DateTime(2020,12,11), Rating = 3 }
                );
           */

                }
        }
    }

