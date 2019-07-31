using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.EntityData
{
    public class EntityData<T> where T : class
    {
        public string NameOrConnectionString => NameOrConnectionString;
        public DbCompiledModel Model => Model;

        public List<T> GetAll()
        {
            using (DbContext entities = DbContextFactory.Create(NameOrConnectionString, Model))
            {
                return entities.Set<T>().ToList();
            }
        }

        public int GetCount()
        {
            using (DbContext entities = DbContextFactory.Create(NameOrConnectionString, Model))
            {
                return entities.Set<T>().Count();
            }
        }

        public List<S> Select<S>(Expression<Func<T, S>> selector)
        {
            using (DbContext entities = DbContextFactory.Create(NameOrConnectionString, Model))
            {
                return entities.Set<T>().Select(selector).ToList();
            }
        }

        public void Insert(T entity)
        {
            using (DbContext entities = DbContextFactory.Create(NameOrConnectionString, Model))
            {
                entities.Set<T>().Add(entity);
                entities.SaveChanges();
            }
        }

        public void Update(T entity)
        {
            using (DbContext entities = DbContextFactory.Create(NameOrConnectionString, Model))
            {
                entities.Entry(entity).State = EntityState.Modified;
                entities.SaveChanges();
            }
        }
        public void Delete(T entity)
        {
            using (DbContext entities = DbContextFactory.Create(NameOrConnectionString, Model))
            {
                entities.Entry(entity).State = EntityState.Deleted;
                entities.SaveChanges();
            }
        }
    }
}
