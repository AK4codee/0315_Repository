using _0315_Repository.Commom.Enum;
using _0315_Repository.Models.DTO.Product;
using _0315_Repository.Models.Entity;
using System.Collections;
using System.Collections.Generic;

namespace _0315_Repository.Services.Interface
{
    public interface IProductService
    {
        IEnumerable<GetAllDto> GetAll();

        GetProductByIdDto GetProductById(int id);

        IEnumerable<GetPromotionDto> GetPromotion();

        bool UpdateProduct(UpdateProductDto product);

        IEnumerable<SortByPriceDto> SortByPrice(ProductEnum.SortEnum sortType);
    }
}
