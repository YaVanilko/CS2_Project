using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DAO
{
    public interface IRepository<T>
    {
        public void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetById(int Id); 
        IEnumerable<T> GetAll();
    }
}
