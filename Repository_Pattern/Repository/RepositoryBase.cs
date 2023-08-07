using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Pattern.Repository
{
    public abstract class RepositoryBase<T> : IRepository<T> where T : class
    {
        protected DbContext dbContext;
        protected DbSet<T> dbSet;

        public RepositoryBase(DbContext context)
        {
            dbContext = context;
            dbSet = context.Set<T>();
        }

        public virtual IQueryable<T> GetAll()
        {
            return dbSet;
        }

        public virtual T GetById(int id)
        {
            return dbSet.Find(id);
        }

        public virtual void Insert(T entity)
        {
            dbSet.Add(entity);
        }

        public virtual void Update(T entity)
        {
            dbContext.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(T entity)
        {
            if (dbContext.Entry(entity).State == EntityState.Detached)
            {
                dbSet.Attach(entity);
            }
            dbSet.Remove(entity);
        }
    }
}
