namespace Craft
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            FeedBacks = new HashSet<FeedBack>();
            List_Of_Orders = new HashSet<List_Of_Order>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Key]
        [Column("Company Name")]
        [StringLength(20)]
        public string Company_Name { get; set; }

        [Required]
        [StringLength(20)]
        public string City { get; set; }

        [Column("Phone Number")]
        [Required]
        [StringLength(50)]
        public string Phone_Number { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FeedBack> FeedBacks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<List_Of_Order> List_Of_Orders { get; set; }
    }
}
