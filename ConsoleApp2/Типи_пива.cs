namespace ConsoleApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Типи пива")]
    public partial class Типи_пива
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string Назва { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Характеристика { get; set; }

        public virtual Пиво Пиво { get; set; }
    }
}
