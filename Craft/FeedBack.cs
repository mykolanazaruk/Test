namespace Craft
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FeedBack")]
    public partial class FeedBack
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string Beer { get; set; }

        [Column("Feedback", TypeName = "text")]
        [Required]
        public string Feedback1 { get; set; }

        [Required]
        [StringLength(20)]
        public string Customer { get; set; }

        public virtual BeerType BeerType { get; set; }

        public virtual Customer Customer1 { get; set; }
    }
}
