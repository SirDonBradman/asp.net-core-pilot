using CoreEMS.Models;

namespace Core.Data {
    public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository {
        private readonly EMSContext _entities;
        public DepartmentRepository(EMSContext context) : base(context) {
            _entities = context;
        }
    }
}