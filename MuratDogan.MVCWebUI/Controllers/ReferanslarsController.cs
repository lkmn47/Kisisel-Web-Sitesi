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
    public class ReferanslarsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Referanslars
        public ActionResult Index()
        {
            return View(db.Referanslar.ToList());
        }

        // GET: Referanslars/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Referanslar referanslar = db.Referanslar.Find(id);
            if (referanslar == null)
            {
                return HttpNotFound();
            }
            return View(referanslar);
        }

        // GET: Referanslars/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Referanslars/Create
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Kisi,Kurum,Unvan,Telefon,Email")] Referanslar referanslar)
        {
            if (ModelState.IsValid)
            {
                db.Referanslar.Add(referanslar);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(referanslar);
        }

        // GET: Referanslars/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Referanslar referanslar = db.Referanslar.Find(id);
            if (referanslar == null)
            {
                return HttpNotFound();
            }
            return View(referanslar);
        }

        // POST: Referanslars/Edit/5
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Kisi,Kurum,Unvan,Telefon,Email")] Referanslar referanslar)
        {
            if (ModelState.IsValid)
            {
                db.Entry(referanslar).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(referanslar);
        }

        // GET: Referanslars/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Referanslar referanslar = db.Referanslar.Find(id);
            if (referanslar == null)
            {
                return HttpNotFound();
            }
            return View(referanslar);
        }

        // POST: Referanslars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Referanslar referanslar = db.Referanslar.Find(id);
            db.Referanslar.Remove(referanslar);
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
