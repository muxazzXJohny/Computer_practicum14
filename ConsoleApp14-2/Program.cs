using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Func();
            Console.ReadKey();
        }
        static void Func()
        {
            int n = int.Parse(Console.ReadLine());
            int x = 1;
            do
            {
                Console.WriteLine(x);
                x++;
            }
            while (x <= n);
        }
    }
}
