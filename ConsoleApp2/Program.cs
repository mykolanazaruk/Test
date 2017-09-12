using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var con = new Model1();
            //var res = con.Пивовар.Find(2);
            //var res1 = con.Пивовар.Take(5).ToList();
            var res2 = con.Типи_пива.Take(3).ToList();
          //  var res2 =con.Список_замовлень.
         
  
        }
    }
}
