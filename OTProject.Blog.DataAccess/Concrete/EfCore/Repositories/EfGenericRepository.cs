using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OTProject.Blog.DataAccess.Concrete.EfCore.Context;
using OTProject.Blog.DataAccess.Interfaces;
using OTProject.Blog.Entities.Interfaces;

namespace OTProject.Blog.DataAccess.Concrete.EfCore.Repositories
{
    public class EfGenericRepository<TEntity>: IGenericDal<TEntity>
        where TEntity: class, ITable, new()
    {
        public async Task<List<TEntity>> GetAll()
        {
            using var context = new BlogContext();
            return await context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            using var context = new BlogContext();
            return await context.Set<TEntity>().FindAsync(id);
        }

        public Task Add(TEntity entity)
        {
            using var context = new BlogContext();
            context.Set<TEntity>().Add(entity);
            return context.SaveChangesAsync();
        }

        public Task Update(TEntity entity)
        {
            using var context = new BlogContext();
            context.Set<TEntity>().Update(entity);
            return context.SaveChangesAsync();
        }

        public Task Remove(TEntity entity)
        {
            using var context = new BlogContext();
            context.Set<TEntity>().Remove(entity);
            return context.SaveChangesAsync();
        }
    }
}