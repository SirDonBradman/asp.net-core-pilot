using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Core.Data;
using Microsoft.Extensions.Logging;
using CoreEMS.Models;

namespace CoreEMS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly IDepartmentRepository _departmentRepository;
        public DepartmentsController(IDepartmentRepository departmentRepository, ILogger<DepartmentsController> logger)
        {
            _departmentRepository = departmentRepository;
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<List<Department>> GetAll() =>
            _departmentRepository.GetAll().ToList();

        // GET by ID action
        [HttpGet("{id}")]
        public async Task<ActionResult<Department>> GetById(string id)
        {
            _logger.LogInformation("Getting item {ID}", id);
        
            var Department = await _departmentRepository.Get(id);

            if (Department == null)
            {
                return NotFound();
            }

            return Department;
        }

        // POST action
        [HttpPost]
        public async Task<ActionResult<Department>> Create(Department Department)
        {
            _departmentRepository.Add(Department);
            await _departmentRepository.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = Department.Id }, Department);
        }

        // PUT action
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, Department Department)
        {
            if (id != Department.Id)
            {
                return BadRequest();
            }

            _departmentRepository.Edit(Department);
            await _departmentRepository.SaveChangesAsync();
            
            return NoContent();
        }

        // DELETE action
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var Department = _departmentRepository.FindBy(col => col.Id == id).FirstOrDefault();

            if (Department == null)
            {
                return NotFound();
            }

            _departmentRepository.Delete(Department);
            await _departmentRepository.SaveChangesAsync();
            
            return NoContent();
        }
    }
}