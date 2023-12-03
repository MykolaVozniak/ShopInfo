namespace Tumbleweed.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public DateTime HireDate { get; set; }
        public bool IsOwner { get; set; }

        // Навігаційні властивості
        public Role Role { get; set; }
        public User User { get; set; }
    }
}
