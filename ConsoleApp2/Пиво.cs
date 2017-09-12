namespace ConsoleApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Пиво
    {
        public int id { get; set; }

        [Column("Вміст алкоголю")]
        public double Вміст_алкоголю { get; set; }

        public int IPA { get; set; }

        [Column("Тип пива")]
        [Required]
        [StringLength(50)]
        public string Тип_пива { get; set; }

        public virtual Типи_пива Типи_пива { get; set; }

        public virtual Пивовар Пивовар { get; set; }
    }
}
