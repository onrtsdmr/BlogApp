using System.Collections.Generic;
using System.Threading.Tasks;
using OTProject.Blog.Entities.Interfaces;

namespace OTProject.Blog.Business.Interfaces
{
    public interface IGenericService<TEntity>
        where TEntity : class, ITable, new()
    {
        Task<List<TEntity>> GetAll();
        Task<TEntity> GetById(int id);
        Task Add(TEntity entity);
        Task Update(TEntity entity);
        Task Remove(TEntity entity);
    }
}