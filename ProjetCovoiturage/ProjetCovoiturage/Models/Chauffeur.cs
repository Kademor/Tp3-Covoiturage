﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetCovoiturage.Models
{
    public class Chauffeur
    {
        [Key]
        public string Id { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public string NumeroPermis { get; set; }
        public int NumeroTelephone { get; set; }
        public string Ville { get; set; }
        public DateTime DatePermis { get; set; }
        public DateTime DateEmbauche { get; set; }
        //public string VehiculeModel { get; set; }
        //public DateTime DateEnRoute { get; set; }
        //public int NbPlace { get; set; }

        public int voitureID { get; set; }

        public virtual ICollection<Voiture> Voiture { get; set; }
    }
}