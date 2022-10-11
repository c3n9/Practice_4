using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество учеников");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите рост " + i + " ученика");
                int r = int.Parse(Console.ReadLine());
                sum  +=  r;
            }
            Console.WriteLine("Средний рост учащихся " + (sum / n) );
        }
    }
}
