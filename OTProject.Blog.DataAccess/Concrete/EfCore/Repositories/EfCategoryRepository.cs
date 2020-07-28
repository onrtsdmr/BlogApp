using OTProject.Blog.DataAccess.Interfaces;
using OTProject.Blog.Entities.Concrete;

namespace OTProject.Blog.DataAccess.Concrete.EfCore.Repositories
{
    public class EfCategoryRepository: EfGenericRepository<Category>, ICategoryDal
    {
        
    }
}