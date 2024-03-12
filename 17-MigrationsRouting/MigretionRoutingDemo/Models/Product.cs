using System.ComponentModel.DataAnnotations;

namespace MigretionRoutingDemo.Models
{
    public class Product
    {
        [Key] public int PID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}