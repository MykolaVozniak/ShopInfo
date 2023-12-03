namespace ShopInfo.Models
{
    public class Category
    {
        public int Id { get; set; }
        public int? MotherCategoryId { get; set; }
        public int ShopId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }

        // Навігаційні властивості
        public Category MotherCategory { get; set; }
        public Shop Shop { get; set; }
    }
}
