using _0315_Repository.Models;
using _0315_Repository.Models.Entity;
using _0315_Repository.Repositorys.Interface;
using System.Collections.Generic;
using System.Linq;

namespace _0315_Repository.Repositorys
{
    public class ProductRepository : IProductRepository
    {
        public void Create(Product product)
        {
            MockData.productList.Add(product);
        }

        public void Delete(Product product)
        {
            MockData.productList.Remove(product);
        }

        public IEnumerable<Product> GetAll()
        {
            return MockData.productList;
        }

        public Product GetProductById(int id)
        {
            return MockData.productList.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Product product)
        {
            var Index = MockData.productList.FindIndex(x => x.Id == product.Id);
            MockData.productList[Index] = product;
        }
    }
}
