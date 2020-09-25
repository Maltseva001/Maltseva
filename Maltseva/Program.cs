using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maltseva
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int L = int.Parse(Console.ReadLine());
            int S = L / 100;
            Console.WriteLine(S);
            Console.ReadKey();
        }
    }
}
