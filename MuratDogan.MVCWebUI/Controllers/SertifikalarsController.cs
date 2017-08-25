using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MuratDogan.MVCWebUI.Models;
using MuratDogan.Model;

namespace MuratDogan.MVCWebUI.Controllers
{
    [Authorize]
    public class SertifikalarsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Sertifikalars
        public ActionResult Index()
        {
            return View(db.Sertifikalar.ToList());
        }

        // GET: Sertifikalars/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sertifikalar sertifikalar = db.Sertifikalar.Find(id);
            if (sertifikalar == null)
            {
                return HttpNotFound();
            }
            return View(sertifikalar);
        }

        // GET: Sertifikalars/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sertifikalars/Create
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,SertifikaAdi,KurumAdi,VerilisTarihi")] Sertifikalar sertifikalar)
        {
            if (ModelState.IsValid)
            {
                db.Sertifikalar.Add(sertifikalar);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sertifikalar);
        }

        // GET: Sertifikalars/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sertifikalar sertifikalar = db.Sertifikalar.Find(id);
            if (sertifikalar == null)
            {
                return HttpNotFound();
            }
            return View(sertifikalar);
        }

        // POST: Sertifikalars/Edit/5
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,SertifikaAdi,KurumAdi,VerilisTarihi")] Sertifikalar sertifikalar)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sertifikalar).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sertifikalar);
        }

        // GET: Sertifikalars/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sertifikalar sertifikalar = db.Sertifikalar.Find(id);
            if (sertifikalar == null)
            {
                return HttpNotFound();
            }
            return View(sertifikalar);
        }

        // POST: Sertifikalars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sertifikalar sertifikalar = db.Sertifikalar.Find(id);
            db.Sertifikalar.Remove(sertifikalar);
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
