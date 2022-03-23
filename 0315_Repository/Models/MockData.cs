using _0315_Repository.Models.Entity;
using System.Collections.Generic;

namespace _0315_Repository.Models
{
    public class MockData
    {
        public static List<Product> productList = new List<Product>()
        {
            new Product() { Id = 1, Name = "蛋糕", Price = 10, IsPromotion = false, CreateUser = "A" },
            new Product() { Id = 2, Name = "餅乾", Price = 20, IsPromotion = true, CreateUser = "A" },
            new Product() { Id = 3, Name = "蛋塔", Price = 30, IsPromotion = false, CreateUser = "A" },
            new Product() { Id = 4, Name = "奶酪", Price = 40, IsPromotion = true, CreateUser = "B" },
            new Product() { Id = 5, Name = "蛋捲", Price = 50, IsPromotion = false, CreateUser = "B" },
            new Product() { Id = 6, Name = "飲料", Price = 60, IsPromotion = true, CreateUser = "B" },
        };
    }
}
