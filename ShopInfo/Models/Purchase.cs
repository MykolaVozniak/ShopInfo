namespace Tumbleweed.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public DateTime PurchaseTime { get; set; }

        // Навігаційні властивості
        public Product Product { get; set; }
        public User User { get; set; }
    }
}
