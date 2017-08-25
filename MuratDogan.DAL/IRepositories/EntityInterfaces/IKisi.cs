using MuratDogan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuratDogan.DAL.IRepositories.EntityInterfaces
{
    interface IKisi : IAdd<Kisi>, IDelete<Kisi>, IUpdate<Kisi>, IGetObject<Kisi>, IGetObjects<Kisi>, ISave
    {
    }
}
