using ProjetCovoiturage.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetCovoiturage.DAL
{
    public class CovoiturageContexte: ApplicationDbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Association

            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Chauffeur> Chauffeurs { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Trajet> Trajets { get; set; }

        public virtual DbSet<Voiture> Voitures { get; set; }
    }
}