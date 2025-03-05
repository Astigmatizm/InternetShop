using InternetShop.Data
namespace internetShop.DataAccess.Repository.Category
{
    internal class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context)
    }
}
