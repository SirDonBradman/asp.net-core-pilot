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
    public class SemestersController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly ISemesterRepository _semesterRepository;
        public SemestersController(ISemesterRepository semesterRepository, ILogger<SemestersController> logger)
        {
            _semesterRepository = semesterRepository;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<Semester>>> GetAll(string departmentId) {
            ICollection<Semester> semesters = null;
            if(departmentId == null){
                semesters = await _semesterRepository.GetAll();
            }
            else {
                semesters = await _semesterRepository.GetAll(departmentId);
            }
            return semesters.ToList();
        }

        // GET by ID action
        [HttpGet("{id}")]
        public async Task<ActionResult<Semester>> GetById(string id)
        {
            _logger.LogInformation("Getting item {ID}", id);
        
            var Semester = await _semesterRepository.Get(id);

            if (Semester == null)
            {
                return NotFound();
            }

            return Semester;
        }

        // POST action
        [HttpPost]
        public async Task<ActionResult<Department>> Create(Semester Semester)
        {
            _semesterRepository.Add(Semester);
            await _semesterRepository.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = Semester.Id }, Semester);
        }

        // PUT action
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, Semester Semester)
        {
            if (id != Semester.Id)
            {
                return BadRequest();
            }

            _semesterRepository.Edit(Semester);
            await _semesterRepository.SaveChangesAsync();
            
            return NoContent();
        }

        // DELETE action
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var Semester = _semesterRepository.FindBy(col => col.Id == id).FirstOrDefault();

            if (Semester == null)
            {
                return NotFound();
            }

            _semesterRepository.Delete(Semester);
            await _semesterRepository.SaveChangesAsync();
            
            return NoContent();
        }
    }
}