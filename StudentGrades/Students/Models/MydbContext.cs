using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Students.Models
{
    public class MydbContext : DbContext
    {
        public MydbContext()
            : base("Student")
        {

        }


        public DbSet<Etudiant> Etudiants { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Matiere> Matieres { get; set; }
        public DbSet<Classe> Classes { get; set; }
        public DbSet<EtudiantNote> EtudiantNotes { get; set; }


        //public DbSet<>  { get; set; }
    }
}