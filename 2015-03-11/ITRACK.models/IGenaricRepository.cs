﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
   public interface IGenaricRepository<TEntity>
    {


        Task<TEntity> GetIdByAsync(int Id);

        IQueryable<TEntity> SearchFor(Expression<Func<TEntity,bool>> predicate  );

        IQueryable<TEntity> GetAll();

        Task EditAsync(TEntity entity);

        Task AddAsync(TEntity entity);

        Task DeleteAsync(TEntity entity);

    }
}
