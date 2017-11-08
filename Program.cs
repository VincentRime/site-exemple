using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additioneur
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========================");
            Console.WriteLine("Saisir une valeur numerique");
            double dblval1 = Convert.ToDouble(Console.ReadLine());
            dblval1++;
            Console.WriteLine(dblval1);
            Console.ReadKey();
        }
    }
}
