using System.Collections.Generic;
using System.Threading.Tasks;
using OTProject.Blog.Entities.Interfaces;

namespace OTProject.Blog.DataAccess.Interfaces
{
    public interface IGenericDal<TEntity> 
        where TEntity: class, ITable ,new()
    {
        Task<List<TEntity>> GetAll();
        Task<TEntity> GetById(int id);
        Task Add(TEntity entity);
        Task Update(TEntity entity);
        Task Remove(TEntity entity);
    }
}