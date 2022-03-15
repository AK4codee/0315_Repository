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
            return View();
        }

    }
}
