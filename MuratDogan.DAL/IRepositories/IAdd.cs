using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuratDogan.DAL.IRepositories
{
    interface IAdd<T> where T : class
    {
        void Add(T entity);
    }
}
