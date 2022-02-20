using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.Repositories
{
    public class SqlRepository<T> : IRepository<T> where T : class, IEntity
    {
        private readonly DbContext dbContext;
        private readonly DbSet<T> dbSet;

        public SqlRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
            dbSet = dbContext.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return dbSet.OrderBy(item => item.Id).ToList();
        }

        public T GetById(int id)
        {
            return dbSet.Find(id);
        }

        public void Add(T item)
        {
            dbSet.Add(item);
        }
        public void Save()
        {
            dbContext.SaveChanges();
        }
        public void Remove(T item)
        {
            dbSet.Remove(item);
        }
    }
}
