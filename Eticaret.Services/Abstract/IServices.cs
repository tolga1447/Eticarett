using Eticaret.Core.Entities;
using System.Linq.Expressions;

namespace Eticaret.Services.Abstract
{
    public interface IServices<T> where T : class,IEntity,new()
    {
        List<T> GetAll();
        List<T> GetAll(Expression<Func<T, bool>> expressions);
        IQueryable<T> GetQueryable();

        T Get(Expression<Func<T, bool>> expressions);

        T Find(int id);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        int SaveChanges();

        //Asenkron metodlar

        Task<T> FindAsync(int id);
        Task<T> GetAsync(Expression<Func<T, bool>> expressions);
        Task<List<T>> GetAllAsync();
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> expressions);
        Task AddAsync(T entity);
       Task<int> SaveChangesAsync();

    }
}
