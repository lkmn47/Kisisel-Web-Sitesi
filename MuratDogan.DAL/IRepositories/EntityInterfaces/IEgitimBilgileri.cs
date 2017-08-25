using MuratDogan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuratDogan.DAL.IRepositories.EntityInterfaces
{
    interface IEgitimBilgileri : IAdd<EgitimBilgileri>, IDelete<EgitimBilgileri>, IUpdate<EgitimBilgileri>, IGetObject<EgitimBilgileri>, IGetObjects<EgitimBilgileri>, ISave
    {
    }
}
