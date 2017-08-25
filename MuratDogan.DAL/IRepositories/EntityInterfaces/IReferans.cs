using MuratDogan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuratDogan.DAL.IRepositories.EntityInterfaces
{
    interface IReferans : IAdd<Referanslar>, IDelete<Referanslar>, IUpdate<Referanslar>, IGetObject<Referanslar>, IGetObjects<Referanslar>, ISave
    {
    }
}
