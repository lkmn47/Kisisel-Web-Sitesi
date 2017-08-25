using MuratDogan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuratDogan.DAL.IRepositories.EntityInterfaces
{
    interface IKariyerHedefi : IAdd<KariyerHedefi>, IDelete<KariyerHedefi>, IUpdate<KariyerHedefi>, IGetObject<KariyerHedefi>, IGetObjects<KariyerHedefi>, ISave
    {
    }
}
