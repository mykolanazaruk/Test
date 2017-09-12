namespace ConsoleApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Покупці пива")]
    public partial class Покупці_пива
    {
        public int id { get; set; }

        [Column("Назва компанії", TypeName = "text")]
        [Required]
        public string Назва_компанії { get; set; }

        [Required]
        [StringLength(20)]
        public string Місто { get; set; }

        [Column("Контактні дані", TypeName = "text")]
        [Required]
        public string Контактні_дані { get; set; }

        public virtual Список_замовлень Список_замовлень { get; set; }
    }
}
