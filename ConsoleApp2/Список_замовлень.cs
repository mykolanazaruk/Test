namespace ConsoleApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Список замовлень")]
    public partial class Список_замовлень
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string Пиво { get; set; }

        [StringLength(20)]
        public string Покупець { get; set; }

        public double Ціна { get; set; }

        public int Кількість { get; set; }

        public virtual Відгуки_про_пиво Відгуки_про_пиво { get; set; }

        public virtual Відгуки_про_пиво Відгуки_про_пиво1 { get; set; }

        public virtual Пивовар Пивовар { get; set; }

        public virtual Покупці_пива Покупці_пива { get; set; }
    }
}
