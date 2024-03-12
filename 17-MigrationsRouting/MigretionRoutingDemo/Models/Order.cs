using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Http.Headers;

namespace MigretionRoutingDemo.Models
{
    public class Order
    {
        [Key] public int OID { get; set; }
        [ForeignKey("Customer")] public int CID { get; set; }
        [ForeignKey("Product")] public int PID { get; set; }
        public int Quantity { get; set; }
        [DataType(DataType.Date)] public DateTime OrderDate { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }


    }
}