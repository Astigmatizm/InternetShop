using internetShop.Models;

namespace internetShop.DataAccess.Repository.Products
{
    public interface IProductRepository : IRepository<Product>
    {
        void Save();
        IEnumerable<Product> GetAllWithCategories();
    }
}
