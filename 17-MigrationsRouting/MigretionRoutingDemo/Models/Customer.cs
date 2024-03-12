using System.ComponentModel.DataAnnotations;

namespace MigretionRoutingDemo.Models
{
    public class Customer
    {
        [Key] public int CID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int Phone { get; set; }
        public string? Email { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
