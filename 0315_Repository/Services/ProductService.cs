using _0315_Repository.Models.DTO.Product;
using _0315_Repository.Models.Entity;
using _0315_Repository.Repositorys.Interface;
using _0315_Repository.Services.Interface;
using System.Collections.Generic;
using System.Linq;

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
            return _productRepository.GetAll().Select(x => new GetAllDto()
            {
                Id = x.Id,
                Name = x.Name,
                Price = x.Price,
                IsPromotion = x.IsPromotion
            });
        }

        public GetProductByIdDto GetProductById(int id)
        {
            var Product = _productRepository.GetProductById(id);

            return new GetProductByIdDto()
            {
                Id = Product.Id,
                Name = Product.Name,
                Price = Product.Price,
                IsPromotion = Product.IsPromotion
            };
        }

        public IEnumerable<GetPromotionDto> GetPromotion()
        {
             return _productRepository.GetAll().Where(x => x.IsPromotion == true).Select(x => new GetPromotionDto()
             {
                 Id = x.Id,
                 Name = x.Name,
                 Price = x.Price,
                 IsPromotion = x.IsPromotion
             });
        }

        public IEnumerable<SortByPriceDto> SortByPrice()
        {
            return _productRepository.GetAll().OrderByDescending(x => x.Price).Select(x => new SortByPriceDto()
            {
                Id = x.Id,
                Name = x.Name,
                Price = x.Price,
                IsPromotion = x.IsPromotion
            });
        }

        public bool UpdateProduct(UpdateProductDto product)
        {
            var IsExist = GetProductById(product.Id);

            if(IsExist != null)
            {
                var Product = new Product()
                {
                    Id = product.Id,
                    Name = product.Name,
                    Price = product.Price,
                    IsPromotion = product.IsPromotion
                };
                _productRepository.Update(Product);
                return true;
            }
            return false;
        }
    }
}
