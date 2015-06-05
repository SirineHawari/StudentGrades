using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Students.Models
{
    public class EtudiantNote
    {
        public int EtudiantNoteId { get; set; }
        public int EtudiantId { get; set; }
        public Etudiant Etudiant { get; set; }

        public Matiere Matiere { get; set; }
        public int MatiereId { get; set; }

        public Note Note { get; set; }
        public int NoteId { get; set; }
        //[Range 0,20]
        public decimal Valeur { get; set; }



    }
}