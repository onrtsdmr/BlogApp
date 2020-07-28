using Microsoft.EntityFrameworkCore;
using OTProject.Blog.Entities.Concrete;

namespace OTProject.Blog.DataAccess.Concrete.EfCore.Context
{
    public class BlogContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(@"server=localhost;port=3306;database=BlogDB;user=root;password=onur123123");
            base.OnConfiguring(optionsBuilder);
        }
    }
}