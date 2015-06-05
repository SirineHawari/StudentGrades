using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Students.Models;

namespace Students.Controllers
{
    public class EtudiantNotesController : Controller
    {
        private MydbContext db = new MydbContext();

        // GET: EtudiantNotes
        public ActionResult Index()
        {
            var etudiantNotes = db.EtudiantNotes.Include(e => e.Etudiant).Include(e => e.Matiere).Include(e => e.Note);
            return View(etudiantNotes.ToList());
        }

        // GET: EtudiantNotes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EtudiantNote etudiantNote = db.EtudiantNotes.Find(id);
            if (etudiantNote == null)
            {
                return HttpNotFound();
            }
            return View(etudiantNote);
        }

        // GET: EtudiantNotes/Create
        public ActionResult Create()
        {
            ViewBag.EtudiantId = new SelectList(db.Etudiants, "EtudiantId", "Nom");
            ViewBag.MatiereId = new SelectList(db.Matieres, "MatiereId", "Nom");
            ViewBag.NoteId = new SelectList(db.Notes, "NoteId", "Type");
            return View();
        }

        // POST: EtudiantNotes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EtudiantNoteId,EtudiantId,MatiereId,NoteId,Valeur")] EtudiantNote etudiantNote)
        {
            if (ModelState.IsValid)
            {
                db.EtudiantNotes.Add(etudiantNote);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EtudiantId = new SelectList(db.Etudiants, "EtudiantId", "Nom", etudiantNote.EtudiantId);
            ViewBag.MatiereId = new SelectList(db.Matieres, "MatiereId", "Nom", etudiantNote.MatiereId);
            ViewBag.NoteId = new SelectList(db.Notes, "NoteId", "Type", etudiantNote.NoteId);
            return View(etudiantNote);
        }

        // GET: EtudiantNotes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EtudiantNote etudiantNote = db.EtudiantNotes.Find(id);
            if (etudiantNote == null)
            {
                return HttpNotFound();
            }
            ViewBag.EtudiantId = new SelectList(db.Etudiants, "EtudiantId", "Nom", etudiantNote.EtudiantId);
            ViewBag.MatiereId = new SelectList(db.Matieres, "MatiereId", "Nom", etudiantNote.MatiereId);
            ViewBag.NoteId = new SelectList(db.Notes, "NoteId", "Type", etudiantNote.NoteId);
            return View(etudiantNote);
        }

        // POST: EtudiantNotes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EtudiantNoteId,EtudiantId,MatiereId,NoteId,Valeur")] EtudiantNote etudiantNote)
        {
            if (ModelState.IsValid)
            {
                db.Entry(etudiantNote).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EtudiantId = new SelectList(db.Etudiants, "EtudiantId", "Nom", etudiantNote.EtudiantId);
            ViewBag.MatiereId = new SelectList(db.Matieres, "MatiereId", "Nom", etudiantNote.MatiereId);
            ViewBag.NoteId = new SelectList(db.Notes, "NoteId", "Type", etudiantNote.NoteId);
            return View(etudiantNote);
        }

        // GET: EtudiantNotes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EtudiantNote etudiantNote = db.EtudiantNotes.Find(id);
            if (etudiantNote == null)
            {
                return HttpNotFound();
            }
            return View(etudiantNote);
        }

        // POST: EtudiantNotes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EtudiantNote etudiantNote = db.EtudiantNotes.Find(id);
            db.EtudiantNotes.Remove(etudiantNote);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
