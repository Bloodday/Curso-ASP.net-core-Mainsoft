using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDbCurso.Interfaces
{
    public interface IDatabaseObject<T>
    {
        public T Create(T obj);

        public bool Update(T objt);

        public T Get(string id);

        public bool Delete(string id);
    }
}
