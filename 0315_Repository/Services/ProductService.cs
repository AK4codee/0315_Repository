using _0315_Repository.Commom.Enum;
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

        public IEnumerable<SortByPriceDto> SortByPrice(ProductEnum.SortEnum sortType)
        {
            var productList = _productRepository.GetAll().Select(x => new SortByPriceDto()
            {
                Id = x.Id,
                Name = x.Name,
                Price = x.Price,
                IsPromotion = x.IsPromotion
            });

            switch(sortType)
            {
                case ProductEnum.SortEnum.Asc:
                    return productList.OrderBy(x => x.Price);
                case ProductEnum.SortEnum.Desc:
                    return productList.OrderByDescending(x => x.Price);
                default:
                    return productList;
            }
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
