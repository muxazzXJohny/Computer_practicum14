using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14_3
{
    class Program
    {

        /// <summary>
        /// Задание 1. Вывести на экран в столбик первые 10 натуральных чисел (циклы с условием, цикл с параметром)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Func();
            Console.ReadKey();
        }
        static void Func()
        {
            for (int x = 1; x <= 5; x++)
            {
                Console.WriteLine("Привет!");
            }
        }
    }
}
