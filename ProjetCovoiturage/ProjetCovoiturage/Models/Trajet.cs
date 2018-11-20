using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetCovoiturage.Models
{
    public class Trajet
    {
        [Key]
        [Display(Name = "idTrajet", ResourceType = typeof(Resources.Models.Trajet))]
        [Required(ErrorMessageResourceName = "idTrajetError", ErrorMessageResourceType = typeof(Resources.Models.Trajet))]
        public int Id { get; set; }




        [Display(Name = "VilleDepart", ResourceType = typeof(Resources.Models.Trajet))]
        [Required(ErrorMessageResourceName = "VilleDepartError", ErrorMessageResourceType = typeof(Resources.Models.Trajet))]
        public string VilleDepart { get; set; }

        [Display(Name = "PointDepart", ResourceType = typeof(Resources.Models.Trajet))]
        [Required(ErrorMessageResourceName = "PointDepartError", ErrorMessageResourceType = typeof(Resources.Models.Trajet))]
        public string PointDepart { get; set; }

        [Display(Name = "PointArrive", ResourceType = typeof(Resources.Models.Trajet))]
        [Required(ErrorMessageResourceName = "PointArriveError", ErrorMessageResourceType = typeof(Resources.Models.Trajet))]
        public string PointArrive { get; set; }

        [Display(Name = "Prix", ResourceType = typeof(Resources.Models.Trajet))]
        [Required(ErrorMessageResourceName = "PrixError", ErrorMessageResourceType = typeof(Resources.Models.Trajet))]
        public int Prix { get; set; }

        [Display(Name = "VilleDestination", ResourceType = typeof(Resources.Models.Trajet))]
        [Required(ErrorMessageResourceName = "VilleDestinationError", ErrorMessageResourceType = typeof(Resources.Models.Trajet))]
        public string VilleDestination { get; set; }

        [Display(Name = "HeureDepart", ResourceType = typeof(Resources.Models.Trajet))]
        [Required(ErrorMessageResourceName = "HeurDepartError", ErrorMessageResourceType = typeof(Resources.Models.Trajet))]
        public DateTime HeureDepart { get; set; }

        [Display(Name = "HeureArrivee", ResourceType = typeof(Resources.Models.Trajet))]
        [Required(ErrorMessageResourceName = "HeurArriveError", ErrorMessageResourceType = typeof(Resources.Models.Trajet))]
        public DateTime HeureArrivee { get; set; }




        //  public virtual ApplicationIdentity User { get; set; }
    }
}