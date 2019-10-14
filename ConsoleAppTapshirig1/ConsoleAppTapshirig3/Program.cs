using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTapshirig3
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

            double resultAvg =Math.Round( ((a + b + c) / 3.0),1);
            double resultSqrt = Math.Pow((a * b * c), 1.0/3);
            Console.WriteLine($"Ededlerin hasilinin 3cu dereceeden koku: {resultSqrt}");
            Console.WriteLine($"A,B ve C ededlirinin ededi ortasi: {resultAvg}");
           
            while (Console.ReadKey().Key != ConsoleKey.Escape) { }

        }
    }
}
