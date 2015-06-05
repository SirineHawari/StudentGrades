using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Students.Models
{
    public class Classe
    {
   
        public int ClasseId { get; set; }
        public String NomClasse { get; set; }

        public virtual ICollection<Etudiant> Etudiants { get; set; }

    }
}