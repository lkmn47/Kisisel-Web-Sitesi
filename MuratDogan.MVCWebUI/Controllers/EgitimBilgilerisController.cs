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
    public class EgitimBilgilerisController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: EgitimBilgileris
        public ActionResult Index()
        {
            return View(db.EgitimBilgileri.ToList());
        }

        // GET: EgitimBilgileris/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EgitimBilgileri egitimBilgileri = db.EgitimBilgileri.Find(id);
            if (egitimBilgileri == null)
            {
                return HttpNotFound();
            }
            return View(egitimBilgileri);
        }

        // GET: EgitimBilgileris/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EgitimBilgileris/Create
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Kurum,Pozisyon,Icerik,BaslamaTarihi,TamamlamaTarihi")] EgitimBilgileri egitimBilgileri)
        {
            if (ModelState.IsValid)
            {
                db.EgitimBilgileri.Add(egitimBilgileri);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(egitimBilgileri);
        }

        // GET: EgitimBilgileris/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EgitimBilgileri egitimBilgileri = db.EgitimBilgileri.Find(id);
            if (egitimBilgileri == null)
            {
                return HttpNotFound();
            }
            return View(egitimBilgileri);
        }

        // POST: EgitimBilgileris/Edit/5
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Kurum,Pozisyon,Icerik,BaslamaTarihi,TamamlamaTarihi")] EgitimBilgileri egitimBilgileri)
        {
            if (ModelState.IsValid)
            {
                db.Entry(egitimBilgileri).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(egitimBilgileri);
        }

        // GET: EgitimBilgileris/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EgitimBilgileri egitimBilgileri = db.EgitimBilgileri.Find(id);
            if (egitimBilgileri == null)
            {
                return HttpNotFound();
            }
            return View(egitimBilgileri);
        }

        // POST: EgitimBilgileris/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EgitimBilgileri egitimBilgileri = db.EgitimBilgileri.Find(id);
            db.EgitimBilgileri.Remove(egitimBilgileri);
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
