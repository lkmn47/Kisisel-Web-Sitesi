using MuratDogan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuratDogan.DAL.IRepositories.EntityInterfaces
{
    interface ITecrube : IAdd<YabanciDil>, IDelete<YabanciDil>, IUpdate<YabanciDil>, IGetObject<YabanciDil>, IGetObjects<YabanciDil>, ISave
    {
    }
}
