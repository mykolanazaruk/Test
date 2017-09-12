namespace Craft
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("List Of Orders")]
    public partial class List_Of_Order
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string Beer { get; set; }

        [Required]
        [StringLength(20)]
        public string Customer { get; set; }

        public double Price { get; set; }

        public int Amount { get; set; }

        [StringLength(20)]
        public string Valuta { get; set; }

        public virtual BeerType BeerType { get; set; }

        public virtual Customer Customer1 { get; set; }
    }
}
