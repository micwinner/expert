using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using instrument.expert.dal;

namespace instrument.expert.repository.Impl
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public Repository()
        {
            DB = new instrumentEntities();
        }

        protected instrumentEntities DB { get; private set; }

        public virtual int Insert(T entity)
        {
            try
            {
                DB.Set<T>().Add(entity);
                return DB.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public virtual int Delete(object id)
        {
            try
            {
                return Delete(DB.Set<T>().Find(id));
            }
            catch (Exception)
            {
                throw;
            }
        }

        public virtual int Delete(T entity)
        {
            try
            {
                if (DB.Entry(entity).State == EntityState.Detached)
                {
                    DB.Set<T>().Attach(entity);
                }
                DB.Set<T>().Remove(entity);
                return DB.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public virtual int Update(T entity)
        {
            try
            {
                switch (DB.Entry(entity).State)
                {
                    case EntityState.Modified:
                        return DB.SaveChanges();
                    case EntityState.Detached:
                        try
                        {
                            DB.Set<T>().Attach(entity);
                            DB.Entry(entity).State = EntityState.Modified;
                            return DB.SaveChanges();
                        }
                        catch (InvalidOperationException)
                        {
                            return -2;
                        }
                    default:
                        return -1;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public virtual T GetByKey(object key)
        {
            try
            {
                return DB.Set<T>().Find(key);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public virtual IList<T> GetByWhere(Func<T, bool> func)
        {
            try
            {
                return DB.Set<T>().Where(func).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public T GetByFunc(Func<T, bool> func)
        {
            try
            {
                return DB.Set<T>().FirstOrDefault(func);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}