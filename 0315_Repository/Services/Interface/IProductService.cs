using _0315_Repository.Models.Entity;
using System.Collections;
using System.Collections.Generic;

namespace _0315_Repository.Services.Interface
{
    public interface IProductService
    {
        IEnumerable<Product> GetAll();

        Product GetProductById(int id);

        IEnumerable<Product> GetPromotion();

        bool UpdateProduct(Product product);

        IEnumerable<Product> SortByPrice();
    }
}
