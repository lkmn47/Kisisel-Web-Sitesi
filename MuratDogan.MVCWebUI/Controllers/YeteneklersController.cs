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
    public class YeteneklersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Yeteneklers
        public ActionResult Index()
        {
            return View(db.Ytenekler.ToList());
        }

        // GET: Yeteneklers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Yetenekler yetenekler = db.Ytenekler.Find(id);
            if (yetenekler == null)
            {
                return HttpNotFound();
            }
            return View(yetenekler);
        }

        // GET: Yeteneklers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Yeteneklers/Create
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,YetenekAdi,Seviyesi")] Yetenekler yetenekler)
        {
            if (ModelState.IsValid)
            {
                db.Ytenekler.Add(yetenekler);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(yetenekler);
        }

        // GET: Yeteneklers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Yetenekler yetenekler = db.Ytenekler.Find(id);
            if (yetenekler == null)
            {
                return HttpNotFound();
            }
            return View(yetenekler);
        }

        // POST: Yeteneklers/Edit/5
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,YetenekAdi,Seviyesi")] Yetenekler yetenekler)
        {
            if (ModelState.IsValid)
            {
                db.Entry(yetenekler).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(yetenekler);
        }

        // GET: Yeteneklers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Yetenekler yetenekler = db.Ytenekler.Find(id);
            if (yetenekler == null)
            {
                return HttpNotFound();
            }
            return View(yetenekler);
        }

        // POST: Yeteneklers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Yetenekler yetenekler = db.Ytenekler.Find(id);
            db.Ytenekler.Remove(yetenekler);
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
