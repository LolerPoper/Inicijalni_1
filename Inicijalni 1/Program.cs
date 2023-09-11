using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicijalni_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 100, b = 3, x;
            double y;

            x = a / b;
            y = a % b;

            Console.WriteLine("a dijeljeno s b je " + x + " i ostatak " + y);
            Console.ReadKey();

        }
    }
}
