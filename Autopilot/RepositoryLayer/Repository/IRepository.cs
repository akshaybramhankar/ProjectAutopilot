﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repository
{
    public interface IRepository<T> where T : class, new()
    {
         IQueryable<T> Get();

        //IEnumerable<T> Get();
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
        T AddAndReturn(T entity);
    }
}
