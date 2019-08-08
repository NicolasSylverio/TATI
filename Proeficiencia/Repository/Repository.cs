using Proeficiencia.Abstracao;
using System;
using System.Data.Entity;
using System.Linq;

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

        public virtual TEntity GetById(Guid id)
        {
            return _dbSet.Find(id);
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return _dbSet;
        }

        public virtual void Update(TEntity obj)
        {
            //  _dbSet.Update(obj);

            Context.SaveChanges();
        }

        public virtual void Remove(Guid id)
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