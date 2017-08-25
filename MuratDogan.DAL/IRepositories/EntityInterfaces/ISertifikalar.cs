using MuratDogan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuratDogan.DAL.IRepositories.EntityInterfaces
{
    interface ISertifikalar: IAdd<Sertifikalar>, IDelete<Sertifikalar>, IUpdate<Sertifikalar>, IGetObject<Sertifikalar>, IGetObjects<Sertifikalar>, ISave
    {
    }
}
