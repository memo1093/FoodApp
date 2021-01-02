using System.Collections.Generic;
using System.Linq;
using foodapp.data.Abstract;
using Microsoft.EntityFrameworkCore;

namespace foodapp.data.Concrete.EfCore
{
    public class EfCoreGenericRepository<TEntity, TContext> : IRepository<TEntity>
        where TEntity : class
        where TContext : DbContext, new()
    {
        public virtual void Create(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Set<TEntity>().Add(entity);
                context.SaveChanges();
            }
        }

        public virtual void Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Set<TEntity>().Remove(entity);
                context.SaveChanges();
            }
        }

        public List<TEntity> GetAll()
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().ToList();
            }
        }

        public TEntity GetById(int id)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().Find(id);
            }
        }

        public virtual void Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        
        
    }
}