using internetShop.Models;
using InternetShop.Data;

namespace internetShop.DataAccess.Repository.Products
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context) : base(context) 
        { 
            _context = context;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
