namespace ConsoleApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Відгуки про пиво")]
    public partial class Відгуки_про_пиво
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string Пиво { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Відгук { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Покупець { get; set; }

        public virtual Список_замовлень Список_замовлень { get; set; }

        public virtual Список_замовлень Список_замовлень1 { get; set; }
    }
}
