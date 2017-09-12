namespace ConsoleApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Пивовар
    {
        public int id { get; set; }

        [Required]
        [StringLength(20)]
        public string Псевдонім { get; set; }

        [Column("Дата народження", TypeName = "date")]
        public DateTime Дата_народження { get; set; }

        [Column("Роки досвіду")]
        public byte Роки_досвіду { get; set; }

        [Required]
        [StringLength(50)]
        public string Пиво { get; set; }

        public virtual Пиво Пиво1 { get; set; }

        public virtual Список_замовлень Список_замовлень { get; set; }

        public override string ToString()
        {
            return $"{id}-{Пиво}";
        }
    }
}
