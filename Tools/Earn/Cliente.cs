using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Earn
{
    public class Cliente
    {
        public void main()
        {
            decimal valUno = 0.9m;
            LocalEarnFactory local = new LocalEarnFactory(0.3m);
            var pruebas = local.GetEarn();
            var total = pruebas.Earn(valUno);
            Console.WriteLine(total);
        }
    }
}
