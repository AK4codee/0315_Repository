using _0315_Repository.Models.Entity;
using _0315_Repository.Repositorys.Interface;
using Dapper;
using System.Collections.Generic;
using System.Data;

namespace _0315_Repository.Repositorys
{
    public class DapperProductRepository : IProductRepository
    {
        private readonly IDbConnection _conn;
        public DapperProductRepository(IDbConnection conn)
        {
            _conn = conn;
        }
        public void Create(Product product)
        {
            _conn.Execute(@"
                INSERT INTO Products([Name], Price, IsPromotion, CreateUser)
                VALUES(@Name, @Price, @IsPromotion, @CreateUser)
            ", product);
        }

        public void Delete(Product product)
        {
            _conn.Execute(@"
            DELETE FROM Products
            WHERE Name=@Name AND Price=@Price AND IsPromotion=@IsPromotion AND CreatUser=@CreatUser",
            product);
        }

        public IEnumerable<Product> GetAll()
        {
            return _conn.Query<Product>("SELECT * FROM Products");
        }

        public Product GetProductById(int id)
        {
            return _conn.QueryFirstOrDefault<Product>("SELECT * From Products WHERE Id = @Id", new { id = id });
        }

        public void Update(Product product)
        {
            _conn.Execute(@"
                UPDATA Products 
                SET Name=@Name, Price=@Price, IsPromotion=@IsPromotion, WHERE Id=@Id",
             product);
        }
    }
}
