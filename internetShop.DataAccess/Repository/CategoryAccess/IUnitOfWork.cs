using internetShop.DataAccess.Repository.Products;

namespace internetShop.DataAccess.Repository.CategoryAccess
{
    public interface IUnitOfWork
    {
        ICategoryRepository CategoryRepository { get; }
        IProductRepository ProductRepository { get; }
        void Save();
    }
}
