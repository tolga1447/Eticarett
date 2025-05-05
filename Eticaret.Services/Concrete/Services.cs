using Eticaret.Core.Entities;
using Eticaret.Data;
using Eticaret.Services.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Eticaret.Services.Concrete
{
    public class Services<T> : IServices<T> where T : class, IEntity, new()
    {
        internal DatabaseContext _context;
        internal DbSet<T> _dbSet;

        public Services(DatabaseContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public async Task AddAsync(T entity)
        {
          await  _dbSet.AddAsync(entity);
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public T Find(int id)
        {
            return _dbSet.Find(id);
        }

        public async Task<T> FindAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public T Get(Expression<Func<T, bool>> expressions)
        {
            return _dbSet.FirstOrDefault(expressions);
        }

        public List<T> GetAll()
        {
            return _dbSet.AsNoTracking().ToList();
        }

        public List<T> GetAll(Expression<Func<T, bool>> expressions)
        {
            return _dbSet.Where(expressions).AsNoTracking().ToList();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _dbSet.AsNoTracking().ToListAsync();
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> expressions)
        {
            return await _dbSet.Where(expressions).AsNoTracking().ToListAsync(); ;
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> expressions)
        {
            return await _dbSet.FirstOrDefaultAsync(expressions);
        }

        public IQueryable<T> GetQueryable()
        {
            return _dbSet;
        }

        public int SaveChanges()
        {
            return  _context.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }
    }
}
