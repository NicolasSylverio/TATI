using System;
using System.Collections.Generic;

namespace Proeficiencia.Abstracao
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        TEntity Update(int obj);
        void Remove(int id);
        int SaveChanges();
    }
}
