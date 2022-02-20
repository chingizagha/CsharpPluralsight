using System.Collections.Generic;
using System.Linq;
using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.Repositories
{
    public class ListRepository<T> : IRepository<T> where T : IEntity
    {
        public readonly List<T> items = new();

        public IEnumerable<T> GetAll()
        {
            return items.ToList();
        }

        public T GetById(int id)
        {
            return items.Single(item => item.Id == id);
        }

        public void Add(T item)
        {
            item.Id = items.Count + 1;
            items.Add(item);
        }
        public void Save()
        {
            //Everything is saved already in the List<T> 
        }
        public void Remove(T item)
        {
            items.Remove(item);
        }
    }
}
