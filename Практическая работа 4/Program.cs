using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_работа_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; i <=100; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }

            }
            Console.WriteLine("Сумма четных чисел в первой сотне равна " + sum);
        }
    }
}
