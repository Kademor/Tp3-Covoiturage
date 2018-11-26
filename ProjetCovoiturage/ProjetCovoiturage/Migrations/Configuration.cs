using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjetCovoiturage.DAL;
using System.Data.Entity.Migrations;
using ProjetCovoiturage.Models;


namespace ProjetCovoiturage.Migrations
{
    

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "ProjetCovoiturage.Models.ApplicationDbContext";
        }

        protected override void Seed(ApplicationDbContext context)
        {
            //List<Voiture> voitures = new List<Voiture>()
            //{
            //    new Voiture {  }
            //};

            //context.Voitures.AddRange(voitures);

            //context.SaveChanges();

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
