using Microsoft.EntityFrameworkCore;
using Proyecto_Merck.Areas.Identity.Data;
using ProyectoMerck.DataAccess.Interfaces;


namespace ProyectoMerck.DataAccess.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {

        //Tendriamos que loggear todas las posibles excepciones en un futuro

        private readonly AppMerckContext _context;
        private readonly DbSet<T> _set;

        public GenericRepository(AppMerckContext context)
        {

            _context = context;
            _set = context.Set<T>();

        }

        public async Task<bool> Add(T entity)
        {

            try
            {

                await _context.Set<T>().AddAsync(entity);

                return true;

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);

                return false;
            }

        }

        public async Task<bool> DeleteById(int id)
        {

            var entity = await GetByIdAsync(id);

            if(entity == null)
            {
                return false;
            }

            try
            {

                _set.Remove(entity);

                return true;

            }
            catch (Exception)
            {

                return false;
            }

        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {

            var entities = await _set.ToListAsync();

            return entities;
        }

        public async Task<T> GetByIdAsync(int id)
        {

            var entity = await _set.FindAsync(id);

            return entity;

        }

        public async Task<bool> Update(T entity)
        {

            try
            {

                _context.Update(entity);

                return true;
            }
            catch(Exception ex)
            {

                Console.WriteLine(ex);

                return false;

            }

        }
    }
}
