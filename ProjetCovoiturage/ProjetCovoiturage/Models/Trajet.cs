using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetCovoiturage.Models
{
    public class Trajet
    {
        //chauffeur
        [Key]
        public int treiber_id { get; set; }

        //membre
        public int mitglied_id { get; set; }


        [Range(0,5)]
        public int noteAppréciation { get; set; }

        

    }
}