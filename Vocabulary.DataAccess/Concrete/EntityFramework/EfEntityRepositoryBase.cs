using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Vocabulary.DataAccess.Abstract;
using Vocabulary.Entity.Abstract;

namespace Vocabulary.DataAccess.Concrete.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity,TContext> :IEntityRepository<TEntity>
    where TEntity:class,IEntity,new()
    where TContext:DbContext,new()
    {
        public List<TEntity> GetWords(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter==null? context.Set<TEntity>().ToList(): context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var AddedEntity = context.Entry(entity);
                AddedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var DeletedEntity = context.Entry(entity);
                DeletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var UpdatedEntity = context.Entry(entity);
                UpdatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public bool GetTime(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().Where(filter).FirstOrDefault() != null;
            }
        }

        public List<TEntity> Get(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context=new TContext())
            {
               return context.Set<TEntity>().Where(filter).ToList();
            }
        }
        public bool QueryWord(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context=new TContext())
            {
                return context.Set<TEntity>().Where(filter).FirstOrDefault() != null;
            }
        }

        public List<TEntity> StatisticsGet(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context=new TContext())
            {
                return context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public bool YearQuery(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().Where(filter).FirstOrDefault() != null;
            }
        }

        public bool GetValue(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context=new TContext())
            {
                return context.Set<TEntity>().Where(filter).FirstOrDefault() != null;
            }
        }
    }
}
