using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.WebSockets;
using System.Text;

namespace JWT.Data
{
    public class RepositoryBase <T> : IRepository<T> where T: class
    {
        private JWTDBContext db;
        public DbSet<T> dbSet;
        public RepositoryBase(JWTDBContext _db)
        {
            this.db = _db;
            this.dbSet = this.db.Set<T>();
        }
        public T getById(object id)
        {
            return dbSet.Find(id);
        }
        public T getSingle(Expression<Func<T, bool>> filter, string[] includes = null)
        {
            IQueryable<T> query = dbSet;
            if(includes !=null)
            {
                foreach (var inc in includes)
                {
                    query = query.Include(inc);
                }
            }
            return query.Where(filter).FirstOrDefault();
        }
        public IEnumerable<T> getAll()
        {
            IEnumerable<T> query = dbSet;
            return query.ToList();
        }
        public IEnumerable<T> getMulti(Expression<Func<T, bool>> filter, string[] includes = null)
        {
            IQueryable<T> query = dbSet;
            if (includes != null)
            {
                foreach (var inc in includes)
                {
                    query = query.Include(inc);
                }
            }
            return query.Where(filter).ToList();
        }
        public void Add(T entry)
        {
            dbSet.Add(entry);
        }
        public void Add(IEnumerable<T> entry)
        {
            dbSet.AddRange(entry);
        }
        public void Update(T entry)
        {
            dbSet.Attach(entry);
            db.Entry(entry).State = EntityState.Modified;
        }
        public void Update(IEnumerable<T> entry)
        {
            dbSet.AttachRange(entry);
            db.Entry(entry).State = EntityState.Modified;
        }
        public void Delete(object id)
        {
            T entry = dbSet.Find(id);
            dbSet.Remove(entry);
        }
        public void Delete(T entry)
        {
            if (db.Entry(entry).State == EntityState.Detached)
                dbSet.Attach(entry);
            dbSet.Remove(entry);
        }
        public void Delete(IEnumerable<T> entry)
        {
            if (db.Entry(entry).State == EntityState.Detached)
                dbSet.AttachRange(entry);
            dbSet.RemoveRange(entry);
        }
        public void Commit()
        {
            this.db.SaveChanges();
        }
    }
}
