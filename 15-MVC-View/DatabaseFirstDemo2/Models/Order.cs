namespace DatabaseFirstDemo2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        [Key]
        public int oID { get; set; }

        public int? cID { get; set; }

        public int? pID { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName("Date of sale")]
        public DateTime? orderDate
        {
            get => dateOrder;
            set => dateOrder = (DateTime) value;
        }
        private DateTime dateOrder;
        
        [DisplayName("Paid?")] public bool? paymentStatus { get; set; }

        [DisplayName("Quantity")] public int? quantity { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Product Product { get; set; }
    }
}
