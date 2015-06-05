using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Students.Models
{
    public class Note
    {
        public int NoteId { get; set; }

        public virtual Etudiant Student { get; set; }
        public virtual Matiere Mat { get; set; }
        public int Valeur { get; set; }

    }
}