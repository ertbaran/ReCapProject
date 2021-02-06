using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
        // T, sadece referans tipli olabilir. where T : class
        // IEntity veya IEntity miraslı olmalı. , IEntity
        // new lenebilir olmalı. , new()
        // Constrain yapısı. / Kısıtlama
        public interface IEntityRepository<T> where T : class, IEntity, new()
        {
            List<T> GetAll(Expression<Func<T, bool>> filter = null);    // Predict- Delegate Yapıları
            T Get(Expression<Func<T, bool>> filter);
            void Add(T entity);
            void Update(T entity);
            void Delete(T entity);
    }
}
