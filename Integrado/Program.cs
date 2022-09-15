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
            long resulM, resulD;
            resulM = NachoOperaMyD.Class1.Multiplicacion(3,4);
            resulD = NachoOperaMyD.Class1.Division(10, 2);
            Console.WriteLine(resulM.ToString());
            Console.WriteLine(resulD.ToString());
            Console.ReadKey();
        }
    }
}
