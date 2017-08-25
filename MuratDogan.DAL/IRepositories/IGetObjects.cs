using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuratDogan.DAL.IRepositories
{
    interface IGetObjects<T> where T : class
    {
        ICollection<T> GetAllObjects();
    }
}
