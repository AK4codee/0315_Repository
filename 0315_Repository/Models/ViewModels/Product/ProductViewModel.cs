using System.Collections.Generic;

namespace _0315_Repository.Models.ViewModels.Product
{
    public class ProductViewModel
    {
        //public int Id { get; set; }
        //public string Name { get; set; }
        //public decimal Price { get; set; }
        //public bool IsPromotion { get; set; }

        public IEnumerable<Banner> BannerList { get; set; }
        public IEnumerable<Activity> ActivityList { get; set; }
        public IEnumerable<Recommend> RecommendList { get; set; }
    }

    public class Banner
    {
        public int Id { get; set; }
        public string ImgUrl { get; set; }
        public string Link { get; set; }
    }

    public class Activity
    {
        public int Id { get; set; }
        public string ImgUrl { get; set; }
        public string Link { get; set; }
    }

    public class Recommend
    {
        public int Id { get; set; }
        public string ImgUrl { get; set; }
        public decimal Price { get; set; }
        public string Link { get; set; }
    }
}
