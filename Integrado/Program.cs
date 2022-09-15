using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NachoOperaSyR;
using NachoOperaMyD;

namespace Integrado
{
    class Program
    {
        static void Main(string[] args)
        {
            long resulS, resulR, resulM, resulD;
            resulS = NachoOperaSyR.Class1.Suma(3, 4);
            resulR = NachoOperaSyR.Class1.Suma(10, 2);
            resulM = NachoOperaMyD.Class1.Multiplicacion(3,4);
            resulD = NachoOperaMyD.Class1.Division(10, 2);
            Console.WriteLine(resulM.ToString());
            Console.WriteLine(resulD.ToString());
            Console.ReadKey();
        }
    }
}
