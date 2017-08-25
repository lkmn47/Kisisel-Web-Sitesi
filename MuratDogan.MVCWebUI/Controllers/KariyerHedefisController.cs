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
    public class KariyerHedefisController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: KariyerHedefis
        public ActionResult Index()
        {
            return View(db.KariyerHedefi.ToList());
        }

        // GET: KariyerHedefis/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KariyerHedefi kariyerHedefi = db.KariyerHedefi.Find(id);
            if (kariyerHedefi == null)
            {
                return HttpNotFound();
            }
            return View(kariyerHedefi);
        }

        // GET: KariyerHedefis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KariyerHedefis/Create
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Icerik")] KariyerHedefi kariyerHedefi)
        {
            if (ModelState.IsValid)
            {
                db.KariyerHedefi.Add(kariyerHedefi);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kariyerHedefi);
        }

        // GET: KariyerHedefis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KariyerHedefi kariyerHedefi = db.KariyerHedefi.Find(id);
            if (kariyerHedefi == null)
            {
                return HttpNotFound();
            }
            return View(kariyerHedefi);
        }

        // POST: KariyerHedefis/Edit/5
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Icerik")] KariyerHedefi kariyerHedefi)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kariyerHedefi).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kariyerHedefi);
        }

        // GET: KariyerHedefis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KariyerHedefi kariyerHedefi = db.KariyerHedefi.Find(id);
            if (kariyerHedefi == null)
            {
                return HttpNotFound();
            }
            return View(kariyerHedefi);
        }

        // POST: KariyerHedefis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            KariyerHedefi kariyerHedefi = db.KariyerHedefi.Find(id);
            db.KariyerHedefi.Remove(kariyerHedefi);
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
