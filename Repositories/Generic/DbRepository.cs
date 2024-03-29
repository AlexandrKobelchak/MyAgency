﻿using Context;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repositories
{
    public class DbRepository<T> : IDbRepository<T> where T : class, IDbEntity
    {
        DbContext _context;

        public DbRepository(DbContext context)
        {
            _context = context;
        }
        public DbContext DbContext => _context;
        public IQueryable<T> AllItems => _context.Set<T>();
        
        public async Task<bool> AddItemAsync(T item)
        {
            await _context.Set<T>().AddAsync(item);
            return await SaveChangesAsync() > 0;
        }

        public async Task<int> AddItemsAsync(IEnumerable<T> items)
        {
            await _context.Set<T>().AddRangeAsync(items);
            return await SaveChangesAsync();
        }

        public async Task<bool> DeleteItemAsync(Guid id)
        {
            T deleted = _context.Set<T>().FirstOrDefault(i => i.Id == id);
            if (deleted == null)
            {
                return false;
            }
            _context.Set<T>().Remove(deleted);
            return await SaveChangesAsync() > 0;
        }

        public async Task<T> GetItemAsync(Guid id)
        {
            return await _context.Set<T>().FirstOrDefaultAsync(i => i.Id == id);
        }
        public async Task<List<T>> ToListAsync()
        {
            return await _context.Set<T>().ToListAsync<T>();
        }

        public async Task<bool> ChangeItemAsync(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            return await SaveChangesAsync() > 0;
        }
        public async Task<bool> UpdateItemAsync(T item)
        {
            _context.Set<T>().Update(item);
            return await SaveChangesAsync() > 0;
        }

        public async Task<int> SaveChangesAsync()
        {
            try
            {
                return await _context.SaveChangesAsync();
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception e)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                return -1;
            }
        }
    }
}