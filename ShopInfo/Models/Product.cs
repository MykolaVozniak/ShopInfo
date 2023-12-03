namespace Tumbleweed.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public int SKU { get; set; }
        public decimal? Price { get; set; }
        public string ImageURL { get; set; }
        public string TaxGroup { get; set; }
        public bool Is18Plus { get; set; }
        public bool IsExciseApplicable { get; set; }

        // Навігаційні властивості
        public Category Category { get; set; }
    }
}
