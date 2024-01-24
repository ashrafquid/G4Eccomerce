


using G4Eccomerce.Model;
using G4Eccomerce.Repository.IRepository;

namespace G4Eccomerce.Repository.Implementation
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
