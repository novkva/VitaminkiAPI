using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepository <T>
    {
        public T GetById(int id);
        public List<T> GetAll();

        public void Add(T item);
        public void Update(int id);
        public void Delete(int id);
    }
}
