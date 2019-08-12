using Proeficiencia.Abstracao;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Proeficiencia.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly Context Context;
        protected readonly DbSet<TEntity> _dbSet;

        protected Repository(Context contexto = null)
        {
            if(contexto == null)
            {
                Context = new Context();
            }
            else
            {
                Context = contexto;
            }

            _dbSet = Context.Set<TEntity>();
        }

        public virtual void Add(TEntity obj)
        {
            _dbSet.Add(obj);

            Context.SaveChanges();
        }

        public virtual TEntity GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return _dbSet.ToListAsync().Result;
        }

        public virtual TEntity Update(int obj)
        {
            return _dbSet.Find(obj);
        }

        public virtual void Remove(int id)
        {
            _dbSet.Remove(_dbSet.Find(id) ?? throw new InvalidOperationException());

            Context.SaveChanges();
        }

        public int SaveChanges()
        {
            return Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}