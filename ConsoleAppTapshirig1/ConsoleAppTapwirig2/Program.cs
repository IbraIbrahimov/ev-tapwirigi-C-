using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTapwirig2
{
    class Program
    {
        static void Main(string[] args)
        { Console.Write("Birinci ededi daxil edin: ");
            string inputA = Console.ReadLine();
            Console.Clear();

            Console.Write("Ikinci ededi daxil edin: ");
            string inputB = Console.ReadLine();
            Console.Clear();

            Console.Write("Uchuncu ededi daxil edin: ");
            string inputC = Console.ReadLine();
            Console.Clear();

            int a = int.Parse(inputA);
            int b = int.Parse(inputB);
            int c = int.Parse(inputC);

            int result1 =Convert.ToInt32( Math.Pow((a + b), 2)-c);
            Console.WriteLine($"Netice: {result1}");
            Console.ReadKey();
            while (Console.ReadKey().Key != ConsoleKey.Tab) { }
        }
    }
}
