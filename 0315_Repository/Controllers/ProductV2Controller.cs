using _0315_Repository.Models.DTO.Product;
using _0315_Repository.Models.Entity;
using _0315_Repository.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace _0315_Repository.Controllers
{
    public class ProductV2Controller : Controller
    {
        private readonly IProductService _productService;
        public ProductV2Controller(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            var productList = _productService.GetAll();
            return View(productList);
        }
        public IActionResult Promotion()
        {
            var productList = _productService.GetPromotion();
            return View(productList);
        }
        public IActionResult Detail(int id)
        {
            var product = _productService.GetProductById(id);
            return View(product);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var product = _productService.GetProductById(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            UpdateProductDto updateProductDto = new UpdateProductDto()
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                IsPromotion = product.IsPromotion
            };

            var isSuccess = _productService.UpdateProduct(updateProductDto);

            if (isSuccess)
                return RedirectToAction(nameof(Detail), product.Id);
            else
                return RedirectToAction(nameof(Index));
        }
    }
}
