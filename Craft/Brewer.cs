namespace Craft
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Brewer
    {
        public int id { get; set; }

        [Required]
        [StringLength(20)]
        public string NikNMame { get; set; }

        [Column(TypeName = "date")]
        public DateTime Birthday { get; set; }

        public byte Experiance { get; set; }

        [Required]
        [StringLength(50)]
        public string Beer { get; set; }

        public virtual BeerType BeerType { get; set; }
    }
}
