


using G4Eccomerce.Model;
using G4Eccomerce.Repository.IRepository;

namespace G4Eccomerce.Repository.Implementation
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext context) : base(context)
        {
        }
    }  
}
