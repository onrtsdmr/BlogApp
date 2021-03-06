﻿using System.Collections.Generic;
using System.Threading.Tasks;
using OTProject.Blog.Business.Interfaces;
using OTProject.Blog.DataAccess.Interfaces;
using OTProject.Blog.Entities.Interfaces;

namespace OTProject.Blog.Business.Concrete
{
    public class GenericManager<TEntity> : IGenericService<TEntity>
        where TEntity : class, ITable, new()

    {
        private readonly IGenericDal<TEntity> _genericDal;

        public GenericManager(IGenericDal<TEntity> genericDal)
        {
            _genericDal = genericDal;
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await _genericDal.GetAll();
        }


        public async Task<TEntity> GetById(int id)
        {
            return await _genericDal.GetById(id);
        }


        public async Task Add(TEntity entity)
        {
            await _genericDal.Add(entity);
        }

        public async Task Update(TEntity entity)
        {
            await _genericDal.Update(entity);
        }

        public async Task Remove(TEntity entity)
        {
            await _genericDal.Remove(entity);
        }
    }
}