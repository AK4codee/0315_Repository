﻿namespace _0315_Repository.Models.DTO.Product
{
    public class GetProductByIdDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public bool IsPromotion { get; set; }
    }
}