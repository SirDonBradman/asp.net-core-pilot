using System.Collections.Generic;
using System.Threading.Tasks;
using CoreEMS.Models;

namespace Core.Data {
    public interface ISemesterRepository : IGenericRepository<Semester> {
        Task<ICollection<Semester>> GetAll(string departmentId);
    }
}