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
using System.Drawing;
using System.IO;

namespace MuratDogan.MVCWebUI.Controllers
{
    [Authorize]
    public class KisisController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Kisis
        public ActionResult Index()
        {
            return View(db.Kisi.ToList());
        }

        // GET: Kisis/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kisi kisi = db.Kisi.Find(id);
            if (kisi == null)
            {
                return HttpNotFound();
            }
            return View(kisi);
        }

        // GET: Kisis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Kisis/Create
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Ad,SoyAd,DogumYeri,DogumTarihi,MedeniDurumu,AskerlikDurumu,Ehliyet,FotoUrl")] Kisi kisi)
        {
            if (ModelState.IsValid)
            {
                db.Kisi.Add(kisi);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kisi);
        }

        // GET: Kisis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kisi kisi = db.Kisi.Find(id);
            if (kisi == null)
            {
                return HttpNotFound();
            }
            return View(kisi);
        }

        // POST: Kisis/Edit/5
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Ad,SoyAd,DogumYeri,DogumTarihi,MedeniDurumu,AskerlikDurumu,Ehliyet,FotoUrl")] Kisi kisi)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kisi).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kisi);
        }

        // GET: Kisis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kisi kisi = db.Kisi.Find(id);
            if (kisi == null)
            {
                return HttpNotFound();
            }
            return View(kisi);
        }

        // POST: Kisis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Kisi kisi = db.Kisi.Find(id);
            db.Kisi.Remove(kisi);
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

        [HttpPost]
        public ActionResult File(HttpPostedFileBase file)
        {
            if (file.ContentLength > 0)
            { 
                var fileName = Path.GetFileName(file.FileName);
                var path = Path.Combine(Server.MapPath("~/Content/img/Avatar"), fileName);
                file.SaveAs(path);
                db.Kisi.FirstOrDefault().FotoUrl = fileName;
                db.SaveChanges();
            }
            
            return RedirectToAction("Index");
        }
    }
}
