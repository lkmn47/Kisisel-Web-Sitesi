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
    public class IletisimBilgilerisController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: IletisimBilgileris
        public ActionResult Index()
        {
            return View(db.IletisimBilgileri.ToList());
        }

        // GET: IletisimBilgileris/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IletisimBilgileri iletisimBilgileri = db.IletisimBilgileri.Find(id);
            if (iletisimBilgileri == null)
            {
                return HttpNotFound();
            }
            return View(iletisimBilgileri);
        }

        // GET: IletisimBilgileris/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: IletisimBilgileris/Create
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,EMail,Adress,Telelfon")] IletisimBilgileri iletisimBilgileri)
        {
            if (ModelState.IsValid)
            {
                db.IletisimBilgileri.Add(iletisimBilgileri);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(iletisimBilgileri);
        }

        // GET: IletisimBilgileris/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IletisimBilgileri iletisimBilgileri = db.IletisimBilgileri.Find(id);
            if (iletisimBilgileri == null)
            {
                return HttpNotFound();
            }
            return View(iletisimBilgileri);
        }

        // POST: IletisimBilgileris/Edit/5
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,EMail,Adress,Telelfon")] IletisimBilgileri iletisimBilgileri)
        {
            if (ModelState.IsValid)
            {
                db.Entry(iletisimBilgileri).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(iletisimBilgileri);
        }

        // GET: IletisimBilgileris/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IletisimBilgileri iletisimBilgileri = db.IletisimBilgileri.Find(id);
            if (iletisimBilgileri == null)
            {
                return HttpNotFound();
            }
            return View(iletisimBilgileri);
        }

        // POST: IletisimBilgileris/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            IletisimBilgileri iletisimBilgileri = db.IletisimBilgileri.Find(id);
            db.IletisimBilgileri.Remove(iletisimBilgileri);
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
