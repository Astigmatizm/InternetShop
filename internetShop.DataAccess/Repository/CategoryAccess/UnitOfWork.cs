
using InternetShop.Data;

namespace internetShop.DataAccess.Repository.CategoryAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public ICategoryRepository CategoryRepository { get; init; }
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            CategoryRepository = new CategoryRepository(context);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
