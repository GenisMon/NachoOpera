using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrado
{
    class Program
    {
        static void Main(string[] args)
        {
            long resulM, resulD, resulS, resulR;
            resulS = NachoOperaSyR.Class1.Suma(8,21);
            resulR = NachoOperaSyR.Class1.Resta(38, 5);
            resulM = NachoOperaMyD.Class1.Multiplicacion(3,4);
            resulD = NachoOperaMyD.Class1.Division(10, 2);
            Console.WriteLine(resulS.ToString());
            Console.WriteLine(resulR.ToString());
            Console.WriteLine(resulM.ToString());
            Console.WriteLine(resulD.ToString());
            Console.ReadKey();
        }
    }
}
