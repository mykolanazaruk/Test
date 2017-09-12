namespace Craft
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Beer")]
    public partial class Beer
    {
        public int id { get; set; }

        public double AcContent { get; set; }

        public int IPA { get; set; }

        [Required]
        [StringLength(50)]
        public string BeerType { get; set; }

        public virtual BeerType BeerType1 { get; set; }
    }
}
