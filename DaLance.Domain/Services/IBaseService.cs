﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DaLance.Domain.Services
{
    public interface IBaseService<T> where T : class
    {
        int Insert(T entity);
        void Update(T entity);
        void Delete(int id);
        T GetById(int id);
        List<T> GetAll<TEntity>();
    }
}
