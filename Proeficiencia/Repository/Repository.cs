using Proeficiencia.Abstracao;
using System;
using System.Data.Entity;
using System.Linq;

namespace Proeficiencia.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly Context _context;
        protected readonly DbSet<TEntity> _dbSet;

        public Repository(Context contexto = null)
        {
            if(contexto == null)
            {
                _context = new Context();
            }
            else
            {
                _context = contexto;
            }

            _dbSet = _context.Set<TEntity>();
        }

        public virtual void Add(TEntity obj)
        {
            _dbSet.Add(obj);

            _context.SaveChanges();
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

            _context.SaveChanges();
        }

        public virtual void Remove(Guid id)
        {
            _dbSet.Remove(_dbSet.Find(id));

            _context.SaveChanges();
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}