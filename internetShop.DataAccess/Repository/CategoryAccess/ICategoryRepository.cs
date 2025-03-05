using internetShop.Models;
namespace internetShop.DataAccess.Repository.Category;

internal interface ICategoryRepository
{
    void Update(Category entity);
    void Save();
}
