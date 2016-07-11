using System;
using System.Collections.Generic;

namespace instrument.expert.repository
{
    public interface IRepository<T> where T : class
    {
        int Insert(T entity);
        int Delete(object id);
        int Delete(T entity);
        int Update(T entity);
        T GetByKey(object key);
        IList<T> GetByWhere(Func<T, bool> func);
        T GetByFunc(Func<T, bool> func);
    }
}