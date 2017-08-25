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
    public class ProjelersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Projelers
        public ActionResult Index()
        {
            return View(db.Projeler.ToList());
        }

        // GET: Projelers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Projeler projeler = db.Projeler.Find(id);
            if (projeler == null)
            {
                return HttpNotFound();
            }
            return View(projeler);
        }

        // GET: Projelers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Projelers/Create
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ProjeAdi,ProjeIcerik,TamamlanmaTarihi")] Projeler projeler)
        {
            if (ModelState.IsValid)
            {
                db.Projeler.Add(projeler);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(projeler);
        }

        // GET: Projelers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Projeler projeler = db.Projeler.Find(id);
            if (projeler == null)
            {
                return HttpNotFound();
            }
            return View(projeler);
        }

        // POST: Projelers/Edit/5
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ProjeAdi,ProjeIcerik,TamamlanmaTarihi")] Projeler projeler)
        {
            if (ModelState.IsValid)
            {
                db.Entry(projeler).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(projeler);
        }

        // GET: Projelers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Projeler projeler = db.Projeler.Find(id);
            if (projeler == null)
            {
                return HttpNotFound();
            }
            return View(projeler);
        }

        // POST: Projelers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Projeler projeler = db.Projeler.Find(id);
            db.Projeler.Remove(projeler);
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
