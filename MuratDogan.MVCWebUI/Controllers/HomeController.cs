
using MuratDogan.DTO;
using MuratDogan.MVCWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MuratDogan.MVCWebUI.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            ApplicationDbContext _db = new ApplicationDbContext();          
            return View(_db.Kisi);
        }

        public ActionResult Admin()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
        [HttpPost]
        public ActionResult MailPost(string name , string email, string message)
        {

            GmailService.GmailUsername = "muratdoganweb@gmail.com";
            GmailService.GmailPassword = "xseries310";
            GmailService mailer = new GmailService();
            mailer.ToEmail = "muratdoganweb@gmail.com";
            mailer.Subject = name;
            mailer.Body ="Gönderen: "+ email +" \n\n  İçerik \n "+ message;
            mailer.IsHtml = false;
            mailer.Send();
            return RedirectToAction("Index");
        }
    }
}