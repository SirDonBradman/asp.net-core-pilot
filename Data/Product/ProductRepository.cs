using ContosoPets.Api.Models;

namespace Core.Data {
    public class ProductRepository : GenericRepository<Product>, IProductRepository {

        private readonly EMSContext _entities;
        public ProductRepository(EMSContext context) : base(context) {
            _entities = context;
        }
    }
}