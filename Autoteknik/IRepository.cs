using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoteknik
{
    public interface IRepository<K, T> where T : Person
    {
        List<T> Objects { get; }
        int Count { get; }
        void Add(T obj);

        void Update(K id, T obj);

        void Delete(K id);

        T Get(K id);
    }
}
