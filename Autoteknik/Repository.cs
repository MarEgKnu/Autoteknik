using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoteknik
{
    public class Repository<K, T> : IRepository<K, T> where T : Person
    {
        public List<T> Objects {  get; }

        public int Count { get { return Objects.Count; } }

        public void Add(T obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(K id)
        {
            throw new NotImplementedException();
        }

        public T Get(K id)
        {
            throw new NotImplementedException();
        }

        public void Update(K id, T obj)
        {
            throw new NotImplementedException();
        }
    }
}
