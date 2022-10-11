using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int f = 1;
            Console.WriteLine("Введите число для вычисления его фаткариала, n!");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                f = f * i;
            }
            Console.WriteLine("Фактариал " + n + " равен " + f);
        }
    }
}
