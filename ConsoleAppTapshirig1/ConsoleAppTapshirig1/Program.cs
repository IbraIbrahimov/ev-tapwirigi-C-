using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTapshirig1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("A-ededini daxil edin: ");
           string inputA = Console.ReadLine();
            Console.Clear();
            Console.Write("B-ededini daxil edin: ");
            string inputB = Console.ReadLine();
            Console.Clear();
            Console.Write("C-ededini daxil edin: ");
            string inputC = Console.ReadLine();
            Console.Clear();

            int a = int.Parse(inputA);
            int b = int.Parse(inputB);
            int c = int.Parse(inputC);

            int result1 = a + b;
            int result2 = b + c;
            int result3 = a + c;
            Console.WriteLine($"Birinci netice: {a}+{b}={result1}");
            Console.WriteLine($"Ikinci netice: {b}+{c}={result2}");
            Console.WriteLine($"Ucuncu netice: {a}+{c}={result3}");
            
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }

        }
    }
}
