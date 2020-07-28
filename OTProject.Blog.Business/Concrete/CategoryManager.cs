using OTProject.Blog.Business.Interfaces;
using OTProject.Blog.DataAccess.Interfaces;
using OTProject.Blog.Entities.Concrete;

namespace OTProject.Blog.Business.Concrete
{
    public class CategoryManager : GenericManager<Category>, ICategoryService
    {
        public CategoryManager(IGenericDal<Category> genericDal) : base(genericDal)
        {
        }
    }
}