﻿namespace _0315_Repository.Models.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsPromotion { get; set; }
        public string CreateUser { get; set; }
    }
}
