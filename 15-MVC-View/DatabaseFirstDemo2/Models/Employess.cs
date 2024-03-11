namespace DatabaseFirstDemo2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employess")]
    public partial class Employess
    {
        [Key]
        public int eID { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Name")] public string eName { get; set; }

        public int? dID { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = true)]
        public int Salary
        {
            get => salary;
            set => salary = (int) value;
        }
        private int salary;

        public virtual Department Department { get; set; }
    }
}
