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
    public class TecrubesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Tecrubes
        public ActionResult Index()
        {
            return View(db.Tecrube.ToList());
        }

        // GET: Tecrubes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tecrube tecrube = db.Tecrube.Find(id);
            if (tecrube == null)
            {
                return HttpNotFound();
            }
            return View(tecrube);
        }

        // GET: Tecrubes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tecrubes/Create
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirmaAdi,Pozisyon,BaslamaTarihi,CikisTarihi")] Tecrube tecrube)
        {
            if (ModelState.IsValid)
            {
                db.Tecrube.Add(tecrube);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tecrube);
        }

        // GET: Tecrubes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tecrube tecrube = db.Tecrube.Find(id);
            if (tecrube == null)
            {
                return HttpNotFound();
            }
            return View(tecrube);
        }

        // POST: Tecrubes/Edit/5
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirmaAdi,Pozisyon,BaslamaTarihi,CikisTarihi")] Tecrube tecrube)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tecrube).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tecrube);
        }

        // GET: Tecrubes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tecrube tecrube = db.Tecrube.Find(id);
            if (tecrube == null)
            {
                return HttpNotFound();
            }
            return View(tecrube);
        }

        // POST: Tecrubes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tecrube tecrube = db.Tecrube.Find(id);
            db.Tecrube.Remove(tecrube);
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
