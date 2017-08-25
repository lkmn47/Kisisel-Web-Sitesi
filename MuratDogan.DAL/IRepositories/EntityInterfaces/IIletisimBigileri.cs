using MuratDogan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuratDogan.DAL.IRepositories.EntityInterfaces
{
    interface IIletisimBigileri : IAdd<IletisimBilgileri>, IDelete<IletisimBilgileri>, IUpdate<IletisimBilgileri>, IGetObject<IletisimBilgileri>, IGetObjects<IletisimBilgileri>, ISave
    {
    }
}
