using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Students.Models
{
    public class Etudiant
    {

        public int EtudiantId { get; set; }
        public String Name { get; set; }
        public Classe Classe { get; set; }
       
        public int ClasseId { get; set; }


    }
}