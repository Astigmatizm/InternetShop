using InternetShop.Data;
using InternetShop.Models;


namespace internetShop.DataAccess.Repository.CategoryAccess
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
        public void Update(Category entity)
        {
            _context.Update(entity);
        }
    }
}
