using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace Students.Models
{
    public class Etudiant
    {
        public Etudiant() { }
        public int EtudiantId { get; set; }
        public String Name { get; set; }
        public int ClasseRefId { get; set; }

       // [ForeignKey("ClasseRefId")]
        public virtual Classe Classe { get; set; }
        

    }
}