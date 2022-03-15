using _0315_Repository.Models.Entity;
using System.Collections.Generic;

namespace _0315_Repository.Repositorys.Interface
{
    public interface IProductRepository
    {
        void Create(Product product);
        void Update(Product product);
        void Delete(Product product);
        IEnumerable<Product> GetAll();
        Product GetProductById(int id);
    }
}
