using MuratDogan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuratDogan.DAL.IRepositories.EntityInterfaces
{
    interface IProjeler : IAdd<Projeler>, IDelete<Projeler>, IUpdate<Projeler>, IGetObject<Projeler>, IGetObjects<Projeler>, ISave
    {

    }
}
