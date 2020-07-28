using OTProject.Blog.Entities.Interfaces;

namespace OTProject.Blog.Entities.Concrete
{
    public class Category: ITable
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}