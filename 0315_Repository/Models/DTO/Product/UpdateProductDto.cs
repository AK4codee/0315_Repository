namespace _0315_Repository.Models.DTO.Product
{
    public class UpdateProductDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public bool IsPromotion { get; set; }
    }
}
