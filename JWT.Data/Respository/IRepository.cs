using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace JWT.Data
{
    public interface IRepository<T> where T : class
    {
        T getById(object id);
        T getSingle(Expression<Func<T, bool>> filter, string[] includes = null);
        IEnumerable<T> getAll();
        IEnumerable<T> getMulti(Expression<Func<T, bool>> filter, string[] includes = null);
        void Add(T entry);
        void Add(IEnumerable<T> entry);
        void Update(T entry);
        void Update(IEnumerable<T> entry);
        void Delete(object id);
        void Delete(T entry);
        void Delete(IEnumerable<T> entry);
        void Commit();

    }
}
