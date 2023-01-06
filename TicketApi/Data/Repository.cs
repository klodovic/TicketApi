﻿using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace TicketApi.Data
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public readonly ApplicationDbContext _db;


        public Repository(ApplicationDbContext db)
        {
            _db= db;
        }

        public async Task CreateAsync(T entity)
        {
            await _db.AddAsync(entity);
            await SaveAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _db.Remove(entity);
            await SaveAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _db.Set<T>().ToListAsync();
        }


        public async Task<T?> GetAsync(int? id)
        {
            if (id.Equals(null))
            {
                return null;
            }

            return await _db.Set<T>().FindAsync(id);
        }

        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _db.Update(entity);
            await _db.SaveChangesAsync();
        }
    }
}
