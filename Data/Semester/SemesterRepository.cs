using System.Collections.Generic;
using CoreEMS.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Data {
    public class SemesterRepository : GenericRepository<Semester>, ISemesterRepository {
        private readonly EMSContext _entities;
        public SemesterRepository(EMSContext context) : base(context) {
            _entities = context;
        }

        public async Task<ICollection<Semester>> GetAll(string departmentId)
        {
            return await Task.Run(() => _entities.Semesters.Where(sem => sem.DepartmentId == departmentId).ToList());
        }
    }
}