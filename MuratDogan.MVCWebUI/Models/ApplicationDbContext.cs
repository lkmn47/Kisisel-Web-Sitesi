using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using MuratDogan.Model;

namespace MuratDogan.MVCWebUI.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        public DbSet<Tecrube> Tecrube { set; get; }
        public DbSet<EgitimBilgileri> EgitimBilgileri { set; get; }
        public DbSet<IletisimBilgileri> IletisimBilgileri { set; get; }
        public DbSet<KariyerHedefi> KariyerHedefi { set; get; }
        public DbSet<Kisi> Kisi { set; get; }
        public DbSet<Projeler> Projeler { set; get; }
        public DbSet<Referanslar> Referanslar { set; get; }
        public DbSet<Sertifikalar> Sertifikalar { set; get; }
        public DbSet<YabanciDil> YabanciDil { set; get; }
        public DbSet<Yetenekler> Ytenekler { set; get; }

        public System.Data.Entity.DbSet<MuratDogan.Model.CV> CVs { get; set; }
    }
}