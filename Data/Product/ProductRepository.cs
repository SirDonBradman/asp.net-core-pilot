using System.Threading.Tasks;
using ContosoPets.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Core.Data.ProductNamespace {
    public class ProductRepository : GenericRepository<Product>, IProductRepository {

        private readonly EMSContext _entities;
        public ProductRepository(EMSContext context) : base(context) {
            _entities = context;
        }
    }
}