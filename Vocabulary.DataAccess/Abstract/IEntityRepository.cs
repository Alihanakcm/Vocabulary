using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Vocabulary.Entity.Abstract;

namespace Vocabulary.DataAccess.Abstract
{
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetWords(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        bool GetTime(Expression<Func<T,bool>> filter=null);
        List<T> Get(Expression<Func<T, bool>> filter = null);
        bool QueryWord(Expression<Func<T,bool>> filter=null);
        List<T> StatisticsGet(Expression<Func<T, bool>> filter = null);
        bool YearQuery(Expression<Func<T,bool>> filter=null);
        bool GetValue(Expression<Func<T, bool>> filter = null);
    }
}
