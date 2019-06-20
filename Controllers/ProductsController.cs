using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Core.Data;
using ContosoPets.Api.Models;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;

namespace ContosoPets.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly IProductRepository _productRepository;
        public ProductsController(IProductRepository productRepository, ILogger<ProductsController> logger)
        {
            _productRepository = productRepository;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAll() =>
            (await _productRepository.GetAll()).ToList();

        // GET by ID action
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetById(string id)
        {
            _logger.LogInformation("Getting item {ID}", id);
        
            //var product = await _context.Products.FindAsync(id);
            var product = await _productRepository.Get(id);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }

        // POST action
        [HttpPost]
        public async Task<ActionResult<Product>> Create(Product product)
        {
            _productRepository.Add(product);
            await _productRepository.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
        }

        // PUT action
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, Product product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }

            _productRepository.Edit(product);
            await _productRepository.SaveChangesAsync();
            
            return NoContent();
        }

        // DELETE action
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var product = _productRepository.FindBy(col => col.Id == id).FirstOrDefault();

            if (product == null)
            {
                return NotFound();
            }

            _productRepository.Delete(product);
            await _productRepository.SaveChangesAsync();
            
            return NoContent();
        }
    }
}