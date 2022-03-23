using _0315_Repository.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace _0315_Repository.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext>options) : base(options) { }

        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product[]
            {
                new Product() { Id = 1, Name = "蛋糕", Price = 10, IsPromotion = false, CreateUser = "A" },
                new Product() { Id = 2, Name = "餅乾", Price = 20, IsPromotion = true, CreateUser = "A" },
                new Product() { Id = 3, Name = "蛋塔", Price = 30, IsPromotion = false, CreateUser = "A" },
                new Product() { Id = 4, Name = "奶酪", Price = 40, IsPromotion = true, CreateUser = "B" },
                new Product() { Id = 5, Name = "蛋捲", Price = 50, IsPromotion = false, CreateUser = "B" },
                new Product() { Id = 6, Name = "飲料", Price = 60, IsPromotion = true, CreateUser = "B" },
            });
        }
    }
}
