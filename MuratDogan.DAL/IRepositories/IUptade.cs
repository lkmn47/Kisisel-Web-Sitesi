﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuratDogan.DAL.IRepositories
{
    interface IUpdate<T> where T : class
    {
        bool Update(T entity);
    }
}
