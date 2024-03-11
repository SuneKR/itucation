namespace DatabaseFirstDemo2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Department
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Department()
        {
            Employesses = new HashSet<Employess>();
        }

        [Key]
        public int dID { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Departsment")] public string dName { get; set; }

        [StringLength(50)]
        public string Location { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employess> Employesses { get; set; }
    }
}
