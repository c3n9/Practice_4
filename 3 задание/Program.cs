using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_задание
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n");
            double n = double.Parse(Console.ReadLine());
            double y = 2*n + 1;
            for (double i = 2*n-1; i >=1; i-=2)
            {
                y = i + Math.Sqrt(y);
            }
            y = Math.Sqrt(y);
            Console.WriteLine("Ответ "+ y);
        }
    }
}
