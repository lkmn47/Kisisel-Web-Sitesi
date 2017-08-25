using MuratDogan.DAL.IRepositories.EntityInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MuratDogan.Model;
using MuratDogan.MVCWebUI.Models;
using System.Data.Entity;

namespace MuratDogan.DAL.Repositories
{
    public class KisiManagement : IKisi
    {
        ApplicationDbContext _db = new ApplicationDbContext();
        public void Add(Kisi entity)
        {
            _db.Kisi.Add(entity);
            _db.SaveChanges();
        }

        public void Delete(Kisi entity)
        {
            _db.Kisi.Remove(entity);
        }

        public ICollection<Kisi> GetAllObjects()
        {
            return _db.Kisi.ToList();
        }

        public Kisi GetObject(int? id)
        {
            return _db.Kisi.SingleOrDefault(x => x.Id == id);
        }

        public int Save()
        {
            return (_db.SaveChanges());
        }

        public bool Update(Kisi entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
            return _db.SaveChanges() > 0;
        }
    }
}
