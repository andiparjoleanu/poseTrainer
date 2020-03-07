using Microsoft.EntityFrameworkCore;
using PoseTrainerLibrary.Context;
using PoseTrainerLibrary.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PoseTrainerLibrary.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly PoseTrainerDbContext _context;

        public BaseRepository(PoseTrainerDbContext context)
        {
            _context = context;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task CreateAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        public T Update(T entity)
        {
            T model = _context.Set<T>().Update(entity).Entity;
            _context.SaveChanges();
            return model;
        }

    }
}
