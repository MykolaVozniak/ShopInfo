namespace ShopInfo.Models
{
    public class Role
    {
        public int Id { get; set; }
        public int ShopId { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }

        // Навігаційні властивості
        public Shop Shop { get; set; }
    }
}
