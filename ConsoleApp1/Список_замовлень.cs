//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Список_замовлень
    {
        public int id { get; set; }
        public string Пиво { get; set; }
        public string Покупець { get; set; }
        public double Ціна { get; set; }
        public int Кількість { get; set; }
    
        public virtual Відгуки_про_пиво Відгуки_про_пиво { get; set; }
        public virtual Відгуки_про_пиво Відгуки_про_пиво1 { get; set; }
        public virtual Пивовар Пивовар { get; set; }
        public virtual Покупці_пива Покупці_пива { get; set; }
    }
}
