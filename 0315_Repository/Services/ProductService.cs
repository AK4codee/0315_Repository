using _0315_Repository.Models.DTO.Product;
using _0315_Repository.Repositorys.Interface;
using _0315_Repository.Services.Interface;
using System.Collections.Generic;

namespace _0315_Repository.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public IEnumerable<GetAllDto> GetAll()
        {
            
        }

        public GetProductByIdDto GetProductById(int id)
        {
            
        }

        public IEnumerable<GetPromotionDto> GetPromotion()
        {
            
        }

        public IEnumerable<SortByPriceDto> SortByPrice()
        {
            
        }

        public bool UpdateProduct(UpdateProductDto product)
        {
            
        }
    }
}
