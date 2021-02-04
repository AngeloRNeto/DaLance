using System.Collections.Generic;

namespace DaLance.Domain.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        int Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetById(int id);
        List<T> GetAll<TEntity>();
    }
}
