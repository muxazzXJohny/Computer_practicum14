using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14_4
{
    /// <summary>
    /// С использованием цветового оформления консоли:
    /// а) вывести на экран горизонтальную строку из 18 символов,
    /// б) вывести на экран вертикальную строку из 25 символов.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Func();
            Func1();
            Console.ReadKey();
        }
        public static void Func()
        {
            int x = 1;
            while (x < 19)
            {
                Console.Write(" ");
                x++;
            }
        }
        public static void Func1()
        {
            int x = 1;
            while (x < 26)
            {
                Console.WriteLine(" ");
                x++;
            }
        }
    }
}
