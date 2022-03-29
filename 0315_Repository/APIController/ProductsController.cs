using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using _0315_Repository.Models;
using _0315_Repository.Models.Entity;
using _0315_Repository.Services.Interface;
using _0315_Repository.Models.ViewModels.Product;
using _0315_Repository.Models.DTO.Product;
using _0315_Repository.Commom.Enum;

namespace _0315_Repository.APIController
{
    //[Route("api/[controller]")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly MyDbContext _context;
        private readonly IProductService _service;

        public ProductsController(MyDbContext context, IProductService service)
        {
            _context = context;
            _service = service;
        }

        // GET: api/Products
        [HttpGet]
        public IActionResult GetProducts()
        {
            var result = _service.GetAll().Select(x => new ProductViewModel()
            {
                Id = x.Id,
                Name = x.Name,
                Price = x.Price,
                IsPromotion = x.IsPromotion,
            });

            //return await _context.Products.ToListAsync();
            return Ok(new ApiResult() { Body = result});
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var product = _service.GetProductById(id);

            if (product == null)
            {
                return Ok(new ApiResult()
                {
                    Code = ApiStatus.Fail
                });
            }

            var result = new ProductDetailViewModel()
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                IsPromotion = product.IsPromotion
            };

            return Ok(new ApiResult() { Body = result });
        }

        // PUT: api/Products/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(int id, Product product)
        {
            if (id != product.Id)
            {
                return Ok(new ApiResult()
                {
                    Code = ApiStatus.Fail
                });
            }

            UpdateProductDto updateProductDto = new UpdateProductDto()
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                IsPromotion = product.IsPromotion
            };
            var isSuccess = _service.UpdateProduct(updateProductDto);
            if (isSuccess)
                return Ok(new ApiResult());
            else
                return Ok(new ApiResult()
                {
                    Code = ApiStatus.Fail
                });
        }

        // POST: api/Products
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProduct", new { id = product.Id }, product);
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.Id == id);
        }
    }
}
