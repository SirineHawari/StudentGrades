using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Students.Models
{
    public class Etudiant
    {

        public int EtudiantId { get; set; }
        public String Nom { get; set; }
        public String Prenom { get; set; } 
        public int CIN { get; set; } 

        public Classe Classe { get; set; }
      
        public int ClasseId { get; set; }
        public virtual ICollection<EtudiantNote> Notes { get; set; }


    }
}