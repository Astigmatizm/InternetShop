using internetShop.Models;
namespace internetShop.DataAccess.Repository.CategoryAccess;

public interface ICategoryRepository : IRepository<Category>
{
    void Save();
}
