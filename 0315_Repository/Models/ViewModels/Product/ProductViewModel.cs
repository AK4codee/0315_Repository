using System.Collections.Generic;

namespace _0315_Repository.Models.ViewModels.Product
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsPromotion { get; set; }

    }
}
