﻿using System.Linq.Expressions;

namespace NLayer.Core.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        IQueryable<T> GetAll(Expression<Func<T, bool>> expression);
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        Task<bool> Any(Expression<Func<T, bool>> expression);
        Task<T> AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        void UpdateAsync(T entity);
        void Delete(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}