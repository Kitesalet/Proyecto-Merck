using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMerck.DataAccess.Interfaces
{
    internal interface IGenericRepository<T>
    {

        public Task<IEnumerable<T>> GetAllAsync();

        public Task<T> GetByIdAsync(int id);

        public Task<bool> Add(T entity);

        public Task<bool> DeleteById(int id);

        public Task<bool> Update(T entity);

    }
}
